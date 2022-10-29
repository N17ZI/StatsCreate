using System;
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
            /*foreach (var item in list)
            {
                MessageBox.Show($" {item?.Name} {item?.Type} {item?.Strength} {item?.Dexterity} {item?.Constitution} {item?.Intellicence}");
            }*/
            var cnt1 = collection.Count(x => true);
            SendBetween.cnt = Convert.ToInt32(cnt1);
        }

        public static void Find(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();

            
            /* MessageBox.Show($" {one.Name} {one?.Type} {one?.Strength} {one?.Dexterity} {one?.Constitution} {one?.Intellicence}");*/
        }
        public static void FindAttributes(string name)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == name).FirstOrDefault();
            
            SendBetween.Damage = one.Damage;
            SendBetween.HP = one.HP;
            SendBetween.Armor = one.Armor;
            SendBetween.MAH = one.MAH;
            SendBetween.MP = one.MP;
            //MessageBox.Show($" {one?.Name} {one?.Type} {one?.Strength} {one?.Dexterity} {one?.Constitution} {one?.Intellicence}");
        }
        public static void ReplaceByName(string name, User user1)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            collection.ReplaceOne(x => x.Name == name, user1);
        }
        public static void FindTypeHero(string type)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Type == type).FirstOrDefault();

            MessageBox.Show($" {one?.Name} {one?.Type} {one?.Strength} {one?.Dexterity} {one?.Constitution} {one?.Intellicence}");
        }
        public static void FindTypeHeros(string type)
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => x.Type == type).ToList();
            foreach (var item in list)
            {
                MessageBox.Show($" {item?.Name} {item?.Type} {item?.Strength} {item?.Dexterity} {item?.Constitution} {item?.Intellicence}");
            }
        }
    }
}
