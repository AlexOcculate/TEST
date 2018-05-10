using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AQBMetadata.ORMDataModel
{

   public partial class MetadataItemXpObject
   {
      public MetadataItemXpObject( Session session ) : base( session ) { }
      public override void AfterConstruction() { base.AfterConstruction( ); }
   }

}
