public class Usuario{
    public int idUsuario{get; set;}
    public string username{get; set;}
    public string contraseña{get; set;}
    public string nombre{get; set;}
    public string apellido{get; set;}
    public string mail{get; set;}

    public Usuario(int idUs, string user, string contra, string nom, string ap, string Mail){
        idUsuario = idUs;
        username = user; 
        contraseña = contra; 
        nombre = nom;
        apellido = ap;
        mail = Mail;
    }

    public Usuario(int idUs, string user, string contra, string nom, string ap, string Mail){

    }
}