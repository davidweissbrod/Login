using System.Data.SqlClient;
using Dapper;

public class BD{
    private static string _connectionString = @"Server=localhost; DataBase=LoginBD; Trusted_Connection = True;";
    private static List<Usuario> listaUsuarios = new List<Usuario>();
    public static List<Usuario> IniciarSesion(int idUs){
        using(SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT idUsuario FROM Usuarios WHERE idUsuario = @pidUsuario";    
            listaUsuarios = db.Query<Usuario>(sql, new {pidUsuario = idUs});
        }
        return listaUsuarios;
    }

    public static Usuario AñadirUsuario(Usuario user){
        string sql = "INSERT INTO Usuarios(idUsuario, username, contraseña, nombre, apellido, mail) VALUES(@pidUsario, @pusername, @pcontraseña, @pnombre, @papellido, @pmail)";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new{pidUsuario = user.idUsuario, pusername = user.username, pcontraseña = user.contraseña, pnombre = user.nombre, papellido = user.apellido, pmail = user.mail});
        }
        return user;
    }

    public static string CambiarContraseña(string nuevaContraseña){
        string sql = "UPDATE Usuarios SET contraseña = @nuevaContraseña WHERE contraseña = @pcontraseña";
        using(SqlConnection db = new SqlConnection(_connectionString))
        {
            db.Execute(sql, new{pcontraseña = nuevaContraseña});
        }
        return nuevaContraseña;
    }
}
