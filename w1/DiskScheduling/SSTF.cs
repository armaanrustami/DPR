using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal class SSTF : IAlgorithm
    {
        // value to which to compare
        private int start = 0;

        public SSTF(Dictionary<String, int> args)
        {
            start = args["start"];
        }

        public void sort(List<int> data)
        {
            List<int> sorted = data.OrderBy(item => Math.Abs(start - item)).ToList();
            data.Clear();

            foreach (int i in sorted)
            {
                data.Add(i);
            }
        }
    }
}