using System;
using System.Text;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly);
            X509Certificate2 certificate = null;
            //manually chose the certificate in the store
            X509Certificate2Collection sel = X509Certificate2UI.SelectFromCollection(store.Certificates, null, null, X509SelectionFlag.SingleSelection);

            if (sel.Count > 0)
            {
                certificate = sel[0];
                //System.Diagnostics.Process.Start("https://rosreestr.eisnot.ru/?auth_code=" + certificate.SerialNumber);
                System.Diagnostics.Process.Start("https://rz.eisnot.ru/?auth_code=" + certificate.SerialNumber);
            }
        }
    }
}
