using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ToolImportVehicle.Entity
{
	public class center_plate
    {
        public int id { get; set; }
        public string lpn { get; set; }
        public byte classify_type { get; set; }
        public decimal ticket_value { get; set; }
        public string fullimage_filename { get; set; }
        public string plateimage_filename { get; set; }
        public bool isPriority { get; set; }
        public string barcode { get; set; }
        public string classify_profile { get; set; }
        public string owner { get; set; }
        public string address { get; set; }
        public DateTime registration_date { get; set; }
        public string registration_number { get; set; }
        public int loading_capacity { get; set; }
        public int seat_capacity { get; set; }
        public DateTime validity_start_date { get; set; }
        public DateTime validity_end_date { get; set; }
        public string ticket_type { get; set; }
        public bool is_violation { get; set; }
        public string note { get; set; }
        public byte status { get; set; }
        public bool is_display { get; set; }
        public DateTime created_Date { get; set; }
        public int userid { get; set; }
        public int approver_id { get; set; }
        public bool is_discount { get; set; }

        public center_plate()
        {
            
        }

        public center_plate(VehicleDisCount vehicle)
        {
            lpn = vehicle.BienSo;
            classify_type = Convert.ToByte(vehicle.LoaiXeMienGiam);
            ticket_value = 0;
            fullimage_filename = "";
            plateimage_filename = "";
            isPriority = !vehicle.IsDiscount;
            barcode = "";
            classify_profile = "";
            owner = "";
            address = "";
            registration_date = DateTime.Now;
            registration_number = "";
            loading_capacity = 0;
            seat_capacity = 0;
            validity_start_date = vehicle.ThoiGianBatDau;
            validity_end_date = vehicle.ThoiGianKetThuc;
            ticket_type = "1";
            is_violation = false;
            note = vehicle.MaChuongTrinh;
            status = 1;
            is_display = true;
            created_Date = DateTime.Now;
            userid = 0;
            approver_id = 0;
            is_discount = vehicle.IsDiscount;
        }

        public override string ToString()
        {
            return $"Biển số: {lpn}   ||   Loại xe: {classify_type}   ||   {note}   ||   Bắt đầu từ : {validity_start_date:dd/MM/yyyy}   ||   Kết thúc : {validity_end_date:dd/MM/yyyy}   ||   Ngày nhập: {created_Date:dd/MM/yyyy HH:mm}";
        }
    }
}
