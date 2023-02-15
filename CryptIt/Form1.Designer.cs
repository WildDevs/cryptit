namespace CryptIt
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lb_crypt = new System.Windows.Forms.Label();
            this.lb_it = new System.Windows.Forms.Label();
            this.lb_hrtop = new System.Windows.Forms.Label();
            this.lb_hrbot = new System.Windows.Forms.Label();
            this.lb_credits = new System.Windows.Forms.Label();
            this.num_cryptkey = new System.Windows.Forms.NumericUpDown();
            this.tb_input = new System.Windows.Forms.TextBox();
            this.tb_output = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.lb_output = new System.Windows.Forms.Label();
            this.lb_input = new System.Windows.Forms.Label();
            this.lb_cryptkey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_cryptkey)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_crypt
            // 
            this.lb_crypt.AutoSize = true;
            this.lb_crypt.Font = new System.Drawing.Font("Copperplate Gothic Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_crypt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lb_crypt.Location = new System.Drawing.Point(243, -3);
            this.lb_crypt.Name = "lb_crypt";
            this.lb_crypt.Size = new System.Drawing.Size(128, 38);
            this.lb_crypt.TabIndex = 0;
            this.lb_crypt.Text = "Crypt";
            // 
            // lb_it
            // 
            this.lb_it.AutoSize = true;
            this.lb_it.Font = new System.Drawing.Font("Copperplate Gothic Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_it.Location = new System.Drawing.Point(365, -3);
            this.lb_it.Name = "lb_it";
            this.lb_it.Size = new System.Drawing.Size(45, 38);
            this.lb_it.TabIndex = 1;
            this.lb_it.Text = "it";
            // 
            // lb_hrtop
            // 
            this.lb_hrtop.AutoSize = true;
            this.lb_hrtop.ForeColor = System.Drawing.Color.Silver;
            this.lb_hrtop.Location = new System.Drawing.Point(-94, 28);
            this.lb_hrtop.Name = "lb_hrtop";
            this.lb_hrtop.Size = new System.Drawing.Size(799, 13);
            this.lb_hrtop.TabIndex = 2;
            this.lb_hrtop.Text = "_________________________________________________________________________________" +
    "___________________________________________________";
            // 
            // lb_hrbot
            // 
            this.lb_hrbot.AutoSize = true;
            this.lb_hrbot.ForeColor = System.Drawing.Color.Silver;
            this.lb_hrbot.Location = new System.Drawing.Point(-72, 290);
            this.lb_hrbot.Name = "lb_hrbot";
            this.lb_hrbot.Size = new System.Drawing.Size(799, 13);
            this.lb_hrbot.TabIndex = 3;
            this.lb_hrbot.Text = "_________________________________________________________________________________" +
    "___________________________________________________";
            // 
            // lb_credits
            // 
            this.lb_credits.AutoSize = true;
            this.lb_credits.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_credits.ForeColor = System.Drawing.Color.Gray;
            this.lb_credits.Location = new System.Drawing.Point(7, 305);
            this.lb_credits.Name = "lb_credits";
            this.lb_credits.Size = new System.Drawing.Size(630, 15);
            this.lb_credits.TabIndex = 4;
            this.lb_credits.Text = "Crypt it, v0.1 (15.05.2016), einfache Caesar Verschlüsselung, entwickelt von Ray-" +
    "works.de";
            // 
            // num_cryptkey
            // 
            this.num_cryptkey.Location = new System.Drawing.Point(593, 44);
            this.num_cryptkey.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.num_cryptkey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_cryptkey.Name = "num_cryptkey";
            this.num_cryptkey.Size = new System.Drawing.Size(44, 20);
            this.num_cryptkey.TabIndex = 5;
            this.num_cryptkey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(7, 70);
            this.tb_input.Multiline = true;
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(497, 89);
            this.tb_input.TabIndex = 6;
            // 
            // tb_output
            // 
            this.tb_output.Location = new System.Drawing.Point(7, 178);
            this.tb_output.Multiline = true;
            this.tb_output.Name = "tb_output";
            this.tb_output.ReadOnly = true;
            this.tb_output.Size = new System.Drawing.Size(623, 89);
            this.tb_output.TabIndex = 7;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_encrypt.Location = new System.Drawing.Point(510, 70);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(123, 42);
            this.btn_encrypt.TabIndex = 8;
            this.btn_encrypt.Text = "Verschlüsseln";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_decrypt.Location = new System.Drawing.Point(510, 117);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(123, 42);
            this.btn_decrypt.TabIndex = 9;
            this.btn_decrypt.Text = "Entschlüsseln";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_copy.Location = new System.Drawing.Point(465, 272);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(165, 23);
            this.btn_copy.TabIndex = 10;
            this.btn_copy.Text = "Text in Eingabefeld kopieren";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // lb_output
            // 
            this.lb_output.AutoSize = true;
            this.lb_output.Location = new System.Drawing.Point(7, 162);
            this.lb_output.Name = "lb_output";
            this.lb_output.Size = new System.Drawing.Size(49, 13);
            this.lb_output.TabIndex = 11;
            this.lb_output.Text = "Ausgabe";
            // 
            // lb_input
            // 
            this.lb_input.AutoSize = true;
            this.lb_input.Location = new System.Drawing.Point(4, 54);
            this.lb_input.Name = "lb_input";
            this.lb_input.Size = new System.Drawing.Size(46, 13);
            this.lb_input.TabIndex = 12;
            this.lb_input.Text = "Eingabe";
            // 
            // lb_cryptkey
            // 
            this.lb_cryptkey.AutoSize = true;
            this.lb_cryptkey.Location = new System.Drawing.Point(478, 47);
            this.lb_cryptkey.Name = "lb_cryptkey";
            this.lb_cryptkey.Size = new System.Drawing.Size(109, 13);
            this.lb_cryptkey.TabIndex = 13;
            this.lb_cryptkey.Text = "Verschlüsselungswert";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(642, 324);
            this.Controls.Add(this.lb_cryptkey);
            this.Controls.Add(this.lb_input);
            this.Controls.Add(this.lb_output);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.tb_output);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.num_cryptkey);
            this.Controls.Add(this.lb_credits);
            this.Controls.Add(this.lb_hrbot);
            this.Controls.Add(this.lb_hrtop);
            this.Controls.Add(this.lb_it);
            this.Controls.Add(this.lb_crypt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crypt it - by Ray-works.de";
            ((System.ComponentModel.ISupportInitialize)(this.num_cryptkey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_crypt;
        private System.Windows.Forms.Label lb_it;
        private System.Windows.Forms.Label lb_hrtop;
        private System.Windows.Forms.Label lb_hrbot;
        private System.Windows.Forms.Label lb_credits;
        private System.Windows.Forms.NumericUpDown num_cryptkey;
        private System.Windows.Forms.TextBox tb_input;
        private System.Windows.Forms.TextBox tb_output;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label lb_output;
        private System.Windows.Forms.Label lb_input;
        private System.Windows.Forms.Label lb_cryptkey;
    }
}

