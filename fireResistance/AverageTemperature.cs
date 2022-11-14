using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireResistance
{
    public class AverageTemperature
    {
       public static string AverageTemperatureConcrete(double[,] sheet, Dictionary<string, int> dictWithKeyIsText, int lenthForCalculation, int criticalTemperature, int widthForCalculation, int additionalWidth = 0)
        {
            string result;
            double valueRow = Interpolation.CheckValue(Convert.ToString(lenthForCalculation), dictWithKeyIsText);
            int sumTemperature = 0;
            int count = 0;
            string text = string.Empty;
            int last = 0;
            for (int i = 0; i < widthForCalculation + 1; i++)
            {
                int current = Convert.ToInt32(Interpolation.interpolationTemperatureSheet(sheet, dictWithKeyIsText, Convert.ToString(lenthForCalculation), Convert.ToString(i)));
                if (current <= criticalTemperature)
                {
                    sumTemperature += current;
                    count++;
                    last = current;
                }
                text += $"  {i}: {current}";
            }
            sumTemperature += last * additionalWidth;
            if (sumTemperature == 0) result = "Все сечение нагрето выше критической температуры";
            else result = Convert.ToString(sumTemperature / (count + additionalWidth));
            return result;
        }
    }
}
