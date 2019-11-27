using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace SkripsiInventory.Services
{
    public class InventoryDataStore
    {
        HttpClient client;

        public InventoryDataStore()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://www.indosuryalife.co.id");

        }

        bool IsConnected => Connectivity.NetworkAccess == NetworkAccess.Internet;
        public async Task<string> GetItemAsync(string id)
        {
            if (id != null && IsConnected)
            {
                var json = await client.GetStringAsync("");


                return await Task.Run(() => json);
            }

            return null;
        }
    }
}
