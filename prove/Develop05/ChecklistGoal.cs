using System;

namespace EternalQuest
{
    public class ChecklistGoal : Goal
    {
        private int pointsPerCompletion;
        private int numberOfCompletions;
        private int targetNumberOfCompletions;
        private int bonusPoints;
        private int items;

        public int Items
        {
            get { return items; }
            set { items = value; }
        }

        public int PointsPerCompletion
        {
            get { return pointsPerCompletion; }
            set { pointsPerCompletion = value; }
        }

        public int NumberOfCompletions
        {
            get { return numberOfCompletions; }
            set { numberOfCompletions = value; }
        }

        public int TargetNumberOfCompletions
        {
            get { return targetNumberOfCompletions; }
            set { targetNumberOfCompletions = value; }
        }

        public int BonusPoints
        {
            get { return bonusPoints; }
            set { bonusPoints = value; }
        }

        public override int GetPoints()
        {
            int totalPoints = PointsPerCompletion * NumberOfCompletions;
            if (NumberOfCompletions == TargetNumberOfCompletions)
            {
                totalPoints += BonusPoints;
                IsComplete = true;
            }
            return totalPoints;
        }
    }
}
