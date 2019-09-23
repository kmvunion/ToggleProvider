﻿using KMV.ToggleProvider;
using KMV.ToggleProvider.Providers;
using KMV.ToggleProvider.Configuration;
using System;

namespace UseTogglesCore
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Using KMV.ToggleProvider demo!");

            UseAppsetingJsonToggleConfiguration();

            Console.ReadLine();
        }

        private static void UseAppsetingJsonToggleConfiguration()
        {
            var path = @"E:\Projects\ToggleProvider\examples\core\CoreGetToggles\ToggleJSONConfig.json";

            IToggleProvider provider = new JsonToggleProvider(
                new JsonConfiguration(path,false,false,true)                
                .AddToggleSection("feature.toggles"));

            PrintToggle("feature1", provider);
            PrintToggle("feature2", provider);
            PrintToggle("feature3", provider);
            PrintToggle("feature4", provider);
        }

        private static void PrintToggle(string featureName, IToggleProvider provider)
        {
            var toggleValue = provider.GetToggleValue(featureName) ? "True" : "False";
            Console.WriteLine($"Toggle value {featureName} is {toggleValue}");
        }
    }
}
