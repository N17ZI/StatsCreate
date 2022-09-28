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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.Size = new System.Drawing.Size(994, 415);
            this.panel1.TabIndex = 0;
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(12, 65);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(287, 61);
            this.bUpdate.TabIndex = 14;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(340, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(603, 229);
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
            this.bCreate.Location = new System.Drawing.Point(12, 277);
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
            this.nDexterity.Size = new System.Drawing.Size(118, 23);
            this.nDexterity.TabIndex = 4;
            // 
            // nConstitution
            // 
            this.nConstitution.Location = new System.Drawing.Point(144, 219);
            this.nConstitution.Name = "nConstitution";
            this.nConstitution.Size = new System.Drawing.Size(118, 23);
            this.nConstitution.TabIndex = 3;
            // 
            // nIntellicence
            // 
            this.nIntellicence.Location = new System.Drawing.Point(144, 248);
            this.nIntellicence.Name = "nIntellicence";
            this.nIntellicence.Size = new System.Drawing.Size(118, 23);
            this.nIntellicence.TabIndex = 2;
            // 
            // nStrenght
            // 
            this.nStrenght.Location = new System.Drawing.Point(144, 161);
            this.nStrenght.Name = "nStrenght";
            this.nStrenght.Size = new System.Drawing.Size(118, 23);
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
            this.ClientSize = new System.Drawing.Size(994, 415);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}