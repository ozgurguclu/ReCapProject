﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarNotFound = "Araba bulunamadı";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarNameAlreadyExists = "Aynı isimde zaten başka bir araba var";
        public static string CarDailyPriceInvalid = "Arabanın günlük fiyatı 0'dan büyük olmalıdır";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarsListed = "Arabalar listelendi";
        public static string CarDescriptionLengthError = "Açıklama en az 25 karakter uzunluğunda olmalıdır";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorsList = "Renkler listesi";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi en az 2 harfden oluşmalıdır";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string BrandsListed = "Markalar listelendi";

        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UsersListed = "Kullanıcılar listelendi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string CustomerNotFound = "Müşteri bulunamadı";
        public static string CustomerAlreadyExists = "Müşteri zaten mevcut";

        public static string RentalAdded = "Kira eklendi";
        public static string RentalDeleted = "Kira silindi";
        public static string RentalUpdated = "Kira güncellendi";
        public static string RentalsListed = "Kiralar listelendi";
        public static string RentalUndeliveredCar = "Araç henüz teslim edilmedi";

        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string FailedLogin = "Başarısız giriş";
        
        public static string MaintenanceTime = "Sistem bakımda";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string AccessTokenCreated = "Token oluşturuldu";

        public static string CarImageAdded = "Resim başarıyla eklendi";
        public static string CarImageDeleted = "Resim başarıyla silindi";
        public static string CarImageUpdated = "Resim başarıyla güncellendi";
        public static string AddingCarImageIsLimited = "Daha fazla resim ekleyemezsiniz";

        public static string PaymentsListed = "Ödemeler listelendi";
    }
}
