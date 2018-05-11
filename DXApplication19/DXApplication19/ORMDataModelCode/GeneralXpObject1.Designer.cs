﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
namespace AQBMetadata.ORMDataModel
{

   public partial class MetadataItemXpObject : XPObject
   {
      int fID;
      public int ID
      {
         get { return fID; }
         set { SetPropertyValue<int>( nameof( ID ), ref fID, value ); }
      }
      int fParentID;
      public int ParentID
      {
         get { return fParentID; }
         set { SetPropertyValue<int>( nameof( ParentID ), ref fParentID, value ); }
      }
      string fDataStoreName;
      public string DataStoreName
      {
         get { return fDataStoreName; }
         set { SetPropertyValue<string>( nameof( DataStoreName ), ref fDataStoreName, value ); }
      }
      string fSnapshotName;
      public string SnapshotName
      {
         get { return fSnapshotName; }
         set { SetPropertyValue<string>( nameof( SnapshotName ), ref fSnapshotName, value ); }
      }
      DateTime fLastWriteTimeUtc;
      public DateTime LastWriteTimeUtc
      {
         get { return fLastWriteTimeUtc; }
         set { SetPropertyValue<DateTime>( nameof( LastWriteTimeUtc ), ref fLastWriteTimeUtc, value ); }
      }
      string fMetadataProvider;
      public string MetadataProvider
      {
         get { return fMetadataProvider; }
         set { SetPropertyValue<string>( nameof( MetadataProvider ), ref fMetadataProvider, value ); }
      }
      string fSyntaxProvider;
      [DevExpress.Xpo.DisplayName( @"Syntax Provider" )]
      public string SyntaxProvider
      {
         get { return fSyntaxProvider; }
         set { SetPropertyValue<string>( nameof( SyntaxProvider ), ref fSyntaxProvider, value ); }
      }
      bool fIsSystem;
      public bool IsSystem
      {
         get { return fIsSystem; }
         set { SetPropertyValue<bool>( nameof( IsSystem ), ref fIsSystem, value ); }
      }
      string fServer;
      public string Server
      {
         get { return fServer; }
         set { SetPropertyValue<string>( nameof( Server ), ref fServer, value ); }
      }
      string fDatabase;
      public string Database
      {
         get { return fDatabase; }
         set { SetPropertyValue<string>( nameof( Database ), ref fDatabase, value ); }
      }
      string fSchema;
      public string Schema
      {
         get { return fSchema; }
         set { SetPropertyValue<string>( nameof( Schema ), ref fSchema, value ); }
      }
      string fType;
      public string Type
      {
         get { return fType; }
         set { SetPropertyValue<string>( nameof( Type ), ref fType, value ); }
      }
      string fParentType;
      public string ParentType
      {
         get { return fParentType; }
         set { SetPropertyValue<string>( nameof( ParentType ), ref fParentType, value ); }
      }
      string fObjectName;
      [DevExpress.Xpo.DisplayName( @"ParentName" )]
      public string ObjectName
      {
         get { return fObjectName; }
         set { SetPropertyValue<string>( nameof( ObjectName ), ref fObjectName, value ); }
      }
      string fNameFullQualified;
      public string NameFullQualified
      {
         get { return fNameFullQualified; }
         set { SetPropertyValue<string>( nameof( NameFullQualified ), ref fNameFullQualified, value ); }
      }
      string fFkCardinality;
      public string FkCardinality
      {
         get { return fFkCardinality; }
         set { SetPropertyValue<string>( nameof( FkCardinality ), ref fFkCardinality, value ); }
      }
      int fFieldsCount;
      [DevExpress.Xpo.DisplayName( @"FkFieldCount" )]
      public int FieldsCount
      {
         get { return fFieldsCount; }
         set { SetPropertyValue<int>( nameof( FieldsCount ), ref fFieldsCount, value ); }
      }
      string fFkFields;
      public string FkFields
      {
         get { return fFkFields; }
         set { SetPropertyValue<string>( nameof( FkFields ), ref fFkFields, value ); }
      }
      string fTkCardinality;
      public string TkCardinality
      {
         get { return fTkCardinality; }
         set { SetPropertyValue<string>( nameof( TkCardinality ), ref fTkCardinality, value ); }
      }
      string fTkObject;
      public string TkObject
      {
         get { return fTkObject; }
         set { SetPropertyValue<string>( nameof( TkObject ), ref fTkObject, value ); }
      }
      string fReferencedObjectName;
      [DevExpress.Xpo.DisplayName( @"TkObjectName" )]
      public string ReferencedObjectName
      {
         get { return fReferencedObjectName; }
         set { SetPropertyValue<string>( nameof( ReferencedObjectName ), ref fReferencedObjectName, value ); }
      }
      int fReferencedFieldsCount;
      [DevExpress.Xpo.DisplayName( @"TkFieldsCount" )]
      public int ReferencedFieldsCount
      {
         get { return fReferencedFieldsCount; }
         set { SetPropertyValue<int>( nameof( ReferencedFieldsCount ), ref fReferencedFieldsCount, value ); }
      }
      string fReferencedFields;
      [DevExpress.Xpo.DisplayName( @"TkFields" )]
      public string ReferencedFields
      {
         get { return fReferencedFields; }
         set { SetPropertyValue<string>( nameof( ReferencedFields ), ref fReferencedFields, value ); }
      }
      string fNameQuoted;
      public string NameQuoted
      {
         get { return fNameQuoted; }
         set { SetPropertyValue<string>( nameof( NameQuoted ), ref fNameQuoted, value ); }
      }
      string fAltName;
      public string AltName
      {
         get { return fAltName; }
         set { SetPropertyValue<string>( nameof( AltName ), ref fAltName, value ); }
      }
      string fName;
      public string Name
      {
         get { return fName; }
         set { SetPropertyValue<string>( nameof( Name ), ref fName, value ); }
      }
      bool fHasDefault;
      public bool HasDefault
      {
         get { return fHasDefault; }
         set { SetPropertyValue<bool>( nameof( HasDefault ), ref fHasDefault, value ); }
      }
      string fExpression;
      public string Expression
      {
         get { return fExpression; }
         set { SetPropertyValue<string>( nameof( Expression ), ref fExpression, value ); }
      }
      string fDotNetDatatype;
      [DevExpress.Xpo.DisplayName( @".NetFieldType" )]
      public string DotNetDatatype
      {
         get { return fDotNetDatatype; }
         set { SetPropertyValue<string>( nameof( DotNetDatatype ), ref fDotNetDatatype, value ); }
      }
      string fDatabaseDatatype;
      public string DatabaseDatatype
      {
         get { return fDatabaseDatatype; }
         set { SetPropertyValue<string>( nameof( DatabaseDatatype ), ref fDatabaseDatatype, value ); }
      }
      bool fIsNullable;
      public bool IsNullable
      {
         get { return fIsNullable; }
         set { SetPropertyValue<bool>( nameof( IsNullable ), ref fIsNullable, value ); }
      }
      int fPrecision;
      public int Precision
      {
         get { return fPrecision; }
         set { SetPropertyValue<int>( nameof( Precision ), ref fPrecision, value ); }
      }
      int fScale;
      public int Scale
      {
         get { return fScale; }
         set { SetPropertyValue<int>( nameof( Scale ), ref fScale, value ); }
      }
      int fSize;
      public int Size
      {
         get { return fSize; }
         set { SetPropertyValue<int>( nameof( Size ), ref fSize, value ); }
      }
      bool fIsPK;
      public bool IsPK
      {
         get { return fIsPK; }
         set { SetPropertyValue<bool>( nameof( IsPK ), ref fIsPK, value ); }
      }
      bool fIsRO;
      public bool IsRO
      {
         get { return fIsRO; }
         set { SetPropertyValue<bool>( nameof( IsRO ), ref fIsRO, value ); }
      }
      string fDescription;
      public string Description
      {
         get { return fDescription; }
         set { SetPropertyValue<string>( nameof( Description ), ref fDescription, value ); }
      }
      string fTag;
      public string Tag
      {
         get { return fTag; }
         set { SetPropertyValue<string>( nameof( Tag ), ref fTag, value ); }
      }
      string fUserData;
      public string UserData
      {
         get { return fUserData; }
         set { SetPropertyValue<string>( nameof( UserData ), ref fUserData, value ); }
      }
      ulong fCount;
      public ulong Count
      {
         get { return fCount; }
         set { SetPropertyValue<ulong>( nameof( Count ), ref fCount, value ); }
      }
   }

}
