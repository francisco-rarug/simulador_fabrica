﻿namespace Rarug.Francisco.Parcial
{
    partial class FormCrud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrud));
            btnCrudOper = new Button();
            btnCrudSuper = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            btnOscuro = new Button();
            btnClaro = new Button();
            SuspendLayout();
            // 
            // btnCrudOper
            // 
            btnCrudOper.BackColor = Color.YellowGreen;
            btnCrudOper.Font = new Font("Futura Md BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrudOper.ForeColor = SystemColors.Desktop;
            btnCrudOper.Location = new Point(12, 73);
            btnCrudOper.Name = "btnCrudOper";
            btnCrudOper.Size = new Size(115, 68);
            btnCrudOper.TabIndex = 0;
            btnCrudOper.Text = "CRUD Operario";
            btnCrudOper.UseVisualStyleBackColor = false;
            btnCrudOper.Click += btnCrudOper_Click;
            // 
            // btnCrudSuper
            // 
            btnCrudSuper.BackColor = SystemColors.GradientActiveCaption;
            btnCrudSuper.Font = new Font("Futura Md BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCrudSuper.Location = new Point(157, 73);
            btnCrudSuper.Name = "btnCrudSuper";
            btnCrudSuper.Size = new Size(116, 68);
            btnCrudSuper.TabIndex = 3;
            btnCrudSuper.Text = "CRUD Supervisor";
            btnCrudSuper.UseVisualStyleBackColor = false;
            btnCrudSuper.Click += btnCrudSuper_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Futura Bk BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.Control;
            btnCerrar.Location = new Point(93, 203);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(108, 29);
            btnCerrar.TabIndex = 6;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(110, 26);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 11;
            label1.Text = "CRUD";
            // 
            // btnOscuro
            // 
            btnOscuro.BackColor = Color.White;
            btnOscuro.Font = new Font("Futura Bk BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnOscuro.ForeColor = SystemColors.ActiveCaptionText;
            btnOscuro.Location = new Point(-8, 203);
            btnOscuro.Name = "btnOscuro";
            btnOscuro.Size = new Size(108, 29);
            btnOscuro.TabIndex = 12;
            btnOscuro.Text = "Oscuro";
            btnOscuro.UseVisualStyleBackColor = false;
            btnOscuro.Click += btnOscuro_Click;
            // 
            // btnClaro
            // 
            btnClaro.BackColor = Color.White;
            btnClaro.Font = new Font("Futura Bk BT", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClaro.ForeColor = SystemColors.ActiveCaptionText;
            btnClaro.Location = new Point(185, 203);
            btnClaro.Name = "btnClaro";
            btnClaro.Size = new Size(108, 29);
            btnClaro.TabIndex = 13;
            btnClaro.Text = "Claro";
            btnClaro.UseVisualStyleBackColor = false;
            btnClaro.Click += btnClaro_Click;
            // 
            // FormCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(285, 225);
            Controls.Add(btnClaro);
            Controls.Add(btnOscuro);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(btnCrudSuper);
            Controls.Add(btnCrudOper);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCrud";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crud";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrudOper;
        private Button btnCrudSuper;
        private Button btnCerrar;
        private Label label1;
        private Button btnOscuro;
        private Button btnClaro;
    }
}