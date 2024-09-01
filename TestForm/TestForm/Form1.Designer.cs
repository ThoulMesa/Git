namespace TestForm
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
            this.txtFrom = new System.Windows.Forms.RichTextBox();
            this.txtTo = new System.Windows.Forms.RichTextBox();
            this.btnTranslate = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.cboTargetLangue = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.cboSourceLangue = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.SuspendLayout();
            // 
            // txtFrom
            // 
            this.txtFrom.BackColor = System.Drawing.Color.DarkGray;
            this.txtFrom.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrom.Location = new System.Drawing.Point(87, 75);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(405, 290);
            this.txtFrom.TabIndex = 0;
            this.txtFrom.Text = "Type in here...";
            // 
            // txtTo
            // 
            this.txtTo.BackColor = System.Drawing.Color.DarkGray;
            this.txtTo.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTo.Location = new System.Drawing.Point(542, 75);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(405, 290);
            this.txtTo.TabIndex = 1;
            this.txtTo.Text = "Translated Text...";
            // 
            // btnTranslate
            // 
            this.btnTranslate.BorderColor = System.Drawing.Color.MediumBlue;
            this.btnTranslate.BorderRadius = 12;
            this.btnTranslate.BorderThickness = 2;
            this.btnTranslate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTranslate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTranslate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTranslate.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnTranslate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTranslate.ForeColor = System.Drawing.Color.White;
            this.btnTranslate.Location = new System.Drawing.Point(428, 518);
            this.btnTranslate.Name = "btnTranslate";
            this.btnTranslate.Size = new System.Drawing.Size(180, 45);
            this.btnTranslate.TabIndex = 5;
            this.btnTranslate.Text = "Translate!";
            this.btnTranslate.TextTransform = Siticone.Desktop.UI.WinForms.Enums.TextTransform.UpperCase;
            this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
            // 
            // cboTargetLangue
            // 
            this.cboTargetLangue.BackColor = System.Drawing.Color.Transparent;
            this.cboTargetLangue.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.cboTargetLangue.BorderRadius = 4;
            this.cboTargetLangue.BorderThickness = 2;
            this.cboTargetLangue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTargetLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTargetLangue.FillColor = System.Drawing.Color.DimGray;
            this.cboTargetLangue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetLangue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTargetLangue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTargetLangue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTargetLangue.ItemHeight = 30;
            this.cboTargetLangue.Location = new System.Drawing.Point(592, 431);
            this.cboTargetLangue.Name = "cboTargetLangue";
            this.cboTargetLangue.Size = new System.Drawing.Size(140, 36);
            this.cboTargetLangue.TabIndex = 7;
            // 
            // cboSourceLangue
            // 
            this.cboSourceLangue.BackColor = System.Drawing.Color.Transparent;
            this.cboSourceLangue.BorderColor = System.Drawing.Color.DarkSlateBlue;
            this.cboSourceLangue.BorderRadius = 6;
            this.cboSourceLangue.BorderThickness = 2;
            this.cboSourceLangue.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboSourceLangue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSourceLangue.FillColor = System.Drawing.Color.DimGray;
            this.cboSourceLangue.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSourceLangue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboSourceLangue.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSourceLangue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboSourceLangue.ItemHeight = 30;
            this.cboSourceLangue.Location = new System.Drawing.Point(304, 431);
            this.cboSourceLangue.Name = "cboSourceLangue";
            this.cboSourceLangue.Size = new System.Drawing.Size(140, 36);
            this.cboSourceLangue.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1042, 641);
            this.Controls.Add(this.cboSourceLangue);
            this.Controls.Add(this.cboTargetLangue);
            this.Controls.Add(this.btnTranslate);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.txtFrom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtFrom;
        private System.Windows.Forms.RichTextBox txtTo;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnTranslate;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboTargetLangue;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox cboSourceLangue;
    }
}

