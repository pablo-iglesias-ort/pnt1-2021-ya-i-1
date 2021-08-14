# Carrito de Compras 馃摉

## Objetivos 馃搵
Desarrollar un sistema, que permita la administraci贸n del stock de productos a una PYME que tiene algunas sucursales de venta de ropa (de cara a los empleados): Empleados, Clientes, Productos, Categorias, Compras, Carritos, Sucursal, StockItem, etc., como as铆 tambi茅n, permitir a los clientes, realizar compras Online.
Utilizar Visual Studio 2019 preferentemente y crear una aplicaci贸n utilizando ASP.NET MVC Core (versi贸n a definir por el docente 2.2 o 3.1).

<hr />

## Enunciado 馃摙
La idea principal de este trabajo pr谩ctico, es que Uds. se comporten como un equipo de desarrollo.
Este documento, les acerca, un equivalente al resultado de una primera entrevista entre el cliente y alguien del equipo, el cual relev贸 e identific贸 la informaci贸n aqu铆 contenida. 
A partir de este momento, deber谩n comprender lo que se est谩 requiriendo y construir dicha aplicaci贸n, 

Deben recopilar todas las dudas que tengan y evacuarlas con su nexo (el docente) de cara al cliente. De esta manera, 茅l nos ayudar谩 a conseguir la informaci贸n ya un poco m谩s procesada. 
Es importante destacar, que este proceso, no debe esperar a ser en clase; es importante, que junten algunas consultas, sea de 铆ndole funcional o t茅cnicas, en lugar de cada consulta enviarla de forma independiente.

Las consultas que sean realizadas por correo deben seguir el siguiente formato:

Subject: [NT1-<CURSO LETRA>-GRP-<GRUPO NUMERO>] <Proyecto XXX> | Informativo o Consulta

Body: 

1.<xxxxxxxx>

2.< xxxxxxxx>


# Ejemplo
**Subject:** [NT1-A-GRP-5] Agenda de Turnos | Consulta

**Body:**

1.La relaci贸n del paciente con Turno es 1:1 o 1:N?

2.Est谩 bien que encaremos la validaci贸n del turno activo, con una propiedad booleana en el Turno?

<hr />

### Proceso de ejecuci贸n en alto nivel 鈽戯笍
 - Crear un nuevo proyecto en [visual studio](https://visualstudio.microsoft.com/en/vs/).
 - Adicionar todos los modelos dentro de la carpeta Models cada uno en un archivo separado.
 - Especificar todas las restricciones y validaciones solicitadas a cada una de las entidades. [DataAnnotations](https://docs.microsoft.com/en-us/dotnet/api/system.componentmodel.dataannotations?view=netcore-3.1).
 - Crear las relaciones entre las entidades
 - Crear una carpeta Data que dentro tendr谩 al menos la clase que representar谩 el contexto de la base de datos DbContext. 
 - Crear el DbContext utilizando base de datos en memoria (con fines de testing inicial). [DbContext](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext?view=efcore-3.1), [Database In-Memory](https://docs.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=vs).
 - Agregar los DbSet para cada una de las entidades en el DbContext.
 - Crear el Scaffolding para permitir los CRUD de las entidades al menos solicitadas en el enunciado.
 - Aplicar las adecuaciones y validaciones necesarias en los controladores.  
 - Realizar un sistema de login con al menos los roles equivalentes a <Usuario Cliente> y <Usuario Administrador> (o con permisos elevados).
 - Si el proyecto lo requiere, generar el proceso de registraci贸n. 
 - Un administrador podr谩 realizar todas tareas que impliquen interacci贸n del lado del negocio (ABM "Alta-Baja-Modificaci贸n" de las entidades del sistema y configuraciones en caso de ser necesarias).
 - El <Usuario Cliente> s贸lo podr谩 tomar acci贸n en el sistema, en base al rol que tiene.
 - Realizar todos los ajustes necesarios en los modelos y/o funcionalidades.
 - Realizar los ajustes requeridos del lado de los permisos.
 - Todo lo referido a la presentaci贸n de la aplicai贸n (cuestiones visuales).
 
<hr />

## Entidades 馃搫

- Usuario
- Cliente
- Empleado
- Producto
- Categoria
- Stock
- StockItem
- Carrito
- CarritoItem
- Compra

`Importante: Todas las entidades deben tener su identificador unico. Id o <ClassNameId>`

`
Las propiedades descriptas a continuaci贸n, son las minimas que deben tener las entidades. Uds. pueden agregar las que consideren necesarias.
De la misma manera Uds. deben definir los tipos de datos asociados a cada una de ellas, como as铆 tambi茅n las restricciones.
`

**Usuario**
```
- Nombre
- Email
- FechaAlta
- Password
```

**Cliente**
```
- Nombre
- Apellido
- DNI
- Telefono
- Direccion
- FechaAlta
- Email
- Compras
- Carritos
```

**Empleado**
```
- Nombre
- Apellido
- Telefono
- Direccion
- FechaAlta
- Email
```

**Producto**
```
- Nombre
- Descripcion
- PrecioVigente
- Activo
- Categoria
```

**Categoria**
```
- Nombre
- Descripcion
- Productos
```

**Sucursal**
```
- Nombre
- Direccion
- Telefono
- Email
- StockItems
```

**StockItem**
```
- Sucursal
- Producto
- Cantidad
```

**Carrito**
```
- Activo
- Cliente
- CarritoItems
- Subtotal
```

**CarritoItem**
```
- Carrito 
- Producto
- ValorUnitario
- Cantidad
- Subtotal
```

**Compra**
```
- Cliente 
- Carrito
- Total
```


**NOTA:** aqu铆 un link para refrescar el uso de los [Data annotations](https://www.c-sharpcorner.com/UploadFile/af66b7/data-annotations-for-mvc/).

<hr />

## Caracteristicas y Funcionalidades 鈱笍
`Todas las entidades, deben tener implementado su correspondiente ABM, a menos que sea implicito el no tener que soportar alguna de estas acciones.`

**Usuario**
- Los Clientes pueden auto registrarse.
- La autoregistraci贸n desde el sitio, es exclusiva para los clientes. Por lo cual, se le asignar谩 dicho rol.
- Los empleados, deben ser agregados por otro empleado o administrador.
	- Al momento, del alta del empleado, se le definir谩 un username y password.
    - Tambi茅n se le asignar谩 a estas cuentas el rol de Empleado.

**Cliente**
- Un cliente puede navegar los productos y sus descripciones sin iniciar sesi贸n, de forma anonima. 
- Para agregar productos en cantidad al carrito, debe iniciar sesi贸n primero.
- El cliente, puede agregar diferentes productos en el carrito, y por cada producto modificar la cantidad que quiere.
-- Esta acci贸n, no implica validaci贸n en stock.
-- El ciente, ver谩 el subtotal, por cada producto/cantidad.
-- Tambi茅n, ver谩 el subtotal, del carrito.
- El cliente, una vez que est谩 satisfecho con su carrito, puede finalizar la compra y elejir谩 un lugar para retirar.
- El cliente puede vaciar el carrito.
- Puede actualizar datos de contacto, direccion, telefono. Pero no puede modificar su Email, DNI, Nombre, Apellido, etc.
- El cliente puede ver el historial de sus compras. Id,Fecha,Sucursal,Monto

**Empleado**
- El empleado, puede listar las compras realizadas en el mes, en modo listado, ordenado de forma descendente por valor de compra.
- Puede dar de alta otros empleados.
- Puede crear productos, categorias, Sucursales, agregar productos al stock de cada sucursal.
- Puede habilitar y/o deshabilitar productos.

**Producto y Categoria**
- No pueden eliminarse del sistema. 
- Solo los producto pueden dehabilitarse.

**Sucursal**
- Cada sucursal, tendr谩 su propio stock.
- Y sus datos de locaci贸n y contacto.
- Por el mercado tan volatil, las sucursales, pueden crearse y eliminarse en todo momento.
-- Para poder eliminar una sucursal, la misma no tiene que tener productos en su stock.

**StockItem**
- Pueden crearse, pero nunca pueden eliminarse desde el sistema. Son dependeintes de la surcursal.
- Puede modificarse la cantidad en todo momento que se dispone de dicho producto, en el stock.
- Se eliminaran, junto con la sucrusal, si esta fuese eliminada.

**Carrito**
- El carrito se crea automaticamente con la creaci贸n de un cliente, en estado activo.
- Solo puede haber un carrito activo por usuario en el sistema.
- Un carrito que no est谩 activo, no puede modificarse en ning煤n aspecto.
- No se puede eliminar carritos.
- El carrito, se desactiva al momento de realizarse una compra de manera automatica.
- Al vaciar el carrito, se eliminan todos los CarritoItems y datos que sean necesarios.
- El subtotal, es un dato calculado.

**CarritoItem**
- El valor unitario del carritoItem, debe actualizarse, al realizar cualquier modificaci贸n, seg煤n el precio que tenga vigente el producto.
- El subtotal, debe ser una propiedad calculada, en base a la cantidad x el valor unitario.


**Compra**
- Al generarse la compra, el carrito que tiene asociado, pasa a estar en estado Inactivo.
- Al finalizar la compra, se validar谩 si hay disponibles en el stock de la locaci贸n que seleccion贸 el cliente. 
-- Si hay stock, disminuye el mismo, y crea la compra.
-- Si no hay stock, verifica en otras locaciones, si hay stock. 
--- Si hay en alguna, propone las locaciones o indica que no hay en stock.
--- Si seleccion贸 una nueva locaci贸n, finaliza la compra.
- Al Finalizar la compra, se le muestra le da las gracias al cliente, se le d谩 el Id de compra y los datos de la Sucursal que eligi贸.
- No se pueden eliminar las compras.


**Aplicaci贸n General**
- Informaci贸n institucional.
- Se deben mostrar los productos por categor铆a.
- Los productos que est谩n deshabilitados, deben visualizarse como Pausados. Independientemente, de que haya o no en stock.
- Los accesos a las funcionalidades y/o capacidades, debe estar basada en los roles que tenga cada individuo.

`
Nota: El negocio tiene lugar y posibilidades de tener un stock ilimitado y cada sucursal est谩 preparado para vender cualquier producto, por lo cual esto no implica restricciones.
`
