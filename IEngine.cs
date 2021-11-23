using System;
namespace OOPFlyingVehicleCore
{
    public interface IEngine : IAboutable
    {

        void Start();

        void Stop();
    }
}
