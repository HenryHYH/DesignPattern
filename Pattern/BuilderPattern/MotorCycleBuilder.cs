namespace Pattern.BuilderPattern
{
    public class MotorCycleBuilder : VehicleBuilder
    {
        public MotorCycleBuilder()
        {
            Vehicle = new Vehicle("MotorCycle");
        }

        public override void BuildDoors()
        {
            Vehicle.Doors = "0";
        }

        public override void BuildEngine()
        {
            Vehicle.Engine = "500 cc";
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "MotorCycle Frame";
        }

        public override void BuildWheels()
        {
            Vehicle.Wheels = "2";
        }
    }
}
