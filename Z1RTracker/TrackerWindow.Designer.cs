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
            this.ArrowBlockPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.BombBlockPicture = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ArrowBlockPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombBlockPicture)).BeginInit();
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
            // ArrowBlockPicture
            // 
            this.ArrowBlockPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ArrowBlockPicture.ImageLocation = ".\\Images\\Blockers\\Arrow.gif";
            this.ArrowBlockPicture.Location = new System.Drawing.Point(37, 50);
            this.ArrowBlockPicture.Name = "ArrowBlockPicture";
            this.ArrowBlockPicture.Size = new System.Drawing.Size(52, 50);
            this.ArrowBlockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ArrowBlockPicture.TabIndex = 1;
            this.ArrowBlockPicture.TabStop = false;
            this.ArrowBlockPicture.Tag = DungeonBlockers.Arrow;
            this.ArrowBlockPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonBlockPictureMouseDown);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(37, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 53);
            this.button1.TabIndex = 2;
            this.button1.Tag = DungeonBlockers.Arrow;
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
            this.button2.Tag = DungeonBlockers.Arrow;
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
            this.button3.Tag = DungeonBlockers.Arrow;
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
            this.button4.Tag = DungeonBlockers.Arrow;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // BombBlockPicture
            // 
            this.BombBlockPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BombBlockPicture.ImageLocation = ".\\Images\\Blockers\\Bomb.gif";
            this.BombBlockPicture.Location = new System.Drawing.Point(107, 50);
            this.BombBlockPicture.Name = "BombBlockPicture";
            this.BombBlockPicture.Size = new System.Drawing.Size(52, 50);
            this.BombBlockPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BombBlockPicture.TabIndex = 1;
            this.BombBlockPicture.TabStop = false;
            this.BombBlockPicture.Tag = DungeonBlockers.Bomb;
            this.BombBlockPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonBlockPictureMouseDown);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(107, 122);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(52, 53);
            this.button5.TabIndex = 2;
            this.button5.Tag = DungeonBlockers.Bomb;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.Location = new System.Drawing.Point(107, 181);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(52, 53);
            this.button6.TabIndex = 2;
            this.button6.Tag = DungeonBlockers.Bomb;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button7.Location = new System.Drawing.Point(107, 240);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(52, 53);
            this.button7.TabIndex = 2;
            this.button7.Tag = DungeonBlockers.Bomb;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Triforce", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(107, 299);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(52, 53);
            this.button8.TabIndex = 2;
            this.button8.Tag = DungeonBlockers.Bomb;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HandleDungeonMouseDown);
            // 
            // TrackerWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BombBlockPicture);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ArrowBlockPicture);
            this.Controls.Add(this.label1);
            this.Name = "TrackerWindow";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ArrowBlockPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BombBlockPicture)).EndInit();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ArrowBlockPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox BombBlockPicture;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

