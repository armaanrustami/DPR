using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal class FIFO : IAlgorithm
    {
        public int pop(List<int> values)
        {

            return values[0];

        }

        public void push(List<int> values,int val)
        {
            values.Add(val);
        }
    }
}