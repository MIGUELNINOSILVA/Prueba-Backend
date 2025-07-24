
# Proyecto de CRUD para productos

Cordial saludo, de antemano agradecer por la oportunidad de poder afrontar este reto, honestamente en cuanto a c# lo estudié hoy mismo, por ende pueden haber algunas cosas que no estén bien del todo, lo importante fue que pude repasar y afrontar el reto.

Mi disposición está en perfeccionar mis habilidades para ser mejor en cuanto a prácticas de desarrollo.




## Requisitos para la instalación

Clonar el proyecto [https://github.com/MIGUELNINOSILVA/Prueba-Backend.git]()

1- Instalar las dependencias requeridas de C#, Se trabajó bajo EntityFramework, base de datos principal SQL server.

Todo se trabajó bajo el ecosistema de Ubuntu.

Hay una base de datos que aparece en las credenciales directa, su nombre ecosistema
```
prueba_tecnica
```

Está junto sus migraciones y declaración de entidad Producto.

Ya luego sería desde el IDE con la herramienta de "ADMINISTRADOR DE PAQUETES NUGET" y ejecutar el comando:

```
Restore-Package
```

Ya por último sería para trabajarlo en entorno de desarrollo 
```
donet watch run
```

El puerto por defecto que se toma es el puerto *5237* para que se considere a la hora de hacer el consumo en el frontend.

Se debe configurar las credenciales de la base de datos y ajustarlas en el archivo  *appsettings.json* en la propiedad *DefaultConnection* dado que el proyecto se trabajó de manera local.


## Referencia de api

#### Obtener todos los productos

```http
  GET /api/productos
```

#### Obtener un producto

```http
  GET /api/productos/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Required |

#### Actualizar un producto
```http
  PUT /api/productos/${id}
```
| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Required |

| Body | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `numeric` | **Required**. Required |
| `nombre`      | `string` | **Required**. Required |
| `precio`      | `numeric` | **Required**. Required |
| `fechaCreacion`      | `string` | **Required**. Required |
| `Estado`      | `boolean` | **Required**. Required |

#### Crear un producto
```http
  POST /api/productos
```

| Body | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `nombre`      | `string` | **Required**. Required |
| `precio`      | `numeric` | **Required**. Required |
| `fechaCreacion`      | `string` | **Required**. Required |
| `Estado`      | `boolean` | **Required**. Required |

#### Eliminar un producto

```http
  DELETE /api/productos/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Required |



