using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    /// <summary>
    /// Sorts data
    /// </summary>
    internal interface IAlgorithm
    {
        /// <summary>
        /// Sorts the data in a certain way
        /// </summary>
        /// <param name="data">Data to sort</param>
        void sort(List<int> data);
    }
}