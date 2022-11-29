﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fireResistance
{
    /// <summary>
    /// The class contains a dictionary with the diameter of the armature and the corresponding area of the armature 
    /// </summary>
    public class DataArmatureInfo
    {
        public static Dictionary<int, double> sheetArmatureDiameter = new Dictionary<int, double>()
        {
            {6, 28.3},
            {8, 50.3},
            {10, 78.5},
            {12, 113.1},
            {14, 153.9},
            {16, 201.1},
            {18, 254.5},
            {20, 314.2},
            {22, 380.1},
            {25, 490.9},
            {28, 615.8},
            {32, 804.3},
            {36, 1017.9},
            {40, 1256.6}
        };

    }
}
