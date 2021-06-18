using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public sealed class LichSuModel
    {
        private LichSuModel() { }

        static readonly LichSuModel LICHSU_DANGKY = new LichSuModel();

        public static LichSuModel Instance => LICHSU_DANGKY;

        //private List<string> _messageReceived = new List<string>();

        //public void AddMessage(string message) => _messageReceived.Add(message);

        //public List<string> GetList => _messageReceived;

        private List<AicCommandModel> _commands = new List<AicCommandModel>();
        public void AddCommand(AicCommandModel model) => _commands.Add(model);
        public List<AicCommandModel> GetList => _commands;
        
    }
}
