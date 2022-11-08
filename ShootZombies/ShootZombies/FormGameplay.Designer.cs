namespace ShootZombies
{
    partial class FormGameplay
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
            this.up = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Label();
            this.down = new System.Windows.Forms.Label();
            this.left = new System.Windows.Forms.Label();
            this.shoot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSoDong = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(209, 61);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(100, 23);
            this.up.TabIndex = 0;
            this.up.Text = "Move Up";
            this.up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right
            // 
            this.right.Location = new System.Drawing.Point(209, 112);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(100, 23);
            this.right.TabIndex = 1;
            this.right.Text = "Move Right";
            this.right.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(209, 174);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(100, 23);
            this.down.TabIndex = 2;
            this.down.Text = "Move Down";
            this.down.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // left
            // 
            this.left.Location = new System.Drawing.Point(209, 236);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(100, 23);
            this.left.TabIndex = 3;
            this.left.Text = "Move Left";
            this.left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shoot
            // 
            this.shoot.Location = new System.Drawing.Point(209, 301);
            this.shoot.Name = "shoot";
            this.shoot.Size = new System.Drawing.Size(100, 23);
            this.shoot.TabIndex = 4;
            this.shoot.Text = "Shoot";
            this.shoot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSoDong
            // 
            this.txtSoDong.Location = new System.Drawing.Point(375, 61);
            this.txtSoDong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoDong.Name = "txtSoDong";
            this.txtSoDong.Size = new System.Drawing.Size(63, 22);
            this.txtSoDong.TabIndex = 6;
            this.txtSoDong.Text = "Up";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(377, 302);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Space";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 236);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(63, 22);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Left";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(377, 175);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 22);
            this.textBox3.TabIndex = 9;
            this.textBox3.Text = "Down";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(375, 113);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 22);
            this.textBox4.TabIndex = 10;
            this.textBox4.Text = "Right";
            // 
            // FormGameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShootZombies.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSoDong);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shoot);
            this.Controls.Add(this.left);
            this.Controls.Add(this.down);
            this.Controls.Add(this.right);
            this.Controls.Add(this.up);
            this.Name = "FormGameplay";
            this.Text = "FormGameplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label up;
        private System.Windows.Forms.Label right;
        private System.Windows.Forms.Label down;
        private System.Windows.Forms.Label left;
        private System.Windows.Forms.Label shoot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtSoDong;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}