"use strict";

window.onload = function () {
    show_selected();
};

function show_selected() {
    var selector = document.getElementById('listaPeluqueros');
    var value = selector[selector.selectedIndex].value;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=9&amp;userID=1&amp;peluqueroID="+value+"' id='Reservar9'>Reservar</a>";

    document.getElementById('display').innerHTML = code;
}

document.getElementById('listaPeluqueros').addEventListener('click', show_selected);;