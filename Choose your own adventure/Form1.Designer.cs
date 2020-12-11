namespace Choose_your_own_adventure
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
            this.dbuttontext = new System.Windows.Forms.Label();
            this.abuttontext = new System.Windows.Forms.Label();
            this.outputtext = new System.Windows.Forms.Label();
            this.scenes = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.scenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dbuttontext
            // 
            this.dbuttontext.AutoSize = true;
            this.dbuttontext.Font = new System.Drawing.Font("mono 07_56", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbuttontext.ForeColor = System.Drawing.Color.White;
            this.dbuttontext.Location = new System.Drawing.Point(404, 382);
            this.dbuttontext.Name = "dbuttontext";
            this.dbuttontext.Size = new System.Drawing.Size(68, 18);
            this.dbuttontext.TabIndex = 0;
            this.dbuttontext.Text = "label1";
            // 
            // abuttontext
            // 
            this.abuttontext.AutoSize = true;
            this.abuttontext.Font = new System.Drawing.Font("mono 07_56", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abuttontext.ForeColor = System.Drawing.Color.White;
            this.abuttontext.Location = new System.Drawing.Point(66, 382);
            this.abuttontext.Name = "abuttontext";
            this.abuttontext.Size = new System.Drawing.Size(68, 18);
            this.abuttontext.TabIndex = 1;
            this.abuttontext.Text = "label2";
            // 
            // outputtext
            // 
            this.outputtext.AutoSize = true;
            this.outputtext.Font = new System.Drawing.Font("mono 07_56", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputtext.ForeColor = System.Drawing.Color.White;
            this.outputtext.Location = new System.Drawing.Point(51, 291);
            this.outputtext.Name = "outputtext";
            this.outputtext.Size = new System.Drawing.Size(68, 18);
            this.outputtext.TabIndex = 2;
            this.outputtext.Text = "label3";
            // 
            // scenes
            // 
            this.scenes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scenes.Location = new System.Drawing.Point(36, 30);
            this.scenes.Name = "scenes";
            this.scenes.Size = new System.Drawing.Size(555, 243);
            this.scenes.TabIndex = 3;
            this.scenes.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = global::Choose_your_own_adventure.Properties.Resources.red_button;
            this.pictureBox1.Location = new System.Drawing.Point(344, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Image = global::Choose_your_own_adventure.Properties.Resources.blue;
            this.pictureBox2.Location = new System.Drawing.Point(12, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(363, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(33, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "A";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.scenes);
            this.Controls.Add(this.outputtext);
            this.Controls.Add(this.abuttontext);
            this.Controls.Add(this.dbuttontext);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown_1);
            ((System.ComponentModel.ISupportInitialize)(this.scenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dbuttontext;
        private System.Windows.Forms.Label abuttontext;
        private System.Windows.Forms.Label outputtext;
        private System.Windows.Forms.PictureBox scenes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

