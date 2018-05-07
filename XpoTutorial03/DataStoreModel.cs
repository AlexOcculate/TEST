using System;
using DevExpress.Xpo;

namespace XpoTutorial03
{

    public class DataStoreModel : XPObject
    {
        public DataStoreModel() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public DataStoreModel(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        // -----------------------------------------------------------------------------------------
        //
        private string _name;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetPropertyValue("Name", ref _name, value);
            }
        }
        //
        string _syntaxProvider;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string SyntaxProvider
        {
            get
            {
                return _syntaxProvider;
            }
            set
            {
                SetPropertyValue("SyntaxProvider", ref _syntaxProvider, value);
            }
        }
        //
        string _connectionString;
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string ConnectionString
        {
            get
            {
                return _connectionString;
            }
            set
            {
                SetPropertyValue("ConnectionString", ref _connectionString, value);
            }
        }
    }

}