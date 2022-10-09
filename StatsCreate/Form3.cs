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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Sender_Click(object sender, EventArgs e)
        {
            if (Sender.SelectedItem != null)
            {
                Receiver.Items.Add(Sender.SelectedItem);
                Sender.Items.Remove(Sender.SelectedItem);
            }
            else
            {
                MessageBox.Show("No item selected");
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
                MessageBox.Show("No item selected");
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if(Receiver.Items.Count > 0)
            {
                string[] s;
                s = new string[Receiver.Items.Count];
                for (int i = 0; i < Receiver.Items.Count; i++)
                {
                    s[i] = Receiver.Items[i].ToString();
                }
                Equipment equipments = new Equipment(s[0]);
                var client = new MongoClient();
                var database = client.GetDatabase("CurrentlyDB");
                var collection = database.GetCollection<User>("Users");
                var update = Builders<User>.Update.Set("Equipments", equipments);
                collection.UpdateOne(x => x.Name == s[0], update);
                MessageBox.Show(s[0]);
            }
            else
            {
                MessageBox.Show("Something wrong");
            }
            /*var updatePush = Builders<Unit>.Update.Push("Skills", skills); 
            collection.UpdateOne(x => x.name == NametextBox.Text, updatePush);*/
        }
    }
}
