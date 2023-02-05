using System;

namespace EternalQuest
{
    public class Goal
    {
        private string name;
        private bool isComplete;
        private int timesCompleted;
        private int targetAmount;
        private int _value;
        private int bonusValue;


        public int BonusValue 
        {
         get { return bonusValue; }
         set { bonusValue = value; }
        }
        public int Value 
        {
        get { return _value; }
        set { _value = value; }
        }

        public int TimesCompleted 
        {
         get { return timesCompleted; }
         set { timesCompleted = value; }
        }

        public int TargetAmount 
        {
         get { return targetAmount; }
         set { targetAmount = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IsComplete
        {
            get { return isComplete; }
            set { isComplete = value; }
        }

        public virtual int GetPoints()
        {
            return 0;
        }
    }
}
