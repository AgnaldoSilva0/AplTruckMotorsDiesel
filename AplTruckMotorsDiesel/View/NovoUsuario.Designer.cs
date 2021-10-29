
namespace AplTruckMotorsDiesel.View
{
    partial class NovoUsuario
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
            this.tbNomeUsuario = new MetroFramework.Controls.MetroTextBox();
            this.cbPermissao = new MetroFramework.Controls.MetroComboBox();
            this.tbNovaSenha = new MetroFramework.Controls.MetroTextBox();
            this.btCadastrar = new MetroFramework.Controls.MetroButton();
            this.cbMostrarSenha = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // tbNomeUsuario
            // 
            // 
            // 
            // 
            this.tbNomeUsuario.CustomButton.Image = null;
            this.tbNomeUsuario.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.tbNomeUsuario.CustomButton.Name = "";
            this.tbNomeUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNomeUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNomeUsuario.CustomButton.TabIndex = 1;
            this.tbNomeUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNomeUsuario.CustomButton.UseSelectable = true;
            this.tbNomeUsuario.CustomButton.Visible = false;
            this.tbNomeUsuario.Lines = new string[0];
            this.tbNomeUsuario.Location = new System.Drawing.Point(23, 73);
            this.tbNomeUsuario.MaxLength = 32767;
            this.tbNomeUsuario.Name = "tbNomeUsuario";
            this.tbNomeUsuario.PasswordChar = '\0';
            this.tbNomeUsuario.PromptText = "Usuário";
            this.tbNomeUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNomeUsuario.SelectedText = "";
            this.tbNomeUsuario.SelectionLength = 0;
            this.tbNomeUsuario.SelectionStart = 0;
            this.tbNomeUsuario.ShortcutsEnabled = true;
            this.tbNomeUsuario.Size = new System.Drawing.Size(295, 23);
            this.tbNomeUsuario.TabIndex = 0;
            this.tbNomeUsuario.UseSelectable = true;
            this.tbNomeUsuario.WaterMark = "Usuário";
            this.tbNomeUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNomeUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPermissao
            // 
            this.cbPermissao.FormattingEnabled = true;
            this.cbPermissao.ItemHeight = 23;
            this.cbPermissao.Items.AddRange(new object[] {
            "1 Visitante",
            "2 Comprador",
            "3 Administrador"});
            this.cbPermissao.Location = new System.Drawing.Point(23, 162);
            this.cbPermissao.Name = "cbPermissao";
            this.cbPermissao.Size = new System.Drawing.Size(295, 29);
            this.cbPermissao.TabIndex = 1;
            this.cbPermissao.UseSelectable = true;
            // 
            // tbNovaSenha
            // 
            // 
            // 
            // 
            this.tbNovaSenha.CustomButton.Image = null;
            this.tbNovaSenha.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.tbNovaSenha.CustomButton.Name = "";
            this.tbNovaSenha.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNovaSenha.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNovaSenha.CustomButton.TabIndex = 1;
            this.tbNovaSenha.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNovaSenha.CustomButton.UseSelectable = true;
            this.tbNovaSenha.CustomButton.Visible = false;
            this.tbNovaSenha.Lines = new string[0];
            this.tbNovaSenha.Location = new System.Drawing.Point(23, 112);
            this.tbNovaSenha.MaxLength = 32767;
            this.tbNovaSenha.Name = "tbNovaSenha";
            this.tbNovaSenha.PasswordChar = '*';
            this.tbNovaSenha.PromptText = "Senha";
            this.tbNovaSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNovaSenha.SelectedText = "";
            this.tbNovaSenha.SelectionLength = 0;
            this.tbNovaSenha.SelectionStart = 0;
            this.tbNovaSenha.ShortcutsEnabled = true;
            this.tbNovaSenha.Size = new System.Drawing.Size(295, 23);
            this.tbNovaSenha.TabIndex = 2;
            this.tbNovaSenha.UseSelectable = true;
            this.tbNovaSenha.WaterMark = "Senha";
            this.tbNovaSenha.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNovaSenha.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCadastrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btCadastrar.Location = new System.Drawing.Point(96, 204);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(153, 40);
            this.btCadastrar.TabIndex = 11;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseCustomBackColor = true;
            this.btCadastrar.UseCustomForeColor = true;
            this.btCadastrar.UseSelectable = true;
            this.btCadastrar.UseStyleColors = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(23, 141);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(64, 15);
            this.cbMostrarSenha.TabIndex = 12;
            this.cbMostrarSenha.Text = "Mostrar";
            this.cbMostrarSenha.UseSelectable = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // NovoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 261);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.tbNovaSenha);
            this.Controls.Add(this.cbPermissao);
            this.Controls.Add(this.tbNomeUsuario);
            this.Name = "NovoUsuario";
            this.Text = "Novo Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tbNomeUsuario;
        private MetroFramework.Controls.MetroComboBox cbPermissao;
        private MetroFramework.Controls.MetroTextBox tbNovaSenha;
        private MetroFramework.Controls.MetroButton btCadastrar;
        private MetroFramework.Controls.MetroCheckBox cbMostrarSenha;
    }
}