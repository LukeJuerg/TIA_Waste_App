using Foundation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TIA_Waste_App.Data;
using TIA_Waste_App.iOS.Data;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(SQlite_IOS))]

namespace TIA_Waste_App.iOS.Data
{
    public class SQlite_IOS : ISQLite
    {
        public SQlite_IOS() { }
        public SQLite.SQLiteConnection GetConnection() 
        {
            var fileName = "Testdb.db3";
            var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentPath, "..", "Library");
            var path = Path.Combine(libraryPath, fileName);
            var connection = new SQLite.SQLiteConnection(path);
            return connection;
        }
    }
}