using System;
using System.Collections.Generic;

namespace P03_TrafficLights
{
    public enum TrafficLightState
    {
        Red,
        Green,
        Yellow
    }

    public class TrafficLight
    {
        private TrafficLightState state;

        public TrafficLight(string initialState)
        {
            this.state = Enum.Parse<TrafficLightState>(initialState);
        }

        public void Update()
        {
            if (this.state == TrafficLightState.Red)
            {
                this.state = TrafficLightState.Green;
            }
            else if (this.state == TrafficLightState.Green)
            {
                this.state = TrafficLightState.Yellow;
            }
            else if (this.state == TrafficLightState.Yellow)
            {
                this.state = TrafficLightState.Red;
            }
        }

        public override string ToString()
        {
            return this.state.ToString();
        }
    }

    public class TrafficLightsProgram
    {
        public static void Main()
        {
            string[] initialStates = Console.ReadLine().Split();
            int updatesCount = int.Parse(Console.ReadLine());
            
            List<TrafficLight> trafficLights = new List<TrafficLight>();

            foreach (var state in initialStates)
            {
                trafficLights.Add(new TrafficLight(state));
            }
            
            for (int i = 0; i < updatesCount; i++)
            {
                foreach (var light in trafficLights)
                {
                    light.Update();
                }

                Console.WriteLine(string.Join(" ", trafficLights));
            }
        }
    }
}
