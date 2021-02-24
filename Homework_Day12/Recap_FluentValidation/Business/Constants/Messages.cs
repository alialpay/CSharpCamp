using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        internal static string ColorAdded = "Renk eklendi";
        internal static string ColorDeleted = "Renk bilgisi silindi";
        internal static string ColorUpdated = "Renk bilgileri güncellendi";
        internal static string ColorsListed = "Renkler listelendi";
        internal static string ColorIdListed = "Renk id'leri listelendi";
        internal static string RentalListed = "Kiralama işlemi listelendi";
        internal static string RentalUpdate = "Kiralama bilgisi güncellendi";
        internal static string CarDescriptionIsNull = "Araba açıklaması boş";
    }
}
