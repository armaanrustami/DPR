using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiskScheduling
{
    interface IAlgorithem
    {

      //  void Addvalue(List<int> list,int value);
       // void remove(List<int> list, int index);
        int process(List<int> list, int value);
    }
}
