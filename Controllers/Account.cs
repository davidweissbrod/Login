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

    public IActionResult Login(){
        ViewBag.inicioSesion = BD.IniciarSesion();
        return View("login");
    }

    public IActionResult CambiarContraseña(string nueva){
        ViewBag.nuevaContraseña = BD.CambiarContraseña(nueva);
        return View("olvide");
    }

    public IActionResult Registro(Usuario user){
        ViewBag.nuevoUsuario = BD.AñadirUsuario(user);
        return View("registro");
    }

    public IActionResult Bienvenida(){
        return View("bienvenida");
    }
}