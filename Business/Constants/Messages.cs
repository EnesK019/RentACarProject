using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string MaintenanceTime = "Sistem bakımda";
        public static string IdInvalid = "Girdiğiniz Id dolu ya da geçersiz";
        public static string DateInvalid = "Girilen tarihler geçersizdir.";

        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarIdInvalid = "Araba ismi geçersiz";
        public static string CarListed = "Arabalar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameExist = "Kullandığınız araba ismi daha önce de kullanılmıştır.";

        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";

        public static string ColorAdded = "Renk eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorUpdated = "Renk güncellendi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomerListed = "Müşteriler listelendi";
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserNameInvalid = "Kullanıcı ismi geçersiz";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserUpdated = "Kullanıcı güncellendi";

        public static string RentalAdded = "Kiralama Bilgisi eklendi";
        public static string RentalDateInvalid = "Kiralama tarihi dolu";
        public static string RentalNotAdded = "Kiralama bilgisi oluşturulamadı";
        public static string RentalListed = "Kiralama Bilgileri listelendi";
        public static string RentalDeleted = "Kiralama Bilgisi silindi";
        public static string RentalUpdated = "Kiralama Bilgisi güncellendi";


        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageListed = "Araba resimleri listelendi";
        public static string CarImageDeleted = "Araba resmi silindi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageIdInvalid = "Bu id de araba resmi yoktur";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Parola yanlış";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullancı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
