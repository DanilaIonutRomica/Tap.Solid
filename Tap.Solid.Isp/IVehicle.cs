namespace Tap.Solid.Isp
{
    internal interface ISteeringVehicle
    {
        public void SteerLeft();
        public void SteerRight();
    }
    internal interface IMovingVehicle
    {
        public void MoveForward();
        public void MoveBackwards();
    }
}
