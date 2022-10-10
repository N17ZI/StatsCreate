namespace StatsCreate
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Receiver = new System.Windows.Forms.ListBox();
            this.Sender = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bReset_Changes = new System.Windows.Forms.Button();
            this.bSave_Changes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Receiver
            // 
            this.Receiver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Receiver.FormattingEnabled = true;
            this.Receiver.ItemHeight = 28;
            this.Receiver.Location = new System.Drawing.Point(3, 3);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(390, 368);
            this.Receiver.TabIndex = 1;
            this.Receiver.Click += new System.EventHandler(this.Receiver_Click);
            this.Receiver.SelectedValueChanged += new System.EventHandler(this.Receiver_SelectedValueChanged);
            // 
            // Sender
            // 
            this.Sender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sender.FormattingEnabled = true;
            this.Sender.ItemHeight = 28;
            this.Sender.Items.AddRange(new object[] {
            "Epic Sword(Weapon)",
            "Lava Axe(Weapon)",
            "Shiva`s guard(Armor)",
            "Blade_Helmet(Helmet)"});
            this.Sender.Location = new System.Drawing.Point(3, 3);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(390, 368);
            this.Sender.TabIndex = 0;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.bReset_Changes);
            this.splitContainer1.Panel1.Controls.Add(this.Sender);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bSave_Changes);
            this.splitContainer1.Panel2.Controls.Add(this.Receiver);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 396;
            this.splitContainer1.TabIndex = 0;
            // 
            // bReset_Changes
            // 
            this.bReset_Changes.Location = new System.Drawing.Point(3, 375);
            this.bReset_Changes.Name = "bReset_Changes";
            this.bReset_Changes.Size = new System.Drawing.Size(390, 63);
            this.bReset_Changes.TabIndex = 3;
            this.bReset_Changes.Text = "Reset changes";
            this.bReset_Changes.UseVisualStyleBackColor = true;
            // 
            // bSave_Changes
            // 
            this.bSave_Changes.Location = new System.Drawing.Point(3, 375);
            this.bSave_Changes.Name = "bSave_Changes";
            this.bSave_Changes.Size = new System.Drawing.Size(390, 63);
            this.bSave_Changes.TabIndex = 2;
            this.bSave_Changes.Text = "Save changes";
            this.bSave_Changes.UseVisualStyleBackColor = true;
            this.bSave_Changes.Click += new System.EventHandler(this.bSave_Changes_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Receiver;
        private ListBox Sender;
        private SplitContainer splitContainer1;
        private Button bReset_Changes;
        private Button bSave_Changes;
    }
}