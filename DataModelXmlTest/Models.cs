using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace DataModel
{
    //
    #region --- BasicModel ---
    public class BasicModel
    {
        [XmlAttribute]
        public int Id { get; set; }
        [XmlAttribute]
        public int Version { get; set; }
        //
        #region --- --- --- CDATA_COMMENT --- --- ---
        [XmlIgnore]
        public string Comment { get; set; }
        [XmlElement("Comment")]
        public XmlCDataSection commentCData
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                if (Comment == null)
                    return null;
                return doc.CreateCDataSection(Comment);
            }
            set
            {
                Comment = value.Value;
            }
        }
        #endregion
        //
        public void XmlSerializeToFile()
        {
            string filePath = string.Format(@"D:\TEMP\CS\{0}.xml", this.GetType().Name);
            XmlSerializer serializer = new XmlSerializer(this.GetType());
            using (TextWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, this);
            }
        }
    }
    #endregion
    //
    [XmlRoot]
    public class UrlTemplate : BasicModel
    {
        public string UrlString { get; set; }
    }

    [XmlRoot]
    public class JarZipFile : BasicModel
    {
        public string UriString { get; set; }
    }

    [XmlRoot]
    public class FinderPath : BasicModel
    {
        public string PathString { get; set; }
    }

    [XmlRoot]
    public class ExcludePattern : BasicModel
    {
        public string PatternString { get; set; }
    }

    [XmlRoot]
    public class DriverManager : BasicModel
    {
        [XmlElement]
        public string Name { get; set; }
        public List<JarZipFile> JarZipFileList { get; set; }
        public List<string> MainClassNameList { get; set; }
        public List<UrlTemplate> UrlTemplateList { get; set; }
    }

    [XmlRoot]
    public class DriverManagerConfiguration : BasicModel
    {
        [XmlAttribute]
        public bool RunFinderStartup { get; set; }
        [XmlAttribute]
        public bool ReplaceDriverFiles { get; set; }
        [XmlAttribute]
        public bool DisplayNewFiles { get; set; }
        //
        public List<FinderPath> FinderPathsList { get; set; }
        public List<ExcludePattern> ExcludePatternsList { get; set; }

    }

    [XmlRoot]
    public class ConnectionProperty : BasicModel
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
    //
    #region --- DataStore ---
    [XmlRoot]
    public class DataStore : BasicModel
    {
        public string Name { get; set; }
        public string DriverName { get; set; }
        public string UrlString { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //
        public List<ConnectionProperty> ConnectionPropertyList { get; set; }
    }
    #endregion
    //
    #region --- DataColumn ---
    [XmlRoot]
    public class DataColumn : BasicModel
    {
        [XmlAttribute]
        public long AcquiredWhen { get; set; }
        public string CatalogName { get; set; }
        public string SchemaName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int DataType { get; set; }
        public string TypeName { get; set; }
        public int ColumnSize { get; set; }
        public int DecimalDigits { get; set; }
        public int NumPrecRadix { get; set; }
        public int Nullable { get; set; }
        //
        #region --- --- --- CDATA_COMMENT --- --- ---
        [XmlIgnore]
        public string Remarks { get; set; }
        [XmlElement("Remarks")]
        public XmlCDataSection remarksCData
        {
            get
            {
                XmlDocument doc = new XmlDocument();
                if (Remarks == null)
                    return null;
                return doc.CreateCDataSection(Remarks);
            }
            set
            {
                Remarks = value.Value;
            }
        }
        #endregion
        //

        public string ColumnDef { get; set; }
        public int OrdinalPosition { get; set; }
        public string isNullable { get; set; }
        public string isAutoIncrement { get; set; }
        public string isGeneratedColumn { get; set; }
    }
    #endregion
    //
    #region --- DataSource ---
    [XmlRoot]
    public class DataSource : BasicModel
    {
        public string Name { get; set; }
        public string DataStoreName { get; set; }
        public bool ReadOnly { get; set; }
        public int FetchSize { get; set; }
        public int LargeMaxRows { get; set; }
        public int MaxFieldSize { get; set; }
        public int MaxRows { get; set; }
        //
        public List<DataColumn> DataColumnList { get; set; }
        public List<int> WarningList { get; set; }
        public List<int> IncludingList { get; set; }
        public List<int> ExcludingList { get; set; }
        public List<int> AvailableList { get; set; }
    }
    #endregion
    //
    [XmlRoot]
    public class DataTarget : BasicModel
    {
    }

    public class x
    {
        public DateTimeOffset Acquired { get; set; }

    }
}
