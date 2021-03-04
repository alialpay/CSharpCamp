using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    //static verilen class'ın newlenmesine gerek olmaz
    public static class Messages
    {
        // publicler büyük harf ile yazılır
        // private olsaydı carAdded şeklinde yazar idik.
        public static string CarAdded = "Araba eklendi.";
        public static string CarDailyPriceInvalid = "Geçersiz günlük ücret";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";
        public static string CarUpdated = "Araba güncellendi";
        public static string RentalAddedError = "Araba eklenemedi";
        public static string RentalAdded = "Araba eklendi";
        public static string RentalDeleted = "Kayıt silindi";
        public static string CustomersListed = "Müşteriler Listelendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri bilgileri güncellendi";
        public static string CustomerIdListed = "Müşteri id'leri listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string UserAdded= "Kullanıcı eklendi";
        public static string BrandNameInvalid = "Geçersiz marka ismi";
        public static string BrandsListed = "Markalar listelendi";
        public static string BrandIdListed = "Marka id'leri listelendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı bilgileri güncellendi";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UserIdListed = "Kullanıcı id'si listelendi";
        public static string BrandAdded = "Marka bilgisi eklendi";
        public static string BrandDeleted = "Geçerli marka sistemden silindi";
        public static string BrandUpdated = "Marka bilgileri güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk bilgisi silindi";
        public static string ColorUpdated = "Renk bilgileri güncellendi";
        public static string ColorsListed = "Renkler listelendi";
        public static string ColorIdListed = "Renk id'leri listelendi";
        public static string RentalListed = "Kiralama işlemi listelendi";
        public static string RentalUpdate = "Kiralama bilgisi güncellendi";
        public static string CarDescriptionIsNull = "Araba açıklaması boş";
        public static string ModelYearInvalid = "Sistemde en fazla 5 yaşlı araba bulunabilir";
        public static string CarCountOfColorError = "Sistemde aynı renkte en fazla 5 araba bulunabilir";
        public static string BrandAlreadyExists = "Aynı markadan zaten bir araba var";
        public static string CarImageLimitExceeded = "Fotoğraf yükleme sınırı aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string OperationClaimsListed = "Operasyonlar listelendi";
        internal static string UserRegistered = "Kayıt oldu";
        internal static string UserNotFound = "Kullanıcı bulunamadı";
        internal static string PasswordError = "Parola hatası";
        internal static string UserAlreadyExists = "Kullanıcı zaten var";
        internal static string AccessTokenCreated = "Token oluşturuldu";
        internal static string SuccessfulLogin = "Başarılı giriş";
    }
}
