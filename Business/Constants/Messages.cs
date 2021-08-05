using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public class Messages
    {
        public static string ModelNameInvalid = "Araç model ismi 2 karakterden uzun olmalıdır.";
        public static string CarAdded = "Araç başarıyla sisteme eklendi.";
        public static string CarDeleted = "Araç başarıyla sistemden silindi.";
        public static string CarsListed = "Araçlar başarıyla listelendi.";
        public static string CarUpdated = "Araç bilgileri başarıyla güncellendi.";
        public static string MaintenanceTime = "Şuan bakımdayız. Daha sonra tekrar deneyiniz.";
        public static string ColorAdded = "Renk başarıyla sisteme eklendi.";
        public static string ColorDeleted = "Renk başarıyla sistemden silindi.";
        public static string ColorUpdated = "Renk bilgileri başarıyla güncellendi.";
        public static string ColorsListed = "Renkler başarıyla listelendi.";
        public static string BrandAdded = "Marka başarıyla sisteme eklendi.";
        public static string BrandDeleted = "Marka başarıyla sistemden silindi.";
        public static string BrandUpdated = "Marka bigileri başarıyla güncellendi.";
        public static string BrandsListed = "Markalar başarıyla listelendi.";
        public static string UserAdded = "Kullanıcı başarıyla sisteme eklendi.";
        public static string UserDeleted = "Kullanıcı başarıyla sistemden silindi.";
        public static string UsersListed = "Kullanıcı başarıyla listelendi.";
        public static string UserUpdated = "Kullanıcı bilgileri başarıyla güncellendi.";
        public static string RentalAdded = "Kiralama işlemi başarıyla gerçekleşti.";
        public static string RentalDeleted = "Kiralama işlemi başarıyla silindi.";
        public static string RentalUpdated = "Kiralama işlemi başarıyla güncellendi.";
        public static string RentalsListed = "Kiralamalar başarıyla listelendi.";
        public static string RentalError = "Bu araç şuan kirada.";
        public static string BrandNameAlreadyExist = "Bu marka daha önce sisteme eklenmiş.";
        public static string CarImageAdded = "Araç fotoğrafı başarıyla sisteme eklendi.";
        public static string CarImageLimitExceeded = "Sadece 5 adet fotoğraf yüklenebilir.";
        public static string CarImageDeleted = "Araç fotoğrafı başarıyla silindi.";
        public static string CarImageNotFound = "Silinmek istenen fotoğraf bulunamadı.";
        public static string CarImageListed = "Tüm araç fotoğrafları listelendi.";
        public static string CarImageUpdated = "Araç fotoğrafı başarıyla güncellendi.";
    }
}