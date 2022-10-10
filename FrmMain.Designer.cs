namespace WFA221010
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.btnKoszones = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Neved:";
            // 
            // tbNev
            // 
            this.tbNev.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNev.Location = new System.Drawing.Point(88, 36);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(252, 32);
            this.tbNev.TabIndex = 1;
            // 
            // btnKoszones
            // 
            this.btnKoszones.BackColor = System.Drawing.Color.LawnGreen;
            this.btnKoszones.Font = new System.Drawing.Font("Ravie", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKoszones.Location = new System.Drawing.Point(12, 93);
            this.btnKoszones.Name = "btnKoszones";
            this.btnKoszones.Size = new System.Drawing.Size(328, 55);
            this.btnKoszones.TabIndex = 2;
            this.btnKoszones.Text = "Köszönj!";
            this.btnKoszones.UseVisualStyleBackColor = false;
            this.btnKoszones.Click += new System.EventHandler(this.btnKoszones_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "Random Szín!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(352, 241);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnKoszones);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Hello World!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tbNev;
        private Button btnKoszones;
        private Button button1;
    }
}