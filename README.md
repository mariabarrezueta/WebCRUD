# WebCRUD - Aplicación CRUD con Autenticación

Este es un proyecto de Ingeniería Web desarrollado con **ASP.NET Core MVC** y **Microsoft SQL Server**, que permite realizar operaciones CRUD sobre una lista de empleadas. Además, incluye un sistema de autenticación para proteger el acceso a las funcionalidades.

---

## Características

- Operaciones CRUD: Crear, Leer, Editar y Eliminar empleadas.
- Autenticación con Identity: Registro, Login, Logout.
- Protección de rutas: Solo usuarios autenticados pueden acceder a CRUD.
- Redirección automática al Login si se intenta acceder sin iniciar sesión.
- Interfaz dinámica que muestra información personalizada del usuario.
- Base de datos conectada a SQL Server Management Studio.

---

## Tecnologías utilizadas

- ASP.NET Core 8.0
- Entity Framework Core
- Microsoft SQL Server (SSMS)
- Bootstrap 5
- C#
- Razor Pages & MVC
  
---

## Estructura del proyecto (MVC)

- **Models**: Definición de clases como `Empleada.cs` (modelo de datos).
- **Views**: Páginas .cshtml para mostrar formularios, tablas y resultados.
- **Controllers**: Lógica del servidor (como `EmpleadasController.cs`) para manejar rutas y acciones.
- **Data**: Configuración del `AppDbContext`, que extiende `IdentityDbContext` para incluir autenticación.

---

## Autenticación y seguridad

El sistema usa **ASP.NET Core Identity** para:

- Registrar nuevos usuarios.
- Iniciar y cerrar sesión.
- Controlar acceso mediante `[Authorize]`.
- Proteger las vistas CRUD (solo accesibles si el usuario está autenticado).
- Mostrar el nombre del usuario y opción de cerrar sesión en la barra de navegación.

---

## Instrucciones para ejecutar

1. Clona este repositorio:

   ```bash
   git clone https://github.com/mariabarrezueta/WebCRUD.git


2. Restaura paquetes e instala herramientas necesarias:
- dotnet restore
- dotnet tool install --global dotnet-ef
- dotnet add package Microsoft.EntityFrameworkCore.Sqlite
- dotnet add package Microsoft.EntityFrameworkCore.Design

3. Crear la base de datos
- dotnet ef migrations add InitialCreate
- dotnet ef database update

4. Ejecuta la aplicacion 
dotnet run

5. Abre el navegador en la URL:
- https://localhost:XXXX/Empleadas

---

## Autora 
Maria Barrezueta Arrieta



## TRABAJO DE DEPLOY 
Mi proyecto implementa funcionalidades de registro e inicio de sesión mediante Identity, así como operaciones CRUD conectadas a una base de datos SQL en la nube de Azure. El objetivo del proyecto es permitir la gestión de registros de empleados, incluyendo autenticación segura y almacenamiento persistente. La aplicación ha sido desplegada en Azure App Service y utiliza GitHub Actions para automatizar el proceso de integración y despliegue continuo. Este trabajo lo realice con credenciales estudiantiles en Azure.

-- Links útiles 

Documentación oficial ASP.NET Core MVC:
https://learn.microsoft.com/es-es/aspnet/core/mvc/overview

Documentación oficial de ASP.NET Identity:
https://learn.microsoft.com/es-es/aspnet/core/security/authentication/identity

Publicación de apps ASP.NET en Azure App Service:
https://learn.microsoft.com/es-es/azure/app-service/quickstart-dotnetcore?tabs=net60&pivots=development-environment-vscode

https://www.youtube.com/watch?v=IfOQjfLR3pc



-- Video explicativo de la deployacion 
https://youtu.be/j-C9lKJBT54

-- Link de deployacion 
webcrud-mvc-cyffhggta0fqdzb6.brazilsouth-01.azurewebsites.net

-- Enlace del proyecto
https://github.com/mariabarrezueta/WebCRUD.git



