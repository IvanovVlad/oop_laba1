using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGamewithpatternsandso.Quests
{
    class TradeQuest : QuestBase
    {
        public TradeQuest(QuestType qType = QuestType.TRADE, string name = "Trade",
            string text = "Hello! Sell me some thing", int goldReward = 10, int expReward = 10)
            : base(qType, name, text, goldReward, expReward)
        {
        }
    }
}
