using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireResistance
{
    public class Data
    {
        public string fireResistanceVolume;
        public double lenthElement;
        public double heightElement;
        public double widthElement;
        public double lenthFromArmatureToEdge;
        public string fixationElement;
        public string armatureClass;
        public string concreteType;
        public string concreteClass;
        public int armatureDiameter;
        public int armatureAmount;
        public double moment;
        public double strength;

        public Data(string fireResistanceVolume, double lenthElement, double heightElement, double widthElement,
                        double lenthFromArmatureToEdge, string fixationElement, string armatureClass, string concreteType,
                        string concreteClass, int armatureDiameter, int armatureAmount, double moment, double strength)
        {
            this.fireResistanceVolume = fireResistanceVolume;
            this.lenthElement = lenthElement;
            this.heightElement = heightElement;
            this.widthElement = widthElement;
            this.lenthFromArmatureToEdge = lenthFromArmatureToEdge;
            this.fixationElement = fixationElement;
            this.armatureClass = armatureClass;
            this.concreteType = concreteType;
            this.concreteClass = concreteClass;
            this.armatureDiameter = armatureDiameter;
            this.armatureAmount = armatureAmount;
            this.moment = moment;
            this.strength = strength;
        }

    }
}
