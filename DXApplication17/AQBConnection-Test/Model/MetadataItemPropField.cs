using AQBConnection_Test.Model;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Xml.Serialization;

namespace AQBConnection_Test
{
   public class MetadataItemPropField
   {
      private DataRow o;

      public MetadataItemPropField(DataRow o)
      {
         this.o = o;
      }

      public FullQualifiedName x
      {
         get
         {
            return new FullQualifiedName();
         }

         set
         {
         }
      }

      #region --- ID ---
      [DisplayName( MetadataItemProps.ID_DISPLAYNAME )]
      [Description( MetadataItemProps.ID_DESCRIPTION )]
      [Category( MetadataItemProps.ID_CATEGORY )]
      [ReadOnly( true )]
      [Browsable( true )]
      [XmlAttribute( MetadataItemProps.ID_XMLNAME )]
      public int IDXXXXX
      {
         [System.Diagnostics.DebuggerStepThrough]
         get
         {
            return (int) this.o[MetadataItemProps.ID_FIELDNAME];
         }
         [System.Diagnostics.DebuggerStepThrough]
         set
         {
            this.o[MetadataItemProps.ID_FIELDNAME] = value;
         }
      }
      #endregion
   }
}
