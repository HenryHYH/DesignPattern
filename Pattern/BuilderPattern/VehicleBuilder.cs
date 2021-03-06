﻿namespace Pattern.BuilderPattern
{
    public abstract class VehicleBuilder
    {
        public Vehicle Vehicle { get; protected set; }

        public abstract void BuildDoors();

        public abstract void BuildFrame();

        public abstract void BuildEngine();

        public abstract void BuildWheels();
    }
}
