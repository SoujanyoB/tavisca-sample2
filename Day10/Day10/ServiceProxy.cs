using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    public class ServiceProxy : IDisposable
    {
        private readonly HttpClient httpClient; // calling a API -- UnManaged Object
        private bool disposed;

        public ServiceProxy(string httpClientFactory)
        {
            httpClient = new HttpClient();
        }
        ~ServiceProxy()
        {
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {

            if (disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed objects
                httpClient.Dispose();
            }
            // Dispose unmanaged objects
            disposed = true;
        }
        public void Get()
        {
            Console.WriteLine("A Get is being invocked on an API");
        }
        public void Post(string request)
        {
            Console.WriteLine("A Post is being invocked on an API");
        }
    }
}
