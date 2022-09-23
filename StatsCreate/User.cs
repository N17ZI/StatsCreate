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
        }
        [BsonId]
        ObjectId _id;
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("type")]
        public string Type { get; set; }
        public double Strength { get; set; }
        [BsonIgnoreIfNull]
        public double Dexterity { get; set; }
        [BsonIgnoreIfNull]
        public double Constitution { get; set; }
        [BsonIgnoreIfNull]
        public double Intellicence { get; set; }
    }
}
