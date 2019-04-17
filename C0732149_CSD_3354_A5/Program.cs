using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732149_CSD_3354_A5
{
    class Program
    {
        static void Main(string[] args)
        {
            { new GenerateList().Run(57); }
        }
        class GenerateList
        {
            const int LEN = 100;
            ArrayList ListQ;
            public void Run(intAddUptoNumber)
            {
                Random r = new Random();
                ListQ = new ArrayList();
                for (int i = 0; i < LEN; i++) { ListQ.Add(r.Next(100)); }
                this.findTwoNumbersThatAddUpto(AddUpToNumber);
            }
        }
    }
}
