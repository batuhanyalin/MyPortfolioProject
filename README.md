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
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/404notFound.png?raw=true)
### 404 Parola Sıfırlama
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/forgetPassword.png?raw=true)


### Yönetim Paneli
#### Anasayfa
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_default.png?raw=true)
#### Projeler
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_project.png?raw=true)
#### Özgeçmiş
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_resume.png?raw=true)
#### Beceriler
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_skill.png?raw=true)
#### Kullanılan Teknolojiler
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_service.png?raw=true)
#### Sosyal Medya
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_socialMedia.png?raw=true)
#### Hakkımda
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_about.png?raw=true)
#### Mesajlar
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_contactMessage.png?raw=true)
#### İletişim Bilgileri
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/admin_contactInfo.png?raw=true)

### Ana Ekran
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_home.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_about.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_resume.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_service.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_skill.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_project.png?raw=true)
####
![](https://github.com/batuhanyalin/MyPortfolioProject/blob/master/MyPortfolioProjectUI/wwwroot/images/projectScreenshots/ui_contact.png?raw=true)