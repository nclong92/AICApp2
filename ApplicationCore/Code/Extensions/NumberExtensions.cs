using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Code.Extensions
{
    public static class NumberExtensions
    {
        public static int GetNumberRandom(int maxValue)
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int random_number = rnd.Next(maxValue);

            return random_number;
        }
    }
}
