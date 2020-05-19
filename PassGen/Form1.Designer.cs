namespace PassGen
{
    partial class Form
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
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.gbType = new System.Windows.Forms.GroupBox();
            this.rbOnlyNumbers = new System.Windows.Forms.RadioButton();
            this.rbNumAndLett = new System.Windows.Forms.RadioButton();
            this.rbNumLettSpec = new System.Windows.Forms.RadioButton();
            this.lbList = new System.Windows.Forms.ListBox();
            this.butGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.gbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLength.Location = new System.Drawing.Point(25, 33);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(115, 20);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Długość hasła:";
            // 
            // numLength
            // 
            this.numLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numLength.Location = new System.Drawing.Point(142, 29);
            this.numLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 29);
            this.numLength.TabIndex = 1;
            this.numLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQuantity.Location = new System.Drawing.Point(414, 30);
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 29);
            this.numQuantity.TabIndex = 3;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblQuantity.Location = new System.Drawing.Point(310, 34);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(102, 20);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Liczba haseł:";
            // 
            // gbType
            // 
            this.gbType.Controls.Add(this.rbNumLettSpec);
            this.gbType.Controls.Add(this.rbNumAndLett);
            this.gbType.Controls.Add(this.rbOnlyNumbers);
            this.gbType.Location = new System.Drawing.Point(40, 115);
            this.gbType.Name = "gbType";
            this.gbType.Size = new System.Drawing.Size(255, 205);
            this.gbType.TabIndex = 4;
            this.gbType.TabStop = false;
            this.gbType.Text = "Typ hasła";
            // 
            // rbOnlyNumbers
            // 
            this.rbOnlyNumbers.AutoSize = true;
            this.rbOnlyNumbers.Location = new System.Drawing.Point(54, 40);
            this.rbOnlyNumbers.Name = "rbOnlyNumbers";
            this.rbOnlyNumbers.Size = new System.Drawing.Size(76, 17);
            this.rbOnlyNumbers.TabIndex = 0;
            this.rbOnlyNumbers.TabStop = true;
            this.rbOnlyNumbers.Text = "Tylko cyfry";
            this.rbOnlyNumbers.UseVisualStyleBackColor = true;
            // 
            // rbNumAndLett
            // 
            this.rbNumAndLett.AutoSize = true;
            this.rbNumAndLett.Location = new System.Drawing.Point(54, 94);
            this.rbNumAndLett.Name = "rbNumAndLett";
            this.rbNumAndLett.Size = new System.Drawing.Size(77, 17);
            this.rbNumAndLett.TabIndex = 1;
            this.rbNumAndLett.TabStop = true;
            this.rbNumAndLett.Text = "Cyfry i litery";
            this.rbNumAndLett.UseVisualStyleBackColor = true;
            // 
            // rbNumLettSpec
            // 
            this.rbNumLettSpec.AutoSize = true;
            this.rbNumLettSpec.Location = new System.Drawing.Point(54, 148);
            this.rbNumLettSpec.Name = "rbNumLettSpec";
            this.rbNumLettSpec.Size = new System.Drawing.Size(143, 17);
            this.rbNumLettSpec.TabIndex = 2;
            this.rbNumLettSpec.TabStop = true;
            this.rbNumLettSpec.Text = "Cyfry, litery, zn. specjalne";
            this.rbNumLettSpec.UseVisualStyleBackColor = true;
            // 
            // lbList
            // 
            this.lbList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 20;
            this.lbList.Location = new System.Drawing.Point(40, 346);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(494, 244);
            this.lbList.TabIndex = 5;
            this.lbList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.copyPass);
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(364, 181);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(152, 55);
            this.butGenerate.TabIndex = 6;
            this.butGenerate.Text = "Generuj";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(39, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "* zaznacz hasło aby zapisać do schowka";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butGenerate);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.gbType);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.numLength);
            this.Controls.Add(this.lblLength);
            this.Name = "Form";
            this.Text = "PasswordGen";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.gbType.ResumeLayout(false);
            this.gbType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.GroupBox gbType;
        private System.Windows.Forms.RadioButton rbNumLettSpec;
        private System.Windows.Forms.RadioButton rbNumAndLett;
        private System.Windows.Forms.RadioButton rbOnlyNumbers;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.Label label1;
    }
}

