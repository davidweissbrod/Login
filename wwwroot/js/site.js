function largoContraseña(contraseña){
    if(contraseña.Lenght < 8){
        return false;
    }
    return true;
}

function caracterEspecial(contraseña){
    const caracteres = "!#$%&*";
    for(let i = 0; i < contraseña.Lenght, i++;){
        if(caracteres.indexOf(contraseña[i])){
            return false;
        }
    }
    return true;
}

function mayus(contraseña){
    for(let i = 0; i < contraseña.Lenght, i++;){
        if(contraseña[i] == contraseña[i].toUpperCase()){
            return true;
        }
    }
    return false;
}