using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class Airport
    {
        private List<AerialVehicle> aerialVehicles = new List<AerialVehicle>();

        private int maxVehicles;

        private string airportCode;

        public List<AerialVehicle> Vehicles
        {
            get
            {
                return this.aerialVehicles;
            }
            set => this.aerialVehicles = value;
        }

        public int MaxVehicles {
            get
            {
                return this.maxVehicles;
            }
            set
            {
                this.maxVehicles = value;
            }

        }

        public string AirportCode {
            get
            {
                return this.airportCode;
            }
            set
            {
                this.airportCode = value;
            }
        }

        private static int defaultMaxVehicles = 5;

        public Airport(string Code) : this(Code, defaultMaxVehicles)
        {
            
        }

        public Airport(string Code, int MaxVehicles)
        {
            maxVehicles = MaxVehicles;
        }

        public string Land(AerialVehicle a)
        {
            //Don't allow more vehicle to lan than the max
            if (this.Vehicles.Count < this.MaxVehicles)
            {
                this.aerialVehicles.Add(a);
                a.CurrentAltitude = 0;
                a.IsFlying = false;
                a.StopEngine();
                return string.Format("{0} lands at {1}", a, this.AirportCode);
            }
            return string.Format("{0} is full can't land here",this.AirportCode);
        }

        public string TakeOff(AerialVehicle a)
        {
            
            return a.TakeOff() + " from " + this.AirportCode;
        }

        public string AllTakeOff()
        {
            string allTakeOff = string.Empty;
            for (int i = 0; i < this.Vehicles.Count; i++)
            {
                allTakeOff += this.TakeOff(this.Vehicles[i]);
            }
            
            return allTakeOff;

        }

        public string Land(List<AerialVehicle> landing)
        {
            string stringLand = string.Empty;
            foreach(AerialVehicle av in landing)
            {
                stringLand += this.Land(av);   
            }

            return stringLand;
        }

    }
}
