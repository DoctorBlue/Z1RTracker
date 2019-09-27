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
            this.ArrowBlock = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowBlock)).BeginInit();
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
            // ArrowBlock
            // 
            this.ArrowBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrowBlock.ImageLocation = ".\\Images\\Blockers\\Arrow.gif";
            this.ArrowBlock.Location = new System.Drawing.Point(37, 50);
            this.ArrowBlock.Name = "ArrowBlock";
            this.ArrowBlock.Size = new System.Drawing.Size(52, 50);
            this.ArrowBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ArrowBlock.TabIndex = 1;
            this.ArrowBlock.TabStop = false;
            this.ArrowBlock.Tag = "Arrow";
            this.ArrowBlock.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonBlockerClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 53);
            this.button1.TabIndex = 2;
            this.button1.Tag = "Arrow";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(37, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 53);
            this.button2.TabIndex = 2;
            this.button2.Tag = "Arrow";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(37, 240);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(52, 53);
            this.button3.TabIndex = 2;
            this.button3.Tag = "Arrow";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(37, 299);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(52, 53);
            this.button4.TabIndex = 2;
            this.button4.Tag = "Arrow";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // TrackerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArrowBlock);
            this.Controls.Add(this.label1);
            this.Name = "TrackerWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ArrowBlock)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ArrowBlock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

