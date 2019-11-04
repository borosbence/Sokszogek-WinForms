namespace Sokszogek_MVP
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxKerulet = new System.Windows.Forms.TextBox();
            this.textBoxTerulet = new System.Windows.Forms.TextBox();
            this.comboBoxSokszog = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOldalC = new System.Windows.Forms.Label();
            this.textBoxOldalA = new System.Windows.Forms.TextBox();
            this.textBoxOldalB = new System.Windows.Forms.TextBox();
            this.textBoxOldalC = new System.Windows.Forms.TextBox();
            this.buttonSzamol = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sokszögek";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kerület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Terület";
            // 
            // textBoxKerulet
            // 
            this.textBoxKerulet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxKerulet.Location = new System.Drawing.Point(73, 36);
            this.textBoxKerulet.Name = "textBoxKerulet";
            this.textBoxKerulet.ReadOnly = true;
            this.textBoxKerulet.Size = new System.Drawing.Size(120, 20);
            this.textBoxKerulet.TabIndex = 3;
            // 
            // textBoxTerulet
            // 
            this.textBoxTerulet.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxTerulet.Location = new System.Drawing.Point(73, 69);
            this.textBoxTerulet.Name = "textBoxTerulet";
            this.textBoxTerulet.ReadOnly = true;
            this.textBoxTerulet.Size = new System.Drawing.Size(120, 20);
            this.textBoxTerulet.TabIndex = 4;
            // 
            // comboBoxSokszog
            // 
            this.comboBoxSokszog.FormattingEnabled = true;
            this.comboBoxSokszog.Location = new System.Drawing.Point(73, 3);
            this.comboBoxSokszog.Name = "comboBoxSokszog";
            this.comboBoxSokszog.Size = new System.Drawing.Size(120, 21);
            this.comboBoxSokszog.TabIndex = 5;
            this.comboBoxSokszog.SelectedIndexChanged += new System.EventHandler(this.comboBoxSokszog_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.59184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.40816F));
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelOldalC, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalA, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalB, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOldalC, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(218, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Oldal A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Oldal B:";
            // 
            // labelOldalC
            // 
            this.labelOldalC.AutoSize = true;
            this.labelOldalC.Location = new System.Drawing.Point(3, 66);
            this.labelOldalC.Name = "labelOldalC";
            this.labelOldalC.Size = new System.Drawing.Size(44, 13);
            this.labelOldalC.TabIndex = 2;
            this.labelOldalC.Text = "Oldal C:";
            // 
            // textBoxOldalA
            // 
            this.textBoxOldalA.Location = new System.Drawing.Point(62, 3);
            this.textBoxOldalA.Name = "textBoxOldalA";
            this.textBoxOldalA.Size = new System.Drawing.Size(120, 20);
            this.textBoxOldalA.TabIndex = 3;
            // 
            // textBoxOldalB
            // 
            this.textBoxOldalB.Location = new System.Drawing.Point(62, 36);
            this.textBoxOldalB.Name = "textBoxOldalB";
            this.textBoxOldalB.Size = new System.Drawing.Size(120, 20);
            this.textBoxOldalB.TabIndex = 4;
            // 
            // textBoxOldalC
            // 
            this.textBoxOldalC.Location = new System.Drawing.Point(62, 69);
            this.textBoxOldalC.Name = "textBoxOldalC";
            this.textBoxOldalC.Size = new System.Drawing.Size(120, 20);
            this.textBoxOldalC.TabIndex = 5;
            // 
            // buttonSzamol
            // 
            this.buttonSzamol.Location = new System.Drawing.Point(12, 118);
            this.buttonSzamol.Name = "buttonSzamol";
            this.buttonSzamol.Size = new System.Drawing.Size(75, 23);
            this.buttonSzamol.TabIndex = 2;
            this.buttonSzamol.Text = "Kiszámol";
            this.buttonSzamol.UseVisualStyleBackColor = true;
            this.buttonSzamol.Click += new System.EventHandler(this.buttonSzamol_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel3.Controls.Add(this.textBoxTerulet, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBoxKerulet, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxSokszog, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 151);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.buttonSzamol);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxKerulet;
        private System.Windows.Forms.TextBox textBoxTerulet;
        private System.Windows.Forms.ComboBox comboBoxSokszog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelOldalC;
        private System.Windows.Forms.TextBox textBoxOldalA;
        private System.Windows.Forms.TextBox textBoxOldalB;
        private System.Windows.Forms.TextBox textBoxOldalC;
        private System.Windows.Forms.Button buttonSzamol;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}

