﻿namespace Rarug.Francisco.Parcial
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            gbRango = new GroupBox();
            rbSupervisor = new RadioButton();
            rbOperario = new RadioButton();
            btnIngresar = new Button();
            btnCerrar = new Button();
            lblTitulo = new Label();
            btnHardSuper = new Button();
            btnHardOper = new Button();
            groupBox1.SuspendLayout();
            gbRango.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupBox1.Location = new Point(278, 149);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(326, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inicio de sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(128, 177);
            label2.Name = "label2";
            label2.Size = new Size(92, 24);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 57);
            label1.Name = "label1";
            label1.Size = new Size(74, 24);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(107, 217);
            textBoxPassword.Margin = new Padding(3, 4, 3, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(114, 29);
            textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(107, 105);
            textBoxUsername.Margin = new Padding(3, 4, 3, 4);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(114, 29);
            textBoxUsername.TabIndex = 0;
            // 
            // gbRango
            // 
            gbRango.Controls.Add(rbSupervisor);
            gbRango.Controls.Add(rbOperario);
            gbRango.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            gbRango.Location = new Point(672, 237);
            gbRango.Margin = new Padding(3, 4, 3, 4);
            gbRango.Name = "gbRango";
            gbRango.Padding = new Padding(3, 4, 3, 4);
            gbRango.Size = new Size(229, 133);
            gbRango.TabIndex = 1;
            gbRango.TabStop = false;
            gbRango.Text = "Rangos";
            // 
            // rbSupervisor
            // 
            rbSupervisor.AutoSize = true;
            rbSupervisor.Location = new Point(25, 91);
            rbSupervisor.Margin = new Padding(3, 4, 3, 4);
            rbSupervisor.Name = "rbSupervisor";
            rbSupervisor.Size = new Size(121, 28);
            rbSupervisor.TabIndex = 1;
            rbSupervisor.Text = "Supervisor";
            rbSupervisor.UseVisualStyleBackColor = true;
            // 
            // rbOperario
            // 
            rbOperario.AutoSize = true;
            rbOperario.Checked = true;
            rbOperario.Location = new Point(25, 44);
            rbOperario.Margin = new Padding(3, 4, 3, 4);
            rbOperario.Name = "rbOperario";
            rbOperario.Size = new Size(105, 28);
            rbOperario.TabIndex = 0;
            rbOperario.TabStop = true;
            rbOperario.Text = "Operario";
            rbOperario.UseVisualStyleBackColor = true;
            // 
            // btnIngresar
            // 
            btnIngresar.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIngresar.Location = new Point(514, 503);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(146, 45);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click_1;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Brown;
            btnCerrar.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCerrar.ForeColor = SystemColors.ButtonFace;
            btnCerrar.Location = new Point(199, 504);
            btnCerrar.Margin = new Padding(3, 4, 3, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(146, 45);
            btnCerrar.TabIndex = 3;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Teal;
            lblTitulo.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(199, 95);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(531, 25);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Bienvenido a la fabrica MísticaMousse";
            // 
            // btnHardSuper
            // 
            btnHardSuper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHardSuper.Location = new Point(61, 255);
            btnHardSuper.Margin = new Padding(3, 4, 3, 4);
            btnHardSuper.Name = "btnHardSuper";
            btnHardSuper.Size = new Size(146, 56);
            btnHardSuper.TabIndex = 5;
            btnHardSuper.Text = "Hardcode supervisor";
            btnHardSuper.UseVisualStyleBackColor = true;
            // 
            // btnHardOper
            // 
            btnHardOper.Font = new Font("Lucida Sans", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHardOper.Location = new Point(61, 343);
            btnHardOper.Margin = new Padding(3, 4, 3, 4);
            btnHardOper.Name = "btnHardOper";
            btnHardOper.Size = new Size(146, 56);
            btnHardOper.TabIndex = 6;
            btnHardOper.Text = "Hardcode operario";
            btnHardOper.UseVisualStyleBackColor = true;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnHardOper);
            Controls.Add(btnHardSuper);
            Controls.Add(lblTitulo);
            Controls.Add(btnCerrar);
            Controls.Add(btnIngresar);
            Controls.Add(gbRango);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MísticaMousse";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gbRango.ResumeLayout(false);
            gbRango.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private GroupBox gbRango;
        private RadioButton rbSupervisor;
        private RadioButton rbOperario;
        private Button btnIngresar;
        private Button btnCerrar;
        private Label label2;
        private Label label1;
        private Label lblTitulo;
        private Button btnHardSuper;
        private Button btnHardOper;
    }
}