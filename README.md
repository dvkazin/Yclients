![Logo](https://www.yclients.com/assets/yclients/2019-template/img/logo.svg)

# API клиент для сервиса онлайн-бронирования YCLIENTS.

## Быстрый сарт

```
using Yclients.Endpoint;

var auth = Authorization.AuthenticationUser("login", "password", "partnerToken");
var userToken = auth.Data.UserToken;
var companyId = 123456; // ID компании можно посмотреть в личном кабинете.

var recordEndpoint = new Record("partnerToken", userToken, companyId);
var records = recordEndpoint.Get();

foreach (var record in records.Data)
{
	Console.WriteLine(record.Client.Name);
}

```

## Что доступно в текущей версии:

| ENDPOINT                                 | CLASS              | GET METHOD               | ADD METHOD | UPDATE METHOD | 
|:----------------------------------------:|:------------------:|:------------------------:|:----------:|:-------------:|
| Авторизовать пользователя                | Authorization      | AuthenticationUser       |            |               |
| Авторизовать пользователя онлайн-записи  | Authorization      | AuthorizationUserBooking |            |               |
| Категория услуг                          | ServiceCategory    | Get                      |            |               |
| Компании                                 | Company            | Get                      |            |               |
| Записи                                   | Record             | Get                      |            |               |
| Сотрудники                               | Staff              | Get                      |            |               |
| Визиты                                   | Visit              | Get                      |            |               |
| Услуги                                   | Service            | Get                      |            |               |