namespace WindowsFormsApplication1
{
    partial class HistoricalEvents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoricalEvents));
            this.circlebutton1 = new ClassLibrary1.Circlebutton();
            this.circlebutton2 = new ClassLibrary1.Circlebutton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // circlebutton1
            // 
            this.circlebutton1.BackColor = System.Drawing.Color.Transparent;
            this.circlebutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circlebutton1.BackgroundImage")));
            this.circlebutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circlebutton1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.circlebutton1.FlatAppearance.BorderSize = 0;
            this.circlebutton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circlebutton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circlebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circlebutton1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlebutton1.Location = new System.Drawing.Point(20, 16);
            this.circlebutton1.Name = "circlebutton1";
            this.circlebutton1.Size = new System.Drawing.Size(158, 61);
            this.circlebutton1.TabIndex = 1;
            this.circlebutton1.Text = "Home";
            this.circlebutton1.UseVisualStyleBackColor = false;
            // 
            // circlebutton2
            // 
            this.circlebutton2.BackColor = System.Drawing.Color.Transparent;
            this.circlebutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circlebutton2.BackgroundImage")));
            this.circlebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.circlebutton2.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.circlebutton2.FlatAppearance.BorderSize = 0;
            this.circlebutton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.circlebutton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.circlebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circlebutton2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circlebutton2.Location = new System.Drawing.Point(589, 16);
            this.circlebutton2.Name = "circlebutton2";
            this.circlebutton2.Size = new System.Drawing.Size(158, 61);
            this.circlebutton2.TabIndex = 2;
            this.circlebutton2.Text = "Next";
            this.circlebutton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.circlebutton1);
            this.panel1.Controls.Add(this.circlebutton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 89);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 307);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type of Calamity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Reference:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discription:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(517, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(466, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "xxxxxxxxxxxxxxxxxxxxxx";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "xxxxxxxxxxxxxxxxxxxxxxxxx";
            // 
            // HistoricalEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 469);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoricalEvents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HistoricalEvents";
            this.Load += new System.EventHandler(this.HistoricalEvents_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ClassLibrary1.Circlebutton circlebutton1;
        private ClassLibrary1.Circlebutton circlebutton2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}