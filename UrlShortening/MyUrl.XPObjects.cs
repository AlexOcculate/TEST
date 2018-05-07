using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace UrlShortening
{
    public partial class MyUrl : XPObject
    {
        public const string ID_PROP_NAME = "Id";
        public const string ID_CAPTIN_NAME = "Id";
        //
        public const string PARENT_ID_PROP_NAME = "ParentId";
        public const string PARENT_ID_CAPTION_NAME = "Parent Id";

        #region --- "Service Fields" ---
        public int Id
        {
            get { return GetPropertyValue<Int32>(ID_PROP_NAME); }
            set { SetPropertyValue(ID_PROP_NAME, value); }
        }
        public int ParentId
        {
            get { return GetPropertyValue<Int32>(PARENT_ID_PROP_NAME); }
            set { SetPropertyValue(PARENT_ID_PROP_NAME, value); }
        }
        #endregion

        protected MyUrl() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        protected MyUrl(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        protected MyUrl(Session session, XPClassInfo classInfo) : base(session, classInfo)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }
        public static XPCollection getCollection(string criteria)
        {
            XPCollection xpc = new XPCollection(typeof(MyUrl));
            xpc.Criteria = criteria;
            return xpc;
        }
        public static void VerifyBuiltinDataValues()
        {
            XPCollection dsColl = new XPCollection(new Session(), typeof(MyUrl), true);
            if (dsColl.Count == 0)
            {
                MyUrl.createBuiltInDataValues();
                return;
            }
        }
        private static void createBuiltInDataValues() { }
    }
}
