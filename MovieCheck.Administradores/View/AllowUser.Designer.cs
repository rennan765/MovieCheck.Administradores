﻿namespace MovieCheck.Administradores.View
{
    partial class AllowUser
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
            this.block = new System.Windows.Forms.Button();
            this.allow = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboUsuarios = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label1.Location = new System.Drawing.Point(45, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autorizar novo usuário";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LabelEmail);
            this.groupBox1.Controls.Add(this.LabelNome);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.block);
            this.groupBox1.Controls.Add(this.allow);
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
            // block
            // 
            this.block.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.block.Location = new System.Drawing.Point(146, 126);
            this.block.Name = "block";
            this.block.Size = new System.Drawing.Size(75, 23);
            this.block.TabIndex = 3;
            this.block.Text = "Bloquear";
            this.block.UseVisualStyleBackColor = true;
            this.block.Click += new System.EventHandler(this.block_Click);
            // 
            // allow
            // 
            this.allow.Location = new System.Drawing.Point(36, 126);
            this.allow.Name = "allow";
            this.allow.Size = new System.Drawing.Size(75, 23);
            this.allow.TabIndex = 2;
            this.allow.Text = "Autorizar";
            this.allow.UseVisualStyleBackColor = true;
            this.allow.Click += new System.EventHandler(this.allow_Click);
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
            // 
            // AllowUser
            // 
            this.AcceptButton = this.allow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.block;
            this.ClientSize = new System.Drawing.Size(284, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "AllowUser";
            this.Text = "AllowUser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button block;
        private System.Windows.Forms.Button allow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboUsuarios;
        private System.Windows.Forms.Label LabelEmail;
        private System.Windows.Forms.Label LabelNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}