using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;
using System;

namespace ExtraConcentratedJuice.ExtraVehicleFix
{
    public class ExtraVehicleFix : RocketPlugin<ExtraVehicleFixConfig>
    {
        public static DateTime lastUpdated;
        protected override void Load()
        {
            Logger.Log("Extra's Wheels Fix Loaded!");
            lastUpdated = DateTime.Now;
        }
        protected override void Unload()
        {
           
        }

        public void FixedUpdate()
        {
            if (Level.isLoaded && (DateTime.Now - lastUpdated).TotalSeconds > Configuration.Instance.update_interval)
            {
                FixTires();
            }
        }

        public void FixTires()
        {
            foreach (InteractableVehicle v in VehicleManager.vehicles)
            {
                foreach(Wheel w in v.tires)
                {
                    if (!w.isAlive)
                    {
                        w.askRepair();
                    }
                }
            }
        }
    }
}
