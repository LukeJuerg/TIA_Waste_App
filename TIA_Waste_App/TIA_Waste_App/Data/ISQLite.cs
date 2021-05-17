using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TIA_Waste_App.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
