function login(){
    var user, pass;

    user=document.getElementById("usuario").value;
    pass=document.getElementById("contraseña").value;
    if(user == "Admin" && pass=="322"){
        window.location="admin.html"
    }
    else if(user == "Usuario" && pass=="322"){
        window.location="/html/usuario.html"
    }
}

function verificarRB()
{
    if(document.getElementById('radio1').checked)
    {
        location.href="./Form_larg.html";
    }   
    if(document.getElementById('radio2').checked)
    {
        location.href="./Form_short.html";
    }   
   
}
function redireccionar()
{
    location.href="./Recomendacion.html"
}

function ref_componentes()
{
    location.href="./descripción_comp1.html"
}

function retrocede_reco()
{
    location.href="./Recomendacion.html"
}
function retrocede_muestra()
{
    location.href="./Form_short.html";
}
function retroceder_total()
{
    location.href="./Form_elegir.html";
}

function avanzar_reclamacion2()
{
    location.href="../html/libro_reclamacion2.html";
}
function retroceder_reclamacion1()
{
    location.href="../html/libro_reclamacion1.html";
}