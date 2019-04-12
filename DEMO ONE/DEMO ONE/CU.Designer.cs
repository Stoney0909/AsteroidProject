namespace DEMO_ONe
{
    partial class CU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CU));
            this.minusShipSpeed = new System.Windows.Forms.Button();
            this.minusProDamage = new System.Windows.Forms.Button();
            this.minusAmountOfPro = new System.Windows.Forms.Button();
            this.addHeatlh = new System.Windows.Forms.Button();
            this.addSpeed = new System.Windows.Forms.Button();
            this.addDamage = new System.Windows.Forms.Button();
            this.addAmountofPro = new System.Windows.Forms.Button();
            this.minusHealth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minusShipSpeed
            // 
            this.minusShipSpeed.Location = new System.Drawing.Point(117, 230);
            this.minusShipSpeed.Name = "minusShipSpeed";
            this.minusShipSpeed.Size = new System.Drawing.Size(75, 23);
            this.minusShipSpeed.TabIndex = 0;
            this.minusShipSpeed.Text = "-";
            this.minusShipSpeed.UseVisualStyleBackColor = true;
            this.minusShipSpeed.Click += new System.EventHandler(this.minusShipSpeed_Click);
            // 
            // minusProDamage
            // 
            this.minusProDamage.Location = new System.Drawing.Point(117, 259);
            this.minusProDamage.Name = "minusProDamage";
            this.minusProDamage.Size = new System.Drawing.Size(75, 23);
            this.minusProDamage.TabIndex = 1;
            this.minusProDamage.Text = "-";
            this.minusProDamage.UseVisualStyleBackColor = true;
            this.minusProDamage.Click += new System.EventHandler(this.minusProDamage_Click);
            // 
            // minusAmountOfPro
            // 
            this.minusAmountOfPro.Location = new System.Drawing.Point(117, 288);
            this.minusAmountOfPro.Name = "minusAmountOfPro";
            this.minusAmountOfPro.Size = new System.Drawing.Size(75, 23);
            this.minusAmountOfPro.TabIndex = 2;
            this.minusAmountOfPro.Text = "-";
            this.minusAmountOfPro.UseVisualStyleBackColor = true;
            this.minusAmountOfPro.Click += new System.EventHandler(this.minusAmountOfPro_Click);
            // 
            // addHeatlh
            // 
            this.addHeatlh.Location = new System.Drawing.Point(564, 201);
            this.addHeatlh.Name = "addHeatlh";
            this.addHeatlh.Size = new System.Drawing.Size(75, 23);
            this.addHeatlh.TabIndex = 3;
            this.addHeatlh.Text = "+";
            this.addHeatlh.UseVisualStyleBackColor = true;
            this.addHeatlh.Click += new System.EventHandler(this.addHeatlh_Click);
            // 
            // addSpeed
            // 
            this.addSpeed.Location = new System.Drawing.Point(564, 230);
            this.addSpeed.Name = "addSpeed";
            this.addSpeed.Size = new System.Drawing.Size(75, 23);
            this.addSpeed.TabIndex = 4;
            this.addSpeed.Text = "+";
            this.addSpeed.UseVisualStyleBackColor = true;
            this.addSpeed.Click += new System.EventHandler(this.addSpeed_Click);
            // 
            // addDamage
            // 
            this.addDamage.Location = new System.Drawing.Point(564, 259);
            this.addDamage.Name = "addDamage";
            this.addDamage.Size = new System.Drawing.Size(75, 23);
            this.addDamage.TabIndex = 5;
            this.addDamage.Text = "+";
            this.addDamage.UseVisualStyleBackColor = true;
            this.addDamage.Click += new System.EventHandler(this.addDamage_Click);
            // 
            // addAmountofPro
            // 
            this.addAmountofPro.Location = new System.Drawing.Point(564, 288);
            this.addAmountofPro.Name = "addAmountofPro";
            this.addAmountofPro.Size = new System.Drawing.Size(75, 23);
            this.addAmountofPro.TabIndex = 6;
            this.addAmountofPro.Text = "+";
            this.addAmountofPro.UseVisualStyleBackColor = true;
            this.addAmountofPro.Click += new System.EventHandler(this.addAmountofPro_Click);
            // 
            // minusHealth
            // 
            this.minusHealth.Location = new System.Drawing.Point(117, 201);
            this.minusHealth.Name = "minusHealth";
            this.minusHealth.Size = new System.Drawing.Size(75, 23);
            this.minusHealth.TabIndex = 7;
            this.minusHealth.Text = "-";
            this.minusHealth.UseVisualStyleBackColor = true;
            this.minusHealth.Click += new System.EventHandler(this.minusHealth_Click);
            // 
            // CU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.minusHealth);
            this.Controls.Add(this.addAmountofPro);
            this.Controls.Add(this.addDamage);
            this.Controls.Add(this.addSpeed);
            this.Controls.Add(this.addHeatlh);
            this.Controls.Add(this.minusAmountOfPro);
            this.Controls.Add(this.minusProDamage);
            this.Controls.Add(this.minusShipSpeed);
            this.Name = "CU";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button minusShipSpeed;
        private System.Windows.Forms.Button minusProDamage;
        private System.Windows.Forms.Button minusAmountOfPro;
        private System.Windows.Forms.Button addHeatlh;
        private System.Windows.Forms.Button addSpeed;
        private System.Windows.Forms.Button addDamage;
        private System.Windows.Forms.Button addAmountofPro;
        private System.Windows.Forms.Button minusHealth;
    }
}