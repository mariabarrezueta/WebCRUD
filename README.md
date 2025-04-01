# Proyecto CRUD ASP.NET Core MVC

## Descripción

Este proyecto implementa una aplicación web en ASP.NET Core MVC con funcionalidades completas de CRUD (Crear, Leer, Actualizar, Eliminar) para gestionar registros de **empleadas domésticas**. La interfaz está desarrollada con Razor Pages y la persistencia de datos se maneja con SQLite mediante Entity Framework Core.

---

## Tecnologías utilizadas

- ASP.NET Core MVC (.NET 6 o superior)
- Entity Framework Core
- SQLite (base de datos local)
- Razor Pages
- Bootstrap (integrado por defecto)
- Visual Studio Code

---

## Funcionalidades

- Listado de empleadas
- Registro de nuevas empleadas
- Edición de datos existentes
- Eliminación de registros
- Visualización de detalles individuales
- Navegación integrada mediante el menú superior

---

## Instrucciones para ejecutar

1. Abre la terminal y navega al directorio del proyecto:
   ```bash
   cd WebCRUD
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
