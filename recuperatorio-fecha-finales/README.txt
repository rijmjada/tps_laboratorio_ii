Errores:

1- El test LibrosDeberianSerEquals no pasa correctamente
2- Repite el string connection al menos 3 veces
3- Stock nunca informa stock, solo se pueden buscar artículos
4- El pdf está incompleto (falta información de la entrega anterior, descripción de la aplicación, etc)

Soluciones:

1- El error estaba en que no ingrese los mismo datos, por eso no pasaba el metodo AreEquals. 
2- Se agrego la clase estatica 'DataAccess' por unica vez el connectionString. 
3- Se modifico el nombre por 'Buscar articulo' y se agrego una opcion llamda 'Stock' que muestra el listado en stock. 
4- Se agrego pdf describiendo la funcionalidades de la app.




