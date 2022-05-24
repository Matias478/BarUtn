# BarUtn
Login:
La aplicacion BarUtn, empieza por un form Login en la cual se pediran los datos necesarios al usuario para luego confirmar si este se encuentra en la lista de usuarios e ingresar en el menu principal.
Cuenta tambien con otros dos botones, aparte del de loguearse, que son para completar los datos pedidos, dependiendo de cual elija se completaran los datos pedidos como los de un empleado o como un administrador.
Si el usuario no se encuentra en la lista sonara un sonido (que espero que reconozcan de que peli es) y se tendran que completar los datos correctamente para ingresar.

Menu Principal:
Una vez el usuario logueado se abrira el form MenuPrincipal en el cual se encontraran las mesas/barra y dependiendo de si el usuario es empleado o administrador se mostraran distintos botones.
Se reproducira un sonido ambiente de un restaurante(Uso exepciones en los casos de los sonidos, ya que estamos trabajando con archivos). Y se cambiara la imagen de fondo dependiendo si el usuario es una administrador o un empleado.
Admin:
Una vez en el form del menu principal si el usuario es admin se podra ver una lista de los empleados, agregar y removerlos. Tambien podra al sub-menu inventario donde podra ver la lista y agregar productos.
Si se clickea el boton Funcion Admin se abrira un sub-menu que contendra 3 botones: 
-Lista Empleados: Abrira el form Lista y mostrara la lista de todos los empleados y admins.
-Agregar Empleados: Se abrira en este caso el form de AgregarEmpleados y se pediran los datos necesarios para crear uno nuevo. En caso de que los datos pedidos sean ingresados incorrectamente sonara un sonido de error(Bastante fuerte tengo que admitir asi que usenlo con un volumen mas bajo cuando estern por esta parte).
-Remover Empleados: Se abrira el form RemoverEmpleados y se mostrara un listBox que contendra la lista de los empleados y tambien se podra elegir uno y al apretar el boton remover, ese empleado sera exterminado de la lista.
Si se clikea el boton inventario tendra acceso sub-menu que contendra:
-Info Inventario: Que mostrara en un richTextBox la info de los productos que se encuentran en el inventario. Tambien habra un boton para rellenar automaticamente el inventario de los productos que tengan pocas unidades
-Agregar Productos: Mostrara un form donde se dara a elegir si quiere agregar una comida o una bebida y luego se pediran los datos necesarios para una nueva carga de cualquiera de esas opciones.

Empleado:
Si se loguea como empleado se podra ver la lista de mesas con la info de cada mesa y gestionar cada mesa y cobrar (Cosa que el admin tambien puede hacer).

Si se clickea el boton Funcion Empleado se abrira un sub-menu que contendra 1 boton:
-Info de Mesas: Abrira el form Lista y mostrara la lista de todas las mesas con la informacion de cada una.

Al clikear en un boton mesa
Se abrira un form Menu donde se podra agregar productos a la mesa, y una vez se desee cerrar la cuenta.


Temas:
-Herencia: Elegi empezar la herencia en la clase producto(Clase Abstracta) para poder extenderla en las subclases comidas/bebidas.
-Propiedades: Estan presentes en las clases: Producto, Persona, Mesa, Bar, Bebidas y Comidas.
-Sobrecarga de constructores: En todas las clases mencionadas,menos en Bar, se usa este concepto.
-Colecciones: Basandome en el parcial que subio el profe lucas me guie para hacer una coleccion dictionary de botones para el control de cada boton y en la clase Bar por ejemplo hay 3 Colecciones tipo lista
-Clases Estaticas: La clase estatica Bar la uso para hardcodear los empleados/administradores, las mesas y un inventario en el futuro.
-Formularios Modal: No uso formularios modales en si, lo que hago es abrir el formulario adentro de un panel en el menu principal.
-Polimorfismo: Se aplica en la clase producto en el metodo abstracto ToString() y cambia lo que muestra en cada una de las clases derivadas.



Falta/Error: 
Al querer salir de la aplicacion desde el menu principal pide que le dos veces al si en el mensaje (Esta seguro que quiere salir?). Sino se presiona dos veces el boton si, el form de login que esta oculto seguira corriendo
No supe como solucionarlo, tratamos con lauti, lo consulte en el grupo, y no se que lo causa. Se una un Application.Exit().

