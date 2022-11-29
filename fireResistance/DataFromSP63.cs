using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireResistance
{
    /// <summary>
    /// The class contains data from SP63 
    /// </summary>
    public class DataFromSP63
    {

        // Нормативное сопротивление бетона сжатию. Данные из таблицы 6.7 СП63 
        public static Dictionary<string, double> sheetConcreteResistNormative = new Dictionary<string, double>()
        {
            {"B15", 11},
            {"B20", 15},
            {"B25", 18.5},
            {"B30", 22},
            {"B35", 25.5},
            {"B40", 29},
            {"B45", 32},
            {"B50", 36}
        };

        // Начальный модуль деформации бетона. Данные из таблицы 6.11 СП63
        public static Dictionary<string, double> sheetConcreteStartElasticityModulus = new Dictionary<string, double>()
        {
            {"B15", 24000},
            {"B20", 27500},
            {"B25", 30000},
            {"B30", 32500},
            {"B35", 34500},
            {"B40", 36000},
            {"B45", 37000},
            {"B50", 38000}
        };

        // Нормативное сопротивление арматуры растяжению. Данные из таблицы 6.13 СП63. Список классов арматуры взят из СП 468
        public static Dictionary<string, double> sheetArmatureResistNormative = new Dictionary<string, double>()
        {
            {"A240", 240},
            {"А400", 390},
            {"А500", 500},
            {"А600", 600},
            {"А800", 800},
            {"А1000", 1000},
            {"В500", 500},
            {"А500С МАРКА 25Г2С ПО ГОСТ Р 52544-2006", 500},
            {"А600С МАРКИ 18Г2СФ ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ", 600},
            {"А500С МАРКИ Ст3Гпс ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ ПО ГОСТ 34028-2016", 500}
        };
        // Расчетное сопротивление арматуры сжатию. Данные из таблицы 6.14 СП63. Список классов арматуры взят из СП 468
        public static Dictionary<string, double> sheetArmatureResistSqueezeСalculation = new Dictionary<string, double>()
        {
            {"A240", 210},
            {"А400", 340},
            {"А500", 400},
            {"А600", 400},
            {"А800", 400},
            {"А1000", 400},
            {"В500", 380},
            {"А500С МАРКА 25Г2С ПО ГОСТ Р 52544-2006", 400},
            {"А600С МАРКИ 18Г2СФ ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ", 400},
            {"А500С МАРКИ Ст3Гпс ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ ПО ГОСТ 34028-2016", 400}
        };

        // Расчетное сопротивление арматуры растяжению. Данные из таблицы 6.14 СП63. Список классов арматуры взят из СП 468
        public static Dictionary<string, double> sheetArmatureResistStretchСalculation = new Dictionary<string, double>()
        {
            {"A240", 210},
            {"А400", 340},
            {"А500", 435},
            {"А600", 520},
            {"А800", 695},
            {"А1000", 870},
            {"В500", 415},
            {"А500С МАРКА 25Г2С ПО ГОСТ Р 52544-2006", 435},
            {"А600С МАРКИ 18Г2СФ ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ", 520},
            {"А500С МАРКИ Ст3Гпс ТЕРМОМЕХАНИЧЕСКИ УПРОЧНЕННАЯ ПО ГОСТ 34028-2016", 435}
        };

    }
}

