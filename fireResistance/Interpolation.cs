using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fireResistance
{
    /// <summary>
    /// The class contains mathods for interpolation values in sheets 
    /// </summary>
    public class Interpolation
    {
        /// <remarks>Defines the index of a column or row depending on the received column or row name.
        /// The values after the comma indicate the position between columns or rows</remarks>
        /// <returns>double - Index</returns>
        public static double CheckValue(string value, Dictionary<string, int> dict)
        {
            double indexValue = -1;
            foreach (var i in dict)
            {
                if (i.Key == value)
                {
                    indexValue = Convert.ToDouble(i.Value);
                }
            }

            if (indexValue == -1)
            {
                double startkey = 0;
                double endkey = 0;
                foreach (var i in dict)
                {
                    if (Convert.ToDouble(i.Key) < Convert.ToDouble(value))
                    {
                        indexValue = i.Value;
                        startkey = Convert.ToDouble(i.Key);
                    }
                    if (Convert.ToDouble(i.Key) > Convert.ToDouble(value))
                    {
                        endkey = Convert.ToDouble(i.Key);
                        indexValue += (Convert.ToDouble(value) - startkey) / (endkey - startkey);
                        break;
                    }

                }
            }
            return indexValue;
        }

        /// <remarks>Interpolation between two values</remarks>
        /// <returns>double</returns>
        public static double interpolationColumn(Dictionary<string, int> firstDictWithKeyIsText, Dictionary<string, int> secondDictWithKeyIsNumber, string valueFirstDict, string valueSecondDict, double[,] sheet)
        {
            
            double valueRow = CheckValue(valueFirstDict, firstDictWithKeyIsText);
            double valueColumn = CheckValue(Convert.ToString(valueSecondDict), secondDictWithKeyIsNumber);
            double result = 0;

            if (valueColumn == Math.Truncate(valueColumn))
            {
                result = sheet[Convert.ToInt32(valueRow), Convert.ToInt32(valueColumn)];
            }
            else
            {
                double valueFirst = sheet[Convert.ToInt32(valueRow), Convert.ToInt32(Math.Truncate(valueColumn))];
                double valueSecond = sheet[Convert.ToInt32(valueRow), Convert.ToInt32(Math.Truncate(valueColumn)) + 1];
                if (valueFirst > valueSecond)
                {
                    result = Math.Round(valueFirst - Math.Abs(valueFirst - valueSecond) * (valueColumn - Math.Truncate(valueColumn)), 3);
                }
                else
                {
                    result = Math.Round(valueFirst + Math.Abs(valueFirst - valueSecond) * (valueColumn - Math.Truncate(valueColumn)), 3);
                }
            }
            return result;
        }

        /// <remarks>Determining the temperature at a specific point by interpolating the values of the tables</remarks>
        /// <returns>string - temperature in degrees Celsius</returns>
        public static string interpolationTemperatureSheet(double[,] sheet, Dictionary<string, int> DictWithKeyIsText, string valueRow, string valueColumn)
        {

            double valueIndexRow = CheckValue(valueRow, DictWithKeyIsText);
            double valueIndexColumn = CheckValue(valueColumn, DictWithKeyIsText);
            double result = 0;
            double resultRowFirst;
            double resultRowSecond;

            if (valueIndexRow == Math.Truncate(valueIndexRow) && valueIndexColumn == Math.Truncate(valueIndexColumn))
            {
                result = sheet[Convert.ToInt32(valueIndexRow), Convert.ToInt32(valueIndexColumn)];
            }
            else if (valueIndexRow == DictWithKeyIsText.Count - 1)
            {
                double valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)), Convert.ToInt32(Math.Truncate(valueIndexColumn))];
                double valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)), Convert.ToInt32(Math.Truncate(valueIndexColumn)) + 1];

                result = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndexColumn - Math.Truncate(valueIndexColumn));

            }
            else if (valueIndexColumn == DictWithKeyIsText.Count - 1)
            {
                double valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)), Convert.ToInt32(Math.Truncate(valueIndexColumn))];
                double valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)) + 1, Convert.ToInt32(Math.Truncate(valueIndexColumn))];

                result = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndexRow - Math.Truncate(valueIndexRow));
            }
            else
            {
                double valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)), Convert.ToInt32(Math.Truncate(valueIndexColumn))];
                double valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)), Convert.ToInt32(Math.Truncate(valueIndexColumn)) + 1];
                
                resultRowFirst = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndexColumn - Math.Truncate(valueIndexColumn));

                valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)) + 1, Convert.ToInt32(Math.Truncate(valueIndexColumn))];
                valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndexRow)) + 1, Convert.ToInt32(Math.Truncate(valueIndexColumn)) + 1];

                resultRowSecond = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndexColumn - Math.Truncate(valueIndexColumn));

                result = resultRowFirst - (resultRowFirst - resultRowSecond) * (valueIndexRow - Math.Truncate(valueIndexRow));
                
            }
            return Convert.ToString(Math.Round(result,0));
        }
    }
}
