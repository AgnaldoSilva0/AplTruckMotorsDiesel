
namespace AplTruckMotorsDiesel.View
{
    partial class GerenciarUsuarios
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
            this.btCriarNovo = new MetroFramework.Controls.MetroButton();
            this.ListViewUsuario = new MetroFramework.Controls.MetroListView();
            this.clmNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSenha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPermissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEditar = new MetroFramework.Controls.MetroButton();
            this.btExcluir = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btCriarNovo
            // 
            this.btCriarNovo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCriarNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btCriarNovo.Location = new System.Drawing.Point(23, 386);
            this.btCriarNovo.Name = "btCriarNovo";
            this.btCriarNovo.Size = new System.Drawing.Size(118, 26);
            this.btCriarNovo.TabIndex = 9;
            this.btCriarNovo.Text = "Novo Usuário";
            this.btCriarNovo.UseCustomBackColor = true;
            this.btCriarNovo.UseCustomForeColor = true;
            this.btCriarNovo.UseSelectable = true;
            this.btCriarNovo.UseStyleColors = true;
            this.btCriarNovo.Click += new System.EventHandler(this.btCriarNovo_Click);
            // 
            // ListViewUsuario
            // 
            this.ListViewUsuario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmSenha,
            this.clmPermissao});
            this.ListViewUsuario.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewUsuario.FullRowSelect = true;
            this.ListViewUsuario.Location = new System.Drawing.Point(23, 63);
            this.ListViewUsuario.Name = "ListViewUsuario";
            this.ListViewUsuario.OwnerDraw = true;
            this.ListViewUsuario.Size = new System.Drawing.Size(411, 307);
            this.ListViewUsuario.TabIndex = 10;
            this.ListViewUsuario.UseCompatibleStateImageBehavior = false;
            this.ListViewUsuario.UseSelectable = true;
            this.ListViewUsuario.View = System.Windows.Forms.View.Details;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            this.clmNome.Width = 152;
            // 
            // clmSenha
            // 
            this.clmSenha.Text = "Senha";
            this.clmSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmSenha.Width = 168;
            // 
            // clmPermissao
            // 
            this.clmPermissao.Text = "Permissao";
            this.clmPermissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPermissao.Width = 87;
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.ForestGreen;
            this.btEditar.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditar.Location = new System.Drawing.Point(169, 386);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(118, 26);
            this.btEditar.TabIndex = 11;
            this.btEditar.Text = "Editar";
            this.btEditar.UseCustomBackColor = true;
            this.btEditar.UseCustomForeColor = true;
            this.btEditar.UseSelectable = true;
            this.btEditar.UseStyleColors = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.BackColor = System.Drawing.Color.Red;
            this.btExcluir.ForeColor = System.Drawing.SystemColors.Control;
            this.btExcluir.Location = new System.Drawing.Point(316, 386);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(118, 26);
            this.btExcluir.TabIndex = 12;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseCustomBackColor = true;
            this.btExcluir.UseCustomForeColor = true;
            this.btExcluir.UseSelectable = true;
            this.btExcluir.UseStyleColors = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // GerenciarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 425);
            this.Controls.Add(this.btExcluir);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.ListViewUsuario);
            this.Controls.Add(this.btCriarNovo);
            this.Name = "GerenciarUsuarios";
            this.Text = "Gerenciar Usuarios";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btCriarNovo;
        private MetroFramework.Controls.MetroListView ListViewUsuario;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmSenha;
        private System.Windows.Forms.ColumnHeader clmPermissao;
        private MetroFramework.Controls.MetroButton btEditar;
        private MetroFramework.Controls.MetroButton btExcluir;
    }
}