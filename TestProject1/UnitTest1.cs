using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication.model;




namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void TestMethod1()
        {
            var f = new WebApplication.model.Finll();


            




        }


        [TestMethod]
        public void TestRedBlackTree()
        {

            RedBlackTree rdTree = new RedBlackTree();

            RedBlackTree.Node node = rdTree.getFirstNode();

            rdTree.deleteNode(node);



        }
    }
}
