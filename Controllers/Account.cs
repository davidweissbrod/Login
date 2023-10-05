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

    
    public IActionResult Login(string name, string contra){
        List<Usuario> listaUsuarios = BD.LevantarUsuarios();
        Usuario user = listaUsuarios.FirstOrDefault(us => us.username == name);
        if(user.contraseña == contra){
            return RedirectToAction("Bienvenida");
        }
        else{
            ViewBag.ErrorContraseña = "Contraseña Incorrecta";
        }
        return View("login");
    }
    }

    public IActionResult CambiarContraseña(string nueva){
        ViewBag.nuevaContraseña = BD.CambiarContraseña(nueva);
        return View("olvide");
    }

    public IActionResult Registro(string username, string contraseña, string nombre, string apellido, string mail){
        Usuario us = new Usuario(username, contraseña, nombre, apellido, mail);
        BD.AñadirUsuario(us);
        return RedirectToAction("NuevoUsuario(user)");
    }

    public IActionResult Bienvenida(Usuario user){
        ViewBag.UsuarioLogueado = user;
        return View("bienvenida");
    }

    public IActionResult SobreNosotros(){
        return View("nosotros");
    }

   
