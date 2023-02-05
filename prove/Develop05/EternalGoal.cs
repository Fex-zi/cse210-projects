using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        private int pointsPerCompletion;

        public int PointsPerCompletion
        {
            get { return pointsPerCompletion; }
            set { pointsPerCompletion = value; }
        }

        public override int GetPoints()
        {
            return PointsPerCompletion;
        }
    }
}
