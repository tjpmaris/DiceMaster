using Raven.Client.Documents;
using System;
using System.Security.Cryptography.X509Certificates;

namespace DiceMaster.Database
{
    public static class DocumentStoreHolder
    {
        private static readonly Lazy<IDocumentStore> LazyStore =
            new Lazy<IDocumentStore>(() =>
            {
                var store = new DocumentStore
                {
                    Certificate = new X509Certificate2("D:\\Portfolio\\Certificates\\dicemaster.client.basic.certificate\\dicemaster.client.basic.certificate.pfx", "secure"),
                    Urls = new[] { "https://a.dicemaster.ravendb.community:8600" },
                    Database = "DiceMaster"
                };

                return store.Initialize();
            });

        public static IDocumentStore Store =>
            LazyStore.Value;
    }
}
