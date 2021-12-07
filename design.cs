namespace NSCmusical
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
            this.label1 = new System.Windows.Forms.Label();
            this.key0 = new System.Windows.Forms.Button();
            this.key1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.key2 = new System.Windows.Forms.Button();
            this.key4 = new System.Windows.Forms.Button();
            this.key6 = new System.Windows.Forms.Button();
            this.key8 = new System.Windows.Forms.Button();
            this.key3 = new System.Windows.Forms.Button();
            this.key5 = new System.Windows.Forms.Button();
            this.key7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Seagull", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(348, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Musical Synthesizer";
            // 
            // key0
            // 
            this.key0.Location = new System.Drawing.Point(-1, 252);
            this.key0.Name = "key0";
            this.key0.Size = new System.Drawing.Size(47, 296);
            this.key0.TabIndex = 1;
            this.key0.Text = "0";
            this.key0.UseVisualStyleBackColor = true;
            this.key0.Click += new System.EventHandler(this.key0_Click);
            // 
            // key1
            // 
            this.key1.BackColor = System.Drawing.Color.Black;
            this.key1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key1.ForeColor = System.Drawing.Color.White;
            this.key1.Location = new System.Drawing.Point(46, 252);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(17, 260);
            this.key1.TabIndex = 2;
            this.key1.Text = "1";
            this.key1.UseVisualStyleBackColor = false;
            this.key1.Click += new System.EventHandler(this.key1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(112)))), ((int)(((byte)(20)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(467, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // key2
            // 
            this.key2.Location = new System.Drawing.Point(59, 252);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(47, 296);
            this.key2.TabIndex = 4;
            this.key2.Text = "2";
            this.key2.UseVisualStyleBackColor = true;
            this.key2.Click += new System.EventHandler(this.key2_Click);
            // 
            // key4
            // 
            this.key4.Location = new System.Drawing.Point(121, 252);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(47, 296);
            this.key4.TabIndex = 5;
            this.key4.Text = "4";
            this.key4.UseVisualStyleBackColor = true;
            this.key4.Click += new System.EventHandler(this.key4_Click);
            // 
            // key6
            // 
            this.key6.Location = new System.Drawing.Point(185, 252);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(47, 296);
            this.key6.TabIndex = 6;
            this.key6.Text = "6";
            this.key6.UseVisualStyleBackColor = true;
            this.key6.Click += new System.EventHandler(this.key6_Click);
            // 
            // key8
            // 
            this.key8.Location = new System.Drawing.Point(247, 252);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(47, 296);
            this.key8.TabIndex = 7;
            this.key8.Text = "8";
            this.key8.UseVisualStyleBackColor = true;
            this.key8.Click += new System.EventHandler(this.key8_Click);
            // 
            // key3
            // 
            this.key3.BackColor = System.Drawing.Color.Black;
            this.key3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key3.ForeColor = System.Drawing.Color.White;
            this.key3.Location = new System.Drawing.Point(104, 253);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(17, 260);
            this.key3.TabIndex = 8;
            this.key3.Text = "3";
            this.key3.UseVisualStyleBackColor = false;
            this.key3.Click += new System.EventHandler(this.key3_Click);
            // 
            // key5
            // 
            this.key5.BackColor = System.Drawing.Color.Black;
            this.key5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key5.ForeColor = System.Drawing.Color.White;
            this.key5.Location = new System.Drawing.Point(169, 252);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(17, 260);
            this.key5.TabIndex = 9;
            this.key5.Text = "5";
            this.key5.UseVisualStyleBackColor = false;
            this.key5.Click += new System.EventHandler(this.key5_Click);
            // 
            // key7
            // 
            this.key7.BackColor = System.Drawing.Color.Black;
            this.key7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.key7.ForeColor = System.Drawing.Color.White;
            this.key7.Location = new System.Drawing.Point(233, 252);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(17, 260);
            this.key7.TabIndex = 10;
            this.key7.Text = "7";
            this.key7.UseVisualStyleBackColor = false;
            this.key7.Click += new System.EventHandler(this.key7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1143, 539);
            this.Controls.Add(this.key7);
            this.Controls.Add(this.key5);
            this.Controls.Add(this.key3);
            this.Controls.Add(this.key8);
            this.Controls.Add(this.key6);
            this.Controls.Add(this.key4);
            this.Controls.Add(this.key2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.key1);
            this.Controls.Add(this.key0);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button key0;
        private Button key1;
        private Button button1;
        private Button key2;
        private Button key4;
        private Button key6;
        private Button key8;
        private Button key3;
        private Button key5;
        private Button key7;
    }
}
