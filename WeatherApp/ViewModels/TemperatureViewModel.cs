using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel :BaseViewModel
    {
        public ITemperatureService TemperatureService;
        public DelegateCommand<string> GetTempCommand { get; set; }
        public TemperatureModel CurrentTemp;
        public void SetTemperatureService(ITemperatureService TempServ)
        {
            TemperatureService = TempServ;
        }

        public static double CelsiusInFahrenheit(double c)
        {
            return Math.Round(c * 9 / 5 + 32, 1);
        }
        public static double FahrenheitInCelsius(double f)
        {
            return Math.Round((f - 32) * 5 / 9, 1);
        }
        public bool CanGetTemp()
        {
            if (TemperatureService==null)
            {
                return false;
            }
            else 
            {
                return true;
            }
            
        }
        /// TODO : Ajoutez le code nécessaire pour réussir les tests et répondre aux requis du projet
    }
}
