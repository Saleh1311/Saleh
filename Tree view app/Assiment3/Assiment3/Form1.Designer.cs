namespace Assiment3
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
            this.tree = new System.Windows.Forms.TreeView();
            this.addn = new System.Windows.Forms.Label();
            this.addc = new System.Windows.Forms.Label();
            this.removen = new System.Windows.Forms.Label();
            this.deletet = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tree
            // 
            this.tree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tree.Location = new System.Drawing.Point(12, 12);
            this.tree.Name = "tree";
            this.tree.Size = new System.Drawing.Size(157, 284);
            this.tree.TabIndex = 0;
            // 
            // addn
            // 
            this.addn.AutoSize = true;
            this.addn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addn.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addn.ForeColor = System.Drawing.SystemColors.Control;
            this.addn.Image = global::Assiment3.Properties.Resources.icons8_add_30px;
            this.addn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addn.Location = new System.Drawing.Point(-2, 0);
            this.addn.MinimumSize = new System.Drawing.Size(174, 34);
            this.addn.Name = "addn";
            this.addn.Size = new System.Drawing.Size(174, 34);
            this.addn.TabIndex = 1;
            this.addn.Text = "Add Nodes ";
            this.addn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addn.Click += new System.EventHandler(this.addn_Click);
            this.addn.MouseLeave += new System.EventHandler(this.Lave);
            this.addn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Move);
            // 
            // addc
            // 
            this.addc.AutoSize = true;
            this.addc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addc.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addc.ForeColor = System.Drawing.SystemColors.Control;
            this.addc.Image = global::Assiment3.Properties.Resources.icons8_add_30px;
            this.addc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addc.Location = new System.Drawing.Point(0, 0);
            this.addc.MinimumSize = new System.Drawing.Size(174, 34);
            this.addc.Name = "addc";
            this.addc.Size = new System.Drawing.Size(174, 34);
            this.addc.TabIndex = 4;
            this.addc.Text = "Add Child Nodes ";
            this.addc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addc.Click += new System.EventHandler(this.addc_Click);
            this.addc.MouseLeave += new System.EventHandler(this.l2);
            this.addc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m2);
            // 
            // removen
            // 
            this.removen.AutoSize = true;
            this.removen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removen.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removen.ForeColor = System.Drawing.SystemColors.Control;
            this.removen.Image = global::Assiment3.Properties.Resources.icons8_remove_30px;
            this.removen.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.removen.Location = new System.Drawing.Point(-1, 0);
            this.removen.MinimumSize = new System.Drawing.Size(174, 34);
            this.removen.Name = "removen";
            this.removen.Size = new System.Drawing.Size(174, 34);
            this.removen.TabIndex = 5;
            this.removen.Text = "Remove Nodes ";
            this.removen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.removen.Click += new System.EventHandler(this.removen_Click);
            this.removen.MouseLeave += new System.EventHandler(this.l3);
            this.removen.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m3);
            // 
            // deletet
            // 
            this.deletet.AutoSize = true;
            this.deletet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletet.Font = new System.Drawing.Font("OCR A Extended", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletet.ForeColor = System.Drawing.SystemColors.Control;
            this.deletet.Image = global::Assiment3.Properties.Resources.icons8_remove_30px;
            this.deletet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletet.Location = new System.Drawing.Point(-1, -1);
            this.deletet.MinimumSize = new System.Drawing.Size(174, 34);
            this.deletet.Name = "deletet";
            this.deletet.Size = new System.Drawing.Size(174, 34);
            this.deletet.TabIndex = 6;
            this.deletet.Text = "Delete Tree";
            this.deletet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletet.Click += new System.EventHandler(this.deletet_Click);
            this.deletet.MouseLeave += new System.EventHandler(this.l4);
            this.deletet.MouseMove += new System.Windows.Forms.MouseEventHandler(this.m4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.addn);
            this.panel1.Location = new System.Drawing.Point(176, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 34);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OrangeRed;
            this.panel2.Controls.Add(this.addc);
            this.panel2.Location = new System.Drawing.Point(175, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 34);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OrangeRed;
            this.panel3.Controls.Add(this.removen);
            this.panel3.Location = new System.Drawing.Point(176, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 34);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.OrangeRed;
            this.panel4.Controls.Add(this.deletet);
            this.panel4.Location = new System.Drawing.Point(176, 156);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 34);
            this.panel4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(362, 308);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tree);
            this.Name = "Form1";
            this.Text = "TreeView APP";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.Label addn;
        private System.Windows.Forms.Label addc;
        private System.Windows.Forms.Label removen;
        private System.Windows.Forms.Label deletet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}

