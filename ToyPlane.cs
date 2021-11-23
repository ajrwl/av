using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOPFlyingVehicle
{
    public class ToyPlane : Airplane
    {
        private bool isWoundUP = false;

        bool IsWoundUP
        {
            get
            {
                return isWoundUP;
            }
            
        }

        public ToyPlane()
        {
            this.MaxAltitude = 50;
            this.Engine = new ToyEngine();
        }

        public override void StartEngine()
        {
            ((ToyEngine)Engine).Start();
        }

        public override string TakeOff()
        {
           return base.TakeOff();
        }

        public void WindUp()
        {
            while (((ToyEngine)Engine).IsFullyWound == false)
            {
                this.Wind();
            }
        }

        public void Wind()
        {
            ((ToyEngine)Engine).Wind();
            isWoundUP = true;
        }

        public void UnWind()
        {
            ((ToyEngine)Engine).UnWind();
        }

        public void UnWindCompletely()
        {
            ((ToyEngine)Engine).NumWinds = 0;
        }

        protected string getWindUpString()
        {
            string woundUp = "It's not wound up.";
            if(IsWoundUP) woundUp = woundUp.Replace("not ", "");
            return woundUp;
        }

        public override string About()
        {
            return base.About() + "\n" + this.getWindUpString();
        }
    }
}
