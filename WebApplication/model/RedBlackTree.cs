using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class RedBlackTree<Value, Comparable> where Comparable : System.IComparable<Comparable>
    {

        log4net.ILog logger = log4net.LogManager.GetLogger("");

        public enum Color { Red, Black };




        public class Node
        {
            public Node parent;
            public Color color;
            public Node left;
            public Node right;

            //Examples using enum:

            public Color RootNodeColor = Color.Red;
            public Color DeletedNodeColor = Color.Black;


            public Comparable key;
            public Value value;


        }


        public  Node root = null;

        public RedBlackTree()
        {
            root = new RedBlackTree<Value, Comparable>.Node();
           
                    
        }

        // nullnode 
        public static Node nullnode = null;


        public Node getFirstNode()
        {
            return this.getMaxNode();
        }


        public Node getMaxNode()
        {

            Node target = null;
            for (target = this.root; target.right != null; target = target.right)
            {

            }

            return target;

        }



        public void transPlant(Node u, Node v)
        {


            if (u.parent == RedBlackTree<Value, Comparable>.nullnode)
            {
                // this comment line

            }

        }


        public RedBlackTree<Value, Comparable> deleteNode(Node z)
        {

            Node y = z;
            Color y_originalColor = y.color;
            Node x = null;

            if (z.left == RedBlackTree<Value, Comparable>.nullnode)
            {

                x = z.right;
                this.transPlant(z, z.right);

            }
            this.fixDelete(x);


            return this;
        }


        /// <summary>
        ///  ノードを削除したあとに　赤赤になっていたら直すもの
        /// </summary>
        //public void fixDelete(RedBlackTree rbTree , Node u,Node v)
        /// delete fixup algorithm a 
        /// while x !== thee.null && x.color == black 
        /// 
        ///  if
        /// 
        public RedBlackTree<Value, Comparable> fixDelete(Node x)
        {
            /// 
            if (x == RedBlackTree<Value, Comparable>.nullnode && x.color == RedBlackTree<Value, Comparable>.Color.Black)
            {
                if (x == x.parent.left)
                {
                    Node w = x.parent.right;

                    if (w.color == RedBlackTree<Value, Comparable>.Color.Red)

                    {
                        w.color = RedBlackTree<Value, Comparable>.Color.Black;
                        this.leftRotate(x);

                    }
                }


            }



            return this;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"></param>
/*        public RedBlackTree<Value,Comparable> leftRotate( Node x)
        {

            Node y = x.right;
            x.right = y.left;

            if (y.left != RedBlackTree<Value,Comparable>.nullnode)
            {
                y.left.parent = x;
            }


            return this;

        }
*/

        public void transplant(Node u, Node v)
        {
            if (u.parent == RedBlackTree<Value, Comparable>.nullnode)
            {
                this.root = v;

            }
            else if (u == u.parent.left)
            {
                u.parent.left = v;
            }
            else
            {
                u.parent.right = v;
            }

            v.parent = u.parent;
        }

        public RedBlackTree<Value, Comparable> insert(Node x)
        {

            Node y = this.root;


            while (y.right == RedBlackTree<Value, Comparable>.nullnode)
            {

                if (y.right.key.CompareTo(x.key) < 0)
                {
                    {

                    }

                }

                y.left = x;

            }
            this.fixInsert();


            return this;
        }


        public RedBlackTree<Value, Comparable> fixInsert()
        {




            


            return this;
        }





        public RedBlackTree<Value, Comparable> leftRotate(Node x)
        {

            Node y = x.right;
            x.right = y.left;

            if (y.left != RedBlackTree<Value, Comparable>.nullnode)
            {
                y.left.parent = x;
            }

            y.parent = x.parent;

            if (x.parent == RedBlackTree<Value, Comparable>.nullnode)
            {
                this.root = y;

            }
            else if (x == x.parent.left)
            {

                x.parent.left = y;
            }
            else
            {
                x.parent.right = y;
            }
            y.left = x;
            x.parent = y;


            return this;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public RedBlackTree<Value, Comparable> rightRotate(Node x)
        {

            /// 今日ここやる 6/6(日）    
            Node y = x.left;
            x.left = y.right;

 
           if (y.right != RedBlackTree<Value, Comparable>.nullnode)
            {
                y.right.parent = x;
            }

            y.parent = x.parent;

            if (x.parent == RedBlackTree<Value, Comparable>.nullnode)
            {
                this.root = y;

            }
            else if (x == x.parent.right)
            {

                x.parent.right = y;
            }
            else
            {
                x.parent.left = y;
            }
            y.right = x;
            x.parent = y;



            return this;

        }


        

    }
}

