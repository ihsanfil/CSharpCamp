using CSharpCamp601.Entities;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCamp601.Services
{
    public class CustomerOperation
    {
        public void AddCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customertCollection = connection.GetCustomerCollection();
            var document = new BsonDocument
            {
                {"CustomerName",customer.CustomerName },
                {"CustomerSurName",customer.CustomerSurName },
                {"CustomerCity",customer.CustomerCity },
                {"CustomerBalance",customer.CustomerBalance },
                {"CustomerShoppingCount",customer.CustomerShoppingCount }
            };

            customertCollection.InsertOne(document);
        }

        public List<Customer> GetAllCustomer()
        {
            var connection = new MongoDbConnection();
            var customertCollection = connection.GetCustomerCollection();
            var customers = customertCollection.Find(new BsonDocument()).ToList();
            List<Customer> customerList = new List<Customer>();
            foreach (var item in customers)
            {
                customerList.Add(new Customer()
                {
                    CustomerId = item["_id"].ToString(),
                    CustomerBalance = decimal.Parse(item["CustomerBalance"].ToString()),
                    CustomerShoppingCount = int.Parse(item["CustomerShoppingCount"].ToString()),
                    CustomerCity = item["CustomerCity"].ToString(),
                    CustomerName = item["CustomerName"].ToString(),
                    CustomerSurName = item["CustomerSurName"].ToString(),
                });
            }

            return customerList;
        }
        public void DeleteCustomer(string customerId)
        {
            var connection = new MongoDbConnection();
            var customertCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            customertCollection.DeleteOne(filter);
        }
   
    
        public void UpdateCustomer(Customer customer)
        {
            var connection = new MongoDbConnection();
            var customertCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customer.CustomerId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName",customer.CustomerName)
                .Set("CustomerSurName", customer.CustomerSurName)
                .Set("CustomerCity", customer.CustomerCity)
                .Set("CustomerBalance", customer.CustomerBalance)
                .Set("CustomerShoppingCount", customer.CustomerShoppingCount);

            customertCollection.UpdateOne(filter, updatedValue);

        }

        public Customer GetCustomerById(string customerId)
        {
            var connection = new MongoDbConnection();
            var customertCollection = connection.GetCustomerCollection();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(customerId));
            var result = customertCollection.Find(filter).FirstOrDefault();

            Customer customer = new Customer()
            {
                CustomerId = result["_id"].ToString(),
                CustomerBalance = decimal.Parse(result["CustomerBalance"].ToString()),
                CustomerShoppingCount = int.Parse(result["CustomerShoppingCount"].ToString()),
                CustomerCity = result["CustomerCity"].ToString(),
                CustomerName = result["CustomerName"].ToString(),
                CustomerSurName = result["CustomerSurName"].ToString()
            };

           
            return customer;

        }
    
    
    }
}
