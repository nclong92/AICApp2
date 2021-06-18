using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class AicCommandModel
    {
        public AicCommandModel(string ghe, int trangThai, DateTime time)
        {
            Position = ghe;
            Status = (AicCommandStatus)trangThai;
            SendTime = time;
        }
        public AicCommandModel(string ghe, AicCommandStatus trangThai, DateTime time)
        {
            Position = ghe;
            Status = trangThai;
            SendTime = time;
        }
        public string Position { get; set; }
        public AicCommandStatus Status { get; set; }
        public DateTime SendTime { get; set; }
    }


    public class AicSpeecherModel
    {
        public AicSpeecherModel(string position, int count)
        {
            Position = position;
            Count = count;

        }
        public string Position { get; set; }
        public int Count { get; set; }

    }

    public enum AicCommandStatus
    {
        [Display(Name = "Hủy")]
        Huy = 0,
        [Display(Name = "Đăng ký")]
        DangKy = 1,
    }
}
