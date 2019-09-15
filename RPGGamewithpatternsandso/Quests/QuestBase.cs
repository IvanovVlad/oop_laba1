using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Quests
{
    class QuestBase
    {
        public enum QuestType
        {
            ASSASINATION,
            TRADE
        }
        public QuestType questType;
        public string Name;
        public string Text;
        public int GoldReward;
        public int ExpReward;

        public QuestBase(QuestType qType, string name = "NoName", string text = "Text", int goldReward = 0, int expReward = 0)
        {
            questType = qType;
            Name = name;
            Text = text;
            GoldReward = goldReward;
            ExpReward = expReward;
        }

        public void GiveReward()
        {
            Characters.Hero.GetInstance(Characters.BaseCharacter.ClassSpec.WARRIOR).heroresources.gold += GoldReward;
            Characters.Hero.GetInstance(Characters.BaseCharacter.ClassSpec.WARRIOR).Expirience += GoldReward;
            Console.WriteLine($"Quest name '{Name}' completed. \nRewards: exp {ExpReward}, gold {GoldReward}");
        }

        public override string ToString()
        {
            return $"Quest name '{Name}'.\n{Text} \nRewards: exp {ExpReward}, gold {GoldReward}";
        }
    }
}
