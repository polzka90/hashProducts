using Discount;
using Grpc.Net.Client;
using HashProduct.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Discount.Discount;

namespace HashProduct.Domain.Acls
{
    public class AclDiscount : IAclDiscount
    {
        private string _baseUrl;
        private int _port;
        public AclDiscount(string baseUrl, int port)
        {
            _baseUrl = baseUrl;
            _port = port;
        }
        public async Task<float> GetDiscountByProductAsync(string productId, string userId)
        {
            float discount = 0;

            try
            {
                using var channel = GrpcChannel.ForAddress(_baseUrl + ":" + _port);
                var client = new DiscountClient(channel);
                DiscountRequest d = new Discount.DiscountRequest { ProductId = productId };

                d.UserId = userId ?? String.Empty;

                var reply = await client.GetDiscountAsync(d);
                discount = reply.Pct;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return discount;
        }
    }
}
