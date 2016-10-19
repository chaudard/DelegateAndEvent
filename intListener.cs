using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsTest3
{
    class intListener
    {
        private string evaluate(intContainer aIntContainer)
        {
            string vString;
            if (aIntContainer.getIntValue() > 0)
                vString = "entier positif";
            else if (aIntContainer.getIntValue() < 0)
                vString = "entier négatif";
            else
                vString = "entier nul";
            return vString;
        }
        public void assignTo(intContainer aIntContainer)
        {
            aIntContainer.FintSignEvaluator += new intContainer.intSignEvaluator(evaluate);
        }
    }
}
