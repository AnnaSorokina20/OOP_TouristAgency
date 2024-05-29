# Курсова робота
На тему: «Розроблення програмного забезпечення з використанням об’єктно-орієнтованої парадигми»

Предметна область: Тур-агенство

## ВСТУП
У сучасному світі подорожі та організація відпочинку стали значно доступнішими завдяки зростанню кількості туристичних агентств і цифрових платформ для бронювання турів. Туристичні агентства допомагають споживачам знайти найкращі пропозиції, організувати поїздки та забезпечують високий рівень сервісу. Це робить тему автоматизації туристичних агентств надзвичайно актуальною, оскільки вона дозволяє значно спростити процеси бронювання та управління турами.
Потенційні користувачі системи автоматизації туристичних агентств охоплюють широкий спектр осіб та організацій. До них можна віднести індивідуальних мандрівників, які бажають швидко і зручно знайти та забронювати тур; туристичні агентства, що прагнуть оптимізувати свою роботу та зменшити витрати на обслуговування клієнтів; корпоративних клієнтів, які організовують поїздки для своїх працівників; а також організаторів групових турів та екскурсій.
Лідери серед програмних аналогів у сфері туристичних послуг включають такі популярні платформи, як Booking.com[4], TripAdvisor[6], Expedia[7]. Ці сервіси пропонують зручні інтерфейси для вибору, бронювання та управління турами, що є важливими аспектами для будь-якого програмного рішення в цій галузі.

Стек технологій для реалізації проекту включає використання:
- C# як основна мова програмування, що забезпечує логіку бізнес-процесів та взаємодію з даними.
-	Windows Forms для створення графічного користувацького інтерфейсу, який дозволяє зручно управляти процесом бронювання турів.
-	PostgreSQL як система управління базами даних для зберігання інформації про користувачів, тури та бронювання, забезпечуючи надійне та масштабоване управління даними.
-	Entity Framework для об'єктно-реляційного відображення (ORM), що спрощує взаємодію з базою даних та підвищує продуктивність розробки.
-	.NET Framework як платформа для розробки та виконання програм, забезпечуючи потрібні бібліотеки та API для взаємодії з операційною системою та іншими програмами.
-	Visual Studio як інтегроване середовище розробки, що забезпечує всі необхідні інструменти для кодування, тестування та розгортання вашої програми.
  
Цей стек технологій забезпечує потужну базу для створення надійних та ефективних десктопних додатків для Windows, здатних обробляти різноманітні задачі управління туристичними послугами.
Також були використані джерела щодо правил оформлення роботи документів [1], [2].


## ФУНКЦІОНАЛЬНІ ВИМОГИ ДО ПРОГРАМНОГО ЗАБЕЗПЕЧЕННЯ
### Аналіз функціональності програмних аналогів

Було розглянуто такі сервіси: JoinUp  та Booking.com 

Вигляд сервісу JoinUp:
![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/e1b2ae24-6765-40a3-bafc-e0806e53135e)

Вигляд сервісу Booking.com:

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/eb500821-46f7-489f-9cc8-cb66c1000cfa)

### Побудова Mind Map для заданої предметної області за резултатами аналізу аналогів

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/23dbeb85-dfa5-4358-a352-f4d9453af281)

### Виділення ролей користувачів і формулювання функціональних вимог

Були виділені три ролі користувачів: «Адміністратор», «Зареєстрований користувач», «Гість».

Опишемо функціональні вимоги кожного типу користувачів.

Адміністратор:

- може авторизуватися.
- може додати тур.
- оновлювати інформацію про тури.
- може передивлятися заброньовані тури.

Зареєстрований користувач:

- може авторизуватися.
- може шукати тури за місцем призначення та вартістю.
- може бронювати тури.
- може відміняти бронь туру.
- може передивлятися заброньовані тури.
  
Гість:

- може зареєструватися, вказавши електронну пошту, ім’я, прізвище, номер телефону і пароль.

## МОДЕЛЮВАННЯ ПРЕДМЕТНОЇ ОБЛАСТІ

Встановлення зв’язків між класами

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/33bb4680-3e68-4f68-94e4-5cc1def1cd21)

## ПРОГРАМНА РЕАЛІЗАЦІЯ КЛАСІВ ПРЕДМЕТНОЇ ОБЛАСТІ І ЇХ ТЕСТУВАННЯ

Структура проєкту з реалізацією класів предметної області

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/21ca778a-bad2-44a8-a70e-bcba6612e4fe)

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/850a9709-af6d-4f32-9a03-59b78915d773)



Результати unit-тестування класів предметної області

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/1c425114-503c-4371-8ea0-db0f88734504)

## ПРОЄКТУВАННЯ І ПРОГРАМНА РЕАЛІЗАЦІЯ КЛАСІВ ІНТЕРФЕЙСУ КОРИСТУВАЧА

Структура проєкту з реалізацією класів інтерфейсу користувача

![image](https://github.com/AnnaSorokina20/OOP_TouristAgency/assets/149331565/98d49be6-d77d-4dbb-a403-25ff1abc3247)

## ВИСНОВОК

У результаті виконання курсової роботи було розроблено програмне забезпечення з використанням об’єктно-орієнтованої парадигми для автоматизації роботи туристичного агентства.
В ході роботи було:
-	Розроблено функціональні вимоги до програмного забезпечення.
-	Побудована модель предметної області у вигляді діаграми класів.
-	Програмно реалізовано і протестовано класи предметної області, зокрема класи для управління користувачами, турами та бронюваннями.
-	Програмно реалізовано класи інтерфейсу користувача, включаючи форми для реєстрації та авторизації користувачів, перегляду та управління турами, а також бронюваннями.
-	Успішно виконано функціональне тестування програмного забезпечення з використанням юніт-тестів.
-	Оформлена пояснювальна записка.

Розроблене програмне забезпечення відповідає функціональним вимогам та забезпечує зручний і ефективний інтерфейс для користувачів туристичного агентства, дозволяючи їм легко управляти процесом бронювання турів, а також організовувати і переглядати історію бронювань.








