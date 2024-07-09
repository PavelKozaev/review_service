# Review service

## О проекте

Микросервис отзывов разработан на ASP.NET Core Web API и интегрируется с основным приложением интернет-магазина для управления отзывами о продуктах и получения рейтинга продуктов.

## Функциональные возможности

- **API для управления отзывами**: CRUD операции для отзывов пользователей о продуктах.
- **API для получения рейтинга продукта**

## Использованные технологии

- ASP.NET Core Web API
- Entity Framework Core 
- MSSQL
- AutoMapper

## Установка и запуск

### Предварительные требования

- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [MSSQL](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Шаги установки

1. Клонируйте репозиторий:

    ```bash
    git clone https://github.com/PavelKozaev/review_service.git
    cd review_service
    ```

2. Настройте строки подключения к базе данных MSSQL в файле конфигурации `appsettings.json`.

3. Примените миграции базы данных:

    ```bash
    dotnet ef database update
    ```

4. Запустите микросервис:

    ```bash
    dotnet run
    ```

## Контрибьютинг

Если вы хотите внести свой вклад в разработку микросервиса, пожалуйста, создайте форк репозитория, создайте новую ветку, внесите свои изменения и отправьте pull request.

## Лицензия

Данный проект не лицензирован.

## Автор

[Pavel Kozaev](https://github.com/PavelKozaev)
