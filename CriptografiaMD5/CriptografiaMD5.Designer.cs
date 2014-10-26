namespace CriptografiaMD5
{
    partial class CriptografiaMD5
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
            this.txtToCript = new System.Windows.Forms.TextBox();
            this.txtResultCrypt = new System.Windows.Forms.TextBox();
            this.txtResultDecrypt = new System.Windows.Forms.TextBox();
            this.bt_Encrypt = new System.Windows.Forms.Button();
            this.bt_Decrypt = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtToCript
            // 
            this.txtToCript.BackColor = System.Drawing.Color.Yellow;
            this.txtToCript.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToCript.Location = new System.Drawing.Point(12, 92);
            this.txtToCript.Name = "txtToCript";
            this.txtToCript.Size = new System.Drawing.Size(618, 41);
            this.txtToCript.TabIndex = 0;
            // 
            // txtResultCrypt
            // 
            this.txtResultCrypt.BackColor = System.Drawing.Color.Yellow;
            this.txtResultCrypt.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultCrypt.Location = new System.Drawing.Point(12, 139);
            this.txtResultCrypt.Name = "txtResultCrypt";
            this.txtResultCrypt.Size = new System.Drawing.Size(474, 41);
            this.txtResultCrypt.TabIndex = 1;
            // 
            // txtResultDecrypt
            // 
            this.txtResultDecrypt.BackColor = System.Drawing.Color.Yellow;
            this.txtResultDecrypt.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultDecrypt.Location = new System.Drawing.Point(12, 186);
            this.txtResultDecrypt.Name = "txtResultDecrypt";
            this.txtResultDecrypt.Size = new System.Drawing.Size(474, 41);
            this.txtResultDecrypt.TabIndex = 2;
            // 
            // bt_Encrypt
            // 
            this.bt_Encrypt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Encrypt.Location = new System.Drawing.Point(492, 139);
            this.bt_Encrypt.Name = "bt_Encrypt";
            this.bt_Encrypt.Size = new System.Drawing.Size(138, 41);
            this.bt_Encrypt.TabIndex = 3;
            this.bt_Encrypt.Text = "Encryptar";
            this.bt_Encrypt.UseVisualStyleBackColor = true;
            this.bt_Encrypt.Click += new System.EventHandler(this.bt_Encrypt_Click);
            // 
            // bt_Decrypt
            // 
            this.bt_Decrypt.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Decrypt.Location = new System.Drawing.Point(492, 189);
            this.bt_Decrypt.Name = "bt_Decrypt";
            this.bt_Decrypt.Size = new System.Drawing.Size(138, 41);
            this.bt_Decrypt.TabIndex = 4;
            this.bt_Decrypt.Text = "Decriptar";
            this.bt_Decrypt.UseVisualStyleBackColor = true;
            this.bt_Decrypt.Click += new System.EventHandler(this.bt_Decrypt_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(642, 302);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.Color.Crimson;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.Location = new System.Drawing.Point(-1, 0);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(645, 51);
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.Color.Crimson;
            this.rectangleShape2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.Location = new System.Drawing.Point(-2, 246);
            this.rectangleShape2.Name = "rectangleShape2";
            this.rectangleShape2.Size = new System.Drawing.Size(645, 58);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Criptografando com MD5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Coloque aqui o texto para Encryptar e Decriptar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(394, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desenvolvido por Fábio Cabral";
            // 
            // CriptografiaMD5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(642, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Decrypt);
            this.Controls.Add(this.bt_Encrypt);
            this.Controls.Add(this.txtResultDecrypt);
            this.Controls.Add(this.txtResultCrypt);
            this.Controls.Add(this.txtToCript);
            this.Controls.Add(this.shapeContainer1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(658, 340);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(658, 340);
            this.Name = "CriptografiaMD5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CriptografiaMD5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtToCript;
        private System.Windows.Forms.TextBox txtResultCrypt;
        private System.Windows.Forms.TextBox txtResultDecrypt;
        private System.Windows.Forms.Button bt_Encrypt;
        private System.Windows.Forms.Button bt_Decrypt;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

