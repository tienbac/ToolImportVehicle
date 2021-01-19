using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using ToolImportVehicle.Entity;

namespace ToolImportVehicle
{
    public class Helper
    {
        #region ReadFile

        public List<center_plate> ReadFileVehicles(string path)
        {
            var listPlates = new List<center_plate>();
            try
            {
                using (var reader = new StreamReader(path))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();

                        if (String.IsNullOrEmpty(line) || line.Contains("Biển số xe (*);BOO gán thẻ (*);Loại ngoại lệ (*);Ngày bắt đầu hiệu lực (*);Ngày hết hiệu lực (*);Mã chương trình KM (*);Mã Trạm;Mã Đoạn;Loại xe miễn giảm") || line.Contains("STT;Trạm;Biển số;Thời hạn;LOẠI XE;LOẠI BIỂN")) continue;

                        VehicleDisCount vehicle = new VehicleDisCount(line);
                        center_plate center = new center_plate(vehicle);

                        listPlates.Add(center);
                    }
                }
            }
            catch (Exception)
            {
                //
            }

            return listPlates;
        }

        #endregion

        #region SQL

        public SqlConnection GetConnection(string connection = "")
        {
            var cnn = connection == "" ? AppSettings.ConnectionString : connection;
            var sqlConnection = new SqlConnection(cnn);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            return sqlConnection;
        }

        public List<T> GetAll<T>(string where = "", bool isMtc = false)
        {
            try
            {
                using (var db = GetConnection())
                {
                    var query = $"SELECT * FROM {typeof(T).Name} {where}";
                    var list = db.Query<T>(query).ToList();
                    return list;
                }

            }
            catch (Exception)
            {
                return null;
            }
        }

        public object GetOne<T>(string where = "")
        {
            try
            {
                using (var db = GetConnection())
                {
                    var query = $"SELECT TOP(1) * FROM {typeof(T).Name} Where {where}";
                    var list = db.Query<T>(query).FirstOrDefault();


                    return list;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void InsertMany<T>(List<T> list)
        {
            try
            {
                using (var db = GetConnection())
                {
                    var query = GetQuery<T>("");
                    db.Execute(query, list);
                }

            }
            catch (Exception)
            {
            }
        }

        public int InsertOne<T>(T obj)
        {
            var status = 0;
            try
            {
                using (var db = GetConnection())
                {
                    var query = GetQuery<T>("");
                    status = db.Execute(query, obj);
                }

            }
            catch (Exception)
            {
            }

            return status;
        }

        public bool CheckExist<T>(string where = "")
        {
            try
            {
                using (var connection = GetConnection())
                {
                    var query = $"SELECT * FROM {typeof(T).Name} Where {where}";
                    var result = connection.Query(query).Any();

                    return result;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public int UpdateOne<T>(T obj, string where)
        {
            var status = 0;
            try
            {
                using (var db = GetConnection())
                {
                    var query = GetQuery<T>(where, false);
                    status = db.Execute(query, obj);
                }
            }
            catch (Exception)
            {
                //
            }

            return status;
        }

        #endregion

        #region Gennerate
        public string GetQuery<T>(string where, bool isInsert = true)
        {
            var listProperties = typeof(T).GetProperties();
            if (isInsert)
            {
                var propertiesString = "";
                var propertiesValues = "";
                foreach (var prpInfo in listProperties)
                {
                    if (prpInfo == listProperties.Last())
                    {
                        propertiesString += $"{prpInfo.Name.ToLower()}";
                        propertiesValues += $"@{prpInfo.Name.ToLower()}";
                    }
                    else if (prpInfo.Name.ToLower() == "id")
                    {
                        continue;
                    }
                    else
                    {
                        propertiesString += $"{prpInfo.Name.ToLower()},";
                        propertiesValues += $"@{prpInfo.Name.ToLower()},";
                    }
                }
                return $"INSERT INTO {typeof(T).Name}({propertiesString}) VALUES ({propertiesValues})";
            }
            else
            {
                var updateValues = "";
                foreach (var prpInfo in listProperties)
                {
                    if (prpInfo == listProperties.Last())
                    {
                        updateValues += $"{prpInfo.Name.ToLower()} = @{prpInfo.Name.ToLower()}";
                    }
                    else if (prpInfo.Name.ToLower() == "id")
                    {
                        continue;
                    }
                    else
                    {
                        updateValues += $"{prpInfo.Name.ToLower()} = @{prpInfo.Name.ToLower()},";
                    }
                }
                return $"UPDATE {typeof(T).Name} SET {updateValues} WHERE {where}";
            }
        }

        #endregion

        #region InVoke

        public void SetInvokeRTB(RichTextBox status, string message, Color color)
        {
            if (status.InvokeRequired)
            {
                status.BeginInvoke((MethodInvoker)delegate ()
                {
                    status.ForeColor = color;
                    status.AppendText(message + Environment.NewLine + Environment.NewLine);
                });
            }
            else
            {
                status.ForeColor = color;
                status.AppendText(message + Environment.NewLine + Environment.NewLine);
            }
        }

        #endregion
    }
}
