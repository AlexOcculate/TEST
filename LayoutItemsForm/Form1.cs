using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace LayoutItemsForm
{
   public partial class Form1 : DevExpress.XtraEditors.XtraForm
   {
      private System.Windows.Forms.BindingSource bindingSource1;
      private List<Props> dataSource;

      public Form1()
      {
         InitializeComponent( );
         this.create( );
         //this.f( );
      }

      private void create()
      {
         this.FormClosing += this.Form1_FormClosing;
         this.bindingSource1 = new BindingSource( this.components );
         this.dataSource = new List<Props>( )
         {
            new Props("prop0", "value0"),
            new Props("prop1", "value1"),
            new Props("prop2", "value2"),
            new Props("prop3", "value3"),
            new Props("prop0", "value0"),
            new Props("prop1", "value1"),
            new Props("prop2", "value2"),
            new Props("prop3", "value3"),
         };
         //
         this.SuspendLayout( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).BeginInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).BeginInit( );
         ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).BeginInit( );
         {
            this.bindingSource1.DataSource = typeof( Props );
            this.bindingSource1.Add( this.dataSource );
            this.createLayoutControl( );
         }
         ((System.ComponentModel.ISupportInitialize) (this.bindingSource1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).EndInit( );
         this.ResumeLayout( false );
         this.PerformLayout( );
      }

      private void Form1_FormClosing( object sender, FormClosingEventArgs e )
      {
         var count = this.dataSource.Count;
      }

      private void createLayoutControl()
      {
         LayoutControl lc = this.layoutControl1; // new LayoutControl( );
         LayoutControlGroup rg = Form1.configRootGroup( lc, "DataStore Connection" );
         {
            lc.Dock = System.Windows.Forms.DockStyle.Fill;

            LayoutControlItem item1 = rg.AddItem( );
            {
               item1.Name = "lciName";
               item1.Text = "Name";
               Control textBox1 = item1.Control = new TextEdit( );
               {
                  textBox1.Name = "TextBox1";
               }
            }
            TabbedControlGroup tg = rg.AddTabbedGroup( );
            {
               tg.Name = "tgg";
               LayoutControlGroup lg1 = tg.AddTabPage( "Connection" ) as LayoutControlGroup;
               {
                  createConnectionStringLayoutControlItem( lg1 );
                  createLoginIDLayoutControlItem( lg1 );
                  createPasswordLayoutControlItem( lg1 );
                  createConnectionPropertiesLayoutControlItem( lg1, this.bindingSource1 );
               }
               LayoutControlGroup lg2 = tg.AddTabPage( "Provider" ) as LayoutControlGroup;
               {
                  createSyntaxProviderLayoutControlItem( lg2 );
                  createMetadataProviderLayoutControlItem( lg2 );
               }
               LayoutControlGroup lg3 = tg.AddTabPage( "Preview" ) as LayoutControlGroup;
               {
                  createSuperToolTipHeaderLayoutControlItem( lg3 );
                  createSuperToolTipContentLayoutControlItems( lg3 );
                  createSuperToolTipFooterLayoutControlItem( lg3 );
               }
               LayoutControlGroup lg4 = tg.AddTabPage( "Description" ) as LayoutControlGroup;
               {
                  createDescriptionLayoutControlItem( lg4 );
               }
               tg.SelectedTabPage = lg1;
            }
         }
      }

      private sealed class SyntaxProviderType
      {
         private readonly string name;
         private readonly int value;
         public static readonly SyntaxProviderType AUTO = new SyntaxProviderType( 0, "auto" );
         public static readonly SyntaxProviderType GENERIC = new SyntaxProviderType( 1, "generic" );
         public static readonly SyntaxProviderType ANSI_SQL_2003 = new SyntaxProviderType( 2, "ansi_sql_2003" );
         public static readonly SyntaxProviderType ANSI_SQL_92 = new SyntaxProviderType( 3, "ansi_sql_92" );
         public static readonly SyntaxProviderType ANSI_SQL_89 = new SyntaxProviderType( 4, "ansi_sql_89" );
         public static readonly SyntaxProviderType[ ] ToArray = new SyntaxProviderType[ ]  {
            AUTO, GENERIC, ANSI_SQL_2003, ANSI_SQL_92, ANSI_SQL_89
         };

         private SyntaxProviderType( int value, string name )
         {
            this.value = value;
            this.name = name;
         }
         public override string ToString()
         {
            return System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase( this.name );
         }
      };
      private LayoutControlItem createSyntaxProviderLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciMetadataProvider";
         lci.Text = "Metadata Provider";
         ComboBoxEdit o = (ComboBoxEdit) (lci.Control = new ComboBoxEdit( ));
         {
            ComboBoxItemCollection coll = o.Properties.Items;
            coll.BeginUpdate( );
            try
            {
               coll.AddRange( SyntaxProviderType.ToArray );
               o.SelectedIndex = 0;
            }
            finally
            {
               coll.EndUpdate( );
            }
         }
         return lci;
      }
      private enum MetadataProviderEnum
      {
         Auto = 0, Generic, MSSQL_Server
      };
      private LayoutControlItem createMetadataProviderLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciMetadataProvider";
         lci.Text = "Metadata Provider";
         ComboBoxEdit o = (ComboBoxEdit) (lci.Control = new ComboBoxEdit( ));
         {
            ComboBoxItemCollection coll = o.Properties.Items;
            coll.BeginUpdate( );
            try
            {
               string[ ] name = Enum.GetNames( typeof( MetadataProviderEnum ) );
               for( int i = 0; i < name.Length; i++ )
               {
                  string tc = System.Globalization.CultureInfo.CurrentUICulture.TextInfo.ToTitleCase( name[ i ] );
                  coll.Add( tc );
               }
               o.SelectedIndex = 0;
            }
            finally
            {
               coll.EndUpdate( );
            }
         }
         return lci;
      }
      private LayoutControlItem createDescriptionLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciDescription";
         lci.Text = "Description";
         lci.TextLocation = DevExpress.Utils.Locations.Top;
         MemoEdit o = (MemoEdit) (lci.Control = new MemoEdit( ));
         return lci;
      }
      private LayoutControlItem createSuperToolTipHeaderLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciHeader";
         lci.Text = "Header";
         lci.TextLocation = DevExpress.Utils.Locations.Top;
         MemoEdit o = (MemoEdit) (lci.Control = new MemoEdit( ));
         return lci;
      }
      private LayoutControlItem createSuperToolTipContentLayoutControlItems( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciContents";
         lci.Text = "Contents";
         lci.TextLocation = DevExpress.Utils.Locations.Top;
         MemoEdit o = (MemoEdit) (lci.Control = new MemoEdit( ));
         return lci;
      }
      private LayoutControlItem createSuperToolTipFooterLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciFooter";
         lci.Text = "Footer";
         lci.TextLocation = DevExpress.Utils.Locations.Top;
         MemoEdit o = (MemoEdit) (lci.Control = new MemoEdit( ));
         return lci;
      }
      private LayoutControlItem createPasswordLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciPassword";
         lci.Text = "Password";
         //lci.Control = new TextEdit( );
         //((TextEdit)lci.Control).Properties.PasswordChar = '*';
         ButtonEdit o = new ButtonEdit( );
         {
            lci.Control = o;
            o.Properties.PasswordChar = '*';
            o.Properties.Buttons[ 0 ].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis;
            o.Properties.ButtonPressed += this.passwordButtonEdit_ButtonPressed;
         }
         return lci;
      }
      private void passwordButtonEdit_ButtonPressed( object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e )
      {
         ButtonEdit o = (ButtonEdit) sender;
         o.Properties.PasswordChar = o.Properties.PasswordChar == '\0' ? '*' : '\0';
      }
      private LayoutControlItem createLoginIDLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciLoginID";
         lci.Text = "Login ID";
         lci.Control = new TextEdit( );
         return lci;
      }
      private static LayoutControlItem createConnectionStringLayoutControlItem( LayoutControlGroup lg )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciConnectionString";
         lci.Text = "Connection String";
         lci.Control = new TextEdit( );
         return lci;
      }

      private static LayoutControlItem createConnectionPropertiesLayoutControlItem( LayoutControlGroup lg, BindingSource bs )
      {
         LayoutControlItem lci = lg.AddItem( );
         lci.Name = "lciConnectionProperties";
         lci.Text = "Connection Properties";
         lci.TextLocation = DevExpress.Utils.Locations.Top;
         GridControl gc = new GridControl( );
         {
            gc.DataSource = bs;
            gc.UseEmbeddedNavigator = true;
            gc.ForceInitialize( );
            gc.RefreshDataSource( );
            GridView gv = gc.MainView as GridView;
            {
               gv.NewItemRowText = "New Row";
               //gv.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
               //gv.InitNewRow += new InitNewRowEventHandler( this.gridView1_InitNewRow );
               gv.OptionsView.ShowFooter = true;
               gv.OptionsBehavior.Editable = true;
               gv.OptionsBehavior.ReadOnly = false;
            }
         }
         lci.Control = gc;
         //gv.OptionsView.
         return lci;
      }

      /////////////////////////////////////////////////////////////////////////////////////////////////////

      private void f()
      {
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).BeginInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).BeginInit( );
         this.SuspendLayout( );
         {
            this.x( );
         }
         ((System.ComponentModel.ISupportInitialize) (this.layoutControl1)).EndInit( );
         ((System.ComponentModel.ISupportInitialize) (this.layoutControlGroup1)).EndInit( );
         this.ResumeLayout( false );
         this.PerformLayout( );
      }
      private void x()
      {
         LayoutControl lc = this.layoutControl1; // new LayoutControl( );
         LayoutControlGroup rg = Form1.configRootGroup( lc, "Root Group" );
         {
            lc.Dock = System.Windows.Forms.DockStyle.Fill;

            LayoutControlItem item1 = rg.AddItem( );
            {
               item1.Name = "Layout Item 1";
               item1.Text = "Name";
               Control textBox1 = item1.Control = new TextEdit( );
               {
                  textBox1.Name = "TextBox1";
               }
            }
            LayoutControlItem item2 = new LayoutControlItem( );
            {
               item2.Parent = lc.Root;
               item2.Name = "Layout Item 2";
               item2.Text = "E-mail";
               Control textBox2 = item2.Control = new TextEdit( );
               {
                  textBox2.Name = "TextBox2";
               }
            }
            // Create a hidden layout item. 
            LayoutControlItem item3 = new LayoutControlItem( );
            {
               lc.HiddenItems.AddRange( new BaseLayoutItem[ ] { item3 } );
               item3.Name = "Layout Item 3";
               item3.Text = "Notes";
               Control textBox3 = item3.Control = new MemoEdit( );
               {
                  textBox3.Name = "TextBox3";
               }
            }
         }
      }
      private static LayoutControlGroup configRootGroup( LayoutControl lc, string titleText )
      {
         LayoutControlGroup rg = lc.Root;
         //
         // rg.AllowHide = false;
         // rg.AllowCustomizeChildren = false;
         //
         rg.GroupBordersVisible = true;
         rg.Text = titleText;
         rg.TextLocation = DevExpress.Utils.Locations.Top;
         rg.TextVisible = true;
         //
         rg.Expanded = true; // BUG?!
         rg.ExpandOnDoubleClick = true;
         rg.ExpandButtonVisible = true;
         rg.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.BeforeText;
         //
         // rg.CustomHeaderButtons.Add( button );
         // rg.CustomButtonClick += ...,
         // LayoutGroup.CustomButtonChecked += ...
         // LayoutGroup.CustomButtonUnchecked += events.

         //
         // rg.CaptionImage = null;
         // rg.Images = null;
         // rg.CaptionImageIndex = -1;
         //
         return rg;
      }
   }

   ////////////////////////////////////////////////////////////////
   [Serializable( )]
   public class Props
   {
      [Display( Name = "Key:" )]
      [StringLength( 100, MinimumLength = 1 )]
      public string Key { get; set; }
      [Display( Name = "Value:" )]
      [StringLength( 100, MinimumLength = 1 )]
      public string Value { get; set; }
      [Display( Name = "Active?" )]
      public bool IsActive { get; set; }

      public Props()
      {
      }

      public Props( string key, string value )
      {
         this.Key = key ?? throw new ArgumentNullException( nameof( key ) );
         this.Value = value ?? throw new ArgumentNullException( nameof( value ) );
      }
   }

}
