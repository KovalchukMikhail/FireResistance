using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fireResistance
{
    /// <summary>
    /// The class contains a method that starts the calculation and creates a report 
    /// </summary>
    public class Controller
    {
        /// <summary>
        /// Launches a method for determining fire resistance and a method for creating a report
        /// </summary>
        public void RunFireResistanceColumn(string comboBoxFireResistanceLimit, double lenthElement, int heightElement, int widthElement,
            double lenthFromArmatureToEdge, string fixationElement, string armatureClass,
            string concreteType, string concreteClass, int armatureDiameter, int armatureAmount,
            double moment, double strength)
        {
            DataFireResistanceColumn data = new DataFireResistanceColumn(comboBoxFireResistanceLimit, lenthElement, heightElement, widthElement, lenthFromArmatureToEdge, fixationElement,
                armatureClass, concreteType, concreteClass, armatureDiameter, armatureAmount, moment, strength);

            data.Сalculation();

            CreateDoc doc = new CreateDoc();
            doc.Create(data);
        }

    }
}
