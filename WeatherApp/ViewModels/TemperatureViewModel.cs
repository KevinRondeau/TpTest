using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class TemperatureViewModel : BaseViewModel
    {
        public ITemperatureService TemperatureService;
        public DelegateCommand<string> GetTempCommand;
        
        public TemperatureModel CurrentTemp { get; set; }

        public TemperatureViewModel()
        {   
                GetTempCommand = new DelegateCommand<string>(GetCurrentTemp, CanGetTemp);
        }


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
        public bool CanGetTemp(String s)
        {       
                return TemperatureService != null;
        }
        private void GetCurrentTemp(Object o)
        {   
            if (TemperatureService == null)
                throw new NullReferenceException();
            _ = GetCurrentTempAsync();
        }
        private async Task GetCurrentTempAsync()
        {
            CurrentTemp = await TemperatureService.GetTempAsync();
        }
       
    }

    
}
