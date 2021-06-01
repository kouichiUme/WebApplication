using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class RedBlackTree
    {

        log4net.ILog logger = log4net.LogManager.GetLogger("");

        public Enum Color { Red,Black };

        public class Node {
            public Node parent;
            public Color color ;
            public Node left;
            public Node right;

            //Examples using enum:
            
            public Color RootNodeColor = Color.Red ;
            public Color DeletedNodeColor = Color.Black ;
           
                
        }



        // nullnode 
         static Object nullnode = null;


        public void deleteNode(RedBlackTree tree, Node z)
        {

            Node y = z;
            y_originalColor = y.color;
            Node x = null;

            if(z.left == RedBlackTree.nullnode)
            {

                x = z.right;
               transPlant(this, z, z.right);

            }
            fixDelete(this, x);


            return;
        }


        public void transPlant(RedBlackTree tree,Node u,Node v)
        {


            if(u.parent == RedBlackTree.nullnode)
            {
                // this comment line
                         

           }

        }


        public void deleteNode()//Dustin test comment
        {

            



            return ;
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
        public void fixDelete(RedBlackTree rbTree , Node x)
        {
            /// 
            if (x ==RedBlackTree.nullnode && x.color == RedBlackTree.Color.Black)
            {
                if(x == x.parent.left)
                {
                    Node w = x.parent.right;

                        if(w.color == RedBlackTree.Color.Red)

                    {
                        w.color = RedBlackThree.color.BLack;
                        this.leftRotate(this, x, parent);

                    }
                }


            }



            return;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <param name="t"></param>
        /// <param name="x"></param>
        public void leftRotate(RedBlackTree t,Node x)
        {

            Node y = x.right;
            x.right = y.left;

            if(y.left != RedBlackTree.nullnode)
            {
                y.left.parent = x;
            }


        }
    }
}
