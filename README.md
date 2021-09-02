# BCP_TEST
Es una aplicacion de prueba que permite iniciars esion con cualquier correo, para obtener el token, luego ese token se usa para hacer llamado a  cualquier request. 
Hay 2 enpoint Exchange, que permite realizar las operaciones para tipo de cambio y Rate, que es el CRUD de mantenimiento de la tabla de tipos de cambio.


## Endpoints (Postman)
* Obtener JWT token (POST /api/Account/Login)
* Adicionar el token obtenido para cualquier request (Bearer Token)
* Realizar la operacion de tipo de cambio (POST /api/Exchanges/Process)
* Realizar la operacion de registrar un nuevo tipo de cambio (POST /api/Rates)}
* Realizar la operacion de actualizar un tipo de cambio existente (PUT /api/Rates)}

## Swagger 
Ver docuemntacion de API swagger en https://localhost:44345/swagger/index.html
