namespace AQBTest
{
   [System.Xml.Serialization.XmlRootAttribute( "MIFQNColl" )]
   public partial class MetadataItemFQNCollection
   {
      #region --- CREATION TIMESTAMP ----
      public const string CREATION_TS_FIELDNAME = "CreationTS";
      public const string CREATION_TS_DISPLAYNAME = "Creation TS";
      public const string CREATION_TS_DESCRIPTION = null;
      //[System.ComponentModel.DataAnnotations.Display( Name = CREATION_TS_DISPLAYNAME, Description = CREATION_TS_DESCRIPTION )]
      //[System.ComponentModel.DataAnnotations.DataType( System.ComponentModel.DataAnnotations.DataType.DateTime )]
      //[System.ComponentModel.ReadOnly( true )]
      [System.Xml.Serialization.XmlAttribute( "cts" )]
      public System.DateTime CreationTS
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
         [System.Diagnostics.DebuggerStepThrough]
         set;
      }
      #endregion

      [System.Xml.Serialization.XmlArray( "MIFQNList" )]
      [System.Xml.Serialization.XmlArrayItem( typeof( MetadataItemFQN ), ElementName = "MIFQN" )]
      public System.ComponentModel.BindingList<MetadataItemFQN> List { get; set; }

      private static readonly System.ComponentModel.BindingList<MetadataItemFQN> emptyList = new System.ComponentModel.BindingList<MetadataItemFQN>( );

      public MetadataItemFQNCollection()
      {
         this.CreationTS = System.DateTime.Now;
         this.List = new System.ComponentModel.BindingList<MetadataItemFQN>( );
      }

      public void Save( string filepathname )
      {
         //if( !System.IO.Directory.Exists( filepathname ) )
         //{
         //   System.IO.Directory.CreateDirectory( filepathname );
         //}
         this.XmlSerialize( filepathname );
      }
      public static MetadataItemFQNCollection Load( string filepathname )
      {
         MetadataItemFQNCollection coll;
         if( System.IO.File.Exists( filepathname ) )
         {
            coll = MetadataItemFQNCollection.XmlDeserialize( filepathname );
         }
         else
         {
            coll = new MetadataItemFQNCollection( );
         }
         return coll;
      }

      #region --- XML Serialization ---
      public void XmlSerialize( string path )
      {
         System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer( typeof( MetadataItemFQNCollection ) );
         using( System.IO.TextWriter tw = new System.IO.StreamWriter( path ) )
         {
            xs.Serialize( tw, this );
         }
      }
      public static MetadataItemFQNCollection XmlDeserialize( string path )
      {
         System.Xml.Serialization.XmlSerializer xs = new System.Xml.Serialization.XmlSerializer( typeof( MetadataItemFQNCollection ) );
         using( System.IO.TextReader tr = new System.IO.StreamReader( path ) )
         {
            var o = xs.Deserialize( tr ) as MetadataItemFQNCollection;
            return o;
         }
      }
      #endregion
   }
}
