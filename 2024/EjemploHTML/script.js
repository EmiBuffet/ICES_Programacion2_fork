function miFuncion() {
    let nombre = document.getElementById('nombre').value
    let apellido = document.getElementById('apellido').value

    let nombre_mas_apellido = nombre + ' ' + apellido

    document.getElementById('nombreapellido').innerText = nombre_mas_apellido;

    alert(nombre_mas_apellido);
}