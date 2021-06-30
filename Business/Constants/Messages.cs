using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    class Messages
    {
        internal static string ModelNameInvalid = "Araç model ismi 2 karakterden uzun olmalıdır.";
        internal static string CarAdded = "Araç başarıyla sisteme eklendi.";
        internal static string CarDeleted = "Araç başarıyla sistemden silindi.";
        internal static string CarsListed ="Araçlar başarı ile listelendi.";
        internal static string CarUpdated = "Araç bilgileri başarıyla güncellendi.";
        internal static string MaintenanceTime = "Şuan bakımdayız. Daha sonra tekrar deneyiniz.";
    }
}
