namespace CIS_161_Lab_3._2_Kelley
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.hourPayLabel = new System.Windows.Forms.Label();
            this.hourPayBox = new System.Windows.Forms.TextBox();
            this.weeklyPayLabel = new System.Windows.Forms.Label();
            this.weeklyPayBox = new System.Windows.Forms.TextBox();
            this.grossPay = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.stateTax = new System.Windows.Forms.Label();
            this.federalTax = new System.Windows.Forms.Label();
            this.netPay = new System.Windows.Forms.Label();
            this.gross = new System.Windows.Forms.Label();
            this.state = new System.Windows.Forms.Label();
            this.federal = new System.Windows.Forms.Label();
            this.net = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.LightGray;
            this.nameLabel.Location = new System.Drawing.Point(23, 19);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(42, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(23, 50);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(117, 23);
            this.nameBox.TabIndex = 1;
            // 
            // idLabel2
            // 
            this.idLabel2.AutoSize = true;
            this.idLabel2.Location = new System.Drawing.Point(184, 19);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(68, 15);
            this.idLabel2.TabIndex = 2;
            this.idLabel2.Text = "ID Number:";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(184, 50);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(117, 23);
            this.idBox.TabIndex = 3;
            // 
            // hourPayLabel
            // 
            this.hourPayLabel.AutoSize = true;
            this.hourPayLabel.Location = new System.Drawing.Point(23, 117);
            this.hourPayLabel.Name = "hourPayLabel";
            this.hourPayLabel.Size = new System.Drawing.Size(68, 15);
            this.hourPayLabel.TabIndex = 4;
            this.hourPayLabel.Text = "Hourly Pay:";
            // 
            // hourPayBox
            // 
            this.hourPayBox.Location = new System.Drawing.Point(23, 158);
            this.hourPayBox.Name = "hourPayBox";
            this.hourPayBox.Size = new System.Drawing.Size(117, 23);
            this.hourPayBox.TabIndex = 5;
            // 
            // weeklyPayLabel
            // 
            this.weeklyPayLabel.AutoSize = true;
            this.weeklyPayLabel.Location = new System.Drawing.Point(184, 117);
            this.weeklyPayLabel.Name = "weeklyPayLabel";
            this.weeklyPayLabel.Size = new System.Drawing.Size(86, 15);
            this.weeklyPayLabel.TabIndex = 6;
            this.weeklyPayLabel.Text = "Hours Worked:";
            this.weeklyPayLabel.Click += new System.EventHandler(this.weeklyPayLabel_Click);
            // 
            // weeklyPayBox
            // 
            this.weeklyPayBox.Location = new System.Drawing.Point(184, 158);
            this.weeklyPayBox.Name = "weeklyPayBox";
            this.weeklyPayBox.Size = new System.Drawing.Size(117, 23);
            this.weeklyPayBox.TabIndex = 7;
            // 
            // grossPay
            // 
            this.grossPay.AutoSize = true;
            this.grossPay.Location = new System.Drawing.Point(23, 221);
            this.grossPay.Name = "grossPay";
            this.grossPay.Size = new System.Drawing.Size(61, 15);
            this.grossPay.TabIndex = 8;
            this.grossPay.Text = "Gross Pay:";
            // 
            // calculateButton
            // 
            this.calculateButton.AutoSize = true;
            this.calculateButton.Location = new System.Drawing.Point(23, 378);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 25);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // stateTax
            // 
            this.stateTax.AutoSize = true;
            this.stateTax.Location = new System.Drawing.Point(23, 265);
            this.stateTax.Name = "stateTax";
            this.stateTax.Size = new System.Drawing.Size(55, 15);
            this.stateTax.TabIndex = 10;
            this.stateTax.Text = "State tax:";
            // 
            // federalTax
            // 
            this.federalTax.AutoSize = true;
            this.federalTax.Location = new System.Drawing.Point(23, 304);
            this.federalTax.Name = "federalTax";
            this.federalTax.Size = new System.Drawing.Size(68, 15);
            this.federalTax.TabIndex = 11;
            this.federalTax.Text = "Federal Tax:";
            // 
            // netPay
            // 
            this.netPay.AutoSize = true;
            this.netPay.Location = new System.Drawing.Point(23, 339);
            this.netPay.Name = "netPay";
            this.netPay.Size = new System.Drawing.Size(51, 15);
            this.netPay.TabIndex = 12;
            this.netPay.Text = "Net Pay:";
            // 
            // gross
            // 
            this.gross.AutoSize = true;
            this.gross.Location = new System.Drawing.Point(184, 221);
            this.gross.Name = "gross";
            this.gross.Size = new System.Drawing.Size(0, 15);
            this.gross.TabIndex = 13;
            this.gross.Click += new System.EventHandler(this.gross_Click);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(184, 265);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(0, 15);
            this.state.TabIndex = 14;
            // 
            // federal
            // 
            this.federal.AutoSize = true;
            this.federal.Location = new System.Drawing.Point(184, 304);
            this.federal.Name = "federal";
            this.federal.Size = new System.Drawing.Size(0, 15);
            this.federal.TabIndex = 15;
            // 
            // net
            // 
            this.net.AutoSize = true;
            this.net.Location = new System.Drawing.Point(184, 339);
            this.net.Name = "net";
            this.net.Size = new System.Drawing.Size(0, 15);
            this.net.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.net);
            this.Controls.Add(this.federal);
            this.Controls.Add(this.state);
            this.Controls.Add(this.gross);
            this.Controls.Add(this.netPay);
            this.Controls.Add(this.federalTax);
            this.Controls.Add(this.stateTax);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.grossPay);
            this.Controls.Add(this.weeklyPayBox);
            this.Controls.Add(this.weeklyPayLabel);
            this.Controls.Add(this.hourPayBox);
            this.Controls.Add(this.hourPayLabel);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.idLabel2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label nameLabel;
        private TextBox nameBox;
        private Label idLabel2;
        private TextBox idBox;
        private Label hourPayLabel;
        private TextBox hourPayBox;
        private Label weeklyPayLabel;
        private TextBox weeklyPayBox;
        private Label grossPay;
        private Button calculateButton;
        private Label stateTax;
        private Label federalTax;
        private Label netPay;
        private Label gross;
        private Label state;
        private Label federal;
        private Label net;
    }
}