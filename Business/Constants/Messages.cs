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

        // Success
        public static string BrandListed = "Marka getirildi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        // Error
        public static string BrandNameCharacterCount = "Error: Brand Name have to 2 Character than bigger";

        // Error
        public static string CarInvalidDailyPrice = "Daily Price have to 0 than bigger";
        public static string NameLenght2CharactersBigger = "Name length have to 2 characters than bigger";
        public static string InvalidProcess = "The Process is not success";

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

        // Color Success
        public static string ColorListed = "Renk Bilgisi listelendi";
        public static string ColorAdded = "Renk Bilgisi eklendi";
        public static string ColorDeleted = "Renk Bilgisi silindi";
        public static string ColorUpdated = "Renk Bilgisi güncellendi";

        // Controls
        public static string MaintenanceTime = "Sistem Bakimda!!"; 
    }
}
