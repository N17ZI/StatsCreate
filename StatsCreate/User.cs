using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace StatsCreate
{
    internal class User
    {
        public User(string name,string type,double strength, double dexterity, double constitution, double intellicence)
        {
            this.Name = name;
            Type = type;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intellicence = intellicence;
            Items = new List<Item>();
        }
        public User(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
            Items = new List<Item>();
        }
        public User()
        {
            Name = Name;
            Items = new List<Item>();
        }
        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("type")]
        [BsonIgnoreIfNull]
        public string Type { get; set; }
        [BsonIgnoreIfNull]
        public string Email { get; set; }
        [BsonIgnoreIfNull]
        public int Age { get; set; }
        [BsonIgnoreIfDefault]
        [BsonIgnoreIfNull]
        public double Strength { get; set; }
        [BsonIgnoreIfNull]
        public double Dexterity { get; set; }
        [BsonIgnoreIfNull]
        public double Constitution { get; set; }
        [BsonIgnoreIfNull]
        public double Intellicence { get; set; }

        [BsonIgnoreIfNull]
        List<Item> Items { get; set; }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
    }
}
