# PolytechEventWebApi
## Описание

Проект WebApi для сайта с event-мэнеджера

## Технологии

- **[.NET 8 и SDK 8](https://dotnet.microsoft.com/ru-ru/)**
- **[CPM (Central Package Management)](https://learn.microsoft.com/en-us/nuget/consume-packages/central-package-management)**
- **[EF Core 8](https://learn.microsoft.com/ru-ru/ef/core/what-is-new/ef-core-8.0/whatsnew)**
- **[ASP .NET Web API](https://learn.microsoft.com/ru-ru/aspnet/core/tutorials/first-web-api?view=aspnetcore-8.0&tabs=visual-studio)**
- **[Automapper](https://automapper.org)**
- **[FluentValidation](https://docs.fluentvalidation.net/en/latest/)**
- **[FluentAssertions](https://fluentassertions.com)**
- **[Swagger](https://swagger.io/)**
- **[Dependency Injection](https://learn.microsoft.com/ru-ru/dotnet/api/microsoft.extensions.dependencyinjection.servicecollection?view=net-8.0)** (ServiceCollection)
- **[Redis](https://redis.io)**



## Архитектура проекта
- [Луковичная архитектура (Onion Architecture)](https://code-maze.com/onion-architecture-in-aspnetcore/).
- Чистая архитектура (Clean architecture)
- Domain-driven design
- Разделение на проекты по слоям: хранилище, бизнес-логика, Web API, тесты

## Описание контроллеров

### Контроллеры ASP .NET Web API

В разработке


## Установка и запуск

1. **Клонирование репозитория:**

        git clone <URL репозитория>
        cd <название папки проекта>

2. **Установка зависимостей:**

        dotnet restore

3. **Запуск локального redis-сервера:**

        redis-server --daemonize yes
        redis-cli
        info
		 
4. **Запуск консольного приложения:**

        dotnet run --project <путь к консольному приложению>

5. **Запуск Web API:**

        dotnet run --project <путь к Web API>

## Запуск тестов

Для запуска тестов используйте команду:

    dotnet test

## Добавление/обновление схемы базы данных с помощью миграций

Для добавления новой миграции выполните следующие шаги:

1. Создайте миграцию:

        dotnet-ef migrations add {MigrationName} --project {MigrationProject} --startup-project ./Web.Host

2. Примените миграцию к базе данных:

        dotnet-ef database update {MigrationName} --project {MigrationProject} --startup-project ./Web.Host

