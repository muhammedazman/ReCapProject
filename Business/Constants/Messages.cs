using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // Success
        public static string CarListed = "Arabalar listelendi";
        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        
        // Error
        public static string CarInvalidDailyPrice = "Daily Price have to 0 than bigger";

        // Users Success
        public static string UserListed = "Kullanicilar listelendi";
        public static string UserAdded = "Kullanici eklendi";
        public static string UserDeleted = "Kullanici silindi";
        public static string UserUpdated = "Kullanici güncellendi";

        // Customers Success
        public static string CustomerListed = "Müsteriler listelendi";
        public static string CustomerAdded = "Müsteri eklendi";
        public static string CustomerDeleted = "Müsteri silindi";
        public static string CustomerUpdated = "Müsteri güncellendi";

        // Rentals Success
        public static string RentalListed = "Kiralama listelendi";
        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalUpdated = "Kiralama güncellendi";
    }
}
