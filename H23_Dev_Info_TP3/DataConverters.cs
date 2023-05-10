using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H23_Dev_Info_TP3
{
    public class DataConverters
    {
		public static double FahrenheitEnCelsius(double temperatureF)
		{
			// la température maximale enregistrée sur Terre est de 134 degrés Fahrenheit
			if(temperatureF > 134)
				throw new ArgumentOutOfRangeException("La température ne peut pas être supérieure à 134 degrés Fahrenheit");
			
			// la température minimale enregistrée sur Terre est de -128 degrés Fahrenheit
			if(temperatureF < -128)
				throw new ArgumentOutOfRangeException("La température ne peut pas être inférieure à -128 degrés Fahrenheit");


			double temperatureC = (temperatureF - 32) * 5 / 9;
			return temperatureC;
		}
	}
}
