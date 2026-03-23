# Proyecto Clase 5 - Autenticación y Autorización

## Información Académica
* **Institución:** Universidad Privada Domingo Savio (UPDS)
* **Carrera:** Ingeniería de Sistemas
* **Materia:** Programación Web 2

## Descripción del Proyecto
Implementación de un sistema de autenticación y autorización utilizando una API REST, base de datos relacional y gestión de identidad mediante contenedores. El proyecto establece la arquitectura backend segura y prepara el entorno para el consumo desde una aplicación frontend moderna.

## Tecnologías Utilizadas
* **Backend:** .NET 9, Entity Framework Core
* **Base de Datos:** PostgreSQL
* **Autenticación:** Keycloak (OAuth 2.0 / OpenID Connect)
* **Contenedores:** Docker, Docker Compose

## Requisitos Previos
* Docker y Docker Compose
* .NET 9.0 SDK

## Instrucciones de Configuración y Ejecución

### 1. Despliegue de Servicios Docker
Ubicarse en el directorio que contiene el archivo de orquestación y levantar los contenedores en segundo plano.

`docker-compose up -d`

### 2. Sincronización de Base de Datos
Navegar al directorio principal de la API (`pw2_clase5`) y aplicar las migraciones correspondientes a Entity Framework.

`dotnet ef database update`

### 3. Ejecución del Servidor Backend
Dentro del mismo directorio de la API, inicializar el entorno de desarrollo. La base de datos se poblará automáticamente mediante el proceso de inicialización de datos.

`dotnet run`

### 4. Verificación de Seguridad
Utilizar una herramienta cliente HTTP para solicitar el token de acceso al servidor de Keycloak mediante el flujo de código de autorización y verificar el acceso a los recursos protegidos según los roles asignados a cada usuario.
