﻿
namespace AplTruckMotorsDiesel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listViewMotor = new MetroFramework.Controls.MetroListView();
            this.clmIdMotor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModeloVeiculo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModeloMotor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmObservacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbFonte = new MetroFramework.Controls.MetroTextBox();
            this.tbMotor = new MetroFramework.Controls.MetroTextBox();
            this.tbAplicacao = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisaGeral = new MetroFramework.Controls.MetroButton();
            this.btPesquisaMotor = new MetroFramework.Controls.MetroButton();
            this.btPesquisaAplicacao = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btCriarNovo = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelPistao = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.listViewPistao = new MetroFramework.Controls.MetroListView();
            this.clmPistaoSelecionado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.listViewBBiela = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panelPistao.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMotor
            // 
            this.listViewMotor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIdMotor,
            this.clmModeloVeiculo,
            this.clmModeloMotor,
            this.clmObservacao});
            this.listViewMotor.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewMotor.FullRowSelect = true;
            this.listViewMotor.Location = new System.Drawing.Point(23, 159);
            this.listViewMotor.Name = "listViewMotor";
            this.listViewMotor.OwnerDraw = true;
            this.listViewMotor.Size = new System.Drawing.Size(754, 211);
            this.listViewMotor.TabIndex = 0;
            this.listViewMotor.UseCompatibleStateImageBehavior = false;
            this.listViewMotor.UseSelectable = true;
            this.listViewMotor.View = System.Windows.Forms.View.Details;
            this.listViewMotor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewMotor_MouseClick);
            // 
            // clmIdMotor
            // 
            this.clmIdMotor.Text = "ID Motor";
            this.clmIdMotor.Width = 114;
            // 
            // clmModeloVeiculo
            // 
            this.clmModeloVeiculo.Text = "Modelo Veículo";
            this.clmModeloVeiculo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmModeloVeiculo.Width = 189;
            // 
            // clmModeloMotor
            // 
            this.clmModeloMotor.Text = "Modelo Motor";
            this.clmModeloMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmModeloMotor.Width = 129;
            // 
            // clmObservacao
            // 
            this.clmObservacao.Text = "Observação";
            this.clmObservacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmObservacao.Width = 317;
            // 
            // tbFonte
            // 
            // 
            // 
            // 
            this.tbFonte.CustomButton.Image = null;
            this.tbFonte.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.tbFonte.CustomButton.Name = "";
            this.tbFonte.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbFonte.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFonte.CustomButton.TabIndex = 1;
            this.tbFonte.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFonte.CustomButton.UseSelectable = true;
            this.tbFonte.CustomButton.Visible = false;
            this.tbFonte.Lines = new string[0];
            this.tbFonte.Location = new System.Drawing.Point(59, 63);
            this.tbFonte.MaxLength = 32767;
            this.tbFonte.Name = "tbFonte";
            this.tbFonte.PasswordChar = '\0';
            this.tbFonte.PromptText = "Font Geral";
            this.tbFonte.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFonte.SelectedText = "";
            this.tbFonte.SelectionLength = 0;
            this.tbFonte.SelectionStart = 0;
            this.tbFonte.ShortcutsEnabled = true;
            this.tbFonte.Size = new System.Drawing.Size(126, 26);
            this.tbFonte.TabIndex = 1;
            this.tbFonte.UseSelectable = true;
            this.tbFonte.WaterMark = "Font Geral";
            this.tbFonte.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFonte.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbMotor
            // 
            // 
            // 
            // 
            this.tbMotor.CustomButton.Image = null;
            this.tbMotor.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.tbMotor.CustomButton.Name = "";
            this.tbMotor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbMotor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbMotor.CustomButton.TabIndex = 1;
            this.tbMotor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbMotor.CustomButton.UseSelectable = true;
            this.tbMotor.CustomButton.Visible = false;
            this.tbMotor.Lines = new string[0];
            this.tbMotor.Location = new System.Drawing.Point(59, 95);
            this.tbMotor.MaxLength = 32767;
            this.tbMotor.Name = "tbMotor";
            this.tbMotor.PasswordChar = '\0';
            this.tbMotor.PromptText = "Motor";
            this.tbMotor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbMotor.SelectedText = "";
            this.tbMotor.SelectionLength = 0;
            this.tbMotor.SelectionStart = 0;
            this.tbMotor.ShortcutsEnabled = true;
            this.tbMotor.Size = new System.Drawing.Size(126, 26);
            this.tbMotor.TabIndex = 2;
            this.tbMotor.UseSelectable = true;
            this.tbMotor.WaterMark = "Motor";
            this.tbMotor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbMotor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbAplicacao
            // 
            // 
            // 
            // 
            this.tbAplicacao.CustomButton.Image = null;
            this.tbAplicacao.CustomButton.Location = new System.Drawing.Point(102, 2);
            this.tbAplicacao.CustomButton.Name = "";
            this.tbAplicacao.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbAplicacao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbAplicacao.CustomButton.TabIndex = 1;
            this.tbAplicacao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbAplicacao.CustomButton.UseSelectable = true;
            this.tbAplicacao.CustomButton.Visible = false;
            this.tbAplicacao.Lines = new string[0];
            this.tbAplicacao.Location = new System.Drawing.Point(59, 127);
            this.tbAplicacao.MaxLength = 32767;
            this.tbAplicacao.Name = "tbAplicacao";
            this.tbAplicacao.PasswordChar = '\0';
            this.tbAplicacao.PromptText = "Aplicação";
            this.tbAplicacao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbAplicacao.SelectedText = "";
            this.tbAplicacao.SelectionLength = 0;
            this.tbAplicacao.SelectionStart = 0;
            this.tbAplicacao.ShortcutsEnabled = true;
            this.tbAplicacao.Size = new System.Drawing.Size(126, 26);
            this.tbAplicacao.TabIndex = 3;
            this.tbAplicacao.UseSelectable = true;
            this.tbAplicacao.WaterMark = "Aplicação";
            this.tbAplicacao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbAplicacao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btPesquisaGeral
            // 
            this.btPesquisaGeral.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btPesquisaGeral.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisaGeral.Location = new System.Drawing.Point(191, 63);
            this.btPesquisaGeral.Name = "btPesquisaGeral";
            this.btPesquisaGeral.Size = new System.Drawing.Size(118, 26);
            this.btPesquisaGeral.TabIndex = 4;
            this.btPesquisaGeral.Text = "Pesquisa Geral";
            this.btPesquisaGeral.UseCustomBackColor = true;
            this.btPesquisaGeral.UseCustomForeColor = true;
            this.btPesquisaGeral.UseSelectable = true;
            this.btPesquisaGeral.UseStyleColors = true;
            this.btPesquisaGeral.Click += new System.EventHandler(this.btPesquisaGeral_Click);
            // 
            // btPesquisaMotor
            // 
            this.btPesquisaMotor.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btPesquisaMotor.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisaMotor.Location = new System.Drawing.Point(191, 95);
            this.btPesquisaMotor.Name = "btPesquisaMotor";
            this.btPesquisaMotor.Size = new System.Drawing.Size(118, 26);
            this.btPesquisaMotor.TabIndex = 5;
            this.btPesquisaMotor.Text = "Pesquisar Motor";
            this.btPesquisaMotor.UseCustomBackColor = true;
            this.btPesquisaMotor.UseCustomForeColor = true;
            this.btPesquisaMotor.UseSelectable = true;
            this.btPesquisaMotor.UseStyleColors = true;
            // 
            // btPesquisaAplicacao
            // 
            this.btPesquisaAplicacao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btPesquisaAplicacao.ForeColor = System.Drawing.SystemColors.Control;
            this.btPesquisaAplicacao.Location = new System.Drawing.Point(191, 127);
            this.btPesquisaAplicacao.Name = "btPesquisaAplicacao";
            this.btPesquisaAplicacao.Size = new System.Drawing.Size(118, 26);
            this.btPesquisaAplicacao.TabIndex = 6;
            this.btPesquisaAplicacao.Text = "Pesquisa Aplicação";
            this.btPesquisaAplicacao.UseCustomBackColor = true;
            this.btPesquisaAplicacao.UseCustomForeColor = true;
            this.btPesquisaAplicacao.UseSelectable = true;
            this.btPesquisaAplicacao.UseStyleColors = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(428, 388);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(349, 121);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.UseCustomForeColor = true;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(85, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Observações";
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            this.metroLabel1.UseStyleColors = true;
            // 
            // btCriarNovo
            // 
            this.btCriarNovo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btCriarNovo.ForeColor = System.Drawing.SystemColors.Control;
            this.btCriarNovo.Location = new System.Drawing.Point(50, 483);
            this.btCriarNovo.Name = "btCriarNovo";
            this.btCriarNovo.Size = new System.Drawing.Size(118, 26);
            this.btCriarNovo.TabIndex = 8;
            this.btCriarNovo.Text = "Novo Registro";
            this.btCriarNovo.UseCustomBackColor = true;
            this.btCriarNovo.UseCustomForeColor = true;
            this.btCriarNovo.UseSelectable = true;
            this.btCriarNovo.UseStyleColors = true;
            this.btCriarNovo.Click += new System.EventHandler(this.btCriarNovo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 26);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(23, 127);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 26);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(23, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 26);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel2.Location = new System.Drawing.Point(687, 512);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(90, 15);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Magenta;
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Agnaldo Silva 1.0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(23, 483);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 26);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // panelPistao
            // 
            this.panelPistao.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPistao.Controls.Add(this.listViewPistao);
            this.panelPistao.Controls.Add(this.metroLabel3);
            this.panelPistao.HorizontalScrollbarBarColor = true;
            this.panelPistao.HorizontalScrollbarHighlightOnWheel = false;
            this.panelPistao.HorizontalScrollbarSize = 10;
            this.panelPistao.Location = new System.Drawing.Point(23, 376);
            this.panelPistao.Name = "panelPistao";
            this.panelPistao.Size = new System.Drawing.Size(145, 101);
            this.panelPistao.TabIndex = 8;
            this.panelPistao.UseCustomBackColor = true;
            this.panelPistao.UseCustomForeColor = true;
            this.panelPistao.UseStyleColors = true;
            this.panelPistao.VerticalScrollbarBarColor = true;
            this.panelPistao.VerticalScrollbarHighlightOnWheel = false;
            this.panelPistao.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(49, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Pistão";
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            this.metroLabel3.UseStyleColors = true;
            // 
            // listViewPistao
            // 
            this.listViewPistao.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPistaoSelecionado});
            this.listViewPistao.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewPistao.FullRowSelect = true;
            this.listViewPistao.Location = new System.Drawing.Point(3, 19);
            this.listViewPistao.Name = "listViewPistao";
            this.listViewPistao.OwnerDraw = true;
            this.listViewPistao.Size = new System.Drawing.Size(139, 79);
            this.listViewPistao.TabIndex = 3;
            this.listViewPistao.UseCompatibleStateImageBehavior = false;
            this.listViewPistao.UseSelectable = true;
            this.listViewPistao.View = System.Windows.Forms.View.List;
            // 
            // clmPistaoSelecionado
            // 
            this.clmPistaoSelecionado.Width = 135;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.metroPanel2.Controls.Add(this.listViewBBiela);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(174, 376);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(145, 101);
            this.metroPanel2.TabIndex = 9;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.UseCustomForeColor = true;
            this.metroPanel2.UseStyleColors = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // listViewBBiela
            // 
            this.listViewBBiela.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listViewBBiela.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewBBiela.FullRowSelect = true;
            this.listViewBBiela.Location = new System.Drawing.Point(3, 19);
            this.listViewBBiela.Name = "listViewBBiela";
            this.listViewBBiela.OwnerDraw = true;
            this.listViewBBiela.Size = new System.Drawing.Size(139, 79);
            this.listViewBBiela.TabIndex = 3;
            this.listViewBBiela.UseCompatibleStateImageBehavior = false;
            this.listViewBBiela.UseSelectable = true;
            this.listViewBBiela.View = System.Windows.Forms.View.List;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 135;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(49, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "B.Biela";
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            this.metroLabel4.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.panelPistao);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btCriarNovo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btPesquisaAplicacao);
            this.Controls.Add(this.btPesquisaMotor);
            this.Controls.Add(this.btPesquisaGeral);
            this.Controls.Add(this.tbAplicacao);
            this.Controls.Add(this.tbMotor);
            this.Controls.Add(this.tbFonte);
            this.Controls.Add(this.listViewMotor);
            this.Name = "Form1";
            this.Text = "Aplicação Diesel Motors";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panelPistao.ResumeLayout(false);
            this.panelPistao.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewMotor;
        private System.Windows.Forms.ColumnHeader clmIdMotor;
        private System.Windows.Forms.ColumnHeader clmModeloVeiculo;
        private System.Windows.Forms.ColumnHeader clmModeloMotor;
        private MetroFramework.Controls.MetroTextBox tbFonte;
        private MetroFramework.Controls.MetroTextBox tbMotor;
        private MetroFramework.Controls.MetroTextBox tbAplicacao;
        private MetroFramework.Controls.MetroButton btPesquisaGeral;
        private MetroFramework.Controls.MetroButton btPesquisaMotor;
        private MetroFramework.Controls.MetroButton btPesquisaAplicacao;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btCriarNovo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.ColumnHeader clmObservacao;
        private MetroFramework.Controls.MetroPanel panelPistao;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroListView listViewPistao;
        private System.Windows.Forms.ColumnHeader clmPistaoSelecionado;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroListView listViewBBiela;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}
