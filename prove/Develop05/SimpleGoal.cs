using System;

namespace EternalQuest
{
    public class SimpleGoal : Goal
    {
        private int points;

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public override int GetPoints()
        {
            if (IsComplete)
            {
                return Points;
            }
            return 0;
        }
    }
}
