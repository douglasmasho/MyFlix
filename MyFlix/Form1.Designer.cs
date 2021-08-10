
namespace MyFlix
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(273, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "MYFLIX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Product Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(317, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pick a movie";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Items.AddRange(new object[] {
            "Dirk Gently\'s Hollistic Detective Agency",
            "Parks And Recreation",
            "Living with yourself",
            "The Office",
            "Community",
            "Great News"});
            this.listBox2.Location = new System.Drawing.Point(294, 159);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox2.Size = new System.Drawing.Size(171, 104);
            this.listBox2.TabIndex = 2;
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Red;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalc.Location = new System.Drawing.Point(286, 330);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(179, 49);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Let\'s flix n chill";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblCost
            // 
            this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Product Sans", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblCost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCost.Location = new System.Drawing.Point(614, 450);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(137, 41);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "The cost";
            this.lblCost.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblSelected.AutoSize = true;
            this.lblSelected.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSelected.Font = new System.Drawing.Font("Product Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSelected.Location = new System.Drawing.Point(39, 450);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(59, 25);
            this.lblSelected.TabIndex = 6;
            this.lblSelected.Text = "Myflix";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(891, 612);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Myflix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSelected;
    }
}

