using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        public static double CelsiusInFahrenheit(double c)
        {
            return Math.Round(c * 9 / 5 + 32, 1);
        }
        public static double FahrenheitInCelsius(double f)
        {
            return Math.Round((f - 32) * 5 / 9, 1);
        }
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
    }
}
