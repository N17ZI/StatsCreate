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

        private void bSave_Changes_Click(object sender, EventArgs e)
        {
            int w = 0;
            string Tag = SendBetween.Username;
            Equipment equipment = new Equipment(Receiver.Items[0].ToString());
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var update = Builders<User>.Update.Push("Equipments", equipment);
            collection.UpdateOne(x => x.Name == Receiver.Items[0].ToString(), update);
            MessageBox.Show(Receiver.Items[0].ToString());
        }

        private void Receiver_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
