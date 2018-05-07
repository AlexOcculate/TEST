using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;

namespace UrlShortening
{
    public partial class MyUrl
    {
        public const string SHORT_URL_PROP_NAME = "SHORT_URL";
        public const string SHORT_URL_CAPTION_NAME = "Short URL";
        //
        public const string LONG_URL_PROP_NAME = "LONG_URL";
        public const string LONG_URL_CAPTION_NAME = "Long URL";
        //
        public const string NAME_PROP_NAME = "Name";
        public const string NAME_CAPTION_NAME = NAME_PROP_NAME;
        //
        public const string DESCRIPTION_PROP_NAME = "Description";
        public const string DESCRIPTION_CAPTION_NAME = DESCRIPTION_PROP_NAME;
        //
        public string ShortUrl
        {
            get { return GetPropertyValue<string>(SHORT_URL_PROP_NAME); }
            set { SetPropertyValue(SHORT_URL_PROP_NAME, value); }
        }
        //
        public string LongUrl
        {
            get { return GetPropertyValue<string>(LONG_URL_PROP_NAME); }
            set { SetPropertyValue(LONG_URL_PROP_NAME, value); }
        }
        //
        public string Name
        {
            get { return GetPropertyValue<String>(NAME_PROP_NAME); }
            set { SetPropertyValue(NAME_PROP_NAME, value); }
        }
        //
        [Delayed(true)]
        public string Description
        {
            get { return GetPropertyValue<String>(DESCRIPTION_PROP_NAME); }
            set { SetPropertyValue(DESCRIPTION_PROP_NAME, value); }
        }
    }
}
