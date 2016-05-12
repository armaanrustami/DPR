using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal class SCAN : IAlgorithm
    {
        private int direction = 0;
        private int start = 0;

        public SCAN(Dictionary<String, int> args)
        {
            start = args["start"];
            direction = args["direction"];
        }

        public void sort(List<int> data)
        {
        }
    }
}