namespace Z1RTracker
{
    partial class TrackerWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.BlockArrow = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BlockArrow)).BeginInit();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Triforce", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dungeon Blocks";
            // 
            // BlockArrow
            // 
            this.BlockArrow.ImageLocation = ".\\Images\\Blockers\\Arrow.gif";
            this.BlockArrow.Location = new System.Drawing.Point(37, 50);
            this.BlockArrow.Name = "BlockArrow";
            this.BlockArrow.Size = new System.Drawing.Size(52, 50);
            this.BlockArrow.TabIndex = 1;
            this.BlockArrow.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 53);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // TrackerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BlockArrow);
            this.Controls.Add(this.label1);
            this.Name = "TrackerWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BlockArrow)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BlockArrow;
        private System.Windows.Forms.Button button1;
    }
}

