﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal class FIFO : IAlgorithm
    {
        public void process(List<int> data)
        {
            data.RemoveAt(0);
        }
    }
}