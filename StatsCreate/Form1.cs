using MongoDB.Bson;
using MongoDB.Driver;

namespace StatsCreate
{
    public partial class Form1 : Form
    {
        double s1, s2, s3, s4;
        static double r = 1;
        

        public Form1()
        {
            InitializeComponent();
            bLevelUP.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserBox();
        }
        private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserBoxChange();
        }
        private void bUpdate_Click(object sender, EventArgs e)
        {
            User user = new User(UserBox.Text, heroBox.Text, Convert.ToDouble(nStrenght.Text),
                                                            Convert.ToDouble(nDexterity.Text),
                                                            Convert.ToDouble(nConstitution.Text),
                                                            Convert.ToDouble(nIntellicence.Text),
                                                            Convert.ToDouble(nXp.Text),
                                                            1);
            DB.ReplaceByName(UserBox.Text, user);

            SendBetween.Username = UserBox.Text;
            SendBetween.hero = heroBox.Text;
            SendBetween.strenght = nStrenght.Text;
            SendBetween.dexter = nDexterity.Text;
            SendBetween.constit = nConstitution.Text;
            SendBetween.intellect = nIntellicence.Text;
            SendBetween.exp = nXp.Text;
            SendBetween.lvl = r;

            LvlUp();
            LoadUserBox();
        }
        private void heroBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warrior warrior = new Warrior();
            Rogue rogue = new Rogue();
            Wizard wizard = new Wizard();
            try
            {
                if (heroBox.SelectedItem.ToString() == "Warrior")
                {
                    nStrenght.Maximum = 250;
                    nStrenght.Minimum = 30;
                    nDexterity.Maximum = 70;
                    nDexterity.Minimum = 15;
                    nConstitution.Maximum = 100;
                    nConstitution.Minimum = 20;
                    nIntellicence.Maximum = 50;
                    nIntellicence.Minimum = 10;
                    nStrenght.Text = warrior.Strength.ToString();
                    nDexterity.Text = warrior.Dexterity.ToString();
                    nConstitution.Text = warrior.Constitution.ToString();
                    nIntellicence.Text = warrior.Intellicence.ToString();
                }
                if (heroBox.SelectedItem.ToString() == "Rogue")
                {
                    nStrenght.Maximum = 55;
                    nStrenght.Minimum = 15;
                    nDexterity.Maximum = 250;
                    nDexterity.Minimum = 30;
                    nConstitution.Maximum = 80;
                    nConstitution.Minimum = 20;
                    nIntellicence.Maximum = 70;
                    nIntellicence.Minimum = 15;
                    nStrenght.Text = rogue.Strength.ToString();
                    nDexterity.Text = rogue.Dexterity.ToString();
                    nConstitution.Text = rogue.Constitution.ToString();
                    nIntellicence.Text = rogue.Intellicence.ToString();
                }
                if (heroBox.SelectedItem.ToString() == "Wizard")
                {
                    nStrenght.Maximum = 45;
                    nStrenght.Minimum = 10;
                    nDexterity.Maximum = 70;
                    nDexterity.Minimum = 20;
                    nConstitution.Maximum = 60;
                    nConstitution.Minimum = 15;
                    nIntellicence.Maximum = 250;
                    nIntellicence.Minimum = 35;
                    nStrenght.Text = wizard.Strength.ToString();
                    nDexterity.Text = wizard.Dexterity.ToString();
                    nConstitution.Text = wizard.Constitution.ToString();
                    nIntellicence.Text = wizard.Intellicence.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Something`s wrong");
            }
        }
        public void bCreate_Click(object sender, EventArgs e)
        {
            string name = UserBox.Text;
            string type = heroBox.Text;
            double xp = Convert.ToDouble(nXp.Value);
            xp = 1000;
            const double lvl = 1;

            s1 = Convert.ToDouble(nStrenght.Text);
            s2 = Convert.ToDouble(nDexterity.Text);
            s3 = Convert.ToDouble(nConstitution.Text);
            s4 = Convert.ToDouble(nIntellicence.Text);

            User user = new User(name, type, s1, s2, s3, s4, xp,lvl);
            DB.AddToDB(user);
            try
            {
                if (heroBox.SelectedItem.ToString() == "Warrior")
                {
                    double Damage = s1 * 5 + s2 + s3 / 10;
                    double HP = s1 * 2 + s3 * 10;
                    double Armor = s2 * 1 + s3 * 2;
                    double MP = s4 * 1;
                    double MAH = s4 * 1;
                    MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}", caption: "Warrior");
                }
                if (heroBox.SelectedItem.ToString() == "Rogue")
                {
                    double HP = s1 + (s3 * 6);
                    double Damage = (s1 * 2) + (s2 * 4);
                    double Armor = s2 * 1.5;
                    double MP = s4 * 1.5;
                    double MAH = s4 * 2;
                    MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}", caption: "Rogue");
                }
                if (heroBox.SelectedItem.ToString() == "Wizard")
                {
                    double HP = s1 + (s3 * 3);
                    double Damage = s1 * 3;
                    double Armor = (s2 * 0.5) + s3;
                    double MP = s4 * 2;
                    double MAH = s4 * 5;
                    MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}", caption: "Wizard");
                }
                LoadUserBox();
            }
            catch
            {
                MessageBox.Show("Something`s wrong");
            }
        }
        public void updateBox()
        {
            UserBox.Items.Clear();
            Level();
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var list = collection.Find(x => true).ToList();
            foreach (var item in list)
            {
                UserBox.Items.Add(item?.Name);
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            const string caption = "Items";
            var result = MessageBox.Show("Add pen to inventory selected hero?", caption ,MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Inventory();
            }
            if(result == DialogResult.No)
            {
                MessageBox.Show("Cancelled");
            }
        }

        private void bLevelUP_Click(object sender, EventArgs e)
        {
            Form2 SkillDialog = new Form2();
            SkillDialog.Show();
        }
        private void Level()
        {
            if (nXp.Value >= 3000)
            {
                bLevelUP.Visible = true;
                bLevelUP.Enabled = true;
            }
            else
            {
                bLevelUP.Visible = false;
            }
        }
        public void Inventory()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            string name = UserBox.Text;

            User user = new User(UserBox.Text, heroBox.Text, Convert.ToDouble(nStrenght.Text),
                                                            Convert.ToDouble(nDexterity.Text),
                                                            Convert.ToDouble(nConstitution.Text),
                                                            Convert.ToDouble(nIntellicence.Text),
                                                            Convert.ToDouble(nXp.Text), 1
                                                            );
            user.AddItem(new Item("Pen", 5));

            DB.ReplaceByName(UserBox.Text, user);
        }

        private void bGet1k_Click(object sender, EventArgs e)
        {
            nXp.Value += 1000;
            User user = new User(UserBox.Text, heroBox.Text, Convert.ToDouble(nStrenght.Text),
                                                            Convert.ToDouble(nDexterity.Text),
                                                            Convert.ToDouble(nConstitution.Text),
                                                            Convert.ToDouble(nIntellicence.Text),
                                                            Convert.ToDouble(nXp.Text), r++
                                                            );
            DB.ReplaceByName(UserBox.Text, user);
            LoadUserBox();
        }

        private void bEquipment_Click(object sender, EventArgs e)
        {
            Form3 EquipmentDialog = new Form3();
            EquipmentDialog.Show();
        }

        private void LoadUserBox()
        {
            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");

            List<User> user = collection.AsQueryable().ToList();
            dataGridView1.DataSource = user;

            nStrenght.Text = dataGridView1.Rows[0].Cells[1].ToString();
            nDexterity.Text = dataGridView1.Rows[0].Cells[2].ToString();
            nConstitution.Text = dataGridView1.Rows[0].Cells[3].ToString();
            nIntellicence.Text = dataGridView1.Rows[0].Cells[4].ToString();
            nXp.Text = dataGridView1.Rows[0].Cells[5].ToString();

            updateBox();
        }
        private void UserBoxChange()
        {
            string type = heroBox.Text;

            var client = new MongoClient();
            var database = client.GetDatabase("CurrentlyDB");
            var collection = database.GetCollection<User>("Users");
            var one = collection.Find(x => x.Name == UserBox.SelectedItem.ToString()).FirstOrDefault();

            heroBox.Text = Convert.ToString(one?.Type);
            nStrenght.Text = Convert.ToString(one?.Strength);
            nDexterity.Text = Convert.ToString(one?.Dexterity);
            nConstitution.Text = Convert.ToString(one?.Constitution);
            nIntellicence.Text = Convert.ToString(one?.Intellicence);
            nXp.Value = Convert.ToDecimal(one?.Xp);
        }
        public void LvlUp()
        {
            
            if (nXp.Value >= 3000)
            {
                
                for (int exp = Convert.ToInt32(nXp.Value); exp > 1000; exp--)
                {
                    double dad = r++;
                    exp -= 1000;
                    User user = new User(UserBox.Text, heroBox.Text, Convert.ToDouble(nStrenght.Text),
                                                            Convert.ToDouble(nDexterity.Text),
                                                            Convert.ToDouble(nConstitution.Text),
                                                            Convert.ToDouble(nIntellicence.Text),
                                                            exp, dad
                                                            );
                    DB.ReplaceByName(UserBox.Text, user);
                }
            }
            else
            {
                
            }
        }
    }
}