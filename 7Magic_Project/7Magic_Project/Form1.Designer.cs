namespace _7Magic_Project
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
            this.sizeSelector = new System.Windows.Forms.NumericUpDown();
            this.initialize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sheet1 = new System.Windows.Forms.TextBox();
            this.sheet2 = new System.Windows.Forms.TextBox();
            this.holesSheet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.noHoles = new System.Windows.Forms.TextBox();
            this.rotateL = new System.Windows.Forms.Button();
            this.rotateR = new System.Windows.Forms.Button();
            this.flipH = new System.Windows.Forms.Button();
            this.flipV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // sizeSelector
            // 
            this.sizeSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.sizeSelector.Location = new System.Drawing.Point(104, 31);
            this.sizeSelector.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.sizeSelector.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.sizeSelector.Name = "sizeSelector";
            this.sizeSelector.Size = new System.Drawing.Size(56, 29);
            this.sizeSelector.TabIndex = 0;
            this.sizeSelector.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // initialize
            // 
            this.initialize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.initialize.Location = new System.Drawing.Point(212, 30);
            this.initialize.Name = "initialize";
            this.initialize.Size = new System.Drawing.Size(102, 33);
            this.initialize.TabIndex = 1;
            this.initialize.Text = "Initialize";
            this.initialize.UseVisualStyleBackColor = true;
            this.initialize.Click += new System.EventHandler(this.initialize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(52, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sheet#1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(224, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sheet#2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(399, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hole(s)";
            // 
            // sheet1
            // 
            this.sheet1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheet1.Location = new System.Drawing.Point(23, 121);
            this.sheet1.Multiline = true;
            this.sheet1.Name = "sheet1";
            this.sheet1.Size = new System.Drawing.Size(137, 152);
            this.sheet1.TabIndex = 6;
            // 
            // sheet2
            // 
            this.sheet2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sheet2.Location = new System.Drawing.Point(195, 121);
            this.sheet2.Multiline = true;
            this.sheet2.Name = "sheet2";
            this.sheet2.Size = new System.Drawing.Size(137, 152);
            this.sheet2.TabIndex = 7;
            // 
            // holesSheet
            // 
            this.holesSheet.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holesSheet.Location = new System.Drawing.Point(367, 121);
            this.holesSheet.Multiline = true;
            this.holesSheet.Name = "holesSheet";
            this.holesSheet.Size = new System.Drawing.Size(137, 152);
            this.holesSheet.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(144, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of holes";
            // 
            // noHoles
            // 
            this.noHoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.noHoles.Location = new System.Drawing.Point(319, 294);
            this.noHoles.Name = "noHoles";
            this.noHoles.Size = new System.Drawing.Size(79, 29);
            this.noHoles.TabIndex = 10;
            // 
            // rotateL
            // 
            this.rotateL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rotateL.Location = new System.Drawing.Point(23, 341);
            this.rotateL.Name = "rotateL";
            this.rotateL.Size = new System.Drawing.Size(102, 33);
            this.rotateL.TabIndex = 11;
            this.rotateL.Text = "Left";
            this.rotateL.UseVisualStyleBackColor = true;
            this.rotateL.Click += new System.EventHandler(this.rotateL_Click);
            // 
            // rotateR
            // 
            this.rotateR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.rotateR.Location = new System.Drawing.Point(148, 341);
            this.rotateR.Name = "rotateR";
            this.rotateR.Size = new System.Drawing.Size(102, 33);
            this.rotateR.TabIndex = 12;
            this.rotateR.Text = "Right";
            this.rotateR.UseVisualStyleBackColor = true;
            this.rotateR.Click += new System.EventHandler(this.rotateR_Click);
            // 
            // flipH
            // 
            this.flipH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.flipH.Location = new System.Drawing.Point(275, 341);
            this.flipH.Name = "flipH";
            this.flipH.Size = new System.Drawing.Size(102, 33);
            this.flipH.TabIndex = 13;
            this.flipH.Text = "Flip H";
            this.flipH.UseVisualStyleBackColor = true;
            this.flipH.Click += new System.EventHandler(this.flipH_Click);
            // 
            // flipV
            // 
            this.flipV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.flipV.Location = new System.Drawing.Point(402, 341);
            this.flipV.Name = "flipV";
            this.flipV.Size = new System.Drawing.Size(102, 33);
            this.flipV.TabIndex = 14;
            this.flipV.Text = "Flip V";
            this.flipV.UseVisualStyleBackColor = true;
            this.flipV.Click += new System.EventHandler(this.flipV_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 399);
            this.Controls.Add(this.flipV);
            this.Controls.Add(this.flipH);
            this.Controls.Add(this.rotateR);
            this.Controls.Add(this.rotateL);
            this.Controls.Add(this.noHoles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.holesSheet);
            this.Controls.Add(this.sheet2);
            this.Controls.Add(this.sheet1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.initialize);
            this.Controls.Add(this.sizeSelector);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "7 Magic -- STD02 (Jenwich Rattanayenjai)";
            ((System.ComponentModel.ISupportInitialize)(this.sizeSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown sizeSelector;
        private System.Windows.Forms.Button initialize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sheet1;
        private System.Windows.Forms.TextBox sheet2;
        private System.Windows.Forms.TextBox holesSheet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox noHoles;
        private System.Windows.Forms.Button rotateL;
        private System.Windows.Forms.Button rotateR;
        private System.Windows.Forms.Button flipH;
        private System.Windows.Forms.Button flipV;
    }
}

