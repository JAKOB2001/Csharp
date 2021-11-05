
namespace Grigalashvili_praqtikuli
{
    partial class FormBase
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
            this.label_base = new System.Windows.Forms.Label();
            this.label_hight = new System.Windows.Forms.Label();
            this.textBox_base = new System.Windows.Forms.TextBox();
            this.textBox_hight = new System.Windows.Forms.TextBox();
            this.button_area = new System.Windows.Forms.Button();
            this.label_answer = new System.Windows.Forms.Label();
            this.label_area = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_wattsHour = new System.Windows.Forms.Label();
            this.label_useTV = new System.Windows.Forms.Label();
            this.label_useWatts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_base
            // 
            this.label_base.AutoSize = true;
            this.label_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_base.Location = new System.Drawing.Point(114, 38);
            this.label_base.Name = "label_base";
            this.label_base.Size = new System.Drawing.Size(40, 16);
            this.label_base.TabIndex = 0;
            this.label_base.Text = "Base";
            // 
            // label_hight
            // 
            this.label_hight.AutoSize = true;
            this.label_hight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hight.Location = new System.Drawing.Point(115, 71);
            this.label_hight.Name = "label_hight";
            this.label_hight.Size = new System.Drawing.Size(39, 16);
            this.label_hight.TabIndex = 1;
            this.label_hight.Text = "Hight";
            // 
            // textBox_base
            // 
            this.textBox_base.Location = new System.Drawing.Point(205, 37);
            this.textBox_base.Name = "textBox_base";
            this.textBox_base.Size = new System.Drawing.Size(100, 20);
            this.textBox_base.TabIndex = 2;
            // 
            // textBox_hight
            // 
            this.textBox_hight.Location = new System.Drawing.Point(205, 71);
            this.textBox_hight.Name = "textBox_hight";
            this.textBox_hight.Size = new System.Drawing.Size(100, 20);
            this.textBox_hight.TabIndex = 3;
            // 
            // button_area
            // 
            this.button_area.Location = new System.Drawing.Point(118, 121);
            this.button_area.Name = "button_area";
            this.button_area.Size = new System.Drawing.Size(188, 23);
            this.button_area.TabIndex = 4;
            this.button_area.Text = "Calculate Area";
            this.button_area.UseVisualStyleBackColor = true;
            this.button_area.Click += new System.EventHandler(this.button_area_Click);
            // 
            // label_answer
            // 
            this.label_answer.AutoSize = true;
            this.label_answer.Location = new System.Drawing.Point(118, 163);
            this.label_answer.Name = "label_answer";
            this.label_answer.Size = new System.Drawing.Size(0, 13);
            this.label_answer.TabIndex = 5;
            // 
            // label_area
            // 
            this.label_area.AutoSize = true;
            this.label_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_area.Location = new System.Drawing.Point(13, 13);
            this.label_area.Name = "label_area";
            this.label_area.Size = new System.Drawing.Size(61, 25);
            this.label_area.TabIndex = 6;
            this.label_area.Text = "Area";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "TV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "How many watts per hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "How many hours did you use";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(368, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label_wattsHour
            // 
            this.label_wattsHour.AutoSize = true;
            this.label_wattsHour.Location = new System.Drawing.Point(121, 332);
            this.label_wattsHour.Name = "label_wattsHour";
            this.label_wattsHour.Size = new System.Drawing.Size(0, 13);
            this.label_wattsHour.TabIndex = 13;
            // 
            // label_useTV
            // 
            this.label_useTV.AutoSize = true;
            this.label_useTV.Location = new System.Drawing.Point(121, 359);
            this.label_useTV.Name = "label_useTV";
            this.label_useTV.Size = new System.Drawing.Size(0, 13);
            this.label_useTV.TabIndex = 14;
            // 
            // label_useWatts
            // 
            this.label_useWatts.AutoSize = true;
            this.label_useWatts.Location = new System.Drawing.Point(121, 390);
            this.label_useWatts.Name = "label_useWatts";
            this.label_useWatts.Size = new System.Drawing.Size(0, 13);
            this.label_useWatts.TabIndex = 15;
            // 
            // FormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_useWatts);
            this.Controls.Add(this.label_useTV);
            this.Controls.Add(this.label_wattsHour);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_area);
            this.Controls.Add(this.label_answer);
            this.Controls.Add(this.button_area);
            this.Controls.Add(this.textBox_hight);
            this.Controls.Add(this.textBox_base);
            this.Controls.Add(this.label_hight);
            this.Controls.Add(this.label_base);
            this.Name = "FormBase";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_base;
        private System.Windows.Forms.Label label_hight;
        private System.Windows.Forms.TextBox textBox_base;
        private System.Windows.Forms.TextBox textBox_hight;
        private System.Windows.Forms.Button button_area;
        private System.Windows.Forms.Label label_answer;
        private System.Windows.Forms.Label label_area;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_wattsHour;
        private System.Windows.Forms.Label label_useTV;
        private System.Windows.Forms.Label label_useWatts;
    }
}

