using System;
using BusinessLayer.Interface;
using Microsoft.EntityFrameworkCore.Storage;
using ModelLayer.Model;
using StackExchange.Redis;
using RepositoryLayer.Interface;
using static RepositoryLayer.Interface.IGreetingRL;
using System.Text.Json;

namespace BusinessLayer.Service
{
    public class GreetingBL : IGreetingBL
    {
        private readonly IGreetingRL _greetingRL;
        private readonly StackExchange.Redis.IDatabase _cache;

        public GreetingBL(IGreetingRL greetingRL, IConnectionMultiplexer redis)
        {
            _greetingRL = greetingRL;
            _cache = redis.GetDatabase();
        }
        public string GetGreeting(string firstName = "", string lastName = "")
        {
            if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
            {
                return $"Hello {firstName} {lastName}";
            }
            else if (!string.IsNullOrEmpty(firstName))
            {
                return $"Hello {firstName}";
            }
            else if (!string.IsNullOrEmpty(lastName))
            {
                return $"Hello {lastName}";
            }
            else
            {
                return "Hello World";
            }
        }

        public GreetingResponseModel SaveGreeting(GreetingModel greetingModel)
        {
            var result = _greetingRL.SaveGreeting(greetingModel);

            GreetingResponseModel response = new GreetingResponseModel();
            response.Id = result.Id;
            response.Greeting = result.Greeting;

            return response;
        }

        public GreetingModel GetGreetingById(int id)
        {
            return _greetingRL.GetGreetingById(id);
        }

        public List<GreetingModel> GetAllGreetings()
        {
            return _greetingRL.GetAllGreetings();
        }

        public GreetingModel EditGreeting(int id, GreetingModel greetingModel)
        {
            return _greetingRL.UpdateGreeting(id, greetingModel);
        }

        public bool DeleteGreeting(int id)
        {
            return _greetingRL.DeleteGreeting(id);
        }

        // Redis Cache
        public async Task<IEnumerable<RequestModel>> GetProductsAsync()
        {
            string cacheKey = "product_list";

            // Try getting data from Redis cache
            var cachedData = await _cache.StringGetAsync(cacheKey);
            if (!cachedData.IsNullOrEmpty)
            {
                return JsonSerializer.Deserialize<IEnumerable<RequestModel>>(cachedData);
            }

            // Fetch from DB and cache it
            var products = await _greetingRL.GetProductsAsync();
            await _cache.StringSetAsync(cacheKey, JsonSerializer.Serialize(products), TimeSpan.FromMinutes(10));

            return products;
        }

    }
}