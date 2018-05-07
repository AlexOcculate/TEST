using DevExpress.XtraTreeList.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeListTest
{
   public partial class Form1 : Form
   {
      public Form1()
      {
         InitializeComponent( );
         //
         //this.treeList.CreateCustomNode += new DevExpress.XtraTreeList.CreateCustomNodeEventHandler( this.treeList_CreateCustomNode );
         //this.treeList.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler( this.treeList_AfterCheckNode );
         //this.treeList.CellValueChanging += new DevExpress.XtraTreeList.CellValueChangedEventHandler( this.treeList_CellValueChanging );
         //this.treeList.CellValueChanged += new DevExpress.XtraTreeList.CellValueChangedEventHandler( this.treeList_CellValueChanged );
         //
         TreeListNode appendNode = this.treeList.AppendNode( new object[] { "xxx"} , 1 );
         TreeListNode appendNode2 = this.treeList.AppendNode( new object[ ] { "YYY" }, 3 );

      }

      private void treeList_CreateCustomNode( object sender, DevExpress.XtraTreeList.CreateCustomNodeEventArgs e )
      {

      }

      private void treeList_CellValueChanging( object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e )
      {

      }

      private void treeList_CellValueChanged( object sender, DevExpress.XtraTreeList.CellValueChangedEventArgs e )
      {

      }

      private void treeList_AfterCheckNode( object sender, DevExpress.XtraTreeList.NodeEventArgs e )
      {

      }
   }
}
