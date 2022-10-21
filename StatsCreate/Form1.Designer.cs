using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StatsCreate
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lCmd5 = new System.Windows.Forms.Label();
            this.tHP = new System.Windows.Forms.TextBox();
            this.lCmd2 = new System.Windows.Forms.Label();
            this.lCmd3 = new System.Windows.Forms.Label();
            this.lCmd4 = new System.Windows.Forms.Label();
            this.lCmd1 = new System.Windows.Forms.Label();
            this.tArmor = new System.Windows.Forms.TextBox();
            this.tMP = new System.Windows.Forms.TextBox();
            this.tMAH = new System.Windows.Forms.TextBox();
            this.tDamage = new System.Windows.Forms.TextBox();
            this.bBollVisible = new System.Windows.Forms.CheckBox();
            this.bFight = new System.Windows.Forms.Button();
            this.bEquipment = new System.Windows.Forms.Button();
            this.bGet1k = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nXp = new System.Windows.Forms.NumericUpDown();
            this.bLevelUP = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UserBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.nDexterity = new System.Windows.Forms.NumericUpDown();
            this.nConstitution = new System.Windows.Forms.NumericUpDown();
            this.nIntellicence = new System.Windows.Forms.NumericUpDown();
            this.nStrenght = new System.Windows.Forms.NumericUpDown();
            this.heroBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nXp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIntellicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStrenght)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lCmd5);
            this.panel1.Controls.Add(this.tHP);
            this.panel1.Controls.Add(this.lCmd2);
            this.panel1.Controls.Add(this.lCmd3);
            this.panel1.Controls.Add(this.lCmd4);
            this.panel1.Controls.Add(this.lCmd1);
            this.panel1.Controls.Add(this.tArmor);
            this.panel1.Controls.Add(this.tMP);
            this.panel1.Controls.Add(this.tMAH);
            this.panel1.Controls.Add(this.tDamage);
            this.panel1.Controls.Add(this.bBollVisible);
            this.panel1.Controls.Add(this.bFight);
            this.panel1.Controls.Add(this.bEquipment);
            this.panel1.Controls.Add(this.bGet1k);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nXp);
            this.panel1.Controls.Add(this.bLevelUP);
            this.panel1.Controls.Add(this.bAdd);
            this.panel1.Controls.Add(this.bUpdate);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.UserBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bCreate);
            this.panel1.Controls.Add(this.nDexterity);
            this.panel1.Controls.Add(this.nConstitution);
            this.panel1.Controls.Add(this.nIntellicence);
            this.panel1.Controls.Add(this.nStrenght);
            this.panel1.Controls.Add(this.heroBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 469);
            this.panel1.TabIndex = 0;
            // 
            // lCmd5
            // 
            this.lCmd5.AutoSize = true;
            this.lCmd5.Location = new System.Drawing.Point(744, 195);
            this.lCmd5.Name = "lCmd5";
            this.lCmd5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lCmd5.Size = new System.Drawing.Size(23, 15);
            this.lCmd5.TabIndex = 33;
            this.lCmd5.Text = "HP";
            this.lCmd5.Visible = false;
            // 
            // tHP
            // 
            this.tHP.Location = new System.Drawing.Point(843, 192);
            this.tHP.Name = "tHP";
            this.tHP.ReadOnly = true;
            this.tHP.Size = new System.Drawing.Size(100, 23);
            this.tHP.TabIndex = 32;
            this.tHP.Visible = false;
            // 
            // lCmd2
            // 
            this.lCmd2.AutoSize = true;
            this.lCmd2.Location = new System.Drawing.Point(744, 80);
            this.lCmd2.Name = "lCmd2";
            this.lCmd2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lCmd2.Size = new System.Drawing.Size(41, 15);
            this.lCmd2.TabIndex = 31;
            this.lCmd2.Text = "Armor";
            this.lCmd2.Visible = false;
            // 
            // lCmd3
            // 
            this.lCmd3.AutoSize = true;
            this.lCmd3.Location = new System.Drawing.Point(744, 122);
            this.lCmd3.Name = "lCmd3";
            this.lCmd3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lCmd3.Size = new System.Drawing.Size(25, 15);
            this.lCmd3.TabIndex = 30;
            this.lCmd3.Text = "MP";
            this.lCmd3.Visible = false;
            // 
            // lCmd4
            // 
            this.lCmd4.AutoSize = true;
            this.lCmd4.Location = new System.Drawing.Point(744, 158);
            this.lCmd4.Name = "lCmd4";
            this.lCmd4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lCmd4.Size = new System.Drawing.Size(35, 15);
            this.lCmd4.TabIndex = 29;
            this.lCmd4.Text = "MAH";
            this.lCmd4.Visible = false;
            // 
            // lCmd1
            // 
            this.lCmd1.AutoSize = true;
            this.lCmd1.Location = new System.Drawing.Point(744, 39);
            this.lCmd1.Name = "lCmd1";
            this.lCmd1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lCmd1.Size = new System.Drawing.Size(51, 15);
            this.lCmd1.TabIndex = 28;
            this.lCmd1.Text = "Damage";
            this.lCmd1.Visible = false;
            // 
            // tArmor
            // 
            this.tArmor.Location = new System.Drawing.Point(843, 77);
            this.tArmor.Name = "tArmor";
            this.tArmor.ReadOnly = true;
            this.tArmor.Size = new System.Drawing.Size(100, 23);
            this.tArmor.TabIndex = 27;
            this.tArmor.Visible = false;
            // 
            // tMP
            // 
            this.tMP.Location = new System.Drawing.Point(843, 114);
            this.tMP.Name = "tMP";
            this.tMP.ReadOnly = true;
            this.tMP.Size = new System.Drawing.Size(100, 23);
            this.tMP.TabIndex = 26;
            this.tMP.Visible = false;
            // 
            // tMAH
            // 
            this.tMAH.Location = new System.Drawing.Point(843, 155);
            this.tMAH.Name = "tMAH";
            this.tMAH.ReadOnly = true;
            this.tMAH.Size = new System.Drawing.Size(100, 23);
            this.tMAH.TabIndex = 25;
            this.tMAH.Visible = false;
            // 
            // tDamage
            // 
            this.tDamage.Location = new System.Drawing.Point(843, 36);
            this.tDamage.Name = "tDamage";
            this.tDamage.ReadOnly = true;
            this.tDamage.Size = new System.Drawing.Size(100, 23);
            this.tDamage.TabIndex = 24;
            this.tDamage.Visible = false;
            // 
            // bBollVisible
            // 
            this.bBollVisible.AutoSize = true;
            this.bBollVisible.Location = new System.Drawing.Point(12, 303);
            this.bBollVisible.Name = "bBollVisible";
            this.bBollVisible.Size = new System.Drawing.Size(98, 19);
            this.bBollVisible.TabIndex = 23;
            this.bBollVisible.Text = "Visible Details";
            this.bBollVisible.UseVisualStyleBackColor = true;
            this.bBollVisible.Click += new System.EventHandler(this.bBollVisible_Click);
            // 
            // bFight
            // 
            this.bFight.Location = new System.Drawing.Point(12, 389);
            this.bFight.Name = "bFight";
            this.bFight.Size = new System.Drawing.Size(287, 68);
            this.bFight.TabIndex = 22;
            this.bFight.Text = "Fight";
            this.bFight.UseVisualStyleBackColor = true;
            this.bFight.Click += new System.EventHandler(this.bFight_Click);
            // 
            // bEquipment
            // 
            this.bEquipment.Location = new System.Drawing.Point(598, 326);
            this.bEquipment.Name = "bEquipment";
            this.bEquipment.Size = new System.Drawing.Size(345, 57);
            this.bEquipment.TabIndex = 21;
            this.bEquipment.Text = "Equipment";
            this.bEquipment.UseVisualStyleBackColor = true;
            this.bEquipment.Click += new System.EventHandler(this.bEquipment_Click);
            // 
            // bGet1k
            // 
            this.bGet1k.Location = new System.Drawing.Point(305, 326);
            this.bGet1k.Name = "bGet1k";
            this.bGet1k.Size = new System.Drawing.Size(287, 57);
            this.bGet1k.TabIndex = 20;
            this.bGet1k.Text = "Get 1000 XP";
            this.bGet1k.UseVisualStyleBackColor = true;
            this.bGet1k.Click += new System.EventHandler(this.bGet1k_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "XP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Type";
            // 
            // nXp
            // 
            this.nXp.Location = new System.Drawing.Point(144, 283);
            this.nXp.Maximum = new decimal(new int[] {
            3333333,
            0,
            0,
            0});
            this.nXp.Name = "nXp";
            this.nXp.Size = new System.Drawing.Size(155, 23);
            this.nXp.TabIndex = 17;
            // 
            // bLevelUP
            // 
            this.bLevelUP.BackColor = System.Drawing.Color.Gold;
            this.bLevelUP.Location = new System.Drawing.Point(12, 65);
            this.bLevelUP.Name = "bLevelUP";
            this.bLevelUP.Size = new System.Drawing.Size(287, 44);
            this.bLevelUP.TabIndex = 16;
            this.bLevelUP.Text = "Level UP";
            this.bLevelUP.UseVisualStyleBackColor = false;
            this.bLevelUP.Click += new System.EventHandler(this.bLevelUP_Click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(598, 389);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(345, 68);
            this.bAdd.TabIndex = 15;
            this.bAdd.Text = "Inventory";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(305, 389);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(287, 68);
            this.bUpdate.TabIndex = 14;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(305, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(638, 270);
            this.dataGridView1.TabIndex = 13;
            // 
            // UserBox
            // 
            this.UserBox.FormattingEnabled = true;
            this.UserBox.Location = new System.Drawing.Point(12, 36);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(287, 23);
            this.UserBox.TabIndex = 12;
            this.UserBox.SelectedIndexChanged += new System.EventHandler(this.UserBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Your nickname is";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intellcence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Constitution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dexterity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strenght";
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(12, 326);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(287, 57);
            this.bCreate.TabIndex = 5;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // nDexterity
            // 
            this.nDexterity.Location = new System.Drawing.Point(144, 190);
            this.nDexterity.Name = "nDexterity";
            this.nDexterity.Size = new System.Drawing.Size(155, 23);
            this.nDexterity.TabIndex = 4;
            // 
            // nConstitution
            // 
            this.nConstitution.Location = new System.Drawing.Point(144, 219);
            this.nConstitution.Name = "nConstitution";
            this.nConstitution.Size = new System.Drawing.Size(155, 23);
            this.nConstitution.TabIndex = 3;
            // 
            // nIntellicence
            // 
            this.nIntellicence.Location = new System.Drawing.Point(144, 248);
            this.nIntellicence.Name = "nIntellicence";
            this.nIntellicence.Size = new System.Drawing.Size(155, 23);
            this.nIntellicence.TabIndex = 2;
            // 
            // nStrenght
            // 
            this.nStrenght.Location = new System.Drawing.Point(144, 161);
            this.nStrenght.Name = "nStrenght";
            this.nStrenght.Size = new System.Drawing.Size(155, 23);
            this.nStrenght.TabIndex = 1;
            // 
            // heroBox
            // 
            this.heroBox.FormattingEnabled = true;
            this.heroBox.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard"});
            this.heroBox.Location = new System.Drawing.Point(12, 132);
            this.heroBox.Name = "heroBox";
            this.heroBox.Size = new System.Drawing.Size(287, 23);
            this.heroBox.TabIndex = 0;
            this.heroBox.SelectedIndexChanged += new System.EventHandler(this.heroBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 469);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nXp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nDexterity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nConstitution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIntellicence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStrenght)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button bCreate;
        private NumericUpDown nDexterity;
        private NumericUpDown nConstitution;
        private NumericUpDown nIntellicence;
        private NumericUpDown nStrenght;
        private ComboBox heroBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private ComboBox UserBox;
        private DataGridView dataGridView1;
        private Button bUpdate;
        private Button bAdd;
        private Button bLevelUP;
        private NumericUpDown nXp;
        private Label label6;
        private Label label7;
        private Button bGet1k;
        private Button bEquipment;
        private Button bFight;
        private CheckBox bBollVisible;
        private Label lCmd2;
        private Label lCmd3;
        private Label lCmd4;
        private Label lCmd1;
        private TextBox tArmor;
        private TextBox tMP;
        private TextBox tMAH;
        private TextBox tDamage;
        private Label lCmd5;
        private TextBox tHP;
    }
}