namespace Assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reuslt = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.mult = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.mod = new System.Windows.Forms.Button();
            this.eq = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label1.Location = new System.Drawing.Point(41, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firsr Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label2.Location = new System.Drawing.Point(3, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Secound Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label3.Location = new System.Drawing.Point(176, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // reuslt
            // 
            this.reuslt.AutoSize = true;
            this.reuslt.BackColor = System.Drawing.Color.Transparent;
            this.reuslt.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reuslt.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.reuslt.Location = new System.Drawing.Point(186, 417);
            this.reuslt.Name = "reuslt";
            this.reuslt.Size = new System.Drawing.Size(0, 36);
            this.reuslt.TabIndex = 3;
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input1.Location = new System.Drawing.Point(192, 113);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(118, 26);
            this.input1.TabIndex = 4;
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input2.Location = new System.Drawing.Point(192, 209);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(118, 26);
            this.input2.TabIndex = 5;
            // 
            // mult
            // 
            this.mult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mult.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult.ForeColor = System.Drawing.Color.Transparent;
            this.mult.Location = new System.Drawing.Point(256, 145);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(58, 26);
            this.mult.TabIndex = 6;
            this.mult.Text = "x";
            this.mult.UseVisualStyleBackColor = false;
            this.mult.Click += new System.EventHandler(this.mult_Click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.ForeColor = System.Drawing.Color.Transparent;
            this.sub.Location = new System.Drawing.Point(192, 145);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(58, 26);
            this.sub.TabIndex = 7;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.Transparent;
            this.add.Location = new System.Drawing.Point(256, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(58, 26);
            this.add.TabIndex = 8;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.div.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.ForeColor = System.Drawing.Color.Transparent;
            this.div.Location = new System.Drawing.Point(192, 177);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(58, 26);
            this.div.TabIndex = 9;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.div_Click);
            // 
            // mod
            // 
            this.mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.mod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mod.ForeColor = System.Drawing.Color.Transparent;
            this.mod.Location = new System.Drawing.Point(320, 177);
            this.mod.Name = "mod";
            this.mod.Size = new System.Drawing.Size(58, 26);
            this.mod.TabIndex = 10;
            this.mod.Text = "%";
            this.mod.UseVisualStyleBackColor = false;
            this.mod.Click += new System.EventHandler(this.mod_Click);
            // 
            // eq
            // 
            this.eq.BackColor = System.Drawing.Color.Blue;
            this.eq.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eq.ForeColor = System.Drawing.Color.Transparent;
            this.eq.Location = new System.Drawing.Point(192, 241);
            this.eq.Name = "eq";
            this.eq.Size = new System.Drawing.Size(58, 26);
            this.eq.TabIndex = 11;
            this.eq.Text = "=";
            this.eq.UseVisualStyleBackColor = false;
            this.eq.Click += new System.EventHandler(this.eq_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 35);
            this.panel1.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.label5.Location = new System.Drawing.Point(133, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 27);
            this.label5.TabIndex = 13;
            this.label5.Text = "Simpul Calcuator";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Blue;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.Transparent;
            this.clear.Location = new System.Drawing.Point(256, 241);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(58, 26);
            this.clear.TabIndex = 13;
            this.clear.Text = "CLEAR";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(432, 482);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.eq);
            this.Controls.Add(this.mod);
            this.Controls.Add(this.div);
            this.Controls.Add(this.add);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.reuslt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcuator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label reuslt;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button mod;
        private System.Windows.Forms.Button eq;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button clear;
    }
}

