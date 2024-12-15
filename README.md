# 💻 Asp.Net Core 8.0 N-Tier Architecture - Repository DesignPattern ile MyPortfolio Projesi
📢 Bir yazılımcının kendisine ait dinamik tabanlı bir portfolyo sitesi olmasını düşündüğüm için .Net 8.0 ile N-Tier Architecture Repository Design Pattern ile kendi portfolyo CV uygulamamı geliştirdim. Aldığım eğitim ve yaptığım projelerimi pekiştirmemde ve hızlı bir kod yapısını oluşturabildiğimi anlamama fayda sağladı. Projeyi yaklaşık 2 gün içinde tamamladım ve https://batuhanyalincv.com.tr websitemde canlıya taşıdım.

## 🪶 Projenin Amacı;
Proje yazılım ve iş hayatı yolculuğumda yaptığım projelerimi, iş hayatımı, becerilerimi, kendim ile ilgili bilgilerimi sunduğum, güncel olarak CV' min görüntülenebilir ve indirilebilir halde olduğu, bununla birlikte iletişim formundan iletişim imkânı da olan bir bir uygulamadır. Bütün bunların arka planda yönetim paneli de mevcuttur ve bu bilgilerin tamamı dinamik şekilde yönetim ekranından yönetilmektedir. Şifre sıfırlama sistemi de olan projemde Admin paneli projeden Areayla ayrılmış durumdadır.

## 🛠️ Kullanılan Bazı Teknolojiler
* 🏗️ N-tier Architecture mimarisiyle Repository Design Patterns üzerine kuruldu.
* 🗄️ DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
* ⚡ Entity Framework 8.0 Veritabanı etkileşimi ve ORM için kullanıldı.
* 🔐 Üyelik sistemi Identity ile kontrol edilip rol bazlı yetkilendirme sağlanmıştır.
* 📧 MimeKit kütüphanesiyle e-posta adresine mail göndererek parola sıfırlama işlemi yapılabilmektedir.
* 🏢 Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır.
* 🧩 Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
* 📦 DTO katmanıyla veri yönetimi kolaylaştırıldı.
* 💻 HTML-CSS Bootstrap ile arayüzler tasarlandı.
* ✅ Fluent Validation - kontrol sistemi kullanılarak verilerin belli kurallara göre alınması sağlandı.
* 🗂️ Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
* 🔄 Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.

# Veritabanı
![Veritabanı](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/database.png?raw=true)
### Giriş
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/login.png?raw=true)
### 404 NotFound
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/forbidden.png?raw=true)

### Yönetim Paneli
#### Dashboard
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_dashboard.png?raw=true)
#### İstatistikler
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_statistic.png?raw=true)
#### Araçlar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_carList.png?raw=true)
#### Bloglar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_blogList.png?raw=true)
#### Araç Özellikleri
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_featureList.png?raw=true)
#### Araç Özellik Eşleme
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_featureSelect.png?raw=true)
#### Etiketler
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_tagList.png?raw=true)
#### Lokasyonlar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_locationList.png?raw=true)
#### Blog Yorumları
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_commentListBlog.png?raw=true)
#### Rezervasyonlar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_reservation.png?raw=true)
###### Rezervasyon Güncelle
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_updateReservation.png?raw=true)
#### İletişim Mesajları
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_contact.png?raw=true)

#### Ana Ekran
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_banner.png?raw=true)
######
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_about-offerCar.png?raw=true)
######
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_service.png?raw=true)
######
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_testimonial.png?raw=true)
######
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_footer.png?raw=true)
#### Bloglar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_blogList.png?raw=true)
##### Blog Detayları
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_blogDetail.png?raw=true)
##### Blog Yorumları
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_comment.png?raw=true)
#### Araçlar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_cars.png?raw=true)
##### Araç Fiyatları
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_carPrice.png?raw=true)
##### Araç Kiralama
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_rentacar.png?raw=true)
##### Araç Filtreleme
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_carFilter.png?raw=true)
#### İletişim Sayfası
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_contact.png?raw=true)
