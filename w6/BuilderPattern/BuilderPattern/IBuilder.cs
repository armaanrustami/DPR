using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    internal interface IBuilder
    {
        void buildGold(bool toggle);

        void buildNFC(bool toggle);

        void buildScreen(bool toggle);

        void buildSpeaker(bool toggle);

        void buildWifi(bool toggle);

        String getName();

        SmartPhone getPhone();
    }
}