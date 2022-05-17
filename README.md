# BarUtn
La aplicacion BarUtn, empieza por un form Login en la cual se pediran los datos necesarios al usuario para luego confirmar si este se encuentra en la lista e ingresar en el menu principal.
Cuenta tambien con otros dos botones, aparte del de loguearse, que son para completar los datos pedidos, dependiendo de cual elija se completaran los datos pedidos como los de un empleado o como un administrador.
Una vez el usuario logueado se abrira el form MenuPrincipal en el cual se encontraran las mesas/barra y dependiendo de si el usuario es empleado o administrador se mostraran distintos botones.

Yendo a la biblioteca de clases yo elegi empezar la herencia en la clase producto(Clase Abstracta) para poder extenderla en las subclases comidas/bebidas.
La clase estatica Bar la uso para hardcodear los empleados/administradores, las mesas y un inventario en el futuro.