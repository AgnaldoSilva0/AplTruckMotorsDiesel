
namespace AplTruckMotorsDiesel.View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbUsuario = new MetroFramework.Controls.MetroTextBox();
            this.btAcessar = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbSenha = new MetroFramework.Controls.MetroTextBox();
            this.cbMostrarSenha = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            // 
            // 
            // 
            this.tbUsuario.CustomButton.Image = null;
            this.tbUsuario.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.tbUsuario.CustomButton.Name = "";
            this.tbUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsuario.CustomButton.TabIndex = 1;
            this.tbUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsuario.CustomButton.UseSelectable = true;
            this.tbUsuario.CustomButton.Visible = false;
            this.tbUsuario.Lines = new string[0];
            this.tbUsuario.Location = new System.Drawing.Point(71, 142);
            this.tbUsuario.MaxLength = 32767;
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.PasswordChar = '\0';
            this.tbUsuario.PromptText = "Usuário";
            this.tbUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsuario.SelectedText = "";
            this.tbUsuario.SelectionLength = 0;
            this.tbUsuario.SelectionStart = 0;
            this.tbUsuario.ShortcutsEnabled = true;
            this.tbUsuario.Size = new System.Drawing.Size(153, 26);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.UseSelectable = true;
            this.tbUsuario.WaterMark = "Usuário";
            this.tbUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btAcessar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btAcessar.ForeColor = System.Drawing.SystemColors.Control;
            this.btAcessar.Location = new System.Drawing.Point(71, 206);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(153, 26);
            this.btAcessar.TabIndex = 10;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseCustomBackColor = true;
            this.btAcessar.UseCustomForeColor = true;
            this.btAcessar.UseSelectable = true;
            this.btAcessar.UseStyleColors = true;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(118, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 73);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // tbSenha
            // 
            // 
            // 
            // 
            this.tbSenha.CustomButton.Image = null;
            this.tbSenha.CustomButton.Location = new System.Drawing.Point(129, 2);
            this.tbSenha.CustomButton.Name = "";
            this.tbSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSenha.CustomButton.TabIndex = 1;
            this.tbSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSenha.CustomButton.UseSelectable = true;
            this.tbSenha.CustomButton.Visible = false;
            this.tbSenha.Lines = new string[0];
            this.tbSenha.Location = new System.Drawing.Point(71, 174);
            this.tbSenha.MaxLength = 32767;
            this.tbSenha.Name = "tbSenha";
            this.tbSenha.PasswordChar = '*';
            this.tbSenha.PromptText = "Senha";
            this.tbSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSenha.SelectedText = "";
            this.tbSenha.SelectionLength = 0;
            this.tbSenha.SelectionStart = 0;
            this.tbSenha.ShortcutsEnabled = true;
            this.tbSenha.Size = new System.Drawing.Size(153, 26);
            this.tbSenha.TabIndex = 12;
            this.tbSenha.UseSelectable = true;
            this.tbSenha.WaterMark = "Senha";
            this.tbSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(230, 179);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(64, 15);
            this.cbMostrarSenha.TabIndex = 13;
            this.cbMostrarSenha.Text = "Mostrar";
            this.cbMostrarSenha.UseSelectable = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // Login
            // 
            this.AcceptButton = this.btAcessar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 243);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.tbSenha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.tbUsuario);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbUsuario;
        private MetroFramework.Controls.MetroButton btAcessar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox tbSenha;
        private MetroFramework.Controls.MetroCheckBox cbMostrarSenha;
    }
}