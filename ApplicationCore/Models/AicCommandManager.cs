using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models
{
    public class AicCommandManager : IDisposable
    {
        public static object lockOnly = new object();
        private AicCommandManager() { }

        private List<AicCommandModel> commandList = new List<AicCommandModel>();
        private List<string> speecherList = new List<string>();

        private static AicCommandManager instance;
        public static AicCommandManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockOnly)
                    {
                        if (instance == null)
                        {
                            instance = new AicCommandManager();
                        }
                    }
                }

                return instance;
            }
        }



        public void Add(string ghe, int trangThai)
        {
            var cmd = new AicCommandModel(ghe, trangThai, DateTime.Now);

            lock (commandList)
            {
                commandList.Add(cmd);
                ProcessAddeded(cmd);
            }
        }

        private int GetCountSpeecher(string ghe)
        {
            var count = 0;
            lock (speecherList)
            {

                var list = commandList.Where(m => m.Position == ghe).ToList();

                var tmp = 0;
                foreach (var item in list)
                {
                    if (item.Status == AicCommandStatus.DangKy)
                    {
                        tmp = 1;

                    }
                    else
                    {
                        if (tmp == 1)
                        {
                            count++;
                            tmp = 0;
                        }
                    }


                }
                if (tmp == 1)
                {
                    count++;
                }
            }
            return count;
        }

        private void AddSpeecher(string ghe)
        {
            lock (speecherList)
            {
                if (!speecherList.Contains(ghe))
                {
                    speecherList.Add(ghe);

                    ProcessAddedSpeecher(new AicSpeecherModel(ghe, GetCountSpeecher(ghe)));
                }
            }

        }


        private void RemoveSpeecher(string ghe)
        {
            lock (speecherList)
            {
                if (speecherList.Contains(ghe))
                {
                    speecherList.Remove(ghe);
                    ProcessRemovedSpeecher(ghe);
                }

            }

        }
        #region Events

        public event EventHandler<AicCommandArgs> OnAdded;
        public event EventHandler<AicSpeecherArgs> OnAddedSpeecher;
        public event EventHandler<PositionArgs> OnRemovedSpeecher;

        public void ProcessAddeded(AicCommandModel cmd)
        {
            if (OnAdded != null)
            {
                OnAdded(this, new AicCommandArgs(cmd));
            }


            if (cmd.Status == AicCommandStatus.DangKy)
            {
                AddSpeecher(cmd.Position);
            }
            else
            {
                RemoveSpeecher(cmd.Position);
            }
        }
        private void ProcessAddedSpeecher(AicSpeecherModel aicSpeecher)
        {
            if (OnAddedSpeecher != null)
            {
                OnAddedSpeecher(this, new AicSpeecherArgs(aicSpeecher));
            }
        }
        private void ProcessRemovedSpeecher(string position)
        {
            if (OnRemovedSpeecher != null)
            {
                OnRemovedSpeecher(this, new PositionArgs(position));
            }
        }
        #endregion


        public void Dispose()
        {
            commandList.Clear();

        }
    }

    public class AicCommandArgs : EventArgs
    {
        public AicCommandModel Data { get; set; }

        public AicCommandArgs(AicCommandModel model)
        {
            this.Data = model;
        }
    }
    public class PositionArgs : EventArgs
    {
        public string Data { get; set; }

        public PositionArgs(string model)
        {
            this.Data = model;
        }
    }
    public class AicSpeecherArgs : EventArgs
    {
        public AicSpeecherModel Data { get; set; }

        public AicSpeecherArgs(AicSpeecherModel model)
        {
            this.Data = model;
        }
    }
}
