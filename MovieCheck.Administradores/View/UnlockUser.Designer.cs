﻿namespace MovieCheck.Administradores.View
{
    partial class UnlockUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LabelEmail = new System.Windows.Forms.Label();
            this.LabelNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.unlock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(55, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Desbloquear usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelEmail);
            this.groupBox1.Controls.Add(this.LabelNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unlock);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboUsuarios);
            this.groupBox1.Location = new System.Drawing.Point(13, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 165);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o usuário";
            // 
            // LabelEmail
            // 
            this.LabelEmail.AutoSize = true;
            this.LabelEmail.Location = new System.Drawing.Point(58, 98);
            this.LabelEmail.Name = "LabelEmail";
            this.LabelEmail.Size = new System.Drawing.Size(35, 13);
            this.LabelEmail.TabIndex = 7;
            this.LabelEmail.Text = "label5";
            // 
            // LabelNome
            // 
            this.LabelNome.AutoSize = true;
            this.LabelNome.Location = new System.Drawing.Point(58, 74);
            this.LabelNome.Name = "LabelNome";
            this.LabelNome.Size = new System.Drawing.Size(35, 13);
            this.LabelNome.TabIndex = 6;
            this.LabelNome.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "E-mail: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nome: ";
            // 
            // unlock
            // 
            this.unlock.Location = new System.Drawing.Point(61, 121);
            this.unlock.Name = "unlock";
            this.unlock.Size = new System.Drawing.Size(133, 29);
            this.unlock.TabIndex = 2;
            this.unlock.Text = "Desbloquear";
            this.unlock.UseVisualStyleBackColor = true;
            this.unlock.Click += new System.EventHandler(this.unlock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Escoha o usuário";
            // 
            // ComboUsuarios
            // 
            this.ComboUsuarios.FormattingEnabled = true;
            this.ComboUsuarios.Location = new System.Drawing.Point(7, 43);
            this.ComboUsuarios.Name = "ComboUsuarios";
            this.ComboUsuarios.Size = new System.Drawing.Size(246, 21);
            this.ComboUsuarios.TabIndex = 0;
            this.ComboUsuarios.SelectedIndexChanged += new System.EventHandler(this.TrocarLabelNomeEmail);
            // 
            // UnlockUser
            // 
            this.AcceptButton = this.unlock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "UnlockUser";
            this.Text = "AllowUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button unlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboUsuarios;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}