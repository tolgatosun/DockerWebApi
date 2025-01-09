Proje Kurulumu ve Çalıştırılması
Bu proje, Docker ve Nginx üzerinde çalışan bir .NET Core Web API uygulamasıdır. Uygulama, birden fazla proje bağımlılığı (örneğin, bir library projesi) içermektedir ve modern konteyner teknolojileri kullanılarak kolaylıkla dağıtılabilir bir altyapı sunmaktadır.

Başlamadan Önce
Docker ve Docker Compose kurulumunun sisteminizde doğru bir şekilde yapılandırıldığından emin olun. Aşağıdaki adımlar, projeyi çalıştırmak ve test etmek için gereken tüm işlemleri içermektedir.

Kurulum Adımları
Proje Dizini:
Command ekranında proje klasörüne gidin:

bash
Kodu kopyala
cd DockerWebApi
Docker Compose ile Projeyi Çalıştırma:
Aşağıdaki komutu çalıştırarak projeyi build edin ve çalıştırın:

bash
Kodu kopyala
docker-compose up --build
API'ye Erişim:
Uygulama çalıştırıldıktan sonra, aşağıdaki URL üzerinden Web API'ye istek atabilirsiniz:

bash
Kodu kopyala
http://localhost:8080/api/Service/users
Örnek Çıktı
Yukarıdaki API'ye yapılan istek sonucunda aşağıdaki gibi bir JSON çıktısı almanız beklenir:

json
Kodu kopyala
[
    {
        "id": 1,
        "name": "John Doe",
        "email": "john.doe@example.com"
    },
    {
        "id": 2,
        "name": "Jane Smith",
        "email": "jane.smith@example.com"
    }
]
Genel Bilgilendirme
Bu proje, Nginx ile bir ters proxy yapılandırması kullanılarak, yüksek performanslı ve ölçeklenebilir bir şekilde konteyner ortamında çalıştırılacak şekilde tasarlanmıştır. Projede kullanılan mimari, hem Web API uygulaması hem de ona bağlı library projesinin uyumlu bir şekilde bir arada çalışmasını sağlamaktadır.

Bu örnek, Docker Compose ile .NET Core Web API projelerinin nasıl hızlıca konteynerize edileceğini ve dağıtılacağını öğrenmek isteyen geliştiriciler için iyi bir başlangıç noktasıdır.
 
![image](https://github.com/user-attachments/assets/44c804a3-a027-4a0d-9d32-c56311d86a94)
