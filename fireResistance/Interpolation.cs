﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fireResistance
{
    public class Interpolation
    {
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

        public static string interpolationTemperatureSheet(double[,] sheet, Dictionary<string, int> DictWithKeyIsText, string value)
        {

            double valueIndex = CheckValue(value, DictWithKeyIsText);
            double result = 0;
            double resultColumnFirst;
            double resultColumnSecond;
            MessageBox.Show($"{valueIndex}");

            if (valueIndex == Math.Truncate(valueIndex))
            {
                result = sheet[Convert.ToInt32(valueIndex), Convert.ToInt32(valueIndex)];
            }
            else
            {
                double valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndex)), Convert.ToInt32(Math.Truncate(valueIndex))];
                double valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndex)), Convert.ToInt32(Math.Truncate(valueIndex)) + 1];
                
                resultColumnFirst = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndex - Math.Truncate(valueIndex));

                valueFirst = sheet[Convert.ToInt32(Math.Truncate(valueIndex)) + 1, Convert.ToInt32(Math.Truncate(valueIndex))];
                valueSecond = sheet[Convert.ToInt32(Math.Truncate(valueIndex)) + 1, Convert.ToInt32(Math.Truncate(valueIndex)) + 1];

                resultColumnSecond = valueFirst - Math.Abs(valueFirst - valueSecond) * (valueIndex - Math.Truncate(valueIndex));

                result = resultColumnFirst - (resultColumnFirst - resultColumnSecond) * (valueIndex - Math.Truncate(valueIndex));
                
                MessageBox.Show($"{valueIndex} {resultColumnFirst} {resultColumnSecond}");
            }
            return Convert.ToString(Math.Round(result,0));
        }
    }
}
