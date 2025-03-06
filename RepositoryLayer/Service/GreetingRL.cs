using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace RepositoryLayer.Service
{
    public class GreetingRL : IGreetingRL
    {

        private readonly string _connectionString;



        HelloGreetingContext _helloGreetingContext;
        public GreetingRL(HelloGreetingContext helloGreetingContext, IConfiguration configuration)
        {
            _helloGreetingContext = helloGreetingContext;
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public string Greet(string message)
        {
            return message;
        }
        //save greeting message in the repository
        public GreetingEntity SaveGreeting(GreetingModel greetingModel)
        {
            GreetingEntity greetingEntity = new GreetingEntity()
            {
                Greeting = greetingModel.GreetingMessage,
            };
            _helloGreetingContext.Greetings.Add(greetingEntity);
            _helloGreetingContext.SaveChanges();
            return greetingEntity;
        }
        //get greeting by id from the repository
        public GreetingModel GetGreetingById(int id)
        {
            GreetingEntity greetingEntity = _helloGreetingContext.Greetings.Find(id);
            GreetingModel greetingModel = new GreetingModel()
            {
                GreetingMessage = greetingEntity.Greeting,
            };
            return greetingModel;
        }
        //get all greetings from the repository
        public List<GreetingModel> GetAllGreetings()
        {
            List<GreetingEntity> greetingEntities = _helloGreetingContext.Greetings.ToList();
            List<GreetingModel> greetingModels = new List<GreetingModel>();
            foreach (var greetingEntity in greetingEntities)
            {
                GreetingModel greetingModel = new GreetingModel()
                {
                    GreetingMessage = greetingEntity.Greeting,
                };
                greetingModels.Add(greetingModel);
            }
            return greetingModels;
        }
        //update the greeting message in the repository
        public GreetingModel UpdateGreeting(int id, GreetingModel greetingModel)
        {
            GreetingEntity greetingEntity = _helloGreetingContext.Greetings.Find(id);
            greetingEntity.Greeting = greetingModel.GreetingMessage;
            _helloGreetingContext.SaveChanges();
            return greetingModel;
        }
        public bool DeleteGreeting(int id)
        {
            GreetingEntity greetingEntity = _helloGreetingContext.Greetings.Find(id);
            if (greetingEntity != null)
            {
                _helloGreetingContext.Greetings.Remove(greetingEntity);
                _helloGreetingContext.SaveChanges();
                return true;
            }
            return false;
        }



        //Redis Cache
        public async Task<IEnumerable<RequestModel>> GetProductsAsync()
        {
            using var connection = new SqlConnection(_connectionString);
            return await connection.QueryAsync<RequestModel>("SELECT * FROM Products");
        }
    }
}