using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Quests
{
    class AssasinationQuest : QuestBase
    {
        public AssasinationQuest(QuestType qType = QuestType.ASSASINATION, string name = "Orc assasination", 
            string text = "Hello! Go kill any type of Enemy, I will pay", int goldReward = 10, int expReward = 10) 
            : base(qType, name, text, goldReward, expReward)
        {
        }
    }
}
