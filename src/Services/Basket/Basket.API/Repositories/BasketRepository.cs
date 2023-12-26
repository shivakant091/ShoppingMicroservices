using Basket.API.Entities;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Basket.API.Repositories
{
    public class BasketRepository : IBasketRepository
    {
        private readonly IDistributedCache _redisCache;

        public BasketRepository(IDistributedCache redisCatch)
        {
            _redisCache = redisCatch ?? throw new ArgumentNullException(nameof(redisCatch));
        }
        public async Task<ShoppingCart> GetBasket(string useName)
        {
            var basket = await _redisCache.GetStringAsync(useName);
            if(String.IsNullOrEmpty(basket))
            {
                return null;
            }
            
            return JsonConvert.DeserializeObject<ShoppingCart>(basket);
        }
        public async Task<ShoppingCart> UpdateBasket(ShoppingCart basket)
        {
            await _redisCache.SetStringAsync(basket.UserName,JsonConvert.SerializeObject(basket));
            return await GetBasket(basket.UserName);
        }
        public async Task DeleteBasket(string userName)
        {
            await _redisCache.RemoveAsync(userName);
        }

        

        
    }
}
