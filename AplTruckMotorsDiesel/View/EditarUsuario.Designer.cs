
namespace AplTruckMotorsDiesel.View
{
    partial class EditarUsuario
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
            this.cbMostrarSenha = new MetroFramework.Controls.MetroCheckBox();
            this.btEditar = new MetroFramework.Controls.MetroButton();
            this.tbNovaSenhaEditar = new MetroFramework.Controls.MetroTextBox();
            this.cbPermissaoEditar = new MetroFramework.Controls.MetroComboBox();
            this.tbNomeUsuarioEditar = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cbEditarSenha = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // cbMostrarSenha
            // 
            this.cbMostrarSenha.AutoSize = true;
            this.cbMostrarSenha.Location = new System.Drawing.Point(24, 138);
            this.cbMostrarSenha.Name = "cbMostrarSenha";
            this.cbMostrarSenha.Size = new System.Drawing.Size(64, 15);
            this.cbMostrarSenha.TabIndex = 17;
            this.cbMostrarSenha.Text = "Mostrar";
            this.cbMostrarSenha.UseSelectable = true;
            this.cbMostrarSenha.CheckedChanged += new System.EventHandler(this.cbMostrarSenha_CheckedChanged);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btEditar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditar.Location = new System.Drawing.Point(97, 201);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(153, 40);
            this.btEditar.TabIndex = 16;
            this.btEditar.Text = "Editar";
            this.btEditar.UseCustomBackColor = true;
            this.btEditar.UseCustomForeColor = true;
            this.btEditar.UseSelectable = true;
            this.btEditar.UseStyleColors = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // tbNovaSenhaEditar
            // 
            // 
            // 
            // 
            this.tbNovaSenhaEditar.CustomButton.Image = null;
            this.tbNovaSenhaEditar.CustomButton.Location = new System.Drawing.Point(211, 1);
            this.tbNovaSenhaEditar.CustomButton.Name = "";
            this.tbNovaSenhaEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNovaSenhaEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNovaSenhaEditar.CustomButton.TabIndex = 1;
            this.tbNovaSenhaEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNovaSenhaEditar.CustomButton.UseSelectable = true;
            this.tbNovaSenhaEditar.CustomButton.Visible = false;
            this.tbNovaSenhaEditar.Enabled = false;
            this.tbNovaSenhaEditar.Lines = new string[0];
            this.tbNovaSenhaEditar.Location = new System.Drawing.Point(24, 109);
            this.tbNovaSenhaEditar.MaxLength = 32767;
            this.tbNovaSenhaEditar.Name = "tbNovaSenhaEditar";
            this.tbNovaSenhaEditar.PasswordChar = '*';
            this.tbNovaSenhaEditar.PromptText = "Senha";
            this.tbNovaSenhaEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNovaSenhaEditar.SelectedText = "";
            this.tbNovaSenhaEditar.SelectionLength = 0;
            this.tbNovaSenhaEditar.SelectionStart = 0;
            this.tbNovaSenhaEditar.ShortcutsEnabled = true;
            this.tbNovaSenhaEditar.Size = new System.Drawing.Size(233, 23);
            this.tbNovaSenhaEditar.TabIndex = 15;
            this.tbNovaSenhaEditar.UseSelectable = true;
            this.tbNovaSenhaEditar.WaterMark = "Senha";
            this.tbNovaSenhaEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNovaSenhaEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbPermissaoEditar
            // 
            this.cbPermissaoEditar.FormattingEnabled = true;
            this.cbPermissaoEditar.ItemHeight = 23;
            this.cbPermissaoEditar.Items.AddRange(new object[] {
            "1 Visitante",
            "2 Comprador",
            "3 Administrador"});
            this.cbPermissaoEditar.Location = new System.Drawing.Point(24, 159);
            this.cbPermissaoEditar.Name = "cbPermissaoEditar";
            this.cbPermissaoEditar.Size = new System.Drawing.Size(295, 29);
            this.cbPermissaoEditar.TabIndex = 14;
            this.cbPermissaoEditar.UseSelectable = true;
            // 
            // tbNomeUsuarioEditar
            // 
            // 
            // 
            // 
            this.tbNomeUsuarioEditar.CustomButton.Image = null;
            this.tbNomeUsuarioEditar.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.tbNomeUsuarioEditar.CustomButton.Name = "";
            this.tbNomeUsuarioEditar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbNomeUsuarioEditar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbNomeUsuarioEditar.CustomButton.TabIndex = 1;
            this.tbNomeUsuarioEditar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbNomeUsuarioEditar.CustomButton.UseSelectable = true;
            this.tbNomeUsuarioEditar.CustomButton.Visible = false;
            this.tbNomeUsuarioEditar.Lines = new string[0];
            this.tbNomeUsuarioEditar.Location = new System.Drawing.Point(24, 70);
            this.tbNomeUsuarioEditar.MaxLength = 32767;
            this.tbNomeUsuarioEditar.Name = "tbNomeUsuarioEditar";
            this.tbNomeUsuarioEditar.PasswordChar = '\0';
            this.tbNomeUsuarioEditar.PromptText = "Usuário";
            this.tbNomeUsuarioEditar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbNomeUsuarioEditar.SelectedText = "";
            this.tbNomeUsuarioEditar.SelectionLength = 0;
            this.tbNomeUsuarioEditar.SelectionStart = 0;
            this.tbNomeUsuarioEditar.ShortcutsEnabled = true;
            this.tbNomeUsuarioEditar.Size = new System.Drawing.Size(295, 23);
            this.tbNomeUsuarioEditar.TabIndex = 13;
            this.tbNomeUsuarioEditar.UseSelectable = true;
            this.tbNomeUsuarioEditar.WaterMark = "Usuário";
            this.tbNomeUsuarioEditar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbNomeUsuarioEditar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(237, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(20, 19);
            this.metroLabel1.TabIndex = 18;
            this.metroLabel1.Text = "id";
            // 
            // cbEditarSenha
            // 
            this.cbEditarSenha.AutoSize = true;
            this.cbEditarSenha.Location = new System.Drawing.Point(263, 113);
            this.cbEditarSenha.Name = "cbEditarSenha";
            this.cbEditarSenha.Size = new System.Drawing.Size(53, 15);
            this.cbEditarSenha.TabIndex = 19;
            this.cbEditarSenha.Text = "Editar";
            this.cbEditarSenha.UseSelectable = true;
            this.cbEditarSenha.CheckedChanged += new System.EventHandler(this.cbEditarSenha_CheckedChanged);
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 258);
            this.Controls.Add(this.cbEditarSenha);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbMostrarSenha);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.tbNovaSenhaEditar);
            this.Controls.Add(this.cbPermissaoEditar);
            this.Controls.Add(this.tbNomeUsuarioEditar);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox cbMostrarSenha;
        private MetroFramework.Controls.MetroButton btEditar;
        private MetroFramework.Controls.MetroTextBox tbNovaSenhaEditar;
        private MetroFramework.Controls.MetroComboBox cbPermissaoEditar;
        private MetroFramework.Controls.MetroTextBox tbNomeUsuarioEditar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox cbEditarSenha;
    }
}