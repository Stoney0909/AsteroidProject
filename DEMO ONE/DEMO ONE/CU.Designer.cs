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
            this.minusProDamage = new System.Windows.Forms.Button();
            this.minusAmountOfPro = new System.Windows.Forms.Button();
            this.addHeatlh = new System.Windows.Forms.Button();
            this.addDamage = new System.Windows.Forms.Button();
            this.addAmountofPro = new System.Windows.Forms.Button();
            this.minusHealth = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minusProDamage
            // 
            this.minusProDamage.BackColor = System.Drawing.Color.Black;
            this.minusProDamage.ForeColor = System.Drawing.Color.White;
            this.minusProDamage.Location = new System.Drawing.Point(117, 259);
            this.minusProDamage.Name = "minusProDamage";
            this.minusProDamage.Size = new System.Drawing.Size(75, 23);
            this.minusProDamage.TabIndex = 1;
            this.minusProDamage.Text = "-";
            this.minusProDamage.UseVisualStyleBackColor = false;
            this.minusProDamage.Click += new System.EventHandler(this.minusProDamage_Click);
            // 
            // minusAmountOfPro
            // 
            this.minusAmountOfPro.BackColor = System.Drawing.Color.Black;
            this.minusAmountOfPro.ForeColor = System.Drawing.Color.White;
            this.minusAmountOfPro.Location = new System.Drawing.Point(117, 288);
            this.minusAmountOfPro.Name = "minusAmountOfPro";
            this.minusAmountOfPro.Size = new System.Drawing.Size(75, 23);
            this.minusAmountOfPro.TabIndex = 2;
            this.minusAmountOfPro.Text = "-";
            this.minusAmountOfPro.UseVisualStyleBackColor = false;
            this.minusAmountOfPro.Click += new System.EventHandler(this.minusAmountOfPro_Click);
            // 
            // addHeatlh
            // 
            this.addHeatlh.BackColor = System.Drawing.Color.Black;
            this.addHeatlh.ForeColor = System.Drawing.Color.White;
            this.addHeatlh.Location = new System.Drawing.Point(564, 201);
            this.addHeatlh.Name = "addHeatlh";
            this.addHeatlh.Size = new System.Drawing.Size(75, 23);
            this.addHeatlh.TabIndex = 3;
            this.addHeatlh.Text = "+";
            this.addHeatlh.UseVisualStyleBackColor = false;
            this.addHeatlh.Click += new System.EventHandler(this.addHeatlh_Click);
            // 
            // addDamage
            // 
            this.addDamage.BackColor = System.Drawing.Color.Black;
            this.addDamage.ForeColor = System.Drawing.Color.White;
            this.addDamage.Location = new System.Drawing.Point(564, 259);
            this.addDamage.Name = "addDamage";
            this.addDamage.Size = new System.Drawing.Size(75, 23);
            this.addDamage.TabIndex = 5;
            this.addDamage.Text = "+";
            this.addDamage.UseVisualStyleBackColor = false;
            this.addDamage.Click += new System.EventHandler(this.addDamage_Click);
            // 
            // addAmountofPro
            // 
            this.addAmountofPro.BackColor = System.Drawing.Color.Black;
            this.addAmountofPro.ForeColor = System.Drawing.Color.White;
            this.addAmountofPro.Location = new System.Drawing.Point(564, 288);
            this.addAmountofPro.Name = "addAmountofPro";
            this.addAmountofPro.Size = new System.Drawing.Size(75, 23);
            this.addAmountofPro.TabIndex = 6;
            this.addAmountofPro.Text = "+";
            this.addAmountofPro.UseVisualStyleBackColor = false;
            this.addAmountofPro.Click += new System.EventHandler(this.addAmountofPro_Click);
            // 
            // minusHealth
            // 
            this.minusHealth.BackColor = System.Drawing.Color.Black;
            this.minusHealth.ForeColor = System.Drawing.Color.White;
            this.minusHealth.Location = new System.Drawing.Point(117, 201);
            this.minusHealth.Name = "minusHealth";
            this.minusHealth.Size = new System.Drawing.Size(75, 23);
            this.minusHealth.TabIndex = 7;
            this.minusHealth.Text = "-";
            this.minusHealth.UseVisualStyleBackColor = false;
            this.minusHealth.Click += new System.EventHandler(this.minusHealth_Click);
            // 
            // CU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(807, 505);
            this.Controls.Add(this.minusHealth);
            this.Controls.Add(this.addAmountofPro);
            this.Controls.Add(this.addDamage);
            this.Controls.Add(this.addHeatlh);
            this.Controls.Add(this.minusAmountOfPro);
            this.Controls.Add(this.minusProDamage);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "CU";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button minusProDamage;
        private System.Windows.Forms.Button minusAmountOfPro;
        private System.Windows.Forms.Button addHeatlh;
        private System.Windows.Forms.Button addDamage;
        private System.Windows.Forms.Button addAmountofPro;
        private System.Windows.Forms.Button minusHealth;
    }
}