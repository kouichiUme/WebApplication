using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class GraphTheory<T> where T : class

    {

        LinkedList<T> list;



        public GraphTheory(T t)
        {
            this.list = new LinkedList<T>();
            list.AddLast(t);

        }

        /// <summary>
        /// 最小全域木
        /// </summary>
        public void genericMinimumSpanningTree()
        {



        }

        public void primMinimumSpanningTree()
        {
            Queue<T> q = new Queue<T>();

            
            while (q.Count!=0)
            {
                T t = q.Min();
                T b = null;
                while((b = this.adj(t)) != null)
                {

                }
            }


        }


        public T adj(T q)
        {
            LinkedListNode<T> t = this.list.Find(q);
            return t.Value;
        }

        /// <summary>
        /// 
        /// </summary>
        public void singleSourceShortestPathProblem()
        {


        }

        public void initalizeSingleSource()
        {


        }

        public void relax() { }



        public void digShortestPath()
        {

        }

        public void bellmanFord()
        {

        }

        public void dijkstra()
        {

        }



    }
}
