using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UnitTestWindowsFormsApp;

namespace UnitTestWindowsFormsAppProject
{
   [TestClass]
   public class UnitTest1
   {
      [TestMethod]
      public void TestMethod1()
      {
         Class1 o = new Class1( );
         bool rtn = o.stub01( true );
         Assert.IsFalse( rtn );
      }
      [TestMethod]
      public void TestMethod2()
      {
         Class1 o = new Class1( );
         bool rtn = o.stub02( true );
         Assert.IsFalse( rtn );
      }
      [TestMethod]
      public void TestMethod_M()
      {
         Class1 o = new Class1( );
         bool rtn = o.M( );
         Assert.IsTrue( rtn );
      }
      [TestMethod]
      [ExpectedException( typeof( IllegalOperation ), "A" )]
      public void TestMethod3()
      {
         Class1 o = new Class1( );
         bool rtn = o.stub03( true );
      }
   }
}
