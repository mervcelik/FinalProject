using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductUpdated = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım zamanı";
        public static string ProductsListed = "Ürünler Listelendi";

        public static string ProductCountOfCategoryError = "Bir kategoride 10'dan fazla ürün olamaz.";
        public static string ProductNameAlreadyExists="Bu isim zaten kullanıldı.";
        public  static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public  static string AuthorizationDenied="Yetkiniz Yok";
        public static string UserRegistered = "Kullanıcı Kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
