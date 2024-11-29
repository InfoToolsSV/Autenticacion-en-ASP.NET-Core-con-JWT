# Autenticación en ASP.NET Core con JWT

Este proyecto demuestra cómo implementar un sistema de autenticación en ASP.NET Core utilizando JWT (JSON Web Tokens). Incluye registro, inicio de sesión y cierre de sesión, con validación de usuarios mediante tokens seguros.

## Características

- Registro de usuarios con Entity Framework Core y base de datos en memoria.
- Inicio de sesión con generación de tokens JWT.
- Almacenamiento de tokens en cookies seguras para mayor protección.
- Validación de rutas protegidas utilizando middleware de autenticación.
- Ejemplo práctico y adaptado para ser escalable en producción.

## Tecnologías utilizadas

- ASP.NET Core 6+
- Entity Framework Core
- JWT (JSON Web Tokens)
- C#

## Configuración

### Clave JWT

El archivo `appsettings.json` contiene la configuración para los JWT. Asegúrate de que la clave (`Key`) sea segura y tenga al menos 32 caracteres.

```json
"Jwt": {
  "Key": "ClaveSecretaMuySeguraYExtensa1234567890",
  "Issuer": "MiAplicacion",
  "Audience": "MisUsuarios",
  "SecureCookies": true
}
```

### Instalación

1. Clona este repositorio:  
   ```bash
   git clone https://github.com/InfoToolsSV/Autenticacion-en-ASP.NET-Core-con-JWT.git
   ```
2. Navega al directorio del proyecto:  
   ```bash
   cd AuthJWT
   ```
3. Restaura los paquetes necesarios:  
   ```bash
   dotnet restore
   ```
4. Ejecuta la aplicación:  
   ```bash
   dotnet run
   ```

## Uso

1. Registra un usuario utilizando el formulario de registro.  
2. Inicia sesión para recibir un token JWT almacenado en cookies seguras.  
3. Accede a rutas protegidas mientras el token sea válido.  
4. Cierra sesión para eliminar el token.

## Capturas de pantalla

*(Incluye capturas de pantalla de tu aplicación aquí para mayor claridad).*

## Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo `LICENSE` para más información.

## Agradecimientos

- [Documentación oficial de ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core)
- [Herramienta para generación de claves seguras](https://passwordsgenerator.net/)
