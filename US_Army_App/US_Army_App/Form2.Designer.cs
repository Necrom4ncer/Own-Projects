namespace US_Army_App
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.soldiers_btn = new System.Windows.Forms.Button();
            this.weapons_btn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.deps_btn = new System.Windows.Forms.Button();
            this.ranks_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(0)))));
            this.listBox1.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(139, 85);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(442, 277);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(20)))), ((int)(((byte)(0)))));
            this.textBox1.Font = new System.Drawing.Font("Asus Rog", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(260, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 28);
            this.textBox1.TabIndex = 1;
            // 
            // soldiers_btn
            // 
            this.soldiers_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.soldiers_btn.Font = new System.Drawing.Font("Asus Rog", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soldiers_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.soldiers_btn.Location = new System.Drawing.Point(12, 389);
            this.soldiers_btn.Name = "soldiers_btn";
            this.soldiers_btn.Size = new System.Drawing.Size(131, 37);
            this.soldiers_btn.TabIndex = 2;
            this.soldiers_btn.Text = "Soldiers";
            this.soldiers_btn.UseVisualStyleBackColor = false;
            this.soldiers_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // weapons_btn
            // 
            this.weapons_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.weapons_btn.Font = new System.Drawing.Font("Asus Rog", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapons_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.weapons_btn.Location = new System.Drawing.Point(274, 389);
            this.weapons_btn.Name = "weapons_btn";
            this.weapons_btn.Size = new System.Drawing.Size(131, 37);
            this.weapons_btn.TabIndex = 3;
            this.weapons_btn.Text = "Weapons";
            this.weapons_btn.UseVisualStyleBackColor = false;
            this.weapons_btn.Click += new System.EventHandler(this.weapons_btn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.button3.Font = new System.Drawing.Font("Asus Rog", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(411, 389);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Comanders";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // deps_btn
            // 
            this.deps_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.deps_btn.Font = new System.Drawing.Font("Asus Rog", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deps_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.deps_btn.Location = new System.Drawing.Point(548, 389);
            this.deps_btn.Name = "deps_btn";
            this.deps_btn.Size = new System.Drawing.Size(160, 37);
            this.deps_btn.TabIndex = 5;
            this.deps_btn.Text = "Departments";
            this.deps_btn.UseVisualStyleBackColor = false;
            this.deps_btn.Click += new System.EventHandler(this.deps_btn_Click);
            // 
            // ranks_btn
            // 
            this.ranks_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(0)))));
            this.ranks_btn.Font = new System.Drawing.Font("Asus Rog", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranks_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ranks_btn.Location = new System.Drawing.Point(155, 389);
            this.ranks_btn.Name = "ranks_btn";
            this.ranks_btn.Size = new System.Drawing.Size(113, 37);
            this.ranks_btn.TabIndex = 6;
            this.ranks_btn.Text = "Ranks";
            this.ranks_btn.UseVisualStyleBackColor = false;
            this.ranks_btn.Click += new System.EventHandler(this.ranks_btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 447);
            this.Controls.Add(this.ranks_btn);
            this.Controls.Add(this.deps_btn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.weapons_btn);
            this.Controls.Add(this.soldiers_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button soldiers_btn;
        private System.Windows.Forms.Button weapons_btn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button deps_btn;
        private System.Windows.Forms.Button ranks_btn;
    }
}