using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OOPFlyingVehicleCore;

namespace OOPFlyingVehicle
{
    public abstract class Engine : IEngine
    {
        public IEngine _iengine;

        public IEngine iEngine
        {
            get => _iengine;
            set
            {
                _iengine = value;
            }
        }

        public bool IsStarted = false;

        public Engine()
        {
            
        }

        public virtual void Start()
        {
            this.IsStarted = true;
        }

        public virtual void Stop()
        {
            this.IsStarted = false;
        }

        public virtual string About()
        {
            string engineString = this.ToString() + " is not started.";
            if (this.IsStarted)
            {
                engineString = engineString.Replace("not ", "");
            }
            return engineString;
        }
    }
}
