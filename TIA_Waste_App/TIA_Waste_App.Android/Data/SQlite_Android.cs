using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TIA_Waste_App.Data;
using TIA_Waste_App.Droid.Data;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQlite_Android))]

namespace TIA_Waste_App.Droid.Data
{
    public class SQlite_Android : ISQLite
    {
        public SQlite_Android() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var sqliteFileName = "TestDB.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);

            return conn;
        }
    }
}