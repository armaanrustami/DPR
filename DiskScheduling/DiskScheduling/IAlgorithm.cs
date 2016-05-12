using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    internal interface IAlgorithm
    {
        int pop(List<int>values);

        void push(List<int>values);
        
    }
}