namespace Assignment2
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
            this.leftlistbox = new System.Windows.Forms.ListBox();
            this.rightlistbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leftlistbox
            // 
            this.leftlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftlistbox.ForeColor = System.Drawing.Color.Teal;
            this.leftlistbox.FormattingEnabled = true;
            this.leftlistbox.ItemHeight = 16;
            this.leftlistbox.Items.AddRange(new object[] {
            "SWE 316",
            "SWE 344",
            "SWE 214",
            "ICS 381",
            "ICS 201"});
            this.leftlistbox.Location = new System.Drawing.Point(62, 63);
            this.leftlistbox.Name = "leftlistbox";
            this.leftlistbox.Size = new System.Drawing.Size(73, 116);
            this.leftlistbox.TabIndex = 0;
            // 
            // rightlistbox
            // 
            this.rightlistbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightlistbox.ForeColor = System.Drawing.Color.Teal;
            this.rightlistbox.FormattingEnabled = true;
            this.rightlistbox.ItemHeight = 16;
            this.rightlistbox.Location = new System.Drawing.Point(203, 63);
            this.rightlistbox.Name = "rightlistbox";
            this.rightlistbox.Size = new System.Drawing.Size(73, 116);
            this.rightlistbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Image = global::Assignment2.Properties.Resources.icons8_shutdown_30px;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(124, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "      Close";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::Assignment2.Properties.Resources.icons8_left_30px_1;
            this.label2.Location = new System.Drawing.Point(141, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "      ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::Assignment2.Properties.Resources.icons8_arrow_30px;
            this.label1.Location = new System.Drawing.Point(141, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "      ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(343, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rightlistbox);
            this.Controls.Add(this.leftlistbox);
            this.Name = "Form1";
            this.Text = "List Box APP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox leftlistbox;
        private System.Windows.Forms.ListBox rightlistbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

