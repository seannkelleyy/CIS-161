namespace Chapter_3_lab_1
{
    partial class chapterThree
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
            this.friendLabel1 = new System.Windows.Forms.Label();
            this.friend1Textbox = new System.Windows.Forms.TextBox();
            this.friendLabel2 = new System.Windows.Forms.Label();
            this.friend2Textbox = new System.Windows.Forms.TextBox();
            this.compareButton = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // friendLabel1
            // 
            this.friendLabel1.AutoSize = true;
            this.friendLabel1.Location = new System.Drawing.Point(12, 23);
            this.friendLabel1.Name = "friendLabel1";
            this.friendLabel1.Size = new System.Drawing.Size(154, 15);
            this.friendLabel1.TabIndex = 0;
            this.friendLabel1.Text = "Enter your 1st friends name:";
            // 
            // friend1Textbox
            // 
            this.friend1Textbox.Location = new System.Drawing.Point(12, 41);
            this.friend1Textbox.Name = "friend1Textbox";
            this.friend1Textbox.Size = new System.Drawing.Size(154, 23);
            this.friend1Textbox.TabIndex = 1;
            // 
            // friendLabel2
            // 
            this.friendLabel2.AutoSize = true;
            this.friendLabel2.Location = new System.Drawing.Point(12, 88);
            this.friendLabel2.Name = "friendLabel2";
            this.friendLabel2.Size = new System.Drawing.Size(159, 15);
            this.friendLabel2.TabIndex = 2;
            this.friendLabel2.Text = "Enter your 2nd friends name:";
            // 
            // friend2Textbox
            // 
            this.friend2Textbox.Location = new System.Drawing.Point(12, 109);
            this.friend2Textbox.Name = "friend2Textbox";
            this.friend2Textbox.Size = new System.Drawing.Size(159, 23);
            this.friend2Textbox.TabIndex = 3;
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(12, 203);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(75, 23);
            this.compareButton.TabIndex = 4;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(12, 169);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 15);
            this.result.TabIndex = 5;
            // 
            // chapterThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.compareButton);
            this.Controls.Add(this.friend2Textbox);
            this.Controls.Add(this.friendLabel2);
            this.Controls.Add(this.friend1Textbox);
            this.Controls.Add(this.friendLabel1);
            this.Name = "chapterThree";
            this.Text = "Two Friends Interactive";
            this.Load += new System.EventHandler(this.chapterThree_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label friendLabel1;
        private TextBox friend1Textbox;
        private Label friendLabel2;
        private TextBox friend2Textbox;
        private Button compareButton;
        private Label result;

    }
}