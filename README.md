# Мануал по запуску проекта с использованием Docker Compose

## Запуск Docker Compose

Следуйте этим шагам, чтобы запустить приложение с помощью Docker Compose:

1. **Откройте PowerShell или терминал в Visual Studio**:
   - Убедитесь, что Вы находитесь в папке проекта, где расположен файл `docker-compose.yml`.

2. **Запустите приложение Docker Desktop**:
   - Убедитесь, что Docker Desktop запущен и работает на Вашем компьютере.

3. **Запустите контейнеры**:
   - Введите следующую команду в терминале:
     ```bash
     docker compose up -d
     ```
   - Эта команда создаст и запустит все контейнеры, указанные в файле `docker-compose.yml`, в фоновом режиме.

4. **Проверьте запущенные контейнеры**:
   - Вы можете проверить, запущены ли контейнеры, используя одну из следующих опций:
     - Откройте приложение Docker Desktop и посмотрите на список запущенных контейнеров.
     - Или выполните команду в терминале:
       ```bash
       docker ps
       ```
     - Если Вам нужно остановить контейнеры, используйте команду:
       ```bash
       docker compose down
     ```
# Мануал по проведению миграции в базе данных

## Проведение миграции в БД

Следуйте этим шагам, чтобы создать миграцию и обновить базу данных:

1. **Создание папки миграции**:
   - Откройте PowerShell или терминал в Visual Studio. Убедитесь, что Вы находитесь в папке проекта, где расположен файл `docker-compose.yml`.
   - Выполните следующую команду для создания миграции:
     ```bash
     dotnet ef migrations add initial -s AuthService.Api -p AuthService.DataAccess
     ```
   - Эта команда создаст новую миграцию с именем `initial` в проекте `AuthService.DataAccess`.

3. **Запуск создания схем в БД и заполнение данных**:
   - После успешного создания миграции выполните следующую команду для обновления базы данных:
     ```bash
     dotnet ef database update -s AuthService.Api -p AuthService.DataAccess
     ```
   - Эта команда применит все миграции к базе данных, создаст необходимые схемы и заполнит их начальными данными, если они указаны в миграциях.
# Запуск pgAdmin

Следуйте этим шагам, чтобы запустить pgAdmin и подключиться к Вашей базе данных:

1. **Открытие pgAdmin**:
   - Перейдите по следующему адресу в Вашем браузере: [http://localhost:5050](http://localhost:5050).
   - Введите логин и пароль:
     - **Email**: miiradiiaz@gmail.com
     - **Пароль**: DiazMD9119

2. **Регистрация сервера**:
   - После входа в pgAdmin выполните следующие шаги для регистрации нового сервера:
     1. Нажмите на кнопку **"Add New Server"** (Добавить новый сервер).
     2. Введите следующие данные:
        - **Host name/address**: postgresauth
        - **Port**: 5432
        - **Maintenance database**: authServiceDb
        - **Username**: postgres
        - **Password**: 8n5nb7mf
     3. Нажмите **"Save"** (Сохранить) для завершения регистрации сервера.

## Примечания

- Убедитесь, что у Вас установлены все необходимые зависимости и конфигурации перед запуском.
- Если возникнут ошибки, проверьте логи контейнеров с помощью команды:
  ```bash
  docker logs <container_name>

