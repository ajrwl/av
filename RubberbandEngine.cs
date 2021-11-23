using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPFlyingVehicle
{
    public class RubberbandEngine : Engine
    {
        private int numWinds;

        private int numWindsFullyWound;

        public int NumWinds {
            get
            {
                return this.numWinds;
            }
            set
            {
                this.numWinds = value;
            }
        }

        public int NumWindsFullyWound {
            get
            {
                return numWindsFullyWound;
            }
            set
            {
                this.numWindsFullyWound = value;
            }
        }

        public bool IsFullyWound { 
            get { return NumWinds >= NumWindsFullyWound; } 
        }

        public RubberbandEngine()
        {
            this.NumWindsFullyWound = 20;
        }

        public override void Stop()
        {
            base.Stop();
            numWinds = 0;
        }
        public override void Start()
        {
            if (IsFullyWound == true)
            {
                base.Start();
            }
        }

        public override string About()
        {
            return base.About();
        }

        internal void Wind()
        {
            numWinds++;
        }

        internal void UnWind()
        {
            while (numWinds > 0)
            {
                numWinds--;
            }
        }
    }
}
