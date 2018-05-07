using System;
using DevExpress.Xpo;

namespace XpoTutorial03
{
    public class DataStoreTreeNode : XPObject
    {
        #region --- Ctors... ---
        public DataStoreTreeNode() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public DataStoreTreeNode(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        #endregion
        //
        #region --- "Service Fields" ---
        public const string ID_PROP_NAME = "Id";
        public int Id
        {
            get { return GetPropertyValue<Int32>(ID_PROP_NAME); }
            set { SetPropertyValue(ID_PROP_NAME, value); }
        }
        public const string PARENT_ID_PROP_NAME = "ParentId";
        public int ParentId
        {
            get { return GetPropertyValue<Int32>(PARENT_ID_PROP_NAME); }
            set { SetPropertyValue(PARENT_ID_PROP_NAME, value); }
        }
        #endregion
        //
        #region --- FIELDS ---
        public const string IS_FOLDER_PROP_NAME = "IsFolder";
        public bool IsFolder
        {
            get { return GetPropertyValue<Boolean>(IS_FOLDER_PROP_NAME); }
            set { SetPropertyValue(IS_FOLDER_PROP_NAME, value); }
        }
        //
        public const string NAME_PROP_NAME = "Name";
        public string Name
        {
            get { return GetPropertyValue<String>(NAME_PROP_NAME); }
            set { SetPropertyValue(NAME_PROP_NAME, value); }
        }
        public const string DESCRIPTION_PROP_NAME = "Description";
        [Delayed(true)]
        public string Description
        {
            get { return GetPropertyValue<String>(DESCRIPTION_PROP_NAME); }
            set { SetPropertyValue(DESCRIPTION_PROP_NAME, value); }
        }
        public const string METADATA_PROVIDER_PROP_NAME = "MetadataProvider";
        public string MetadataProvider
        {
            get { return GetPropertyValue<String>(METADATA_PROVIDER_PROP_NAME); }
            set { SetPropertyValue(METADATA_PROVIDER_PROP_NAME, value); }
        }
        public const string SYNTAX_PROVIDER_PROP_NAME = "SyntaxProvider";
        public string SyntaxProvider
        {
            get { return GetPropertyValue<String>(SYNTAX_PROVIDER_PROP_NAME); }
            set { SetPropertyValue(SYNTAX_PROVIDER_PROP_NAME, value); }
        }
        public const string CONNECTION_STRING_PROP_NAME = "ConnectionString";
        public string ConnectionString
        {
            get { return GetPropertyValue<String>(CONNECTION_STRING_PROP_NAME); }
            set { SetPropertyValue(CONNECTION_STRING_PROP_NAME, value); }
        }
        #endregion
        //
        #region --- Icon Imagens ---
        [NonPersistent]
        public int StateImageIndex
        {
            get { return IsFolder ? 0 : 2; }
        }
        [NonPersistent]
        public int SelectImageIndex
        {
            get { return 0; }
        }
        #endregion
    }
}