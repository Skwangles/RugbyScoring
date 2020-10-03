using System;
using System.Collections.Generic;
using System.Text;

namespace Rugby_Scores
{
    class Team
    {
        private int conversionCount;
        private int tryCount;
        private int PointsModern { get; set; }
        private int PointsOld { get; set; }
        public Team()
        {
            PointsOld = 0;
            PointsModern = 0;
            tryCount = 0;
           conversionCount = 0;
        }

        public void AddTry()
        {
            tryCount++;
            PointsModern += 5;           
        }

        public void AddPenDrop()
        {
            PointsOld += 1;
            PointsModern += 3;                
        }

        public void AddConversion()
        {
            PointsOld += 1;
            PointsModern += 2;
            conversionCount++;
        }

        public int[] points()
        {
            var point = new int[]
            {
                PointsModern, PointsOld
            };
            return point;
        }

        public int Unconverted()
        {
            return (tryCount - conversionCount);
        }
    }
}
