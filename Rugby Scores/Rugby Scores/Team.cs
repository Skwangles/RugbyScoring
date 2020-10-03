using System;
using System.Collections.Generic;
using System.Text;

namespace Rugby_Scores
{
    class Team
    {
        private int conversionCount;
        private int tryCount;
        private int pointsModern;
        private int pointsOld;
        public Team()
        {
            pointsOld = 0;
            pointsModern = 0;
            tryCount = 0;
           conversionCount = 0;
        }

        public void AddTry()
        {
            tryCount++;
            pointsModern += 5;           
        }

        public void AddPenDrop()
        {
            pointsOld += 1;
            pointsModern += 3;                
        }

        public void AddConversion()
        {
            pointsOld += 1;
            pointsModern += 2;
            conversionCount++;
        }

        public int Unconverted()
        {
            return (tryCount - conversionCount);
        }
    }
}
