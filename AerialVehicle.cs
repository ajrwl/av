using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public abstract class AerialVehicle
    {
        private int maxAltitude;

        private int currentAltitiude;

        private bool isFlying = false;

        private Engine engine = new Engine();

        public Engine Engine {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public bool IsFlying
        {
            get
            {
                return isFlying;
            }
            set
            {
                this.isFlying = value;
            }
        }

        public int MaxAltitude {
            get
            {
                return maxAltitude;
            }
            set
            {
                this.maxAltitude = value;
            }
         }

        public int CurrentAltitude {
            get
            {
                return currentAltitiude;
            }
            set
            {
                this.currentAltitiude = value;
            }
        }   

        public AerialVehicle()
        {
            this.Engine = new Engine();
            
        }

        public virtual void StartEngine()
        {
            Engine.IsStarted = true;
        }

        public virtual void StopEngine()
        {
            Engine.IsStarted = false;
        }

        public void FlyUp()
        {
            if (Engine.IsStarted == true)
            {
                FlyUp(1000);
            }
        }

        public void FlyUp(int HowManyFeet)
        {
            if (HowManyFeet < 0)
            {
                throw new InvalidOperationException("Can't FlyUp a negative amount");
            } else if (currentAltitiude + HowManyFeet <= maxAltitude)
            {
                currentAltitiude += HowManyFeet;
            } else
            {
                throw new InvalidOperationException("Can't surpass max altitude");
            }
        }

        public void FlyDown()
        {
            if (CurrentAltitude > 0)
            {
                FlyDown(1000);
            }
        }

        public void FlyDown(int HowManyFeet)
        {
            if (HowManyFeet < 0) {
                throw new InvalidOperationException("Can't FlyDown a negative amount");
            } else if (currentAltitiude - HowManyFeet >= 0)
            {
                currentAltitiude -= HowManyFeet;
            }
        }
        public virtual string TakeOff()
        {
            if (Engine.IsStarted == true)
            {
                return "OOPFlyingVehicle.Airplane is flying";
            }
            return "OOPFlyingVehicle.Airplane can't fly it's engine is not started.";
        }
        
        /// <summary>
        /// Returns a string that describes if an engine is started
        /// </summary>
        /// <returns></returns>
        protected string getEngineStartedString()
        {
            return this.Engine.About();
        }

        public virtual string About()
        {
            string about = string.Format("This {0} has a max altitude of {1} ft. \nIt's current altitude is {2} ft. \n{3}", 
                this.ToString(), this.MaxAltitude.ToString(), this.CurrentAltitude, this.getEngineStartedString());
            return about;
            
        }
    }
}
