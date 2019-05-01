namespace DEMO_ONe
{
    partial class CharacterUpgrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterUpgrade));
            this.continuebutton = new System.Windows.Forms.Button();
            this.addcoolDown = new System.Windows.Forms.Button();
            this.addhealth = new System.Windows.Forms.Button();
            this.ProTextBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.HealthTextBox = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // continuebutton
            // 
            this.continuebutton.BackColor = System.Drawing.Color.Black;
            this.continuebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuebutton.ForeColor = System.Drawing.Color.White;
            this.continuebutton.Location = new System.Drawing.Point(272, 298);
            this.continuebutton.Name = "continuebutton";
            this.continuebutton.Size = new System.Drawing.Size(144, 57);
            this.continuebutton.TabIndex = 2;
            this.continuebutton.Text = "Continue";
            this.continuebutton.UseVisualStyleBackColor = false;
            this.continuebutton.Click += new System.EventHandler(this.continuebutton_Click);
            // 
            // addcoolDown
            // 
            this.addcoolDown.BackColor = System.Drawing.Color.Black;
            this.addcoolDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcoolDown.ForeColor = System.Drawing.Color.White;
            this.addcoolDown.Location = new System.Drawing.Point(481, 187);
            this.addcoolDown.Name = "addcoolDown";
            this.addcoolDown.Size = new System.Drawing.Size(116, 57);
            this.addcoolDown.TabIndex = 3;
            this.addcoolDown.Text = "+";
            this.addcoolDown.UseVisualStyleBackColor = false;
            this.addcoolDown.Click += new System.EventHandler(this.addcoolDown_Click);
            // 
            // addhealth
            // 
            this.addhealth.BackColor = System.Drawing.Color.Black;
            this.addhealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addhealth.ForeColor = System.Drawing.Color.White;
            this.addhealth.Location = new System.Drawing.Point(481, 124);
            this.addhealth.Name = "addhealth";
            this.addhealth.Size = new System.Drawing.Size(116, 57);
            this.addhealth.TabIndex = 4;
            this.addhealth.Text = "+";
            this.addhealth.UseVisualStyleBackColor = false;
            this.addhealth.Click += new System.EventHandler(this.addhealth_Click);
            // 
            // ProTextBox
            // 
            this.ProTextBox.AutoSize = true;
            this.ProTextBox.BackColor = System.Drawing.Color.Black;
            this.ProTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProTextBox.ForeColor = System.Drawing.Color.White;
            this.ProTextBox.Location = new System.Drawing.Point(251, 189);
            this.ProTextBox.Name = "ProTextBox";
            this.ProTextBox.Size = new System.Drawing.Size(218, 46);
            this.ProTextBox.TabIndex = 7;
            this.ProTextBox.Text = "Cool Down";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(182, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(358, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Character Upgrade";
            // 
            // HealthTextBox
            // 
            this.HealthTextBox.AutoSize = true;
            this.HealthTextBox.BackColor = System.Drawing.Color.Black;
            this.HealthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthTextBox.ForeColor = System.Drawing.Color.White;
            this.HealthTextBox.Location = new System.Drawing.Point(251, 128);
            this.HealthTextBox.Name = "HealthTextBox";
            this.HealthTextBox.Size = new System.Drawing.Size(135, 46);
            this.HealthTextBox.TabIndex = 11;
            this.HealthTextBox.Text = "Health";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.Black;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.DarkRed;
            this.error.Location = new System.Drawing.Point(177, 387);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(335, 29);
            this.error.TabIndex = 12;
            this.error.Text = "You don\'t have enough money";
            this.error.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "300 per a Purchase";
            // 
            // CharacterUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.HealthTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProTextBox);
            this.Controls.Add(this.addhealth);
            this.Controls.Add(this.addcoolDown);
            this.Controls.Add(this.continuebutton);
            this.Name = "CharacterUpgrade";
            this.Text = "CharacterUpgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.Button addcoolDown;
        private System.Windows.Forms.Button addhealth;
        private System.Windows.Forms.Label ProTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label HealthTextBox;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Label label1;
    }
}