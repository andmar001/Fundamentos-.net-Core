# Comandos comunes de dotnet CLI

- dotnet --version
- dotnet new --list    # Listar plantillas
- dotnet new console   # Crea un nuevo proyecto de consola 
- dotnet run           # Compila y ejecuta el proyecto
- dotnet info          # Ver todas las versiones de los componentes de .NET Core que tenemos instalados

- dotnet new webapi    # Crea un nuevo proyecto webapi

- dotnet build        # Compila el proyecto

- dotnet restore      # Restaura las dependencias del proyecto

- dotnet watch run    # Compila y ejecuta el proyecto, y se queda escuchando cambios. Realtime de la ejecucionm

archivo.exe es el ejecutable del proyecto

- dotnet clean        # Elimina los archivos temporales del proyecto
- dotnet build        # Reconstruye los archivos del proyecto una vez que se limpia

# Modo release
Elimina los archivos que no se necesitan en modo de produccion, creando una version mas liviana del proyecto
- dotnet build --configuration release

# Crear archivo de configuracion global json
- dotnet new globaljson
Podemos forzar la configuracion de las vesiones de los componentes de .NET Core que queremos usar

# instalar paquetes nuget desde la linea de comandos
# https://www.nuget.org/
- dotnet add package Microsoft.EntityFrameworkCore.SqlServer

# instalacion de humanizer
- dotnet add package Humanizer --version 2.14.1

# podemos encontrar los paquetes instalados en el archivo .csproj
- humanizer nos permite trabajar con fechas de una forma mas amigable
convierte una fecha en un texto o algun numero.