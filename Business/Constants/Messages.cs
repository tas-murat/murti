using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün başarıyla eklendi";
        public static string ProductRemoved = "Ürün başarıyla silindi";
        public static string ProductUpdated = "Ürün başarıyla güncellendi";

        public static string UserNotFound = "Kullanıcı Bulunamadı";

        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin="Sisteme giriş başarılı";

        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarılı bir şekilde kayıt edildi";
        public static string AccessTokenCreated = "Access Token başarıyla oluşturuldu";

        public static string AuthorizationDenied = "Yekiniz yok";
        public static string ProductNameAlreadyExsists="Ürün ismi zaten mevcut";
    }
}
