
using System;

namespace DataModel
{
    class Program
    {
        public static void Main(string[] args)
        {
            UrlTemplate o1 = TestUrlTemplate();
            //
            JarZipFile o2 = TestJarZipFile();
            //
            FinderPath o3 = TestFinderPath();
            //
            ExcludePattern o4 = TestExcludePattern();
            //
            DriverManager o5 = TestDriverManager(o1, o2);
            //
            DriverManagerConfiguration o6 = TestDriverManagerConfiguration();
            //
            ConnectionProperty o7 = TestConnectionProperty();
            //
            DataStore o8 = TestDataStore();
            //
            DataColumn o9 = TestDataColumn();
        }

        private static UrlTemplate TestUrlTemplate()
        {
            var o = new UrlTemplate
            {
                Id = 12,
                Version = 123,
                Comment = "alalala",
                UrlString = "URL String"
            };
            o.XmlSerializeToFile();
            return o;
        }

        private static JarZipFile TestJarZipFile()
        {
            var o = new JarZipFile
            {
                Id = 12,
                Version = 123,
                Comment = "alalala",
                UriString = "URI String"
            };
            o.XmlSerializeToFile();
            return o;
        }

        private static FinderPath TestFinderPath()
        {
            var o = new FinderPath
            {
                Id = 12,
                Version = 123,
                Comment = "alalala",
                PathString = "Path String"
            };
            o.XmlSerializeToFile();
            return o;
        }

        private static ExcludePattern TestExcludePattern()
        {
            var o = new ExcludePattern
            {
                Id = 12,
                Version = 123,
                Comment = "alalala",
                PatternString = "Path String"
            };
            o.XmlSerializeToFile();
            return o;
        }

        private static DriverManager TestDriverManager(UrlTemplate o1, JarZipFile o2)
        {
            var o = new DriverManager
            {
                Id = 12,
                Version = 123,
                Comment = "alalala",
                Name = "QWERTY",
                JarZipFileList = new System.Collections.Generic.List<JarZipFile>(),
                UrlTemplateList = new System.Collections.Generic.List<UrlTemplate>(),
                MainClassNameList = new System.Collections.Generic.List<string>()
            };
            o.MainClassNameList.Add("org.j256.h2");
            o.MainClassNameList.Add("org.jdbc.Oracle");
            o.UrlTemplateList.Add(o1);
            o.UrlTemplateList.Add(o1);
            o.JarZipFileList.Add(o2);
            o.JarZipFileList.Add(o2);
            o.JarZipFileList.Add(o2);

            o.XmlSerializeToFile();
            return o;
        }

        private static DriverManagerConfiguration TestDriverManagerConfiguration()
        {
            var o = new DriverManagerConfiguration
            {
                RunFinderStartup = true,
                ReplaceDriverFiles = true,
                DisplayNewFiles = true,
                FinderPathsList = new System.Collections.Generic.List<FinderPath>(),
                ExcludePatternsList = new System.Collections.Generic.List<ExcludePattern>()
            };
            o.FinderPathsList.Add(new FinderPath());
            o.FinderPathsList.Add(new FinderPath());
            o.FinderPathsList.Add(new FinderPath());
            o.FinderPathsList.Add(new FinderPath());
            o.XmlSerializeToFile();
            return o;
        }

        private static ConnectionProperty TestConnectionProperty()
        {
            var o = new ConnectionProperty
            {
                Name = "nome",
                Value = "o valor"
            };
            o.XmlSerializeToFile();
            return o;
        }

        private static DataStore TestDataStore()
        {
            var o = new DataStore
            {
                Name = "dataStore0001",
                DriverName = "org.jdbc.h2",
                UrlString = "jdbc:aaa:www:1235",
                Username = "usuario01",
                Password = "12!@asQW",
                ConnectionPropertyList = new System.Collections.Generic.List<ConnectionProperty>()
            };
            ConnectionProperty cp = new ConnectionProperty();
            cp.Comment = "qazxswedcvfrtgb yhnmjuiklop";
            cp.Value = "123!@#:asdQWE:tgb";
            o.ConnectionPropertyList.Add(cp);
            o.ConnectionPropertyList.Add(new ConnectionProperty());
            o.ConnectionPropertyList.Add(cp);
            o.XmlSerializeToFile();
            return o;
        }

        private static DataColumn TestDataColumn()
        {
            var o = new DataColumn
            {
                AcquiredWhen = DateTime.Now.Ticks,
                CatalogName = "Cat",
                SchemaName = null,
                TableName = "tablename",
                ColumnName = "salary"
            };
            o.XmlSerializeToFile();
            return o;
        }
    }
}
