
namespace TestClientApp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelEnter = new System.Windows.Forms.Label();
            this.BTEnter = new System.Windows.Forms.Button();
            this.TBEnter = new System.Windows.Forms.TextBox();
            this.labelAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelEnter
            // 
            this.labelEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEnter.AutoSize = true;
            this.labelEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnter.ForeColor = System.Drawing.Color.Black;
            this.labelEnter.Location = new System.Drawing.Point(12, 20);
            this.labelEnter.Name = "labelEnter";
            this.labelEnter.Size = new System.Drawing.Size(144, 19);
            this.labelEnter.TabIndex = 0;
            this.labelEnter.Text = "Enter a message";
            // 
            // BTEnter
            // 
            this.BTEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTEnter.BackColor = System.Drawing.Color.Maroon;
            this.BTEnter.FlatAppearance.BorderSize = 0;
            this.BTEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTEnter.ForeColor = System.Drawing.Color.White;
            this.BTEnter.Location = new System.Drawing.Point(12, 111);
            this.BTEnter.Name = "BTEnter";
            this.BTEnter.Size = new System.Drawing.Size(187, 45);
            this.BTEnter.TabIndex = 1;
            this.BTEnter.Text = "Enter";
            this.BTEnter.UseVisualStyleBackColor = false;
            this.BTEnter.Click += new System.EventHandler(this.BTEnter_Click);
            // 
            // TBEnter
            // 
            this.TBEnter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBEnter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TBEnter.ForeColor = System.Drawing.Color.Black;
            this.TBEnter.Location = new System.Drawing.Point(12, 62);
            this.TBEnter.Name = "TBEnter";
            this.TBEnter.Size = new System.Drawing.Size(187, 26);
            this.TBEnter.TabIndex = 2;
            this.TBEnter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBEnter_KeyDown);
            // 
            // labelAnswer
            // 
            this.labelAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAnswer.AutoSize = true;
            this.labelAnswer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAnswer.ForeColor = System.Drawing.Color.Black;
            this.labelAnswer.Location = new System.Drawing.Point(12, 179);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(36, 19);
            this.labelAnswer.TabIndex = 3;
            this.labelAnswer.Text = "...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(216, 225);
            this.Controls.Add(this.labelAnswer);
            this.Controls.Add(this.TBEnter);
            this.Controls.Add(this.BTEnter);
            this.Controls.Add(this.labelEnter);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(232, 259);
            this.Name = "MainForm";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEnter;
        private System.Windows.Forms.Button BTEnter;
        private System.Windows.Forms.TextBox TBEnter;
        private System.Windows.Forms.Label labelAnswer;
    }
}

