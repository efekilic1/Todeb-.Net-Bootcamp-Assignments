using System;
namespace Businnes.Configuration.Response
{
    public class CommandResponse
    {
        // Yaptığımız işlemler sonucunda kullanıcaya bir mesaj göstermek istediğimizde
        // bu nesneyi kullanıyoruz.

        public bool Status { get; set; }
        public string Message { get; set; }

    }
}
