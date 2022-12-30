using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Message
{
    public static class Message
    {
        public readonly static string ReturnProduct = "Ürünler başarıyla listelendi.";
        public readonly static string ErrorReturnProduct = "Ürünler listelenemedi.";
        public readonly static string ErrorCreateProduct = "Ürün zaten mevcut";
        public readonly static string SuccessCreateProduct = "Ürün başarılı bir şekilde oluşturuldu.";
        public readonly static string ErrorDeleteProduct = "Ürün mevcut değil.";
        public readonly static string SuccessDeleteProduct = "Ürün başarıyla silindi";
        public readonly static string ErrorUpdateProduct = "Ürün mevcut değil.";
        public readonly static string SuccessUpdateProduct = "Ürün başarıyla güncellendi.";
    }
}
