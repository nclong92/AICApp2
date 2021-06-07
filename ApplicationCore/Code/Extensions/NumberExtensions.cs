using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Code.Extensions
{
    public static class NumberExtensions
    {
        public static int GetNewRandom(int oldNumber)
        {
            var random = new Random();
            var randomGhe = random.Next(1, 1000);

            if (randomGhe != oldNumber)
            {
                return randomGhe;
            }
            else
            {
                return GetNewRandom(oldNumber);
            }

        }
    }
}
