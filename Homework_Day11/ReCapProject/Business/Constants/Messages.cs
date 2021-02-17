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
        public static string CustomersListed;
        public static string CustomerDeleted;
        public static string CustomerUpdated;
        public static string CustomerIdListed;
        public static string CustomerAdded;
        public static string UserAdded;
        public static string BrandNameInvalid;
        public static string BrandsListed;
        public static string BrandIdListed;
        public static string UserDeleted;
        public static string UserUpdated;
        public static string UserListed;
        public static string UserIdListed;
        public static string BrandAdded;
        public static string BrandDeleted;
        public static string BrandUpdated;
        internal static string ColorAdded;
        internal static string ColorDeleted;
        internal static string ColorUpdated;
        internal static string ColorsListed;
        internal static string ColorIdListed;
        internal static string RentalListed;
        internal static string RentalUpdate;
    }
}
