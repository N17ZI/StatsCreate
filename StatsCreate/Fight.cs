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
        int s,b;    
        private void bReady_Click(object sender, EventArgs e)
        {
            if(cTeamA.Text == "Warrior`s") { s = 0; }
            if(cTeamA.Text == "Rogue`s") { s = 1; }
            if(cTeamA.Text == "Wizard`s") { s = 2; }
            if (cTeamB.Text == "Warrior`s") { b = 0; }
            if (cTeamB.Text == "Rogue`s") { b = 1; }
            if (cTeamB.Text == "Wizard`s") { b = 2; }
            fillTeam();
        }

        private void bAuto_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            
            int r1, r2;
            DB.FindAll();
            int totalHp = SendBetween.cnt;

            for (int i = 0; i < totalHp; i++)
            {
                if (i == 0)
                {
                    var list = collection.Find(x => x.Name == "1").ToList();
                    foreach (var item in list)
                    {
                        dataGridView1.Rows.Add(item?.Name, item?.Type, item?.Strength, item?.Dexterity);
                    }
                }
                else
                {
                    if (dataGridView1.RowCount > 1)
                    {
                        var list1 = collection.Find(x => x.Name == "").ToList();
                        foreach (var item in list1)
                        {
                            dataGridView2.Rows.Add(item?.Name, item?.Type, item?.Strength, item?.Dexterity);
                        }
                    }
                }
            }
        }

        public void fillTeam()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            string[] type = { "Warrior", "Rogue", "Wizard","Auto" };
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
                
            var list = collection.Find(x => x.Type == type[s]).ToList();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item?.Name, item?.Type, item?.Strength, item?.Dexterity);
            }
            var list1 = collection.Find(x => x.Type == type[b]).ToList();
            foreach (var item in list1)
            {
                dataGridView2.Rows.Add(item?.Name, item?.Type, item?.Strength, item?.Dexterity);
            }
            
        }
    }
}
