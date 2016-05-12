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
            List<int> upper = new List<int>();
            List<int> lower = new List<int>();

            foreach (int val in data)
            {
                if (val >= start) upper.Add(val);
            }

            foreach (int val in data)
            {
                if (val < start) lower.Add(val);
            }

            upper.Sort();
            lower = lower.OrderByDescending(p => p).ToList();

            List<int> sorted = new List<int>();

            if (direction == 1)
            {
                sorted.AddRange(upper);
                sorted.AddRange(lower);
            }
            else
            {
                sorted.AddRange(lower);
                sorted.AddRange(upper);
            }

            data.Clear();

            foreach (int i in sorted)
            {
                data.Add(i);
            }
        }
    }
}