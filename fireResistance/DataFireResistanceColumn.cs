using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace fireResistance
{
    /// <summary>
    /// Class contains all varibals for calculation fire resistance
    /// </summary>
    public class DataFireResistanceColumn
    {
        public string fireResistanceVolume;
        public double lenthElement;
        public int heightElement;
        public int widthElement;
        public double lenthFromArmatureToEdge;
        public string fixationElement;
        public string armatureClass;
        public string concreteType;
        public string concreteClass;
        public int armatureDiameter;
        public int armatureAmount;
        public double moment;
        public double strength;
        public double armatureSquare; //площадь арматуры
        public double concreteResistNormative; // Нормативное Сопротивление бетона
        public int distanceFromBringToPointAverageTemperature; // Расстояние от грани обогреваемой поверхности до сечения определяемого по п. 5.4
        public int criticalTemperatureConcrete = 600; // Критическая температура бетона
        public string temperatureArmature; // Температура на расстоянии а от обогреваемой поверхности
        public string temperatureConcrete; // Температура бетона
        public double gammaBT; // коэф. гамма б т
        public double betaB; // коэф. бета б
        public double concreteResistWithTemperatureNormative; // Нормативное сопративление бетона осевому сжатию с учетом действия температуры
        public double armatureResistNormative; // Нормативное сопративление арматуры растяжению
        public double armatureResistWithTemperatureNormative; // Нормативное сопротивление арматуры растяжению с учетом действия температуры
        public double gammaST; // коэф. гамма с т
        public double betaS; // коэф. бета с
        public double armatureResistSqueezeСalculation; // Расчетное сопротивление арматуры сжатию
        public double armatureResistSqueezeWithTemperatureСalculation; // Расчетное сопротивление арматуры сжатию с учетом температуры
        public double armatureResistStretchСalculation; // Расчетное сопротивление арматуры растяжению
        public double armatureResistStretchWithTemperatureСalculation; // Расчетное сопротивление арматуры растяжению с учетом температуры
        public double armatureElasticityModulus = 200000; // Модуль деформации арматуры
        public double concreteStartElasticityModulus; // Начальный модуль деформации бетона
        public double deepConcreteWarming; // Глубина прогрева бетона до критической температуры
        public double workHeight; // Рабочая высота сечения
        public double heightProfileWithWarming; // Высота сечения при нагреве
        public double workWidthWithWarming; // Рабочая ширина сечения при нагреве
        public double squareChangedProfile; // Площадь приведенного поперечного сечения
        public double workHeightProfileWithWarming; // Рабочая высота сечения при нагреве
        public double randomEccentricity; // Случайный эксцентриситет
        public double eccentricityStrength; // Эксцентриситет продольной силы относительно центра тяжести
        public double eccentricityTemperature = 0; // Температурный эксцентриситет, при 4 стороннем нагреве равно 0
        public double relativelyEccentricityStrength; // Относительное значение эксцентриситета продольной силы
        public double workLenth; // Рабочая длинна сечения
        public double fiL = 2; // Коэффициент учитывающий влияние длительности действия нагрузки
        public double momentOfInertiaConcrete; // Момент инерции бетонного сечения относительно центра тяжести приведенного сечения
        public double momentOfInertiaArmature; // Момент инерции арматуры относительно центра тяжести сечения элемента
        public double armatureElasticityModulusWithWarming; // Модуль деформации арматуры при нагреве
        public double concreteElasticityModulusWithWarming; // Модуль деформации бетона при нагреве
        public double flexuralStiffness; // Изгибная жесткость
        public double strengthCritical; // Критическая сила
        public double deflectionСoefficient; // Коэффициент учитывающий влияние прогиба
        public double finalEccentricity; // Расстояние от точки приложения силы до центра тяжести арматуры
        public double relativeDeformationArmature; // Относительная деформация растянутой арматуры
        public double relativeDeformationConcrete; // Относительная деформация сжатого бетона
        public double boundaryRelativeHeightSqueezeZone; // Граничная относительная высота сжатой зоны
        public double heightSqueezeZoneFirst; // Высота сжатой зоны в случае когда относительная высота сжатой зоны меньше граничной относительной высоты сжатой зоны
        public double heightSqueezeZoneSecond; // Высота сжатой зоны в случае когда относительная высота сжатой зоны больше граничной относительной высоты сжатой зоны
        public double heightSqueezeZone; // Высота сжатой зоны после проверки условия
        public double relativeHeightSqueezeZone; // Относительная высота сжатой зоны
        public double demandLeftPart; // левая часть условия
        public double demandRightPart; // правая часть условия
        public double result;
        public bool checkFirst = true;
        public bool checkSecond = true;
        public bool checkthird = true;

        public DataFireResistanceColumn(string fireResistanceVolume, double lenthElement, int heightElement, int widthElement,
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
            this.moment = moment / 0.00000010197162123;
            this.strength = strength / 0.00010197162123;
        }

        /// <summary>
        /// Assigns values to all unknown variables
        /// </summary>
        public void Сalculation()
        {
            armatureSquare = DataArmatureInfo.sheetArmatureDiameter[armatureDiameter] * armatureAmount;
            concreteResistNormative = DataFromSP63.sheetConcreteResistNormative[concreteClass];

            if (concreteType == "ТЯЖЕЛЫЙ, НА СИЛИКАТНОМ ЗАПОЛНИТЕЛЕ") deepConcreteWarming = Interpolation.interpolationColumn(Temperature.fireResistanceForCriticalTemperature, Temperature.temperatureForCriticalTemperature, fireResistanceVolume, Convert.ToString(Math.Min(Math.Min(widthElement, heightElement), 1000)), Temperature.criticalTemperatureConcreteSilicate);
            else deepConcreteWarming = Interpolation.interpolationColumn(Temperature.fireResistanceForCriticalTemperature, Temperature.temperatureForCriticalTemperature, fireResistanceVolume, Convert.ToString(Math.Min(Math.Min(widthElement, heightElement), 1000)), Temperature.criticalTemperatureConcreteCarbonate);
            workHeight = heightElement - lenthFromArmatureToEdge;
            heightProfileWithWarming = heightElement - 2 * deepConcreteWarming;
            workWidthWithWarming = widthElement - 2 * deepConcreteWarming;
            squareChangedProfile = 0.9 * heightProfileWithWarming * workWidthWithWarming;
            workHeightProfileWithWarming = workHeight - deepConcreteWarming;
            distanceFromBringToPointAverageTemperature = Convert.ToInt32(0.2 * workHeightProfileWithWarming) + Convert.ToInt32(deepConcreteWarming);
            if (concreteType == "ТЯЖЕЛЫЙ, НА СИЛИКАТНОМ ЗАПОЛНИТЕЛЕ") criticalTemperatureConcrete = 500;
            temperatureArmature = ChooseTemperatureArmature(fireResistanceVolume, lenthFromArmatureToEdge, widthElement, heightElement);
            temperatureConcrete = ChooseTemperatureConcrete(fireResistanceVolume, widthElement, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperatureConcrete);
            //gammaBT = Interpolation.interpolationColumn(DataFromeSP468.concreteTypeForSheet, DataFromeSP468.temperatureForSheet, concreteType, temperatureConcrete, DataFromeSP468.sheetGammaBT);
            gammaBT = 1;
            betaB = Interpolation.interpolationColumn(DataFromeSP468.concreteTypeForSheet, DataFromeSP468.temperatureForSheet, concreteType, temperatureConcrete, DataFromeSP468.sheetBetaB);
            concreteResistWithTemperatureNormative = concreteResistNormative * gammaBT;
            gammaST = Interpolation.interpolationColumn(DataFromeSP468.armatureClassForSheet, DataFromeSP468.temperatureForSheet, armatureClass, temperatureArmature, DataFromeSP468.sheetGammaSt);
            betaS = Interpolation.interpolationColumn(DataFromeSP468.armatureClassForSheet, DataFromeSP468.temperatureForSheet, armatureClass, temperatureArmature, DataFromeSP468.sheetBetaS);
            armatureResistNormative = DataFromSP63.sheetArmatureResistNormative[armatureClass];
            armatureResistWithTemperatureNormative = armatureResistNormative * gammaST;
            armatureResistSqueezeСalculation = DataFromSP63.sheetArmatureResistSqueezeСalculation[armatureClass];
            armatureResistSqueezeWithTemperatureСalculation = armatureResistSqueezeСalculation * gammaST;
            armatureResistStretchСalculation = DataFromSP63.sheetArmatureResistStretchСalculation[armatureClass];
            armatureResistStretchWithTemperatureСalculation = armatureResistStretchСalculation * gammaST;
            concreteStartElasticityModulus = DataFromSP63.sheetConcreteStartElasticityModulus[concreteClass];
           
            randomEccentricity = Math.Max(Math.Max(lenthElement/600, heightElement/30), 10);

            if (moment / strength > randomEccentricity) eccentricityStrength = moment / strength;
            else eccentricityStrength = randomEccentricity;

            if (eccentricityStrength / heightProfileWithWarming < 0.15) relativelyEccentricityStrength = 0.15;
            else if (eccentricityStrength / heightProfileWithWarming > 1.5) relativelyEccentricityStrength = 1.5;
            else relativelyEccentricityStrength = eccentricityStrength / heightProfileWithWarming;

            workLenth = DataFromeSP468.FixationElementSheet[fixationElement] * lenthElement;
            momentOfInertiaConcrete = workWidthWithWarming * Math.Pow(heightProfileWithWarming, 3) / 12;
            momentOfInertiaArmature = armatureSquare * Math.Pow(heightElement - 2 * lenthFromArmatureToEdge, 2) / 2;
            armatureElasticityModulusWithWarming = armatureElasticityModulus * betaS;
            concreteElasticityModulusWithWarming = concreteStartElasticityModulus * betaB;
            flexuralStiffness = 0.15 * concreteElasticityModulusWithWarming * momentOfInertiaConcrete / (fiL * (0.3 + relativelyEccentricityStrength)) + 0.7 * armatureElasticityModulusWithWarming * momentOfInertiaArmature;
            strengthCritical = Math.Pow(Math.PI, 2) * flexuralStiffness / Math.Pow(workLenth, 2);
            if (strength > strengthCritical)
            {
                checkFirst = false;
                return;
            }
            deflectionСoefficient = 1 / (1 - strength / strengthCritical);
            finalEccentricity = eccentricityStrength * deflectionСoefficient + 0.5 * (workHeightProfileWithWarming - lenthFromArmatureToEdge) + eccentricityTemperature;
            relativeDeformationArmature = armatureResistStretchWithTemperatureСalculation / armatureElasticityModulusWithWarming;
            boundaryRelativeHeightSqueezeZone = 0.8 / (1 + relativeDeformationArmature / 0.0035);
            heightSqueezeZoneFirst = (strength + armatureResistWithTemperatureNormative * armatureSquare - armatureResistSqueezeWithTemperatureСalculation * armatureSquare) / (concreteResistWithTemperatureNormative * workWidthWithWarming);
            heightSqueezeZoneSecond = (strength + armatureResistWithTemperatureNormative * armatureSquare * (1 + boundaryRelativeHeightSqueezeZone) / (1 - boundaryRelativeHeightSqueezeZone) - armatureResistSqueezeWithTemperatureСalculation * armatureSquare) /
                                            (concreteResistWithTemperatureNormative * workWidthWithWarming + 2 * armatureResistWithTemperatureNormative * armatureSquare / (workHeightProfileWithWarming * (1 - boundaryRelativeHeightSqueezeZone)));
            relativeHeightSqueezeZone = heightSqueezeZoneFirst / workHeightProfileWithWarming;
            
            if (relativeHeightSqueezeZone <= boundaryRelativeHeightSqueezeZone) heightSqueezeZone = heightSqueezeZoneFirst;
            else
            {
                heightSqueezeZone = heightSqueezeZoneSecond;
                checkSecond = false;
            }
                

            if (relativeHeightSqueezeZone < boundaryRelativeHeightSqueezeZone || heightSqueezeZone < workHeightProfileWithWarming)
            {
                demandLeftPart = strength * finalEccentricity;
                demandRightPart = concreteResistWithTemperatureNormative * workWidthWithWarming * heightSqueezeZone * (workHeightProfileWithWarming - 0.5 * heightSqueezeZone) + armatureResistSqueezeWithTemperatureСalculation * armatureSquare * (workHeight - lenthFromArmatureToEdge);
                result = demandLeftPart / demandRightPart;
                if (demandLeftPart > demandRightPart) checkthird = false;

            }
            else
            {
                distanceFromBringToPointAverageTemperature = Convert.ToInt32(0.5 * heightSqueezeZone);
                temperatureConcrete = ChooseTemperatureConcrete(fireResistanceVolume, widthElement, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperatureConcrete);
                //gammaBT = Interpolation.interpolationColumn(DataFromeSP468.concreteTypeForSheet, DataFromeSP468.temperatureForSheet, concreteType, temperatureConcrete, DataFromeSP468.sheetGammaBT);
                gammaBT = 1;
                betaB = Interpolation.interpolationColumn(DataFromeSP468.concreteTypeForSheet, DataFromeSP468.temperatureForSheet, concreteType, temperatureConcrete, DataFromeSP468.sheetBetaB);
                concreteResistWithTemperatureNormative = concreteResistNormative * gammaBT;
                concreteElasticityModulusWithWarming = concreteStartElasticityModulus * betaB;
                flexuralStiffness = 0.15 * concreteElasticityModulusWithWarming * momentOfInertiaConcrete / (fiL * (0.3 + relativelyEccentricityStrength)) + 0.7 * armatureElasticityModulusWithWarming * momentOfInertiaArmature;
                strengthCritical = Math.Pow(Math.PI, 2) * flexuralStiffness / Math.Pow(workLenth, 2);
                deflectionСoefficient = 1 / (1 - strength / strengthCritical);
                finalEccentricity = eccentricityStrength * deflectionСoefficient + 0.5 * (workHeightProfileWithWarming - lenthFromArmatureToEdge) + eccentricityTemperature;
                heightSqueezeZoneFirst = (strength + armatureResistWithTemperatureNormative * armatureSquare - armatureResistSqueezeWithTemperatureСalculation * armatureSquare) / (concreteResistWithTemperatureNormative * workWidthWithWarming);
                heightSqueezeZoneSecond = (strength + armatureResistWithTemperatureNormative * armatureSquare * (1 + boundaryRelativeHeightSqueezeZone) / (1 - boundaryRelativeHeightSqueezeZone) - armatureResistSqueezeWithTemperatureСalculation * armatureSquare) /
                                                (concreteResistWithTemperatureNormative * workWidthWithWarming + 2 * armatureResistWithTemperatureNormative * armatureSquare / (workHeightProfileWithWarming * (1 - boundaryRelativeHeightSqueezeZone)));
                relativeHeightSqueezeZone = heightSqueezeZoneFirst / workHeightProfileWithWarming;

                if (relativeHeightSqueezeZone <= boundaryRelativeHeightSqueezeZone) heightSqueezeZone = heightSqueezeZoneFirst;
                else heightSqueezeZone = heightSqueezeZoneSecond;

                demandLeftPart = strength * finalEccentricity;
                demandRightPart = concreteResistWithTemperatureNormative * workWidthWithWarming * heightSqueezeZone * (workHeightProfileWithWarming - 0.5 * heightSqueezeZone) + armatureResistSqueezeWithTemperatureСalculation * armatureSquare * (workHeight - lenthFromArmatureToEdge);
                result = demandLeftPart / demandRightPart;
                if (demandLeftPart > demandRightPart) checkthird = false;

            }

        }

        /// <summary>
        /// Determines the temperature of armature
        /// </summary>
        /// <remarks>if the width is 200 - 400 mm, the temperature is determined by
        /// the graphs of appendix B SP468 with interpolation. If the width is biger than 400 mm,
        /// the temperature value is taken as for the width of 400 mm</remarks>
        /// <returns>string - temperature of armature in degrees Celsius</returns>
        public static string ChooseTemperatureArmature(string fireResistanceVolume, double lenthFromArmatureToEdge, double widthElement, double heightElement = 0)
        {
            double width;

            if (heightElement != 0) width = Math.Min(heightElement, widthElement);
            else width = widthElement;
            string temperature = string.Empty;
            string temperatureFirst = string.Empty;
            string temperatureSecond = string.Empty;

            if (width == 200)
            {
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"200_{fireResistanceVolume}"))
                    {
                        temperature = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet200, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }
            }
            else if (width == 300)
            {
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"300_{fireResistanceVolume}"))
                    {
                        temperature = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet300, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }
            }
            else if (width >= 400)
            {
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"400_{fireResistanceVolume}"))
                    {
                        temperature = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet400, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }
            }
            else if (width > 200 && width < 300)
            {
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"200_{fireResistanceVolume}"))
                    {
                        temperatureFirst = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet200, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }

                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"300_{fireResistanceVolume}"))
                    {
                        temperatureSecond = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet300, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }
                temperature = Convert.ToString(Math.Round(Convert.ToInt32(temperatureFirst) - (width - 200) / 100 * (Convert.ToInt32(temperatureFirst) - Convert.ToInt32(temperatureSecond)), 0));
                if (Convert.ToInt32(temperature) > Convert.ToInt32(temperatureFirst)) temperature = temperatureFirst;
            }
            else if (width > 300 && width < 400)
            {
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"300_{fireResistanceVolume}"))
                    {
                        temperatureFirst = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet300, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }

                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"400_{fireResistanceVolume}"))
                    {
                        temperatureSecond = Interpolation.interpolationTemperatureSheet(name.Value, Temperature.lenthFromArmatureToEdgeSheet400, Convert.ToString(lenthFromArmatureToEdge), Convert.ToString(lenthFromArmatureToEdge));
                    }
                }
                temperature = Convert.ToString(Math.Round(Convert.ToInt32(temperatureFirst) - (width - 300) / 100 * (Convert.ToInt32(temperatureFirst) - Convert.ToInt32(temperatureSecond)), 0));
                if (Convert.ToInt32(temperature) > Convert.ToInt32(temperatureFirst)) temperature = temperatureFirst;
            }
            return temperature;
        }



        /// <summary>
        /// Determines the temperature of concrete
        /// </summary>
        /// <remarks>if the width(width biger height) is 200 - 400 mm, the temperature is determined by
        /// the graphs of appendix B SP468 with interpolation. If the width(width biger height) is biger than 400 mm,
        /// the temperature value is taken as for the width of 400 mm. If width biger height, then width and height change places</remarks>
        /// <returns>string - temperature of concrete in degrees Celsius</returns>
        public static string ChooseTemperatureConcrete(string fireResistanceVolume, int widthElement, int heightElement, int distanceFromBringToPointAverageTemperature, int criticalTemperature)
        {
            string temperature = string.Empty;
            if (widthElement == 200 && heightElement >= widthElement)
            {
                int lenthForCalculation = distanceFromBringToPointAverageTemperature;
                int widthForCalculation = widthElement / 2;
                if (lenthForCalculation > widthForCalculation) lenthForCalculation = widthForCalculation;
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"200_{fireResistanceVolume}"))
                    {
                        temperature = AverageTemperature.AverageTemperatureConcrete(name.Value, Temperature.lenthFromArmatureToEdgeSheet200, lenthForCalculation, criticalTemperature, widthForCalculation);
                    }
                }

            }
            else if (widthElement == 300 && heightElement >= widthElement)
            {
                int lenthForCalculation = distanceFromBringToPointAverageTemperature;
                int widthForCalculation = widthElement / 2;
                if (lenthForCalculation > widthForCalculation) lenthForCalculation = widthForCalculation;
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"300_{fireResistanceVolume}"))
                    {
                        temperature = AverageTemperature.AverageTemperatureConcrete(name.Value, Temperature.lenthFromArmatureToEdgeSheet300, lenthForCalculation, criticalTemperature, widthForCalculation);
                    }
                }
            }
            else if (widthElement == 400 && heightElement >= widthElement)
            {
                int lenthForCalculation = distanceFromBringToPointAverageTemperature;
                int widthForCalculation = widthElement / 2;
                if (lenthForCalculation > widthForCalculation) lenthForCalculation = widthForCalculation;
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"400_{fireResistanceVolume}"))
                    {
                        temperature = AverageTemperature.AverageTemperatureConcrete(name.Value, Temperature.lenthFromArmatureToEdgeSheet400, lenthForCalculation, criticalTemperature, widthForCalculation);
                    }
                }
            }
            else if (widthElement > 400 && heightElement >= widthElement)
            {
                int lenthForCalculation = distanceFromBringToPointAverageTemperature;
                int widthForCalculation = 400 / 2;
                if (lenthForCalculation > widthForCalculation) lenthForCalculation = widthForCalculation;
                int additionalWidth = (widthElement - 400) / 2;
                foreach (var name in Temperature.chooseArrayTemperature)
                {
                    if (name.Key.EndsWith($"400_{fireResistanceVolume}"))
                    {
                        temperature = AverageTemperature.AverageTemperatureConcrete(name.Value, Temperature.lenthFromArmatureToEdgeSheet400, lenthForCalculation, criticalTemperature, widthForCalculation, additionalWidth);
                    }
                }
            }
            else if (widthElement > 200 && widthElement < 300 && heightElement >= widthElement)
            {
                string temperatureFirst = ChooseTemperatureConcrete(fireResistanceVolume, 200, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperature);
                string temperatureSecond = ChooseTemperatureConcrete(fireResistanceVolume, 300, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperature);
                temperature = Convert.ToString(Math.Round(Convert.ToDouble(temperatureFirst) - (Convert.ToDouble(widthElement) - 200) / 100 * (Convert.ToDouble(temperatureFirst) - Convert.ToDouble(temperatureSecond)), 0));
            }
            else if (widthElement > 300 && widthElement < 400 && heightElement >= widthElement)
            {
                string temperatureFirst = ChooseTemperatureConcrete(fireResistanceVolume, 300, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperature);
                string temperatureSecond = ChooseTemperatureConcrete(fireResistanceVolume, 400, heightElement, distanceFromBringToPointAverageTemperature, criticalTemperature);

                temperature = Convert.ToString(Math.Round(Convert.ToDouble(temperatureFirst) - (Convert.ToDouble(widthElement) - 300) / 100 * (Convert.ToDouble(temperatureFirst) - Convert.ToDouble(temperatureSecond)), 0));
            }
            else if (widthElement > heightElement)
            {
                temperature = ChooseTemperatureConcrete(fireResistanceVolume, heightElement, widthElement, distanceFromBringToPointAverageTemperature, criticalTemperature);
            }
            return temperature;
        }
    }
}
