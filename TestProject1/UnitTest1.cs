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
        public void TestRedBlackTree()
        {

            RedBlackTree<long,long> rdTree = new RedBlackTree<long,long>();

            RedBlackTree<long, long>.Node node = rdTree.getFirstNode();

            rdTree.leftRotate(node).rightRotate(node);
            
            rdTree.deleteNode(node).rightRotate(node);



        }
    }
}
