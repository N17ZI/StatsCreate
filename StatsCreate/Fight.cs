using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;

namespace StatsCreate
{
    public partial class Fight : Form
    {
        public Fight()
        {
            InitializeComponent();
        }
        private void bReady_Click(object sender, EventArgs e)
        {
            fillTeam();
        }

        public void fillTeam()
        {
            string[] type = { "Warrior", "Rogue", "Wizard" };
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => x.Type == type[0]).ToList();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item?.Name,item?.Type, item?.Strength, item?.Dexterity);
                dataGridView2.Rows.Add(item?.Name, item?.Type, item?.Strength, item?.Dexterity);
            }
        }
    }
}
