
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class RodCutProblem
    {
        SortedDictionary<string, string> openWith;


        public RodCutProblem()
        {


            openWith = new SortedDictionary<string, string>();
            openWith.Add("1","2");

            SortedDictionary<int, int> intDictionary= new SortedDictionary<int, int>();

            intDictionary.Add(1, 3);

        }


        public String[] getOptions()
        {

            String[] values = new string[10];
            return values;
        }




    }
}
