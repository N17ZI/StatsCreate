using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StatsCreate
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            GetData();
        }

        private void Sender_Click(object sender, EventArgs e)
        {
            if (Sender.SelectedItem != null && Receiver.Items.Count < 3)
            {
                Receiver.Items.Add(Sender.SelectedItem);
                Sender.Items.Remove(Sender.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected or dont have space");
            }
        }

        private void Receiver_Click(object sender, EventArgs e)
        {
            if (Receiver.SelectedItem != null)
            {
                Sender.Items.Add(Receiver.SelectedItem);
                Receiver.Items.Remove(Receiver.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected or dont have space");
            }
        }

        private void bSave_Changes_Click(object sender, EventArgs e)
        {
            string[] s;
            s = new string[Receiver.Items.Count];
            for (int i = 0; i < Receiver.Items.Count; i++)
            {
                s[i] = Receiver.Items[i].ToString();
                Equipment equipment = new Equipment(s[i]);
                DB.Find(SendBetween.Username);
                var client = new MongoClient();
                var database = client.GetDatabase("CurrentlyDB");
                var collection = database.GetCollection<User>("Users");
                var update = Builders<User>.Update.Push("Equipments", equipment);
                collection.UpdateOne(x => x.Name == SendBetween.Username, update);
            }
        }

        private void Receiver_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        public void GetData()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == SendBetween.Username).FirstOrDefault();
            if (one.Equipments.Count != 0)
            {
                foreach (var item in one.Equipments)
                {
                    Receiver.Items.Add(item);
                    if (!Sender.Items.Contains(item))
                    {
                        Sender.Items.Remove(item);
                    }
                }
            }
        }

        private void Receiver_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Sender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
