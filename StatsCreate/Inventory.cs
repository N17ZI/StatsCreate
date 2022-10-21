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
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
            labelchange();
        }
        int x = 0;

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = listView1.SelectedIndices;
            if (indices.Count > 0)
            {
                string index = listView1.FocusedItem.Text;
                
                int y = listView1.FocusedItem.Index;
                

                string ctg = Convert.ToString(listView1.Items[y].SubItems[x + 1].Text);
                string str = Convert.ToString(listView1.Items[y].SubItems[x + 2].Text);
                string dxt = Convert.ToString(listView1.Items[y].SubItems[x + 3].Text);
                string intl = Convert.ToString(listView1.Items[y].SubItems[x + 4].Text);
                string cons = Convert.ToString(listView1.Items[y].SubItems[x + 5].Text);

                listView2.Items.Add(new ListViewItem(new[] { index, ctg ,str,dxt,intl,cons }));
                listView1.Items.RemoveAt(y);
                listView2.Update();
            }
        }

        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = listView2.SelectedIndices;
            if (indices.Count > 0)
            {
                string index = listView2.FocusedItem.Text;

                int y = listView2.FocusedItem.Index;

                string ctg = Convert.ToString(listView2.Items[y].SubItems[x + 1].Text);
                string str = Convert.ToString(listView2.Items[y].SubItems[x + 2].Text);
                string dxt = Convert.ToString(listView2.Items[y].SubItems[x + 3].Text);
                string intl = Convert.ToString(listView2.Items[y].SubItems[x + 4].Text);
                string cons = Convert.ToString(listView2.Items[y].SubItems[x + 5].Text);

                listView1.Items.Add(new ListViewItem(new[] { index, ctg, str, dxt, intl, cons }));
                listView2.Items.RemoveAt(y);
                listView1.Update();
            }
        }
        public void labelchange()
        {
            //s1 = str; s2 = dxt; s3 = const ; s4=intl
            tStrength.Text = SendBetween.strenght;
            tDexterity.Text = SendBetween.dexter;
            tIntellicente.Text = SendBetween.intellect;
            tConstitution.Text = SendBetween.constit;
            double Damage,HP,Armor,MP,MAH;
            if (SendBetween.hero == "Warrior")
            {
                Damage = Convert.ToInt32(SendBetween.strenght)* 5 + Convert.ToDouble(SendBetween.dexter) + 
                Convert.ToDouble(SendBetween.constit) / 10;
                HP = Convert.ToInt32(SendBetween.strenght) * 2 + Convert.ToDouble(SendBetween.constit) * 10;
                Armor = Convert.ToDouble(SendBetween.dexter) * 1 + Convert.ToDouble(SendBetween.constit) * 2;
                MP = Convert.ToDouble(SendBetween.intellect) * 1;
                MAH = Convert.ToDouble(SendBetween.intellect) * 1;
                lbDamage.Text += " " + Damage;
                lbArmor.Text += " " + Armor;
                lbMana.Text += " " + MP;
            }
            if (SendBetween.hero == "Rogue")
            {
                Damage = (Convert.ToInt32(SendBetween.strenght) * 2) + (Convert.ToDouble(SendBetween.dexter) * 4);
                HP = Convert.ToInt32(SendBetween.strenght) + (Convert.ToDouble(SendBetween.constit) * 6);
                Armor = (Convert.ToDouble(SendBetween.dexter) * 1.5);
                MP = Convert.ToDouble(SendBetween.intellect) * 1.5;
                MAH = Convert.ToDouble(SendBetween.intellect) * 2;
                lbDamage.Text += " " + Damage;
                lbArmor.Text += " " + Armor;
                lbMana.Text += " " + MP;
            }
            if (SendBetween.hero == "Wizard")
            {
                Damage = Convert.ToInt32(SendBetween.strenght) * 3;
                HP = (Convert.ToInt32(SendBetween.strenght) + ((Convert.ToDouble(SendBetween.constit) * 3)));
                Armor = (Convert.ToDouble(SendBetween.dexter) * 0.5) + (Convert.ToDouble(SendBetween.constit));
                MP = Convert.ToDouble(SendBetween.intellect) * 2;
                MAH = Convert.ToDouble(SendBetween.intellect) * 5;
                lbDamage.Text += " " + Damage;
                lbArmor.Text += " " + Armor;
                lbMana.Text += " " + MP;
            }
            checkUpgrade();
        }
        public void checkUpgrade()
        {
/*            MessageBox.Show(listView1.Items[0].SubItems[x + 1].Text);
            MessageBox.Show(listView2.Items.Count.ToString());*/
            if (listView2.Items.Count > 0)
            {
                for (int i = 0; i < listView2.Items.Count; i++)
                {
                    if (listView2.Items[i].SubItems[x + 1].Text == "Weapons" && Convert.ToInt32(listView2.Items[0].SubItems[x + 2].Text) <=
                        Convert.ToInt32(SendBetween.strenght) && Convert.ToInt32(listView2.Items[0].SubItems[x + 3].Text) <=
                        Convert.ToInt32(SendBetween.dexter) && Convert.ToInt32(listView2.Items[0].SubItems[x + 4].Text) <=
                        Convert.ToInt32(SendBetween.intellect) && Convert.ToInt32(listView2.Items[0].SubItems[x + 5].Text) <=
                        Convert.ToInt32(SendBetween.constit))
                    {
                        string gradeDamage = listView2.Items[i].SubItems[x + 2].Text;
                        lbDamage.Text += "+" + (gradeDamage);
                    }
                    if (listView2.Items[i].SubItems[x + 1].Text == "Helmet" && Convert.ToInt32(listView2.Items[0].SubItems[x + 2].Text) <=
                        Convert.ToInt32(SendBetween.strenght) && Convert.ToInt32(listView2.Items[0].SubItems[x + 3].Text) <=
                        Convert.ToInt32(SendBetween.dexter) && Convert.ToInt32(listView2.Items[0].SubItems[x + 4].Text) <=
                        Convert.ToInt32(SendBetween.intellect) && Convert.ToInt32(listView2.Items[0].SubItems[x + 5].Text) <=
                        Convert.ToInt32(SendBetween.constit))
                    {
                        string gradeHelmet = listView2.Items[i].SubItems[x + 2].Text;
                        lbArmor.Text += "+" + (gradeHelmet);
                        lbMana.Text += "+" + (gradeHelmet);
                    }
                    if (listView2.Items[i].SubItems[x + 1].Text == "Armor" && Convert.ToInt32(listView2.Items[0].SubItems[x + 2].Text) <=
                        Convert.ToInt32(SendBetween.strenght) && Convert.ToInt32(listView2.Items[0].SubItems[x + 3].Text) <=
                        Convert.ToInt32(SendBetween.dexter) && Convert.ToInt32(listView2.Items[0].SubItems[x + 4].Text) <=
                        Convert.ToInt32(SendBetween.intellect) && Convert.ToInt32(listView2.Items[0].SubItems[x + 5].Text) <=
                        Convert.ToInt32(SendBetween.constit))
                    {
                        string gradeArmor = listView2.Items[i].SubItems[x + 2].Text;
                        lbArmor.Text += "+" + (gradeArmor);
                    }
                    else { MessageBox.Show("Dont have enought stats"); }
                }
            }
            else if(listView2.Items.Count == 0)
            {
                
            }
        }

        private void GetData_Click(object sender, EventArgs e)
        {
            checkUpgrade();
        }
    }

}
