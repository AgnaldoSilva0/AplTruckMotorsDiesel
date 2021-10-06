
namespace AplTruckMotorsDiesel.View
{
    partial class VincularAplicacao
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
            this.cbModeloVeiculo = new MetroFramework.Controls.MetroComboBox();
            this.cbBbiela = new MetroFramework.Controls.MetroComboBox();
            this.cbBmancal = new MetroFramework.Controls.MetroComboBox();
            this.cbJunta = new MetroFramework.Controls.MetroComboBox();
            this.cbPistao = new MetroFramework.Controls.MetroComboBox();
            this.cbBoleo = new MetroFramework.Controls.MetroComboBox();
            this.cbAneis = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbVeiculoSelecionado = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.cbBagua = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cbKitMotor = new MetroFramework.Controls.MetroComboBox();
            this.btVincular = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cbModeloVeiculo
            // 
            this.cbModeloVeiculo.FormattingEnabled = true;
            this.cbModeloVeiculo.ItemHeight = 23;
            this.cbModeloVeiculo.Location = new System.Drawing.Point(94, 68);
            this.cbModeloVeiculo.Name = "cbModeloVeiculo";
            this.cbModeloVeiculo.Size = new System.Drawing.Size(121, 29);
            this.cbModeloVeiculo.TabIndex = 0;
            this.cbModeloVeiculo.UseSelectable = true;
            this.cbModeloVeiculo.SelectedIndexChanged += new System.EventHandler(this.cbModeloVeiculo_SelectedIndexChanged);
            // 
            // cbBbiela
            // 
            this.cbBbiela.FormattingEnabled = true;
            this.cbBbiela.ItemHeight = 23;
            this.cbBbiela.Location = new System.Drawing.Point(94, 173);
            this.cbBbiela.Name = "cbBbiela";
            this.cbBbiela.Size = new System.Drawing.Size(121, 29);
            this.cbBbiela.TabIndex = 1;
            this.cbBbiela.UseSelectable = true;
            // 
            // cbBmancal
            // 
            this.cbBmancal.FormattingEnabled = true;
            this.cbBmancal.ItemHeight = 23;
            this.cbBmancal.Location = new System.Drawing.Point(94, 208);
            this.cbBmancal.Name = "cbBmancal";
            this.cbBmancal.Size = new System.Drawing.Size(121, 29);
            this.cbBmancal.TabIndex = 2;
            this.cbBmancal.UseSelectable = true;
            // 
            // cbJunta
            // 
            this.cbJunta.FormattingEnabled = true;
            this.cbJunta.ItemHeight = 23;
            this.cbJunta.Location = new System.Drawing.Point(94, 243);
            this.cbJunta.Name = "cbJunta";
            this.cbJunta.Size = new System.Drawing.Size(121, 29);
            this.cbJunta.TabIndex = 3;
            this.cbJunta.UseSelectable = true;
            // 
            // cbPistao
            // 
            this.cbPistao.FormattingEnabled = true;
            this.cbPistao.ItemHeight = 23;
            this.cbPistao.Location = new System.Drawing.Point(94, 103);
            this.cbPistao.Name = "cbPistao";
            this.cbPistao.Size = new System.Drawing.Size(121, 29);
            this.cbPistao.TabIndex = 4;
            this.cbPistao.UseSelectable = true;
            // 
            // cbBoleo
            // 
            this.cbBoleo.FormattingEnabled = true;
            this.cbBoleo.ItemHeight = 23;
            this.cbBoleo.Location = new System.Drawing.Point(94, 278);
            this.cbBoleo.Name = "cbBoleo";
            this.cbBoleo.Size = new System.Drawing.Size(121, 29);
            this.cbBoleo.TabIndex = 5;
            this.cbBoleo.UseSelectable = true;
            // 
            // cbAneis
            // 
            this.cbAneis.FormattingEnabled = true;
            this.cbAneis.ItemHeight = 23;
            this.cbAneis.Location = new System.Drawing.Point(94, 138);
            this.cbAneis.Name = "cbAneis";
            this.cbAneis.Size = new System.Drawing.Size(121, 29);
            this.cbAneis.TabIndex = 6;
            this.cbAneis.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(26, 73);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Veiculo:";
            // 
            // lbVeiculoSelecionado
            // 
            this.lbVeiculoSelecionado.AutoSize = true;
            this.lbVeiculoSelecionado.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lbVeiculoSelecionado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbVeiculoSelecionado.Location = new System.Drawing.Point(221, 73);
            this.lbVeiculoSelecionado.Name = "lbVeiculoSelecionado";
            this.lbVeiculoSelecionado.Size = new System.Drawing.Size(121, 19);
            this.lbVeiculoSelecionado.TabIndex = 8;
            this.lbVeiculoSelecionado.Text = "Motor Selecionado";
            this.lbVeiculoSelecionado.UseCustomForeColor = true;
            this.lbVeiculoSelecionado.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(26, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(44, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "Pistão";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(26, 146);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Anéis:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(26, 253);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(49, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "J.Junta:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(26, 183);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(48, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "B.Biela";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(26, 218);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(62, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "B.Mancal";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(26, 288);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(49, 19);
            this.metroLabel8.TabIndex = 14;
            this.metroLabel8.Text = "B.Oleo";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(26, 323);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(51, 19);
            this.metroLabel10.TabIndex = 17;
            this.metroLabel10.Text = "B.Agua";
            // 
            // cbBagua
            // 
            this.cbBagua.FormattingEnabled = true;
            this.cbBagua.ItemHeight = 23;
            this.cbBagua.Location = new System.Drawing.Point(94, 313);
            this.cbBagua.Name = "cbBagua";
            this.cbBagua.Size = new System.Drawing.Size(121, 29);
            this.cbBagua.TabIndex = 16;
            this.cbBagua.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(26, 358);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(67, 19);
            this.metroLabel11.TabIndex = 19;
            this.metroLabel11.Text = "KIT Motor";
            // 
            // cbKitMotor
            // 
            this.cbKitMotor.FormattingEnabled = true;
            this.cbKitMotor.ItemHeight = 23;
            this.cbKitMotor.Location = new System.Drawing.Point(94, 348);
            this.cbKitMotor.Name = "cbKitMotor";
            this.cbKitMotor.Size = new System.Drawing.Size(121, 29);
            this.cbKitMotor.TabIndex = 18;
            this.cbKitMotor.UseSelectable = true;
            // 
            // btVincular
            // 
            this.btVincular.BackColor = System.Drawing.Color.Cyan;
            this.btVincular.Location = new System.Drawing.Point(-1, 401);
            this.btVincular.Name = "btVincular";
            this.btVincular.Size = new System.Drawing.Size(370, 48);
            this.btVincular.TabIndex = 20;
            this.btVincular.Text = "Vincular";
            this.btVincular.UseCustomBackColor = true;
            this.btVincular.UseSelectable = true;
            this.btVincular.Click += new System.EventHandler(this.btVincular_Click);
            // 
            // VincularAplicacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 461);
            this.Controls.Add(this.btVincular);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.cbKitMotor);
            this.Controls.Add(this.metroLabel10);
            this.Controls.Add(this.cbBagua);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lbVeiculoSelecionado);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cbAneis);
            this.Controls.Add(this.cbBoleo);
            this.Controls.Add(this.cbPistao);
            this.Controls.Add(this.cbJunta);
            this.Controls.Add(this.cbBmancal);
            this.Controls.Add(this.cbBbiela);
            this.Controls.Add(this.cbModeloVeiculo);
            this.Name = "VincularAplicacao";
            this.Text = "VincularAplicacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox cbModeloVeiculo;
        private MetroFramework.Controls.MetroComboBox cbBbiela;
        private MetroFramework.Controls.MetroComboBox cbBmancal;
        private MetroFramework.Controls.MetroComboBox cbJunta;
        private MetroFramework.Controls.MetroComboBox cbPistao;
        private MetroFramework.Controls.MetroComboBox cbBoleo;
        private MetroFramework.Controls.MetroComboBox cbAneis;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbVeiculoSelecionado;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroComboBox cbBagua;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cbKitMotor;
        private MetroFramework.Controls.MetroButton btVincular;
    }
}