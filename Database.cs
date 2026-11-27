using Microsoft.Data.Sqlite;
using System.Data;

namespace MakiUniformManager;

internal static class Database
{
    private static readonly string Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MakiLabs", "MakiUniformManager"); 

    public static string FilePath =>
        Path.Combine(Folder, "divise.db"); //qui è dove si trova il nostro DataBase

    public static void Initialize()
    {
        Directory.CreateDirectory(Folder); //crea la cartella

        using var connection =
            new SqliteConnection($"Data Source={FilePath}"); //strada del database

        connection.Open(); //si connette al database

        using var command = connection.CreateCommand(); //crea un comando Query

        //questo è il testo del comando, bisogna seguire le regole SQL
        command.CommandText = """
            CREATE TABLE IF NOT EXISTS Dipendenti (
                Id INTEGER PRIMARY KEY,
                Nome TEXT NOT NULL,
                Cognome TEXT NOT NULL,
                Attivo INTEGER NOT NULL DEFAULT 1
            );
            """;

        command.ExecuteNonQuery(); //a quanto pare esegue il comando NON Query?
    }

    public static DataTable GetDipendenti()
    {
        using var connection =
            new SqliteConnection($"Data Source={FilePath}");

        connection.Open();

        using var command = connection.CreateCommand();

        command.CommandText = """
        SELECT Id, Nome, Cognome, Attivo 
        FROM Dipendenti
        ORDER BY Cognome, Nome;
        """;

        using var reader = command.ExecuteReader(); //esegue la query

        var table = new DataTable(); //è una tabella excel praticamente, ma non excel
        table.Load(reader); //carica il risultato della query e lo mette sulla tabella

        return table; //restituisce quella tabella
    }

    public static void AddDipendenti(string nome, string cognome)
    {
        using var connection = new SqliteConnection($"Data Source ={FilePath}");

        connection.Open();

        using var command = connection.CreateCommand();

        //qui sotto inserisco in Dipendenti (una pagina di Divise.db) con insert into (NonQuery)
        //di seguito $nome e $cognome sono parametri SQL, quindi segue altre regole
        command.CommandText = """
            INSERT INTO Dipendenti (Nome, Cognome) 
            VALUES ($nome, $cognome);
            """;

        command.Parameters.AddWithValue("$nome", nome);
        command.Parameters.AddWithValue("$cognome", cognome);

        command.ExecuteNonQuery();
    }
}

