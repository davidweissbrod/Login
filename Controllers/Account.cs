using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Login.Models;

namespace Login.Controllers;

public class Account : Controller{
    private readonly ILogger<Account> _logger;

    public Account(ILogger<Account> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(){
        return View("Index");
    }

    public IActionResult Login(int id){
        ViewBag.inicioSesion = BD.IniciarSesion(id);
        return View("login");
    }

    public IActionResult NuevoUsuario(Usuario us){
        ViewBag.Username = us.username;
        ViewBag.Nombre = us.nombre;
        ViewBag.Apellido = us.apellido;
        ViewBag.mail = us.mail;
        return View("registro");
    }
    public IActionResult CambiarContraseña(string nueva){
        ViewBag.nuevaContraseña = BD.CambiarContraseña(nueva);
        return View("olvide");
    }

    public IActionResult Registro(Usuario user){
        ViewBag.nuevoUsuario = BD.AñadirUsuario(user);
        return RedirectToAction("NuevoUsuario(user)");
    }

    public IActionResult Bienvenida(){
        return View("bienvenida");
    }
}