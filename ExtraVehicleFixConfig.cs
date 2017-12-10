using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtraConcentratedJuice.ExtraVehicleFix
{
    public class ExtraVehicleFixConfig : IRocketPluginConfiguration
    {
        public int update_interval;
        public void LoadDefaults()
        {
            update_interval = 1;
        }
    }
}
