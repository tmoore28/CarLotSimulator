using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {

        }
        public Car(string year, string make, string model, string engineNoise, string honkNoise, bool isDriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDriveable = isDriveable;  
        }
        
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; } = true;

        public string MakeEngineNoise(string noise)
        {
            EngineNoise = noise;
            return noise;
        }
        public string MakeHonkNoise(string noise)
        {
            HonkNoise = noise;
            return noise;
        }
        public string year;
        public string model;
        public string make;
        public string engineNoise;
        public string honkNoise;
        public string isDriveable;

    }

}
