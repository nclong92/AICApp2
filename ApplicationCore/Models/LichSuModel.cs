using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class LichSuModel
    {
        public LichSuModel(string message)
        {
            Message = message;
        }

        public string Message { get; set; }

        public static List<LichSuModel> GetList(IEnumerable<string> messages)
        {
            return messages.Select(m => new LichSuModel(m)).ToList();
        }
    }
}
