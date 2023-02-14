using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Equation
{
    internal class matrix
    {
        private readonly List<lineareq> listOfEquations = new List<lineareq>();

        private int width;

        public int Width
        {
            get
            {
                return this.width;
            }
        }

        public int Length
        {
            get
            {
                return listOfEquations.Count;
            }
        }

        public lineareq RecieveEquation(int index)
        {
            return listOfEquations[index];
        }

        public lineareq LayoutOfEquation(int index, lineareq LinEq)
        {
            return listOfEquations[index] = LinEq;
        }

        public void ForwardElimination()
        {
            int Rows = this.Length;
            int Column = this.Width;

            for (int LRow = 0; LRow < Rows; LRow++)
            {
                for (int i = LRow + 1; i < Column - 1; i++)
                {
                    double Element = this.RecieveEquation(i).Array[LRow] / this.RecieveEquation(LRow).Array[LRow];

                    for (int LCol = LRow; LCol < Column; LCol++)
                        this.RecieveEquation(i).Array[LCol] -= Element * this.RecieveEquation(LRow).Array[LCol];
                }
            }
        }

        internal void ShowResults()
        {
            throw new NotImplementedException();
        }

        internal void JoinEquation(lineareq lineareq)
        {
            throw new NotImplementedException();
        }
    }
}
