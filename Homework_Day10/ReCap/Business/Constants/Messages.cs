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
    }
}
