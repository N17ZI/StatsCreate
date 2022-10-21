using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace StatsCreate
{
    internal class User
    {
        public User(string name,string type,double strength, double dexterity, double constitution,
            double intellicence,double xp,double lvl/*,double damage,double hp,double armor,double mp,double mah*/)
        {
            this.Name = name;
            Type = type;
            Strength = strength;
            Dexterity = dexterity;
            Constitution = constitution;
            Intellicence = intellicence;

            Xp = xp;
            Lvl = lvl;

            /*Damage = damage;
            HP = hp;
            Armor = armor;
            MP = mp;
            MAH = mah;*/

            Skills = new List<Skill>();
            Items = new List<Item>();
            Equipments = new List<Equipment>();
        }
        public User(string name, double xp,double lvl)
        {
            Name = name;

            Xp = xp;
            Lvl = lvl;

            Skills = new List<Skill>();
            Items = new List<Item>();
            Equipments = new List<Equipment>();
        }

        [BsonId]
        [BsonIgnoreIfDefault]
        ObjectId _id;
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("type")]
        [BsonIgnoreIfNull]
        public string Type { get; set; }
        /*public double HP { get; set; }
        public double MP { get; set; }
        public double Damage { get; set; }
        public double Armor { get; set; }
        public double MAH { get; set; }*/

        [BsonIgnoreIfNull]
        public double Lvl { get; set; }
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
        public double Xp { get; set; }

        [BsonIgnoreIfNull]
        List<Item> Items { get; set; }
        public void AddItem(Item item)
        {
            Items.Add(item);
        }
        [BsonIgnoreIfNull]
        List<Skill> Skills { get; set; }
        public void AddSkill(Skill skill)
        {
            Skills.Add(skill);
        }
        public void RemoveSkill(Skill skill)
        {
            Skills.Remove(skill);
        }
        [BsonIgnoreIfNull]
        public List<Equipment> Equipments { get; set; }
    }
}
