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
