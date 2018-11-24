"use strict";

window.onload = function () {
    try {
        show_selected();
    } catch (e) {

    }
    try {
        show_selected10();
    } catch (e) {

    }
    try {
        show_selected11();
    } catch (e) {

    }
    try {
        show_selected12();
    } catch (e) {

    }
    try {
        show_selected16();
    } catch (e) {

    }
    try {
        show_selected17();
    } catch (e) {

    }
    try {
        show_selected18();
    } catch (e) {

    }
    try {
        show_selected19();
    } catch (e) {

    }
   
};

function show_selected() {
    try {
        var selector = document.getElementById('listaPeluqueros');
        var value = selector[selector.selectedIndex].value;
        var user = document.getElementById("id").textContent;
        var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=9&amp;userID=" + user+"&amp;peluqueroID=" + value + "' id='Reservar9'>Reservar</a>";

        document.getElementById('display').innerHTML = code;
    } catch (e) {
       
    }
}


function show_selected10() {
    var selector = document.getElementById('listaPeluqueros10');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=10&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar10'>Reservar</a>";

    document.getElementById('display10').innerHTML = code;
}


function show_selected11() {
    var selector = document.getElementById('listaPeluqueros11');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=11&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar11'>Reservar</a>";

    document.getElementById('display11').innerHTML = code;
}


function show_selected12() {
    var selector = document.getElementById('listaPeluqueros12');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=12&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar12'>Reservar</a>";

    document.getElementById('display12').innerHTML = code;
}


function show_selected16() {
    var selector = document.getElementById('listaPeluqueros16');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=16&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar16'>Reservar</a>";

    document.getElementById('display16').innerHTML = code;
}


function show_selected17() {
    var selector = document.getElementById('listaPeluqueros17');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=17&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar17'>Reservar</a>";

    document.getElementById('display17').innerHTML = code;
}


function show_selected18() {
    var selector = document.getElementById('listaPeluqueros18');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=18&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar18'>Reservar</a>";

    document.getElementById('display18').innerHTML = code;
}


function show_selected19() {
    var selector = document.getElementById('listaPeluqueros19');
    var value = selector[selector.selectedIndex].value;
    var user = document.getElementById("id").textContent;
    var code = "<a class='btn btn-light' href='/Turnos/NuevoTurno?horario=19&amp;userID=" + user + "&amp;peluqueroID=" + value + "' id='Reservar19'>Reservar</a>";

    document.getElementById('display19').innerHTML = code;
}
try {
    document.getElementById('listaPeluqueros').addEventListener('click', show_selected);;
}
catch (err) {
   
}
try {
    document.getElementById('listaPeluqueros10').addEventListener('click', show_selected10);;
} catch (e) {

}
try {
    document.getElementById('listaPeluqueros11').addEventListener('click', show_selected11);;
} catch (e) {

}
try {
    document.getElementById('listaPeluqueros12').addEventListener('click', show_selected12);;
} catch (e) {

}

try {
    document.getElementById('listaPeluqueros16').addEventListener('click', show_selected16);;
} catch (e) {

}
try {
    document.getElementById('listaPeluqueros17').addEventListener('click', show_selected17);;
} catch (e) {

}

try {
    document.getElementById('listaPeluqueros18').addEventListener('click', show_selected18);;
} catch (e) {

}

try {
    document.getElementById('listaPeluqueros19').addEventListener('click', show_selected19);;
} catch (e) {

}
