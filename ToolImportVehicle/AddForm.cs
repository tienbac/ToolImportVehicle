using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolImportVehicle.Entity;

namespace ToolImportVehicle
{
    public partial class AddForm : Form
    {
        Helper helper = new Helper();
        public AddForm()
        {
            InitializeComponent();
        }

        private void AddFormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm main = new MainForm();
            main.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            VehicleDisCount vehicle = new VehicleDisCount
            {
                BienSo = txtPlate.Text.ToUpper(),
                BOO = "",
                LoaiNgoaiLe = "",
                ThoiGianBatDau =
                    DateTime.ParseExact($"{dtpStartDate.Text}", "dd/MM/yyyy", CultureInfo.CurrentCulture),
                ThoiGianKetThuc =
                    DateTime.ParseExact($"{dtpEndDate.Text}", "dd/MM/yyyy", CultureInfo.CurrentCulture),
                MaChuongTrinh = txtNote.Text.ToUpper(),
                MaDoan = "",
                MaTram = "",
                LoaiXeMienGiam = cbbTypeVehicle.SelectedItem.ToString(),
                IsDiscount = !cbIsNotDiscount.Checked
            };

            center_plate center = new center_plate(vehicle);

            var check = helper.CheckExist<center_plate>($"lpn = '{center.lpn}' AND validity_end_date > GETDATE()");
            if (!check)
            {
                var status = helper.InsertOne<center_plate>(center);

                if (status == 1)
                {
                    helper.SetInvokeRTB(rtbAddNewStatus, $"LƯU THÀNH CÔNG XE : {center.ToString()}", Color.Green);
                }
                else
                {
                    helper.SetInvokeRTB(rtbAddNewStatus, $"LƯU KHÔNG THÀNH CÔNG XE : {center.ToString()}", Color.Red);
                }
            }
            else
            {
                var status = helper.UpdateOne<center_plate>(center, $"lpn = '{center.lpn}'");
                if (status == 1)
                {
                    helper.SetInvokeRTB(rtbAddNewStatus, $"CẬP NHẬT THÀNH CÔNG XE : {center.ToString()}", Color.Green);
                }
                else
                {
                    helper.SetInvokeRTB(rtbAddNewStatus, $"CẬP NHẬT LỖI XE : {center.ToString()}", Color.Red);
                }
            }
        }
    }
}
