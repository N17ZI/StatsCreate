using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace StatsCreate
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bColdSnap_Click(object sender, EventArgs e)
        {
            User user = new User(SendBetween.Username, SendBetween.hero, Convert.ToDouble(SendBetween.strenght),
                                                            Convert.ToDouble(SendBetween.dexter),
                                                            Convert.ToDouble(SendBetween.constit),
                                                            Convert.ToDouble(SendBetween.intellect),
                                                            Convert.ToDouble(SendBetween.exp));
            bColdSnap.BackColor = Color.Green;
            bColdSnap.Enabled = false;
            DB.ReplaceByName(SendBetween.Username, user);
        }
    }
}
