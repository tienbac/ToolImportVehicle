using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToolImportVehicle.Entity
{
    public class VehicleDisCount
    {
        public string BienSo { get; set; }
        public string BOO { get; set; }
        public string LoaiNgoaiLe { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }
        public string MaChuongTrinh { get; set; }
        public string MaTram { get; set; }
        public string MaDoan { get; set; }
        public string LoaiXeMienGiam { get; set; }

        public bool IsDiscount { get; set; }

        public VehicleDisCount()
        {
            
        }

        public VehicleDisCount(string line)
        {
            var data = line.Split(';');
            if (data.Length >= 9)
            {
                BienSo = data[0];
                BOO = data[1];
                LoaiNgoaiLe = data[2];
                ThoiGianBatDau = DateTime.ParseExact($"{data[3]}", "dd/MM/yyyy", CultureInfo.CurrentCulture);
                ThoiGianKetThuc = DateTime.ParseExact($"{data[4]}", "dd/MM/yyyy", CultureInfo.CurrentCulture);
                MaChuongTrinh = data[5];
                MaTram = data[6];
                MaDoan = data[7];
                LoaiXeMienGiam = data[8];
                IsDiscount = true;
            }
            else
            {
                BienSo = data[2];
                ThoiGianBatDau = DateTime.ParseExact($"31/12/2020", "dd/MM/yyyy", CultureInfo.CurrentCulture);
                ThoiGianKetThuc = DateTime.ParseExact($"{data[3]}", "dd/MM/yyyy", CultureInfo.CurrentCulture);
                MaChuongTrinh = $"Xe Miễn Phí {data[5]}";
                MaTram = data[1];
                IsDiscount = false;
            }
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
