
namespace AplTruckMotorsDiesel.View
{
    partial class ListarItens
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
            this.btListarKitMotor = new MetroFramework.Controls.MetroButton();
            this.btListarMotor = new MetroFramework.Controls.MetroButton();
            this.btListarAneis = new MetroFramework.Controls.MetroButton();
            this.btListarBAgua = new MetroFramework.Controls.MetroButton();
            this.btListarBOleo = new MetroFramework.Controls.MetroButton();
            this.btListarJunta = new MetroFramework.Controls.MetroButton();
            this.btListarBMancal = new MetroFramework.Controls.MetroButton();
            this.btListarBBiela = new MetroFramework.Controls.MetroButton();
            this.btListarPistao = new MetroFramework.Controls.MetroButton();
            this.listViewItens = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodigoOriginal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmMarca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmObservacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btEditarRegistro = new MetroFramework.Controls.MetroButton();
            this.btExcluirRegistro = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btListarKitMotor
            // 
            this.btListarKitMotor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarKitMotor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarKitMotor.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarKitMotor.Location = new System.Drawing.Point(23, 319);
            this.btListarKitMotor.Name = "btListarKitMotor";
            this.btListarKitMotor.Size = new System.Drawing.Size(153, 26);
            this.btListarKitMotor.TabIndex = 27;
            this.btListarKitMotor.Text = "Kit Motor";
            this.btListarKitMotor.UseCustomBackColor = true;
            this.btListarKitMotor.UseCustomForeColor = true;
            this.btListarKitMotor.UseSelectable = true;
            this.btListarKitMotor.UseStyleColors = true;
            this.btListarKitMotor.Click += new System.EventHandler(this.btListarKitMotor_Click);
            // 
            // btListarMotor
            // 
            this.btListarMotor.BackColor = System.Drawing.Color.Green;
            this.btListarMotor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarMotor.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarMotor.Location = new System.Drawing.Point(23, 63);
            this.btListarMotor.Name = "btListarMotor";
            this.btListarMotor.Size = new System.Drawing.Size(153, 26);
            this.btListarMotor.TabIndex = 26;
            this.btListarMotor.Text = "Motor";
            this.btListarMotor.UseCustomBackColor = true;
            this.btListarMotor.UseCustomForeColor = true;
            this.btListarMotor.UseSelectable = true;
            this.btListarMotor.UseStyleColors = true;
            this.btListarMotor.Click += new System.EventHandler(this.btListarMotor_Click);
            // 
            // btListarAneis
            // 
            this.btListarAneis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarAneis.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarAneis.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarAneis.Location = new System.Drawing.Point(23, 287);
            this.btListarAneis.Name = "btListarAneis";
            this.btListarAneis.Size = new System.Drawing.Size(153, 26);
            this.btListarAneis.TabIndex = 25;
            this.btListarAneis.Text = "Anéis";
            this.btListarAneis.UseCustomBackColor = true;
            this.btListarAneis.UseCustomForeColor = true;
            this.btListarAneis.UseSelectable = true;
            this.btListarAneis.UseStyleColors = true;
            this.btListarAneis.Click += new System.EventHandler(this.btListarAneis_Click);
            // 
            // btListarBAgua
            // 
            this.btListarBAgua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarBAgua.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarBAgua.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarBAgua.Location = new System.Drawing.Point(23, 254);
            this.btListarBAgua.Name = "btListarBAgua";
            this.btListarBAgua.Size = new System.Drawing.Size(153, 26);
            this.btListarBAgua.TabIndex = 24;
            this.btListarBAgua.Text = "Bomba Agua";
            this.btListarBAgua.UseCustomBackColor = true;
            this.btListarBAgua.UseCustomForeColor = true;
            this.btListarBAgua.UseSelectable = true;
            this.btListarBAgua.UseStyleColors = true;
            this.btListarBAgua.Click += new System.EventHandler(this.btListarBAgua_Click);
            // 
            // btListarBOleo
            // 
            this.btListarBOleo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarBOleo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarBOleo.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarBOleo.Location = new System.Drawing.Point(23, 222);
            this.btListarBOleo.Name = "btListarBOleo";
            this.btListarBOleo.Size = new System.Drawing.Size(153, 26);
            this.btListarBOleo.TabIndex = 23;
            this.btListarBOleo.Text = "Bomba Oleo";
            this.btListarBOleo.UseCustomBackColor = true;
            this.btListarBOleo.UseCustomForeColor = true;
            this.btListarBOleo.UseSelectable = true;
            this.btListarBOleo.UseStyleColors = true;
            this.btListarBOleo.Click += new System.EventHandler(this.btListarBOleo_Click);
            // 
            // btListarJunta
            // 
            this.btListarJunta.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarJunta.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarJunta.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarJunta.Location = new System.Drawing.Point(23, 190);
            this.btListarJunta.Name = "btListarJunta";
            this.btListarJunta.Size = new System.Drawing.Size(153, 26);
            this.btListarJunta.TabIndex = 22;
            this.btListarJunta.Text = "Junta";
            this.btListarJunta.UseCustomBackColor = true;
            this.btListarJunta.UseCustomForeColor = true;
            this.btListarJunta.UseSelectable = true;
            this.btListarJunta.UseStyleColors = true;
            this.btListarJunta.Click += new System.EventHandler(this.btListarJunta_Click);
            // 
            // btListarBMancal
            // 
            this.btListarBMancal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarBMancal.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarBMancal.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarBMancal.Location = new System.Drawing.Point(23, 158);
            this.btListarBMancal.Name = "btListarBMancal";
            this.btListarBMancal.Size = new System.Drawing.Size(153, 26);
            this.btListarBMancal.TabIndex = 21;
            this.btListarBMancal.Text = "B.Mancal";
            this.btListarBMancal.UseCustomBackColor = true;
            this.btListarBMancal.UseCustomForeColor = true;
            this.btListarBMancal.UseSelectable = true;
            this.btListarBMancal.UseStyleColors = true;
            this.btListarBMancal.Click += new System.EventHandler(this.btListarBMancal_Click);
            // 
            // btListarBBiela
            // 
            this.btListarBBiela.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarBBiela.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarBBiela.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarBBiela.Location = new System.Drawing.Point(23, 126);
            this.btListarBBiela.Name = "btListarBBiela";
            this.btListarBBiela.Size = new System.Drawing.Size(153, 26);
            this.btListarBBiela.TabIndex = 20;
            this.btListarBBiela.Text = "B.Biela";
            this.btListarBBiela.UseCustomBackColor = true;
            this.btListarBBiela.UseCustomForeColor = true;
            this.btListarBBiela.UseSelectable = true;
            this.btListarBBiela.UseStyleColors = true;
            this.btListarBBiela.Click += new System.EventHandler(this.btListarBBiela_Click);
            // 
            // btListarPistao
            // 
            this.btListarPistao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btListarPistao.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btListarPistao.ForeColor = System.Drawing.SystemColors.Control;
            this.btListarPistao.Location = new System.Drawing.Point(23, 94);
            this.btListarPistao.Name = "btListarPistao";
            this.btListarPistao.Size = new System.Drawing.Size(153, 26);
            this.btListarPistao.TabIndex = 19;
            this.btListarPistao.Text = "Pistão";
            this.btListarPistao.UseCustomBackColor = true;
            this.btListarPistao.UseCustomForeColor = true;
            this.btListarPistao.UseSelectable = true;
            this.btListarPistao.UseStyleColors = true;
            this.btListarPistao.Click += new System.EventHandler(this.btListarPistao_Click);
            // 
            // listViewItens
            // 
            this.listViewItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmCodigo,
            this.clmCodigoOriginal,
            this.clmMarca,
            this.clmObservacao});
            this.listViewItens.FullRowSelect = true;
            this.listViewItens.HideSelection = false;
            this.listViewItens.Location = new System.Drawing.Point(182, 63);
            this.listViewItens.MultiSelect = false;
            this.listViewItens.Name = "listViewItens";
            this.listViewItens.Size = new System.Drawing.Size(701, 282);
            this.listViewItens.TabIndex = 28;
            this.listViewItens.UseCompatibleStateImageBehavior = false;
            this.listViewItens.View = System.Windows.Forms.View.Details;
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            this.clmId.Width = 52;
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Código";
            this.clmCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCodigo.Width = 173;
            // 
            // clmCodigoOriginal
            // 
            this.clmCodigoOriginal.Text = "Codigo Original";
            this.clmCodigoOriginal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCodigoOriginal.Width = 164;
            // 
            // clmMarca
            // 
            this.clmMarca.Text = "Marca";
            this.clmMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmMarca.Width = 116;
            // 
            // clmObservacao
            // 
            this.clmObservacao.Text = "Observação";
            this.clmObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmObservacao.Width = 192;
            // 
            // btEditarRegistro
            // 
            this.btEditarRegistro.BackColor = System.Drawing.Color.Green;
            this.btEditarRegistro.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btEditarRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btEditarRegistro.Location = new System.Drawing.Point(571, 351);
            this.btEditarRegistro.Name = "btEditarRegistro";
            this.btEditarRegistro.Size = new System.Drawing.Size(153, 26);
            this.btEditarRegistro.TabIndex = 29;
            this.btEditarRegistro.Text = "Editar Registro";
            this.btEditarRegistro.UseCustomBackColor = true;
            this.btEditarRegistro.UseCustomForeColor = true;
            this.btEditarRegistro.UseSelectable = true;
            this.btEditarRegistro.UseStyleColors = true;
            // 
            // btExcluirRegistro
            // 
            this.btExcluirRegistro.BackColor = System.Drawing.Color.Red;
            this.btExcluirRegistro.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btExcluirRegistro.ForeColor = System.Drawing.SystemColors.Control;
            this.btExcluirRegistro.Location = new System.Drawing.Point(730, 351);
            this.btExcluirRegistro.Name = "btExcluirRegistro";
            this.btExcluirRegistro.Size = new System.Drawing.Size(153, 26);
            this.btExcluirRegistro.TabIndex = 30;
            this.btExcluirRegistro.Text = "Excluir Registro";
            this.btExcluirRegistro.UseCustomBackColor = true;
            this.btExcluirRegistro.UseCustomForeColor = true;
            this.btExcluirRegistro.UseSelectable = true;
            this.btExcluirRegistro.UseStyleColors = true;
            // 
            // ListarItens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 385);
            this.Controls.Add(this.btExcluirRegistro);
            this.Controls.Add(this.btEditarRegistro);
            this.Controls.Add(this.listViewItens);
            this.Controls.Add(this.btListarKitMotor);
            this.Controls.Add(this.btListarMotor);
            this.Controls.Add(this.btListarAneis);
            this.Controls.Add(this.btListarBAgua);
            this.Controls.Add(this.btListarBOleo);
            this.Controls.Add(this.btListarJunta);
            this.Controls.Add(this.btListarBMancal);
            this.Controls.Add(this.btListarBBiela);
            this.Controls.Add(this.btListarPistao);
            this.Name = "ListarItens";
            this.Text = "ListarItens";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btListarKitMotor;
        private MetroFramework.Controls.MetroButton btListarMotor;
        private MetroFramework.Controls.MetroButton btListarAneis;
        private MetroFramework.Controls.MetroButton btListarBAgua;
        private MetroFramework.Controls.MetroButton btListarBOleo;
        private MetroFramework.Controls.MetroButton btListarJunta;
        private MetroFramework.Controls.MetroButton btListarBMancal;
        private MetroFramework.Controls.MetroButton btListarBBiela;
        private MetroFramework.Controls.MetroButton btListarPistao;
        private System.Windows.Forms.ListView listViewItens;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ColumnHeader clmCodigoOriginal;
        private System.Windows.Forms.ColumnHeader clmMarca;
        private System.Windows.Forms.ColumnHeader clmObservacao;
        private MetroFramework.Controls.MetroButton btEditarRegistro;
        private MetroFramework.Controls.MetroButton btExcluirRegistro;
    }
}