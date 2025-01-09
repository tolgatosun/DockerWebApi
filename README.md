#Docker Desktop kurulumu tamamlandıktan sonra command ekranından DockerWebApi dizinine gelerek 
docker-compose up --build   #komutu çalıştırarak

http://localhost:8080/api/Service/users   #webapi adresine istek atarak aşağıdaki örnek çıktıyı görmeniz gerekir. 
Basitçe olarak Docker ile nginx üzerinden çalışan bir .net core webapi projesi ve library bağımlığı olan bir proje örneği gerçekleştirdik

[
{
id: 1,
name: "Ahmet Yılmaz",
email: "ahmet@example.com",
age: 30
},
{
id: 2,
name: "Ayşe Demir",
email: "ayse@example.com",
age: 25
},
{
id: 3,
name: "Mehmet Kaya",
email: "mehmet@example.com",
age: 35
}
]
