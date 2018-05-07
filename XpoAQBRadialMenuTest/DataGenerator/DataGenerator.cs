using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataGenerator
{
    public sealed class DataGeneratorWrapper
    {
        const string DGSDK_DLL = "D:\\Program Files (x86)\\DTM Data Generation SDK\\x64\\dgsdk.dll";
        //
        const string LIST_TXT = "D:\\Program Files (x86)\\DTM Data Generation SDK\\samples.cs\\list.txt";
        const string LIBRARY_MDB = "D:\\Program Files (x86)\\DTM Data Generation SDK\\library.mdb";
        const string LIBRARY_ITEM = "Countries";
        //
        const string DB_ODBC_CONN_NM = "DBSRV_QWERTY_Sales";
        const string USER = ""; // "DBSRV\\user01";
        const string PWD = "";  // "8a0IucJ@Nx1Qy5HfFrX0Ob3m";
        const string DB = "Sales";
        const string TBLNM = "dbo.Orders";
        const string COLNM = "[Product Name]";
        const string STMT = "select distinct [Product Name] from dbo.Orders order by [Product Name]";
        //
        const string PROJECT_DGP = "D:\\Program Files (x86)\\DTM Data Generation SDK\\samples.cs\\testproject.dgp";
        const string PROJECT_LOG = "D:\\Program Files (x86)\\DTM Data Generation SDK\\samples.cs\\testproject.log";
        // --- --- ---
        #region --- Fill Methods... ---
        // --- --- ---
        #region --- List Interface ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitList(int values, string[] list);
        //
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string ListValue(int listHandle, int sequentially);
        #endregion
        // --- --- ---
        #region --- File Interface ---
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitFile(string File);
        //
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string FileValue(int fileHandle, int sequentially);
        // --- --- ---
        #endregion
        // --- --- ---
        #region --- Table Interface ---
        /// <summary>
        /// Important: you should pass quoted "[...]" or \"...\" or \'...\' string for tables and columns
        /// like "Order Details" to this function.
        /// Please use native quotation symbols of your database system. 
        /// </summary>
        /// <param name="dbHandle"></param>
        /// <param name="table"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitTable(int dbHandle, string table, string column);
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tableHandle"></param>
        /// <param name="sequentially">0 means the function will return values from the table sequentially, otherwise randomically.</param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string TableValue(int tableHandle, int sequentially);
        #endregion
        // --- --- ---
        #region --- Library Interface ---
        // --- --- ---
        /// <summary>
        /// The value library uses SQLite physical format as data storage.
        /// It can be modified by Value Library Manager or any compatible editor e.g. DTM Data Editor.
        /// </summary>
        /// <param name="libraryPathName"></param>
        /// <param name="Item"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitLibrary(string libraryPathName, string Item);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string LibraryValue(int libraryHandle, int sequentially);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void SetLibraryPath(string path);
        #endregion
        // --- --- ---
        #region --- Incremental Interface ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Start">First value of the sequence.</param>
        /// <param name="Step">Value added at each iteration.</param>
        /// <param name="UseEach">How many times the generated value will be used before add 'Step' value.</param>
        /// <param name="CycleLength">Number of iterations current value will be reinitialized by 'Start' value. 0 means no cycle.</param>
        /// <returns>generated value</returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitIncremental(int Start, int Step, int UseEach, int CycleLength);
        //
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string IncrementalValue(int handle);
        #endregion
        // --- --- ---
        #region --- Mask Interface ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitMask(string mask);
        /// <summary>
        /// Masks
        /// The mask is a text string with any number of 'A', 'a' and 'N' characters.During the value generation process the 'A' and 'a'
        /// characters is replaced with a random letter(from 'A' to 'Z' and from 'a' to 'z') and the 'N' character is replaced with a
        /// random figure. {n} means iterate last sign 1 to n times.All the rest of the mask characters will be moved to the result
        /// value without any changes. If you want to specify several different masks for filling a field, you should use the
        /// "From the List" method and specify masks as values with the "Use list items as a mask" mode on. You can use '\' character for
        /// escape next mask sign. For example, \a will be used as a 'a' letter without any replacements. Also, you can use I or I{n}
        /// item for autoincrement field. n is field size, I{3} means 001,002,...,999
        ///
        /// There are mask items:
        ///
        ///   A - letter from 'A' to 'Z'. 
        ///   a - letter from 'a' to 'z'. 
        ///   N - digit from '0' to '9'. 
        ///   Z - hexadecimal digit from '0' to '9' and 'A' to 'F'. 
        ///   {n} - repeater, value will be used from 1 to n times.n should be from 1 to 999. 
        ///   {=n} - repeater, value will be used n times.
        ///   { n; m } - repeater, value will be used from n to m times.n should be less then m and both numbers from 1 to 999. 
        ///   I{n} - autoincrement value from 1 to 10** n.
        ///   # - copy value of the last used {} block. 
        ///   
        /// compatibility warning: this fill method is obsolete.Please use it for backward compatibility only.
        /// </summary>
        /// <param name="maskHandle"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string MaskValue(int maskHandle);
        #endregion
        // --- --- ---
        #region --- Pattern Interface ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="parttern">definition of the Pattern that will be used to generate value.</param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitPattern(string parttern);
        //
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string PatternValue(int handle);
        //
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void PatternEndOfRow(int patternHandle);
        #endregion
        // --- --- ---
        #region --- Database Statement Interface ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbHandle">Valid handle generated by ConnectDB function.</param>
        /// <param name="sql">SQL statement definition like 'select AuthorID from Authors order by Name'</param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int InitStatement(int dbHandle, string sql);
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dbHandle">Valid handle generated by ConnectDB function.</param>
        /// <param name="sequentially">0 means the function will return values from the query results sequentially, random otherwise</param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string StatementValue(int dbHandle, int sequentially);
        #endregion
        // --- --- ---
        /// <summary>
        /// There are fill methods: 
        /// 
        /// From list
        /// From text file
        /// From table
        /// From Values Library
        /// Incremental
        /// By Mask(obsolete)
        /// By Pattern
        /// By SQL statement
        ///
        /// All fill methods consist of two functions: initialization and data generation.The first function saves fill methods
        /// properties into internal structures and prepares handle(DG_HANDLE type). The second(data generation) function accepts
        /// this handle as parameter.
        ///
        /// Important: before use you should copy to local buffer result of any function of this API level.
        /// 
        /// All functions of this group return generated value as string. The user should made required conversions manually.
        /// 
        /// SDK offers function PrevValue that returns previously generated value for specified method's handle. This function
        /// is helpful for depended values generation.
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string PrevValue(int handle);
        // --- --- ---
        #endregion
        // --- --- ---
        #region -- Low Level Methods... ---
        // --- --- ---
        /// <summary>
        /// This function generates short integer random value in range 0 to 32767. The user can change bound of the range using
        /// function parameters.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int ShortRandom(int from, int to);
        // --- --- ---
        /// <summary>
        /// This function generates integer random value in range 0 to 2147483647. The user can change bounds of the range
        /// using function parameters.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int IntRandom(int from, int to);
        // --- --- ---
        /// <summary>
        /// CharRandom, CharRandomUpper, CharRandomLower, CharRandomDigit
        /// Returns random char from A-Z, a-z or 0-9 sets.
        ///
        /// C/C++/C#
        ///    char CharRandom()
        ///    char CharRandomUpper() /* A-Z */
        ///    char CharRandomLower() /* a-z */
        ///    char CharRandomDigit() /* 0-9 */
        /// </summary>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern char CharRandom();
        // --- --- ---
        /// <summary>
        /// CharRandom, CharRandomUpper, CharRandomLower, CharRandomDigit
        /// Returns random char from A-Z, a-z or 0-9 sets.
        ///
        /// C/C++/C#
        ///    char CharRandom()
        ///    char CharRandomUpper() /* A-Z */
        ///    char CharRandomLower() /* a-z */
        ///    char CharRandomDigit() /* 0-9 */
        /// </summary>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern char CharRandomUpper();
        // --- --- ---
        /// <summary>
        /// CharRandom, CharRandomUpper, CharRandomLower, CharRandomDigit
        /// Returns random char from A-Z, a-z or 0-9 sets.
        ///
        /// C/C++/C#
        ///    char CharRandom()
        ///    char CharRandomUpper() /* A-Z */
        ///    char CharRandomLower() /* a-z */
        ///    char CharRandomDigit() /* 0-9 */
        /// </summary>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern char CharRandomLower();
        // --- --- ---
        /// <summary>
        /// CharRandom, CharRandomUpper, CharRandomLower, CharRandomDigit
        /// Returns random char from A-Z, a-z or 0-9 sets.
        ///
        /// C/C++/C#
        ///    char CharRandom()
        ///    char CharRandomUpper() /* A-Z */
        ///    char CharRandomLower() /* a-z */
        ///    char CharRandomDigit() /* 0-9 */
        /// </summary>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.U1)]
        public static extern char CharRandomDigit();
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.R8)]
        public static extern double DoubleRandom(double from, double to, int digits);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string StringRandom(int length);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string DateRandom(string format, string from, string to);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string TimeRandom(string format, string from, string to);
        // --- --- ---
        #endregion
        // --- --- ---
        #region --- Project Interface ---
        // --- --- ---
        /// <summary>
        /// NewProject creates new empty project.
        /// </summary>
        /// <returns>The new project handle (prjHandle)</returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int NewProject();
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int LoadProject(string fileName);
        // --- --- ---
        /// <summary>
        /// Saves the project specified by handle project (prjHandle) to the disk file.
        /// </summary>
        /// <param name="prjHandle"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int SaveProject(int prjHandle, string fileName);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void CloseProject(int prjHandle);
        // --- --- ---
        /// <summary>
        /// RunProject executes the project with specified database connection.
        /// </summary>
        /// <param name="projHandle"></param>
        /// <param name="connHandle"></param>
        /// <param name="log"></param>
        /// <returns>0 for success or non-zero otherwise.</returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int RunProject(int projHandle, int connHandle, string log);
        // --- --- ---
        /// <summary>
        /// Retrieves selected project property.
        /// </summary>
        /// <param name="prjHandle"></param>
        /// <param name="propertyId"></param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetProjectProperty(int prjHandle, int propertyId);
        // --- --- ---
        /// <summary>
        /// Sets or changes specified project property.
        /// </summary>
        /// <param name="prjHandle"></param>
        /// <param name="propertyId"></param>
        /// <param name="value"></param>
        /// <returns>
        /// 0 - executes successfully.
        /// -1 - invalid handle
        /// -2 - passed handle does not allocated.
        /// -4 - unknown property ID.
        /// </returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetProjectProperty(int prjHandle, int propertyId, string value);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string SetProjectProperty(int prjHandle, int propertyId, string value);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int RemoveRule(int prjHandle, int idx);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int GetRule(int handle, int order);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int SetRule(int prjHandle, int idx, int ruleHandle);
        // --- --- ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="prjHandle">Project handle where the rule will be added.</param>
        /// <param name="ruleHandle">Handle of rule that will be added to the project.</param>
        /// <returns>
        /// 0 for success
        /// -1 for invalid project handle
        /// -2 for not allocated project handle.
        /// </returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int AddRule(int prjHandle, int ruleHandle);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int nRules(int handle);
        // --- --- ---
        #endregion
        // --- --- ---
        #region --- Rule Interface ---
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void CloseRule(int ruleHandle);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetRuleProperty(int ruleHandle, int propertyId);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        static extern string SetRuleProperty(int ruleHandle, int propertyId, string value);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int GetRuleItem(int handle, int order);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int SetRuleItem(int ruleHandle, int idx, int itemHandle);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int RemoveRuleItem(int ruleHandle, int idx);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int AddRuleItem(int ruleHandle, int itemHandle);
        // --- --- ---
        /// <summary>
        /// returns numbers of items (each item corresponds to one field of output data) in the specified rule.
        /// </summary>
        /// <param name="ruleHandle"></param>
        /// <returns>Returns number of items (>=0) in success or -1 otherwise.</returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int nRuleItems(int ruleHandle);
        // --- --- ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="itemHandle"></param>
        /// <param name="propertyId">Property code from DG_ITEM_PROPS list (see table below or DGSKD.H).</param>
        /// <returns></returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetItemProperty(int itemHandle, int propertyId);
        // --- --- ---
        /// <summary>
        /// Changes selected property of the specified item.
        /// </summary>
        /// <param name="itemHandle"></param>
        /// <param name="propertyId"></param>
        /// <param name="value"></param>
        /// <returns>
        /// 0 for success
        /// -1 for invalid rule handle
        /// -2 for unknown or unsupported property ID.
        /// </returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int SetItemProperty(int itemHandle, int propertyId, string value);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void CloseItem(int itemHandle);
        // --- --- ---
        #endregion
        // --- --- ---
        #region --- General Interface ---
        // --- --- ---
        /// <summary>
        /// 
        /// </summary>
        /// <param name="odbcDataSource">
        /// Name of predefined ODBC data source. Please use ODBC Administrator
        /// (odbcad32.exe or Control Panel icon) to prepare this name.
        /// </param>
        /// <param name="user">OPTIONAL and define login (user name) that will be used for connection</param>
        /// <param name="password">OPTIONAL and define login (password) that will be used for connection</param>
        /// <param name="database">OPTIONAL as well and can be use with Microsoft SQL server only</param>
        /// <returns>value>0: The handle to the database connection; 0: otherwise</returns>
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int ConnectDB(string odbcDataSource, string user, string password, string database);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void DisconnectDB(int dbHandle);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.I4)]
        public static extern int ExecDB(int dbHandle, string sqlStmt);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        public static extern string GetError(int handle);
        // --- --- ---
        [DllImport(DGSDK_DLL, CharSet = CharSet.Unicode)]
        public static extern void CloseH(int handle);
        // --- --- ---
        #endregion
        // --- --- ---
    }
}
