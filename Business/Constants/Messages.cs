using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi.";
        public static string CarDetailsInvalid = "Geçersiz araba bilgileri.";
        public static string CarDeleted = "Araba silindi.";
        public static string CarUpdated = "Araba bilgileri güncellendi.";
        public static string CarsListed = "Arabalar listelendi.";

        public static string BrandAdded = "Marka eklendi.";
        public static string BrandUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandsListed = "Markalar listelendi.";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string RentalAdded = "Kiralama bilgisi eklendi.";
        public static string RentalUpdated = "Kiralama bilgisi güncellendi.";
        public static string RentalDeleted = "Kiralama bilgisi silindi.";
        public static string RentalFailed = "Kiralanmak istenen araç uygun değil.";
        public static string RentalsListed = "Araç kiralama bilgileri listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UsersListed = "Kullanıcılar listelendi.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";

        public static string CarImageUploaded = "Resim yüklendi.";
        public static string PasswordError = "Şifre hatalı.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut.";
        public static string UserRegistered = "Kullanıcı başarıyla kaydedildi.";
        public static string AccessTokenCreated = "Access Token oluşturuldu.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
    }
}
