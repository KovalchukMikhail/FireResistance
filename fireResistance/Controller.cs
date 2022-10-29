using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireResistance
{
    public class Controller
    {
        public void Run(string comboBoxFireResistanceLimit, double lenthElement, double heightElement, double widthElement,
            double lenthFromArmatureToEdge, string fixationElement, string armatureClass,
            string concreteType, string concreteClass, int armatureDiameter, int armatureAmount,
            double moment, double strength)
        {
            //Data data = new Data(comboBoxFireResistanceLimit, lenthElement, heightElement, widthElement, lenthFromArmatureToEdge, fixationElement,
            //    armatureClass, concreteType, concreteClass, armatureDiameter, armatureAmount, moment, strength);

            string text = $"{comboBoxFireResistanceLimit} {lenthElement} {heightElement} {widthElement} {lenthFromArmatureToEdge} {fixationElement} {armatureClass} {concreteType} " +
                            $"{concreteClass} {armatureDiameter} {armatureAmount} {moment} {strength}";

            MessageBox.Show(text);
        }

    }
}
