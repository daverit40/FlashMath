using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlashMath.Classes
{
    public class Game
    {
        public int factFamily;
        public List<Answer> answers;

        public Game(int FactFamily)
        {
            this.factFamily = FactFamily;
        }

        public void recordAnswer(Answer answer)
        {
            this.answers.Add(answer);
        }
    }
}