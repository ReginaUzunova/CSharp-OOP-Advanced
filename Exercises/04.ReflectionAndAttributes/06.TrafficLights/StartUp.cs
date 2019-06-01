using System;
using System.Collections.Generic;
using System.Reflection;

namespace TrafficLights
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int number = int.Parse(Console.ReadLine());

            TrafficLight[] trafficLights = new TrafficLight[input.Length];

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            for (int i = 0; i < number; i++)
            {
                List<string> result = new List<string>();

                foreach (var light in trafficLights)
                {
                    light.Update();
                    var field = typeof(TrafficLight).GetField("currentColor", BindingFlags.NonPublic | BindingFlags.Instance);
                    result.Add(field.GetValue(light).ToString());
                }

                Console.WriteLine(string.Join(" ", result));
            }
        }
    }
}
