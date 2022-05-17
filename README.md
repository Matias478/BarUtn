# BarUtn
La aplicacion BarUtn, empieza por un form Login en la cual se pediran los datos necesarios al usuario para luego confirmar si este se encuentra en la lista e ingresar en el menu principal.
Cuenta tambien con otros dos botones, aparte del de loguearse, que son para completar los datos pedidos, dependiendo de cual elija se completaran los datos pedidos como los de un empleado o como un administrador.
Una vez el usuario logueado se abrira el form MenuPrincipal en el cual se encontraran las mesas/barra y dependiendo de si el usuario es empleado o administrador se mostraran distintos botones.

Una vez en el form del menu principal si el usuario es admin se podra ver una lista de los empleados, agregar y removerlos tambien.
Y por el momento si se loguea como empleado se podra ver la lista de mesas con la info de cada mesa.
Ademas de los 20 botones que controlan el form menu de cada mesa, donde se podra cargar los productos y sus cantidades. Mostrando tambien el saldo que lleva la mesa por el momento.

Si se clickea el boton Funcion Admin se abrira un sub-menu que contendra 3 botones: 
-Lista Empleados: Abrira el form Lista y mostrara la lista de todos los empleados y admins.
-Agregar Empleados: Se abrira en este caso el form de AgregarEmpleados y se pediran los datos necesarios para crear uno nuevo.
-Remover Empleados: Se abrira el form RemoverEmpleados y se mostrara un listBox que contendra la lista de los empleados y tambien se podra elegir uno y al apretar el boton remover, ese empleado sera exterminado de la lista.

Si se clickea el boton Funcion Empleado (por el momento) se abrira un sub-menu que contendra 1 boton:
-Info de Mesas: Abrira el form Lista y mostrara la lista de todas las mesas con la informacion de cada una.


Yendo a la biblioteca de clases yo elegi empezar la herencia en la clase producto(Clase Abstracta) para poder extenderla en las subclases comidas/bebidas.
La clase estatica Bar la uso para hardcodear los empleados/administradores, las mesas y un inventario en el futuro.
Basandome en el parcial que subio el profe lucas me guie para hacer el dictionary de botones para el control de cada boton.

Falta/Error: 
El estado de cada mesa indicando con colores si esta ocupada o libre, no estara disponible por el momento, espero poder solucionarlo para la entrega final
Al querer salir de la aplicacion desde el menu principal pide que le dos veces al si en el mensaje (Esta seguro que quiere salir?).

