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
            double Points = Convert.ToDouble(SendBetween.exp);
            pts.Text = words + Convert.ToString(Math.Round(Points / 3000));
        }
        string words = "You have points in count = ";
        static int Up = Convert.ToInt32(SendBetween.exp) / 3000;

        User user = new User(SendBetween.Username, SendBetween.hero, Convert.ToDouble(SendBetween.strenght),
                                                            Convert.ToDouble(SendBetween.dexter),
                                                            Convert.ToDouble(SendBetween.constit),
                                                            Convert.ToDouble(SendBetween.intellect),
                                                            Convert.ToDouble(SendBetween.exp), 
                                                            Convert.ToDouble(SendBetween.lvl));
        public void Check()
        {
            if(Up == 0)
            {
                this.Close();
            }
        }
        private void bColdSnap_Click(object sender, EventArgs e)
        {
            if (Up != 0)
            {
                bColdSnap.BackColor = Color.Green;
                bColdSnap.Enabled = false;
                string text = bColdSnap.Text;
                user.AddSkill(new Skill(text));
                DB.ReplaceByName(SendBetween.Username, user);
                Up--;
                pts.Text = words + Up.ToString();
            }
            else
            {
                Check();
            }
        }

        private void bTornado_Click(object sender, EventArgs e)
        {
            if (Up != 0) 
            {
                bTornado.BackColor = Color.Green;
                bTornado.Enabled = false;
                string text = bTornado.Text;
                user.AddSkill(new Skill(text));
                DB.ReplaceByName(SendBetween.Username, user);
                Up--;
                pts.Text = words + Up.ToString();
            }
            else
            {
                Check();
            }
        }

        private void bBlast_Click(object sender, EventArgs e)
        {
            if (Up != 0)
            {
                bBlast.BackColor = Color.Green;
                bBlast.Enabled = false;
                string text = bBlast.Text;
                user.AddSkill(new Skill(text));
                DB.ReplaceByName(SendBetween.Username, user);
                Up--;
                pts.Text = words + Up.ToString();
            }
            else
            {
                Check();
            }
        }

        private void bAlacrity_Click(object sender, EventArgs e)
        {
            if (Up != 0)
            {
                bAlacrity.BackColor = Color.Green;
                bAlacrity.Enabled = false;
                string text = bAlacrity.Text;
                user.AddSkill(new Skill(text));
                DB.ReplaceByName(SendBetween.Username, user);
                Up--;
                pts.Text = words + Up.ToString();
            }
            else
            {
                Check();
            }
        }

        private void bGhostWalk_Click(object sender, EventArgs e)
        {
            if (Up != 0)
            {
                bGhostWalk.BackColor = Color.Green;
                bGhostWalk.Enabled = false;
                string text = bGhostWalk.Text;
                user.AddSkill(new Skill(text));
                DB.ReplaceByName(SendBetween.Username, user);
                Up--;
                pts.Text = words + Up.ToString();
            }
            else
            {
                Check();
            }
        }
    }
}
