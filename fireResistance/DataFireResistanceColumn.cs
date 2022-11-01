﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireResistance
{
    public class DataFireResistanceColumn
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
        public double armatureSquare; //площадь арматуры
        public double concreteResistNormative; // Нормативное Сопротивление бетона
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
        public double relativelyEccentricityStrength; // Относительное значение эксцентриситета продольной силы
        public double workLenth; // Рабочая длинна сечения
        public double fiL = 2; // Коэффициент учитывающий влияние длительности действия нагрузки
        public double momentOfInertiaConcrete; // Момент инерции бетонного сечения относительно центра тяжести приведенного сечения
        public double momentOfInertiaArmature; // Момент инерции арматуры относительно центра тяжести сечения элемента
        public double armatureElasticityModulusWithWarming; // Модуль деформации арматуры при нагреве
        public double concreteElasticityModulusWithWarming; // Модуль деформации бетона при нагреве
        public double FlexuralStiffness; // Изгибная жесткость
        public double strengthCritical; // Критическая сила
        public double deflectionСoefficient; // Коэффициент учитывающий влияние прогиба
        public double finalEccentricity; // Расстояние от точки приложения силы до центра тяжести арматуры
        public double relativeDeformationArmature; // Относительная деформация растянутой арматуры
        public double relativeDeformationConcrete; // Относительная деформация сжатого бетона
        public double boundaryRelativeHeightSqueezeZone; // Граничная относительная высота сжатой зоны
        public double heightSqueezeZone; // Высота сжатой зоны в случае когда относительная высота сжатой зоны меньше граничной относительной высоты сжатой зоны
        public double relativeHeightSqueezeZone; // Относительная высота сжатой зоны
        public double result;





        public DataFireResistanceColumn(string fireResistanceVolume, double lenthElement, double heightElement, double widthElement,
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

        public void Сalculation()
        {
            armatureSquare = DataArmatureInfo.sheetArmatureDiameter[armatureDiameter] * armatureAmount;
            concreteResistNormative = DataFromSP63.sheetConcreteResistNormative[concreteClass];
            temperatureArmature = "600";//!!!!!!!!!!!!!!!!!!!!!!!!!!!! сделать автоматическим
            temperatureConcrete = "500";//!!!!!!!!!!!!!!!!!!!!!!!!!!!! сделать автоматическим
            gammaBT = Interpolation.interpolationColumn(DataFromeSP468.concreteTypeForSheet, DataFromeSP468.temperatureForSheet, concreteType, temperatureConcrete, DataFromeSP468.sheetGammaBT);
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
            deepConcreteWarming = 60;//!!!!!!!!!!!!!!!!!!!!!!!!!!!! сделать автоматическим
            workHeight = heightElement - lenthFromArmatureToEdge;
            heightProfileWithWarming = heightElement - 2 * deepConcreteWarming;
            workWidthWithWarming = widthElement - 2 * deepConcreteWarming;
            squareChangedProfile = 0.9 * heightProfileWithWarming * workWidthWithWarming;
            workHeightProfileWithWarming = workHeight - deepConcreteWarming;
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
            FlexuralStiffness = 0.15 * concreteElasticityModulusWithWarming * momentOfInertiaConcrete / (fiL * (0.3 + relativelyEccentricityStrength)) + 0.7 * armatureElasticityModulusWithWarming * momentOfInertiaArmature;
            strengthCritical = Math.Pow(Math.PI, 2) * FlexuralStiffness / Math.Pow(workLenth, 2);


        }
    }
}
