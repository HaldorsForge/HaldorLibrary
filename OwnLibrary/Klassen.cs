using System;
using System.Data;
using System.Data.SQLite;

namespace HaldorLibrary
{
    //INI Bearbeitung
    public class IniWorker
    {
        //TODO Einlesen der INI-Daten
            //TODO brauch Dateipfad
        //TODO Bearbeiten der INI-Daten
    }

    //CSV Import
    public class CsvImport
    {
        //TODO Einlesen der CSV-Daten
            //TODO brauch Dateipfad
    }

    //TODO DB-Connection
    public class DbConnector
    {
        //TODO Connectionstring
        SQLiteConnection connection = new SQLiteConnection();
        DataSet myDataSet = new DataSet();

        public void ConOpen(String dbfilename)	//dbfilename = @"//DBank.s3db"; //TODO korrekter Pfad
        {
            connection.ConnectionString = "Data Source = " + dbfilename;
            connection.Open();
            
        }
        public void ConClose()
        {
            connection.Close();
        }
    }
    
    //TODO Listen mit DB-Daten bestücken
    public class DbListFiller
    {
        //TODO brauch DbConnector
        //TODO brauch Commandstring
        public void Fill()
        {
            DbConnector db = new DbConnector();
            db.ConOpen("");	//dbfilename = @"//DBank.s3db"; //TODO korrekter Pfad
        }

        //TODO brauch List-Typ (List, ListView, ComboBox, ...)

    }

    //TODO Background-Changer
    public class BgChanger
    {
        //TODO brauch Intervall
        //TODO Bilderimport
            //TODO brauch Dateipfade
        //TODO Bilder als Image setzen
    }

    //TODO Runtime Objekte erstellen
    public class RunObjects
    {
        //TODO brauch Objekttyp
        //TODO brauch Objektparameter (Name, Größe, Position, Text,...)
    }

    //TODO Aufbau DB abfragen
    public class DbConstruction
    {
        //TODO brauch DbConnector
    }
}
