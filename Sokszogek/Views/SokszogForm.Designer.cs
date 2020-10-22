namespace Sokszogek.Views
{
    partial class SokszogForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.OldalBLabel = new System.Windows.Forms.Label();
            this.OldalATextBox = new System.Windows.Forms.TextBox();
            this.OldalBTextBox = new System.Windows.Forms.TextBox();
            this.KeruletTextBox = new System.Windows.Forms.TextBox();
            this.TeruletTextBox = new System.Windows.Forms.TextBox();
            this.CalcButton = new System.Windows.Forms.Button();
            this.SokszogListComboBox = new System.Windows.Forms.ComboBox();
            this.OldalAerrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.OldalBerrorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.OldalCTextBox = new System.Windows.Forms.TextBox();
            this.OldalCLabel = new System.Windows.Forms.Label();
            this.OldalCerrorP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.OldalAerrorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldalBerrorP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldalCerrorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sokszög";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kerület";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Terület";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 26);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Oldal A";
            // 
            // OldalBLabel
            // 
            this.OldalBLabel.AutoSize = true;
            this.OldalBLabel.Location = new System.Drawing.Point(205, 77);
            this.OldalBLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OldalBLabel.Name = "OldalBLabel";
            this.OldalBLabel.Size = new System.Drawing.Size(41, 13);
            this.OldalBLabel.TabIndex = 4;
            this.OldalBLabel.Text = "Oldal B";
            // 
            // OldalATextBox
            // 
            this.OldalATextBox.Location = new System.Drawing.Point(250, 26);
            this.OldalATextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OldalATextBox.Name = "OldalATextBox";
            this.OldalATextBox.Size = new System.Drawing.Size(113, 20);
            this.OldalATextBox.TabIndex = 5;
            // 
            // OldalBTextBox
            // 
            this.OldalBTextBox.Location = new System.Drawing.Point(250, 74);
            this.OldalBTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OldalBTextBox.Name = "OldalBTextBox";
            this.OldalBTextBox.Size = new System.Drawing.Size(113, 20);
            this.OldalBTextBox.TabIndex = 6;
            // 
            // KeruletTextBox
            // 
            this.KeruletTextBox.Location = new System.Drawing.Point(77, 74);
            this.KeruletTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.KeruletTextBox.Name = "KeruletTextBox";
            this.KeruletTextBox.Size = new System.Drawing.Size(113, 20);
            this.KeruletTextBox.TabIndex = 7;
            // 
            // TeruletTextBox
            // 
            this.TeruletTextBox.Location = new System.Drawing.Point(77, 121);
            this.TeruletTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.TeruletTextBox.Name = "TeruletTextBox";
            this.TeruletTextBox.Size = new System.Drawing.Size(113, 20);
            this.TeruletTextBox.TabIndex = 8;
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(29, 163);
            this.CalcButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(73, 23);
            this.CalcButton.TabIndex = 9;
            this.CalcButton.Text = "Kiszámol";
            this.CalcButton.UseVisualStyleBackColor = true;
            this.CalcButton.Click += new System.EventHandler(this.CalcButton_Click);
            // 
            // SokszogListComboBox
            // 
            this.SokszogListComboBox.FormattingEnabled = true;
            this.SokszogListComboBox.Location = new System.Drawing.Point(77, 26);
            this.SokszogListComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SokszogListComboBox.Name = "SokszogListComboBox";
            this.SokszogListComboBox.Size = new System.Drawing.Size(113, 21);
            this.SokszogListComboBox.TabIndex = 10;
            this.SokszogListComboBox.SelectedValueChanged += new System.EventHandler(this.SokszogListComboBox_SelectedValueChanged);
            // 
            // OldalAerrorP
            // 
            this.OldalAerrorP.ContainerControl = this;
            // 
            // OldalBerrorP
            // 
            this.OldalBerrorP.ContainerControl = this;
            // 
            // OldalCTextBox
            // 
            this.OldalCTextBox.Location = new System.Drawing.Point(250, 121);
            this.OldalCTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.OldalCTextBox.Name = "OldalCTextBox";
            this.OldalCTextBox.Size = new System.Drawing.Size(113, 20);
            this.OldalCTextBox.TabIndex = 11;
            // 
            // OldalCLabel
            // 
            this.OldalCLabel.AutoSize = true;
            this.OldalCLabel.Location = new System.Drawing.Point(205, 124);
            this.OldalCLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.OldalCLabel.Name = "OldalCLabel";
            this.OldalCLabel.Size = new System.Drawing.Size(41, 13);
            this.OldalCLabel.TabIndex = 12;
            this.OldalCLabel.Text = "Oldal C";
            // 
            // OldalCerrorP
            // 
            this.OldalCerrorP.ContainerControl = this;
            // 
            // SokszogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 205);
            this.Controls.Add(this.OldalCLabel);
            this.Controls.Add(this.OldalCTextBox);
            this.Controls.Add(this.SokszogListComboBox);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.TeruletTextBox);
            this.Controls.Add(this.KeruletTextBox);
            this.Controls.Add(this.OldalBTextBox);
            this.Controls.Add(this.OldalATextBox);
            this.Controls.Add(this.OldalBLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "SokszogForm";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.SokszogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OldalAerrorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldalBerrorP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OldalCerrorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label OldalBLabel;
        private System.Windows.Forms.TextBox OldalATextBox;
        private System.Windows.Forms.TextBox OldalBTextBox;
        private System.Windows.Forms.TextBox KeruletTextBox;
        private System.Windows.Forms.TextBox TeruletTextBox;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.ComboBox SokszogListComboBox;
        private System.Windows.Forms.ErrorProvider OldalAerrorP;
        private System.Windows.Forms.ErrorProvider OldalBerrorP;
        private System.Windows.Forms.Label OldalCLabel;
        private System.Windows.Forms.TextBox OldalCTextBox;
        private System.Windows.Forms.ErrorProvider OldalCerrorP;
    }
}