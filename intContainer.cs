using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsTest3
{
    class intContainer
    {
        public event intSignEvaluator FintSignEvaluator;
        public delegate string intSignEvaluator(intContainer aIntContainer);

        private int FintValue;
        public intContainer(int aValue)
        {
            FintValue = aValue;
        }
        public int getIntValue()
        {
            return FintValue;
        }

        public string evaluation()
        {
            string vString;
            if (FintSignEvaluator != null)
                vString = FintSignEvaluator(this);
            else
                vString = "il n y a pas d evaluateur";
            return vString;
        }

    }
}
