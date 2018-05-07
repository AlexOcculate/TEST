namespace AQBTest
{
   public static class Global
   {
      #region --- CREATION TIMESTAMP ----
      public static System.DateTime CreationTS
      {
         [System.Diagnostics.DebuggerStepThrough]
         get;
      }
      #endregion

      public static string DataStoreCollectionFileName = @"DataStoreCollection.xml";
      public static string DataStoreCollectionFilePathName = @"D:\TEMP\SQLite\" + DataStoreCollectionFileName;
   }
}
