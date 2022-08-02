using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15
{
    class ArithProgression : ISeries
    {
        private int Start;
        private int Step;
        private int N;
        private int V;
        public ArithProgression(int step, int n)
        {
            Step = step;
            N = n;
        }
        public void SetStart(int x)
        {
            Start = x;
            V = x;
        }
        public int GetNext()
        {
           V += Step;
           return V;
        }

        public void Reset()
        {
            V = Start;
        }
    }
}
