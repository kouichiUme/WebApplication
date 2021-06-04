using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.model
{
    public class RedBlackTree
    {

        log4net.ILog logger = log4net.LogManager.GetLogger("");

        public enum Color { Red,Black };

        


        public class Node {
            public Node parent;
            public Color color ;
            public Node left;
            public Node right;

            //Examples using enum:
            
            public Color RootNodeColor = Color.Red ;
            public Color DeletedNodeColor = Color.Black ;
           
                
        }


        private Node root = null;

        public RedBlackTree()
        {
            root= new Node();
        }

        // nullnode 
         static Object nullnode = null;


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


        public void deleteNode(RedBlackTree tree, Node z)
        {

            Node y = z;
            Color y_originalColor = y.color;
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


        public void deleteNode(Node x )//Dustin test comment
        {


            this.fixDelete(this,x);


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
                        w.color = RedBlackTree.Color.Black;
                        this.leftRotate(this, x);

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


        public void transplant(Node u ,Node v)
        {
            if(u.parent == RedBlackTree.nullnode)
            {
                this.root = v;

            }else if(u == u.parent.left)
            {
                u.parent.left = v;
            }else
            {
                u.parent.right = v;
            }

            v.parent = u.parent;
        }

        public void insert(Node x)
        {

            

            return;
        }


        private void leftRotate(Node x)
        {

            Node y = x.right;
            x.right = y.left;

            if(y.left == RedBlackTree.nullnode)
            {
                y.left.parent = x;
            }

            y.parent = x.parent;

            if(x.parent == RedBlackTree.nullnode)
            {
                this.root = y;

            }else if(x == x.parent.left){

                x.parent.left = y;
            }else
            {
                x.parent.right = y;
            }
            y.left = x;
            x.parent = y;




            return;
        }


    }
}
