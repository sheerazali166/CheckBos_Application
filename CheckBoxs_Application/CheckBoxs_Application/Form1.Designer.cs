namespace CheckBoxs_Application
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxCricket = new System.Windows.Forms.CheckBox();
            this.checkBoxHockey = new System.Windows.Forms.CheckBox();
            this.checkBoxFootball = new System.Windows.Forms.CheckBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(133, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(244, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hobbies:";
            // 
            // checkBoxCricket
            // 
            this.checkBoxCricket.AutoSize = true;
            this.checkBoxCricket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCricket.Location = new System.Drawing.Point(133, 108);
            this.checkBoxCricket.Name = "checkBoxCricket";
            this.checkBoxCricket.Size = new System.Drawing.Size(77, 24);
            this.checkBoxCricket.TabIndex = 2;
            this.checkBoxCricket.Text = "Cricket";
            this.checkBoxCricket.UseVisualStyleBackColor = true;
            // 
            // checkBoxHockey
            // 
            this.checkBoxHockey.AutoSize = true;
            this.checkBoxHockey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHockey.Location = new System.Drawing.Point(225, 108);
            this.checkBoxHockey.Name = "checkBoxHockey";
            this.checkBoxHockey.Size = new System.Drawing.Size(81, 24);
            this.checkBoxHockey.TabIndex = 2;
            this.checkBoxHockey.Text = "Hockey";
            this.checkBoxHockey.UseVisualStyleBackColor = true;
            // 
            // checkBoxFootball
            // 
            this.checkBoxFootball.AutoSize = true;
            this.checkBoxFootball.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFootball.Location = new System.Drawing.Point(325, 108);
            this.checkBoxFootball.Name = "checkBoxFootball";
            this.checkBoxFootball.Size = new System.Drawing.Size(85, 24);
            this.checkBoxFootball.TabIndex = 2;
            this.checkBoxFootball.Text = "Football";
            this.checkBoxFootball.UseVisualStyleBackColor = true;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(174, 164);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(113, 28);
            this.buttonSubmit.TabIndex = 3;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 334);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.checkBoxFootball);
            this.Controls.Add(this.checkBoxHockey);
            this.Controls.Add(this.checkBoxCricket);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxCricket;
        private System.Windows.Forms.CheckBox checkBoxHockey;
        private System.Windows.Forms.CheckBox checkBoxFootball;
        private System.Windows.Forms.Button buttonSubmit;
    }
}

