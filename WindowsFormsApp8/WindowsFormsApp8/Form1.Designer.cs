namespace WindowsFormsApp8
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
            this.brandTB = new System.Windows.Forms.TextBox();
            this.modelTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.engineCB = new System.Windows.Forms.ComboBox();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.engineTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addB = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.removeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // brandTB
            // 
            this.brandTB.Location = new System.Drawing.Point(429, 50);
            this.brandTB.Name = "brandTB";
            this.brandTB.Size = new System.Drawing.Size(100, 20);
            this.brandTB.TabIndex = 6;
            // 
            // modelTB
            // 
            this.modelTB.Location = new System.Drawing.Point(429, 74);
            this.modelTB.Name = "modelTB";
            this.modelTB.Size = new System.Drawing.Size(100, 20);
            this.modelTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Engine Type";
            // 
            // engineCB
            // 
            this.engineCB.FormattingEnabled = true;
            this.engineCB.Items.AddRange(new object[] {
            "Gas",
            "Disel",
            "Elecrical"});
            this.engineCB.Location = new System.Drawing.Point(429, 97);
            this.engineCB.Name = "engineCB";
            this.engineCB.Size = new System.Drawing.Size(100, 21);
            this.engineCB.TabIndex = 10;
            // 
            // colorCB
            // 
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Blue",
            "Green",
            "White"});
            this.colorCB.Location = new System.Drawing.Point(429, 121);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(100, 21);
            this.colorCB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Color";
            // 
            // engineTB
            // 
            this.engineTB.Location = new System.Drawing.Point(429, 146);
            this.engineTB.Name = "engineTB";
            this.engineTB.Size = new System.Drawing.Size(100, 20);
            this.engineTB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Engine V";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(391, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Car";
            // 
            // addB
            // 
            this.addB.Location = new System.Drawing.Point(394, 172);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(75, 23);
            this.addB.TabIndex = 16;
            this.addB.Text = "Add";
            this.addB.UseVisualStyleBackColor = true;
            this.addB.Click += new System.EventHandler(this.addB_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(315, 201);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 95);
            this.listBox1.TabIndex = 17;
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(395, 302);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(75, 23);
            this.removeB.TabIndex = 18;
            this.removeB.Text = "Remove";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.engineTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.colorCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.engineCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.brandTB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brandTB;
        private System.Windows.Forms.TextBox modelTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox engineCB;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox engineTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addB;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button removeB;
    }
}

