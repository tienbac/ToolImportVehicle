using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ToolImportVehicle.Entity;

namespace ToolImportVehicle
{
    public partial class MainForm : Form
    {
        private static FileInfo fileInfo = null;
        static List<center_plate> listPlates = new List<center_plate>();
        public Helper helper = new Helper();
        private static DateTime hsd = DateTime.ParseExact("31/01/2021", "dd/MM/yyyy", CultureInfo.CurrentCulture);
        public MainForm()
        {
            InitializeComponent();

            if (DateTime.Now > hsd)
            {
                Environment.Exit(0);
            }

        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            lblSaveStatus.Text = "";
            lblSaveFail.Text = "";
            rtbSaveResult.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.csv) | *.csv";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var filePath = openFileDialog.FileName;
                fileInfo = new FileInfo(filePath);
                txtFileName.Text = fileInfo.Name;

                listPlates = helper.ReadFileVehicles(fileInfo.FullName);

                lblTotalVehicle.Text = $"{listPlates.Count}";
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtbSaveResult.Clear();
            var success = 0;
            var fail = 0;
            foreach (var center in listPlates)
            {
                var check = helper.CheckExist<center_plate>($"lpn = '{center.lpn}' AND validity_end_date > GETDATE()");
                if (!check)
                {
                    var status = helper.InsertOne<center_plate>(center);

                    if (status == 1)
                    {
                        helper.SetInvokeRTB(rtbSaveResult, $"LƯU THÀNH CÔNG XE : {center.ToString()}", Color.Green);
                        success += 1;
                    }
                    else
                    {
                        helper.SetInvokeRTB(rtbSaveResult, $"LƯU KHÔNG THÀNH CÔNG XE : {center.ToString()}", Color.Red);
                        fail += 1;
                    }
                }
                else
                {
                    var status = helper.UpdateOne<center_plate>(center, $"lpn = '{center.lpn}'");
                    if (status == 1)
                    {
                        helper.SetInvokeRTB(rtbSaveResult, $"LƯU THÀNH CÔNG XE : {center.ToString()}", Color.Green);
                        success += 1;
                    }
                    else
                    {
                        helper.SetInvokeRTB(rtbSaveResult, $"LƯU KHÔNG THÀNH CÔNG XE : {center.ToString()}", Color.Red);
                        fail += 1;
                    }
                }
            }

            lblSaveStatus.ForeColor = Color.Green;
            lblSaveStatus.Text = $"LƯU THÀNH CÔNG {success} XE !";

            if (fail > 0)
            {
                lblSaveFail.ForeColor = Color.Red;
                lblSaveFail.Text = $"LỖI {fail} XE !";
            }
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            rtbSaveResult.Clear();
            var plate = txtPlateCheck.Text;

            var center = helper.GetOne<center_plate>($"lpn = '{plate}'");

            if (center != null)
            {
                helper.SetInvokeRTB(rtbSaveResult, center.ToString(), Color.Coral);
            }
            else
            {
                helper.SetInvokeRTB(rtbSaveResult, $"Xe có biển số {plate} chưa được nhập vào hệ thống !", Color.Red);
            }
        }

        private void btnAddPlate_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            addForm.Show();

            this.Hide();
        }

        private void MainFormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
