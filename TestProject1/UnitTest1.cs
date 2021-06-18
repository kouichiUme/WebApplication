using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.model;
using System;


namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void TestMethod1()
        {
            var f = new WebApplication.model.Finll();


            f.a();

            Console.WriteLine("hoge");




        }
        [TestMethod]
        public void testLeftRotate()
        {
            RedBlackTree <long, long> rdTree = new RedBlackTree<long, long>();


            RedBlackTree<long, long>.Node node = new RedBlackTree<long, long>.Node();
            rdTree.insert(node);


            RedBlackTree<long, long>.Node x = rdTree.getMaxNode();
            RedBlackTree<long, long>.Node toRecovery = x.left;
            rdTree.leftRotate(x);
            rdTree.rightRotate(toRecovery);
        }



        [TestMethod]
        public void TestRedBlackTree()
        {

            RedBlackTree<long,long> rdTree = new RedBlackTree<long,long>();

            RedBlackTree<long, long>.Node node = rdTree.getFirstNode();

            rdTree.leftRotate(node).rightRotate(node);
            
            rdTree.deleteNode(node).rightRotate(node);



        }

        //https://www.youtube.com/watch?v=95s3ndZRGbk
        //Make the tree at 2:27 (for testing right rotate)
        [TestMethod]
        public void TestMakeSimpleRedBlackTree()
        {
            RedBlackTree<long,long> rdTree = new RedBlackTree<long,long>();
            rdTree.root.value = 10;

            RedBlackTree<long, long>.Node tempNode;
            RedBlackTree<long, long>.Node root = rdTree.root;

            root.left = new RedBlackTree<long, long>.Node();
            root.left.value = 5;
            root.left.parent = root;
            

            RedBlackTree<long, long>.Node toRotate = root.left;

            RedBlackTree<long, long>.Node no17 = new RedBlackTree<long, long>.Node();
            no17.parent = root;
            no17.value = 12;

            root.right = no17;
            
           

            tempNode = root.left;
            tempNode.left = new RedBlackTree<long, long>.Node(); 
            tempNode.left.value = 2;
            tempNode.left.parent = tempNode;

            tempNode.right = new RedBlackTree<long, long>.Node(); 
            tempNode.right.value = 8;
            tempNode.right.parent = tempNode;

            // RedBlackTree<long, long>.Node tempNode2 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node tempNode2 = tempNode.right;

            tempNode2.left = new RedBlackTree<long, long>.Node(); 
            tempNode2.left.value = 6;
            tempNode2.left.parent = tempNode2;

            tempNode2.right = new RedBlackTree<long, long>.Node(); 
            tempNode2.right.value = 9;
            tempNode2.right.parent = tempNode2;

            //tempNOde.right 

            rdTree.rightRotate(toRotate);

            
            //;
        }

        //https://www.youtube.com/watch?v=95s3ndZRGbk
        //Make the tree at 2:27 (for testing right rotate)
        [TestMethod]
        public void TestMakeSimpleRedBlackTree2()
        {
            RedBlackTree<long,long> rdTree = new RedBlackTree<long,long>();

            RedBlackTree<long, long>.Node no10 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node root = rdTree.root;
            rdTree.root = no10;
            no10.parent = RedBlackTree<long, long>.nullnode;
            no10.value = 10;

            RedBlackTree<long, long>.Node no5 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node no12 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node no2 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node no6 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node no8 = new RedBlackTree<long, long>.Node();
            RedBlackTree<long, long>.Node no9 = new RedBlackTree<long, long>.Node();

            root.left = no5;
            no5.parent = root;

            root.right = no12;
            no12.parent = root;

            no5.left = no2;
            no2.parent = no5;

            no5.right = no8;
            no8.parent = no5;

            no8.left = no6;
            no6.parent = no8;

            no8.right = no9;
            no9.parent = no8;

            rdTree.rightRotate(no5);
        }


        [TestMethod]
        public void TestDictionary()
        {

            WebApplication.model.RodCutProblem rd = new WebApplication.model.RodCutProblem();


            rd.


        }
        
    }
}
