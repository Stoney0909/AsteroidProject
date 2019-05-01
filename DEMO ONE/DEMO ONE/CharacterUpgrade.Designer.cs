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
            this.minusHealth = new System.Windows.Forms.Button();
            this.continuebutton = new System.Windows.Forms.Button();
            this.addcoolDown = new System.Windows.Forms.Button();
            this.addhealth = new System.Windows.Forms.Button();
            this.minusAmountofPro = new System.Windows.Forms.Button();
            this.HealthTextBox = new System.Windows.Forms.Label();
            this.ProTextBox = new System.Windows.Forms.Label();
            this.totalmoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minusHealth
            // 
            this.minusHealth.BackColor = System.Drawing.Color.Black;
            this.minusHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusHealth.ForeColor = System.Drawing.Color.White;
            this.minusHealth.Location = new System.Drawing.Point(95, 124);
            this.minusHealth.Name = "minusHealth";
            this.minusHealth.Size = new System.Drawing.Size(116, 57);
            this.minusHealth.TabIndex = 0;
            this.minusHealth.Text = "-";
            this.minusHealth.UseVisualStyleBackColor = false;
            this.minusHealth.Click += new System.EventHandler(this.minusHealth_Click);
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
            this.addcoolDown.Location = new System.Drawing.Point(460, 187);
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
            this.addhealth.Location = new System.Drawing.Point(460, 124);
            this.addhealth.Name = "addhealth";
            this.addhealth.Size = new System.Drawing.Size(116, 57);
            this.addhealth.TabIndex = 4;
            this.addhealth.Text = "+";
            this.addhealth.UseVisualStyleBackColor = false;
            this.addhealth.Click += new System.EventHandler(this.addhealth_Click);
            // 
            // minusAmountofPro
            // 
            this.minusAmountofPro.BackColor = System.Drawing.Color.Black;
            this.minusAmountofPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusAmountofPro.ForeColor = System.Drawing.Color.White;
            this.minusAmountofPro.Location = new System.Drawing.Point(95, 187);
            this.minusAmountofPro.Name = "minusAmountofPro";
            this.minusAmountofPro.Size = new System.Drawing.Size(116, 57);
            this.minusAmountofPro.TabIndex = 5;
            this.minusAmountofPro.Text = "-";
            this.minusAmountofPro.UseVisualStyleBackColor = false;
            this.minusAmountofPro.Click += new System.EventHandler(this.minusAmountofPro_Click);
            // 
            // HealthTextBox
            // 
            this.HealthTextBox.AutoSize = true;
            this.HealthTextBox.Location = new System.Drawing.Point(309, 140);
            this.HealthTextBox.Name = "HealthTextBox";
            this.HealthTextBox.Size = new System.Drawing.Size(47, 17);
            this.HealthTextBox.TabIndex = 6;
            this.HealthTextBox.Text = "health";
            // 
            // ProTextBox
            // 
            this.ProTextBox.AutoSize = true;
            this.ProTextBox.Location = new System.Drawing.Point(319, 213);
            this.ProTextBox.Name = "ProTextBox";
            this.ProTextBox.Size = new System.Drawing.Size(71, 17);
            this.ProTextBox.TabIndex = 7;
            this.ProTextBox.Text = "CoolDown";
            // 
            // totalmoney
            // 
            this.totalmoney.AutoSize = true;
            this.totalmoney.Location = new System.Drawing.Point(190, 59);
            this.totalmoney.Name = "totalmoney";
            this.totalmoney.Size = new System.Drawing.Size(50, 17);
            this.totalmoney.TabIndex = 8;
            this.totalmoney.Text = "money";
            // 
            // CharacterUpgrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalmoney);
            this.Controls.Add(this.ProTextBox);
            this.Controls.Add(this.HealthTextBox);
            this.Controls.Add(this.minusAmountofPro);
            this.Controls.Add(this.addhealth);
            this.Controls.Add(this.addcoolDown);
            this.Controls.Add(this.continuebutton);
            this.Controls.Add(this.minusHealth);
            this.Name = "CharacterUpgrade";
            this.Text = "CharacterUpgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minusHealth;
        private System.Windows.Forms.Button continuebutton;
        private System.Windows.Forms.Button addcoolDown;
        private System.Windows.Forms.Button addhealth;
        private System.Windows.Forms.Button minusAmountofPro;
        private System.Windows.Forms.Label HealthTextBox;
        private System.Windows.Forms.Label ProTextBox;
        private System.Windows.Forms.Label totalmoney;
    }
}