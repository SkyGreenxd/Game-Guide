# Курсовая работа: Приложение «Руководство по играм от miHoYo» на языке C#

## Описание
Данная курсовая работа посвящена разработке приложения на языке C# с использованием **WinForms**, которое служит руководством и справочником для игр компании miHoYo. Приложение включает в себя несколько полезных функций для игроков, направленных на улучшение игрового опыта:

## Функционал
1. **Персонажи**  
   В этом разделе пользователи могут выбрать любого персонажа из игры и получить полную информацию о нем. Включает:
   - Изображение и описание персонажа
   - Элемент персонажа
   - Рекомендованные артефакты и оружие
   - Способности и пассивные таланты
   - «Созвездия»
   - Материалы для максимального повышения уровня персонажа и прокачки талантов

2. **Калькулятор**  
   Этот инструмент позволяет пользователю ввести данные, необходимые для прокачки персонажей, и получить информацию о необходимых ресурсах для повышения уровня.

3. **Ресурсы**  
   Модуль предоставляет информацию о доступных ресурсах в определенные дни. Пользователи могут увидеть, какие ресурсы доступны в выбранный день, чтобы эффективно планировать свои действия в игре.

4. **Создание собственного Тир-Листа**  
   Данный функционал позволяет пользователям создать таблицу с оценками для персонажей, которые они могут распределять по категориям в зависимости от своих предпочтений. В изначальной таблице присутствует 7 строк с оценками: S, A, B, C, D, E, F, где S – это лучший рейтинг, а F – худший. Пользователь может изменить количество и названия строк по своему усмотрению, а также перетаскивать персонажей в различные фрагменты списка.

Проект ориентирован на улучшение пользовательского опыта и предоставление удобного инструмента для помощи в игровом процессе.

## Необходимые зависимости
- **SQL Server** и **SQL Server Management Studio** (SSMS)
- **Visual Studio** или иная IDE с поддержкой .NET Framework

## Установка

1) Для начала, склонируйте репозиторий на локальную машину
2) Настройка базы данных
  - В папке База данных SQL Server находится экспортированный файл базы данных и изображения, используемые для приложения.
  - Импортируйте базу данных в SQL Server, следуя инструкции SQL Server Management Studio.
  - ***Важное уточнение***: в базе данных не хранятся сами фотографии, а только пути к ним. Для корректной работы, убедитесь, что изображения, на которые ссылается база данных, находятся по соответствующему пути на вашем устройстве или сервере.
3) Открыть проект в IDE, поддерживающей .NET Framework

## Технологии
В проекте используются следующие технологии:

- **C#** для разработки приложения,
- **WinForms** для интерфейса приложения,
- **SQL Server** для хранения и управления данными.


Этот проект создан в рамках учебного процесса и не предназначен для коммерческого использования.
