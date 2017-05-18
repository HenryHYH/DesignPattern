namespace Pattern.BuilderPattern
{
    public class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override void BuildDoors()
        {
            Vehicle.Doors = "4";
        }

        public override void BuildEngine()
        {
            Vehicle.Engine = "2500 cc";
        }

        public override void BuildFrame()
        {
            Vehicle.Frame = "Car Frame";
        }

        public override void BuildWheels()
        {
            Vehicle.Wheels = "4";
        }
    }
}
