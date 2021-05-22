
namespace Static_graphics
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.X_trackBar = new System.Windows.Forms.TrackBar();
            this.Y_trackBar = new System.Windows.Forms.TrackBar();
            this.Whide_trackBar = new System.Windows.Forms.TrackBar();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Color_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whide_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(629, 440);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(662, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Тощина";
            // 
            // X_trackBar
            // 
            this.X_trackBar.Location = new System.Drawing.Point(662, 60);
            this.X_trackBar.Maximum = 6;
            this.X_trackBar.Name = "X_trackBar";
            this.X_trackBar.Size = new System.Drawing.Size(130, 56);
            this.X_trackBar.TabIndex = 4;
            this.X_trackBar.Scroll += new System.EventHandler(this.X_trackBar_Scroll);
            // 
            // Y_trackBar
            // 
            this.Y_trackBar.Location = new System.Drawing.Point(662, 143);
            this.Y_trackBar.Maximum = 4;
            this.Y_trackBar.Name = "Y_trackBar";
            this.Y_trackBar.Size = new System.Drawing.Size(130, 56);
            this.Y_trackBar.TabIndex = 5;
            this.Y_trackBar.Scroll += new System.EventHandler(this.Y_trackBar_Scroll);
            // 
            // Whide_trackBar
            // 
            this.Whide_trackBar.Location = new System.Drawing.Point(662, 229);
            this.Whide_trackBar.Minimum = 1;
            this.Whide_trackBar.Name = "Whide_trackBar";
            this.Whide_trackBar.Size = new System.Drawing.Size(130, 56);
            this.Whide_trackBar.TabIndex = 6;
            this.Whide_trackBar.Value = 1;
            this.Whide_trackBar.Scroll += new System.EventHandler(this.Whide_trackBar_Scroll);
            // 
            // Color_button
            // 
            this.Color_button.Location = new System.Drawing.Point(666, 301);
            this.Color_button.Name = "Color_button";
            this.Color_button.Size = new System.Drawing.Size(126, 25);
            this.Color_button.TabIndex = 7;
            this.Color_button.Text = "Изменить цвет";
            this.Color_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Color_button);
            this.Controls.Add(this.Whide_trackBar);
            this.Controls.Add(this.Y_trackBar);
            this.Controls.Add(this.X_trackBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whide_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar X_trackBar;
        private System.Windows.Forms.TrackBar Y_trackBar;
        private System.Windows.Forms.TrackBar Whide_trackBar;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Color_button;
    }
}

