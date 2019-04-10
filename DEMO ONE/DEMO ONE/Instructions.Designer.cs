namespace DEMO_ONe
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.label1 = new System.Windows.Forms.Label();
            this.obj_controls = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Castellar", 55.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 113);
            this.label1.TabIndex = 2;
            this.label1.Text = "INSTRUCTIONS";
            // 
            // obj_controls
            // 
            this.obj_controls.BackColor = System.Drawing.SystemColors.HighlightText;
            this.obj_controls.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.obj_controls.FormattingEnabled = true;
            this.obj_controls.ItemHeight = 22;
            this.obj_controls.Items.AddRange(new object[] {
            "Objective: You are the pilot of a spaceship in outerspace, ",
            "",
            "with one main mission: survive. Waves of asteroids will swarm",
            "",
            "your ship, and you must defend against them. As you progress,",
            "",
            "a boss will spawn, a beefy, strong enemy you must defeat before",
            "",
            "moving on.",
            "",
            "Controls: Use w, a, s, d keys to move the spaceship in the directions respective " +
                "to",
            "",
            "the locations on the keyboard.",
            "",
            "Use your mouse to rotate the ship and left click to fire the laser cannon."});
            this.obj_controls.Location = new System.Drawing.Point(190, 183);
            this.obj_controls.Name = "obj_controls";
            this.obj_controls.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.obj_controls.Size = new System.Drawing.Size(662, 356);
            this.obj_controls.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(377, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 60);
            this.button1.TabIndex = 4;
            this.button1.Text = "Main Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Castellar", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(377, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(281, 60);
            this.button2.TabIndex = 5;
            this.button2.Text = "the top ten";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 728);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.obj_controls);
            this.Controls.Add(this.label1);
            this.Name = "Instructions";
            this.Text = "Instructions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox obj_controls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}