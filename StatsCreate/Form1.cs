namespace StatsCreate
{
    public partial class Form1 : Form
    {
        int index;
        double s1, s2, s3, s4;
        public Form1()
        {
            InitializeComponent();
        }


        private void heroBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Warrior warrior = new Warrior();
            Rogue rogue = new Rogue();
            Wizard wizard = new Wizard();

            if(heroBox.SelectedItem.ToString() == "Warrior")
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

        public void bCreate_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToDouble(nStrenght.Text);
            s2 = Convert.ToDouble(nDexterity.Text);
            s3 = Convert.ToDouble(nConstitution.Text);
            s4 = Convert.ToDouble(nIntellicence.Text);
            if (heroBox.SelectedItem.ToString() == "Warrior")
            {
                double Damage = s1 * 5 + s2 + s3 / 10;
                double HP = s1 * 2 + s3 * 10;
                double Armor = s2 * 1 + s3 * 2;
                double MP = s4 * 1;
                double MAH = s4 * 1;
                MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}",caption: "Warrior");
            }
            if (heroBox.SelectedItem.ToString() == "Rogue")
            {
                double HP = s1 + (s3 * 6);
                double Damage = (s1 * 2) + (s2 * 4);
                double Armor = s2 * 1.5;
                double MP = s4 * 1.5;
                double MAH = s4 * 2;
                MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}",caption:"Rogue");
            }
            if (heroBox.SelectedItem.ToString() == "Wizard")
            {
                double HP = s1 + (s3 * 3);
                double Damage = s1 * 3;
                double Armor = (s2 * 0.5) + s3;
                double MP = s4 * 2;
                double MAH = s4 * 5;
                index = 3;
                MessageBox.Show($"HP - {HP}\nDamage - {Damage}\nArmor - {Armor}\nMana - {MP}\nMagicDamage - {MAH}", caption: "Wizard");
            }
        }

        public void nStrenght_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}