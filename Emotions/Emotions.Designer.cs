namespace Emotions
{
    partial class frmEmotions
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
            this.btnHappy = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSad = new System.Windows.Forms.Button();
            this.btnScared = new System.Windows.Forms.Button();
            this.btnExcited = new System.Windows.Forms.Button();
            this.btnBored = new System.Windows.Forms.Button();
            this.btnTired = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHappy
            // 
            this.btnHappy.Location = new System.Drawing.Point(12, 56);
            this.btnHappy.Name = "btnHappy";
            this.btnHappy.Size = new System.Drawing.Size(75, 23);
            this.btnHappy.TabIndex = 0;
            this.btnHappy.Text = "Happy";
            this.btnHappy.UseVisualStyleBackColor = true;
            this.btnHappy.Click += new System.EventHandler(this.btnHappy_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(13, 13);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(107, 13);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "How are you feeling?";
            // 
            // btnSad
            // 
            this.btnSad.Location = new System.Drawing.Point(12, 104);
            this.btnSad.Name = "btnSad";
            this.btnSad.Size = new System.Drawing.Size(75, 23);
            this.btnSad.TabIndex = 2;
            this.btnSad.Text = "Sad";
            this.btnSad.UseVisualStyleBackColor = true;
            this.btnSad.Click += new System.EventHandler(this.btnSad_Click);
            // 
            // btnScared
            // 
            this.btnScared.Location = new System.Drawing.Point(12, 149);
            this.btnScared.Name = "btnScared";
            this.btnScared.Size = new System.Drawing.Size(75, 23);
            this.btnScared.TabIndex = 3;
            this.btnScared.Text = "Scared";
            this.btnScared.UseVisualStyleBackColor = true;
            this.btnScared.Click += new System.EventHandler(this.btnScared_Click);
            // 
            // btnExcited
            // 
            this.btnExcited.Location = new System.Drawing.Point(171, 56);
            this.btnExcited.Name = "btnExcited";
            this.btnExcited.Size = new System.Drawing.Size(75, 23);
            this.btnExcited.TabIndex = 4;
            this.btnExcited.Text = "Excited";
            this.btnExcited.UseVisualStyleBackColor = true;
            this.btnExcited.Click += new System.EventHandler(this.btnExcited_Click);
            // 
            // btnBored
            // 
            this.btnBored.Location = new System.Drawing.Point(171, 104);
            this.btnBored.Name = "btnBored";
            this.btnBored.Size = new System.Drawing.Size(75, 23);
            this.btnBored.TabIndex = 5;
            this.btnBored.Text = "Bored";
            this.btnBored.UseVisualStyleBackColor = true;
            this.btnBored.Click += new System.EventHandler(this.btnBored_Click);
            // 
            // btnTired
            // 
            this.btnTired.Location = new System.Drawing.Point(171, 149);
            this.btnTired.Name = "btnTired";
            this.btnTired.Size = new System.Drawing.Size(75, 23);
            this.btnTired.TabIndex = 6;
            this.btnTired.Text = "Tired";
            this.btnTired.UseVisualStyleBackColor = true;
            this.btnTired.Click += new System.EventHandler(this.btnTired_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(16, 196);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(9, 8);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmEmotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTired);
            this.Controls.Add(this.btnBored);
            this.Controls.Add(this.btnExcited);
            this.Controls.Add(this.btnScared);
            this.Controls.Add(this.btnSad);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnHappy);
            this.Name = "frmEmotions";
            this.Text = "Emotions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHappy;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSad;
        private System.Windows.Forms.Button btnScared;
        private System.Windows.Forms.Button btnExcited;
        private System.Windows.Forms.Button btnBored;
        private System.Windows.Forms.Button btnTired;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button button1;
    }
}

