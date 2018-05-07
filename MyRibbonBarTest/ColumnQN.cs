using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Xml.Serialization;

namespace MyRibbonBarTest
{
    [Serializable]
    public class ColumnQnList
    {
        internal List<ColumnQN> items;
        //
        public ColumnQnList()
        {
            Items = new List<ColumnQN>();
        }
        public ColumnQnList(BindingList<ColumnQN> colQnBindingList)
        {
            Items = new List<ColumnQN>();
            foreach (var c in colQnBindingList)
            {
                Items.Add(c);
            }
        }
        //
        public List<ColumnQN> Items { get => items; set => items = value; }
        //
        public bool Serialize(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(ColumnQnList));
                    serializer.Serialize(writer, this);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
    [Serializable]
    public class ColumnQN
    {
        public ColumnQN()
        {
        }

        [XmlAttribute]
        public string ObjectType
        {
            get; set;
        }
        [XmlAttribute]
        public string ParentType
        {
            get; set;
        }

        #region --- Server Names ---
        public string ServerAltName
        {
            get; set;
        }
        public string ServerName
        {
            get; set;
        }
        public string ServerNameFull
        {
            get; set;
        }
        public string ServerNameQuoted
        {
            get; set;
        }
        #endregion

        #region --- Database Names ---
        public string DatabaseAltName
        {
            get; set;
        }
        public string DatabaseName
        {
            get; set;
        }
        public string DatabaseNameFull
        {
            get; set;
        }
        public string DatabaseNameQuoted
        {
            get; set;
        }
        #endregion

        #region --- Schema Names ---
        public string SchemaAltName
        {
            get; set;
        }
        public string SchemaName
        {
            get; set;
        }
        public string SchemaNameFull
        {
            get; set;
        }
        public string SchemaNameQuoted
        {
            get; set;
        }
        #endregion

        #region --- Parent Names (TABLE|VIEW|PROCEDURE|SYNONYM) ---
        public string ParentAltName
        {
            get; set;
        }
        public string ParentName
        {
            get; set;
        }
        public string ParentNameFull
        {
            get; set;
        }
        public string ParentNameQuoted
        {
            get; set;
        }
        #endregion

        #region --- Column Names ---
        public string AltName
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public string NameFull
        {
            get; set;
        }
        public string NameQuoted
        {
            get; set;
        }
        #endregion

        [XmlAttribute]
        public bool IsNullable
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsReadOnly
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsPrimaryKey
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsSystem
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsDefault
        {
            get; set;
        }
        [XmlAttribute]
        public bool IsVirtual
        {
            get; set;
        }
        public string Expression
        {
            get; set;
        }
        public string DatabaseTypeName
        {
            get; set;
        }
        public string StorageTypeName
        {
            get; set;
        }
        public long Size
        {
            get; set;
        }
        public int Precision
        {
            get; set;
        }
        public int Scale
        {
            get; set;
        }

        public string Remarks
        {
            get; set;
        }

        public override string ToString()
        {
            return NameFull;
        }
        //
        public bool Serialize(string filename)
        {
            try
            {
                XmlSerializer _xmlserializer = new XmlSerializer(typeof(ColumnQN));
                Stream stream = new FileStream(filename, FileMode.Create);
                _xmlserializer.Serialize(stream, this);
                stream.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
