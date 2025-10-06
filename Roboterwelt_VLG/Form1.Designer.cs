namespace Roboterwelt_VLG
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
            this.button1 = new System.Windows.Forms.Button();
            this.button_schritt = new System.Windows.Forms.Button();
            this.button_linksdrehen = new System.Windows.Forms.Button();
            this.button_rechtsdrehen = new System.Windows.Forms.Button();
            this.button_umdrehen = new System.Windows.Forms.Button();
            this.button_aufheben = new System.Windows.Forms.Button();
            this.button_ablegen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 16);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "ausführen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_schritt
            // 
            this.button_schritt.Location = new System.Drawing.Point(63, 71);
            this.button_schritt.Name = "button_schritt";
            this.button_schritt.Size = new System.Drawing.Size(50, 50);
            this.button_schritt.TabIndex = 1;
            this.button_schritt.Text = "🠝";
            this.button_schritt.UseVisualStyleBackColor = true;
            this.button_schritt.Click += new System.EventHandler(this.button_schritt_Click);
            // 
            // button_linksdrehen
            // 
            this.button_linksdrehen.Location = new System.Drawing.Point(7, 72);
            this.button_linksdrehen.Name = "button_linksdrehen";
            this.button_linksdrehen.Size = new System.Drawing.Size(50, 50);
            this.button_linksdrehen.TabIndex = 2;
            this.button_linksdrehen.Text = "⭯";
            this.button_linksdrehen.UseVisualStyleBackColor = true;
            this.button_linksdrehen.Click += new System.EventHandler(this.button_linksdrehen_Click);
            // 
            // button_rechtsdrehen
            // 
            this.button_rechtsdrehen.Location = new System.Drawing.Point(119, 71);
            this.button_rechtsdrehen.Name = "button_rechtsdrehen";
            this.button_rechtsdrehen.Size = new System.Drawing.Size(50, 50);
            this.button_rechtsdrehen.TabIndex = 3;
            this.button_rechtsdrehen.Text = "⭮";
            this.button_rechtsdrehen.UseVisualStyleBackColor = true;
            this.button_rechtsdrehen.Click += new System.EventHandler(this.button_rechtsdrehen_Click);
            // 
            // button_umdrehen
            // 
            this.button_umdrehen.Location = new System.Drawing.Point(7, 127);
            this.button_umdrehen.Name = "button_umdrehen";
            this.button_umdrehen.Size = new System.Drawing.Size(50, 50);
            this.button_umdrehen.TabIndex = 4;
            this.button_umdrehen.Text = "⮏";
            this.button_umdrehen.UseVisualStyleBackColor = true;
            this.button_umdrehen.Click += new System.EventHandler(this.button_umdrehen_Click);
            // 
            // button_aufheben
            // 
            this.button_aufheben.Location = new System.Drawing.Point(63, 127);
            this.button_aufheben.Name = "button_aufheben";
            this.button_aufheben.Size = new System.Drawing.Size(50, 50);
            this.button_aufheben.TabIndex = 5;
            this.button_aufheben.Text = "⭱";
            this.button_aufheben.UseVisualStyleBackColor = true;
            this.button_aufheben.Click += new System.EventHandler(this.button_aufheben_Click);
            // 
            // button_ablegen
            // 
            this.button_ablegen.Location = new System.Drawing.Point(119, 127);
            this.button_ablegen.Name = "button_ablegen";
            this.button_ablegen.Size = new System.Drawing.Size(50, 50);
            this.button_ablegen.TabIndex = 6;
            this.button_ablegen.Text = "⭳";
            this.button_ablegen.UseVisualStyleBackColor = true;
            this.button_ablegen.Click += new System.EventHandler(this.button_ablegen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button_ablegen);
            this.groupBox1.Controls.Add(this.button_schritt);
            this.groupBox1.Controls.Add(this.button_aufheben);
            this.groupBox1.Controls.Add(this.button_linksdrehen);
            this.groupBox1.Controls.Add(this.button_umdrehen);
            this.groupBox1.Controls.Add(this.button_rechtsdrehen);
            this.groupBox1.Location = new System.Drawing.Point(713, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Roboterwelt";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_schritt;
        private System.Windows.Forms.Button button_linksdrehen;
        private System.Windows.Forms.Button button_rechtsdrehen;
        private System.Windows.Forms.Button button_umdrehen;
        private System.Windows.Forms.Button button_aufheben;
        private System.Windows.Forms.Button button_ablegen;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}