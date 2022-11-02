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
        public void RunFireResistanceColumn(string comboBoxFireResistanceLimit, double lenthElement, double heightElement, double widthElement,
            double lenthFromArmatureToEdge, string fixationElement, string armatureClass,
            string concreteType, string concreteClass, int armatureDiameter, int armatureAmount,
            double moment, double strength)
        {
            DataFireResistanceColumn data = new DataFireResistanceColumn(comboBoxFireResistanceLimit, lenthElement, heightElement, widthElement, lenthFromArmatureToEdge, fixationElement,
                armatureClass, concreteType, concreteClass, armatureDiameter, armatureAmount, moment, strength);

            data.Сalculation();

            //string text = $"{comboBoxFireResistanceLimit} {lenthElement} {heightElement} {widthElement} {lenthFromArmatureToEdge} {fixationElement} {armatureClass} {concreteType} " +
            //                $"{concreteClass} {armatureDiameter} {armatureAmount} {moment} {strength}";

            string text = Convert.ToString(data.boundaryRelativeHeightSqueezeZone) + "  " + Convert.ToString(data.workHeightProfileWithWarming) + "  " + Convert.ToString(data.relativeHeightSqueezeZone) + "  " + Convert.ToString(data.heightSqueezeZoneFirst) + "  " + Convert.ToString(data.heightSqueezeZoneSecond) + "  " + Convert.ToString(data.heightSqueezeZone) + "  " + Convert.ToString(data.demandLeftPart) + "  " + Convert.ToString(data.demandRightPart) + "  " + Convert.ToString(data.result);

            MessageBox.Show(text);
        }

    }
}
