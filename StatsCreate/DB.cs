﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;


namespace StatsCreate
{
    internal class DB : Form
    {

        private const string UserCollection = "users";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            return database.GetCollection<T>(collection);
        }
        public static void AddToDB(User user)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            collection.InsertOne(user);
        }
        
        public static void FindAll()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                Console.WriteLine($" {item?.Name} {item?.Type} {item?.Strength} {item?.Dexterity} {item?.Constitution} {item?.Intellicence}");
            }

        }


        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();

            Console.WriteLine($" {one?.Name} {one?.Type} {one?.Strength} {one?.Dexterity} {one?.Constitution} {one?.Intellicence}");

        }
        public async Task<List<User>> GetAllUsers()
        {
            var usersCollection = ConnectToMongo<User>(UserCollection);
            var results = await usersCollection.FindAsync(_ => true);
            return results.ToList();
        }
    }
}