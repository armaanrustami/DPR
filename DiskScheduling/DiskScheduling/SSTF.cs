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

        public SSTF(int start)
        {
            this.start = start;
        }

        public void process(List<int> data)
        {
            // easier than in-place
            List<int> sorted = new List<int>();
            sorted.Add(start);
            data.Remove(start);

            int next = 0;
            int min = Math.Abs(data[0] - start);

            for (int i = 0; i < data.Count; i++)
            {
                next = Math.Abs(data[i] - start);
                if (min < next)
                {
                    sorted.Add(data[i]);
                }
            }

            data = sorted;
        }
    }
}