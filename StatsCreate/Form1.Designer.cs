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
            this.bCreate = new System.Windows.Forms.Button();
            this.nDexterity = new System.Windows.Forms.NumericUpDown();
            this.nConstitution = new System.Windows.Forms.NumericUpDown();
            this.nIntellicence = new System.Windows.Forms.NumericUpDown();
            this.nStrenght = new System.Windows.Forms.NumericUpDown();
            this.heroBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nDexterity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nConstitution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nIntellicence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nStrenght)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(12, 180);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(218, 57);
            this.bCreate.TabIndex = 5;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // nDexterity
            // 
            this.nDexterity.Location = new System.Drawing.Point(112, 87);
            this.nDexterity.Name = "nDexterity";
            this.nDexterity.Size = new System.Drawing.Size(118, 23);
            this.nDexterity.TabIndex = 4;
            // 
            // nConstitution
            // 
            this.nConstitution.Location = new System.Drawing.Point(112, 116);
            this.nConstitution.Name = "nConstitution";
            this.nConstitution.Size = new System.Drawing.Size(118, 23);
            this.nConstitution.TabIndex = 3;
            // 
            // nIntellicence
            // 
            this.nIntellicence.Location = new System.Drawing.Point(112, 145);
            this.nIntellicence.Name = "nIntellicence";
            this.nIntellicence.Size = new System.Drawing.Size(118, 23);
            this.nIntellicence.TabIndex = 2;
            // 
            // nStrenght
            // 
            this.nStrenght.Location = new System.Drawing.Point(112, 58);
            this.nStrenght.Name = "nStrenght";
            this.nStrenght.Size = new System.Drawing.Size(118, 23);
            this.nStrenght.TabIndex = 1;
            this.nStrenght.ValueChanged += new System.EventHandler(this.nStrenght_ValueChanged);
            // 
            // heroBox
            // 
            this.heroBox.FormattingEnabled = true;
            this.heroBox.Items.AddRange(new object[] {
            "Warrior",
            "Rogue",
            "Wizard"});
            this.heroBox.Location = new System.Drawing.Point(12, 12);
            this.heroBox.Name = "heroBox";
            this.heroBox.Size = new System.Drawing.Size(218, 23);
            this.heroBox.TabIndex = 0;
            this.heroBox.SelectedIndexChanged += new System.EventHandler(this.heroBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Strenght";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dexterity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Constitution";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Intellcence";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}