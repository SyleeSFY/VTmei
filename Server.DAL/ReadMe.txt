1. Для миграций использовать:
Server.DAL % dotnet ef migrations add InitialCreate --startup-project ../Server.Api
Server.DAL % dotnet ef database update --startup-project ../Server.Api
т.к. сейчас мы храним одно подключение к бд в Server.Api
 то обращаемся так(по хорошему api не должен знать про существование dal)
 todo: вынести appsetings в общий файл