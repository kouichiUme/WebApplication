using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class GraphTheory<T> where T : new()

    {

        LinkedList<T> list;



        public GraphTheory(T t)
        {
            this.list = new LinkedList<T>();
            list.AddLast(t);

        }



        

    }
}
