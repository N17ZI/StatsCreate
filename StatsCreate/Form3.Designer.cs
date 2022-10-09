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
            this.Sender = new System.Windows.Forms.ListBox();
            this.Receiver = new System.Windows.Forms.ListBox();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Sender
            // 
            this.Sender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sender.FormattingEnabled = true;
            this.Sender.ItemHeight = 28;
            this.Sender.Items.AddRange(new object[] {
            "Shiva",
            "Cuirass"});
            this.Sender.Location = new System.Drawing.Point(12, 12);
            this.Sender.Name = "Sender";
            this.Sender.Size = new System.Drawing.Size(348, 228);
            this.Sender.TabIndex = 0;
            this.Sender.Click += new System.EventHandler(this.Sender_Click);
            // 
            // Receiver
            // 
            this.Receiver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Receiver.FormattingEnabled = true;
            this.Receiver.ItemHeight = 28;
            this.Receiver.Location = new System.Drawing.Point(419, 12);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(369, 228);
            this.Receiver.TabIndex = 1;
            this.Receiver.Click += new System.EventHandler(this.Receiver_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(419, 263);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(369, 45);
            this.bSave.TabIndex = 2;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.Receiver);
            this.Controls.Add(this.Sender);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox Sender;
        private ListBox Receiver;
        private Button bSave;
    }
}