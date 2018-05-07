using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XpoTutorial03
{
    public static class ImagesHelper
    {
        private static DevExpress.Utils.ImageCollection imagesCore;
        public static DevExpress.Utils.ImageCollection DataStoreTreeNodeImagesColletion
        {
            get
            {
                if (imagesCore == null)
                {
                    imagesCore = new DevExpress.Utils.ImageCollection();
                    imagesCore.AddImage(global::XpoTutorial03.Properties.Resources.folderClosed_16x16);
                    imagesCore.AddImage(global::XpoTutorial03.Properties.Resources.folderOpen_16x16);
                    imagesCore.AddImage(global::XpoTutorial03.Properties.Resources.database_16x16);
                }
                return imagesCore;
            }
        }

    }
}
