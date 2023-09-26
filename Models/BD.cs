using System.Data.SqlClient;
using Dapper;

public class BD{
    private static string _connectionString = @"Server=localhost; DataBase=LoginBD; Trusted_Connection = True;";

    public static void AñadirUsuario(Usuario user){
        string sql = "INSERT INTO Usuarios(idUsuario, username, contraseña, nombre, apellido, mail) VALUES(@pidUsario, @pusername, @pcontraseña, @pnombre, @papellido, @pmail)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new{pidUsuario = user.idUsuario, pusername = user.username, pcontraseña = user.contraseña, pnombre = user.nombre, papellido = user.apellido, pmail = mail.user});
        }
    }

    public static void CambiarContraseña(Usuario user, string nuevaContraseña){
        string sql = "UPDATE Usuarios SET contraseña = @nuevaContraseña WHERE contraseña = @pcontraseña";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new{pcontraseña = user.contraseña});
        }
    }
}
