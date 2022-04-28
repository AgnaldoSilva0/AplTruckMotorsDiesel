
namespace AplTruckMotorsDiesel.View
{
    partial class Form_ListaNota
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
            this.listViewListaNotas = new MetroFramework.Controls.MetroListView();
            this.clmNumeroNota = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmModelo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPlaca = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmObs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPesquisaNumero = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisar = new MetroFramework.Controls.MetroButton();
            this.btPesquisarModelo = new MetroFramework.Controls.MetroButton();
            this.tbPesquisaModelo = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisarData = new MetroFramework.Controls.MetroButton();
            this.tbPesquisaData = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisarPlaca = new MetroFramework.Controls.MetroButton();
            this.tbPesquisaPlaca = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisarNumero = new MetroFramework.Controls.MetroButton();
            this.btPesquisarCliente = new MetroFramework.Controls.MetroButton();
            this.tbPesquisarCliente = new MetroFramework.Controls.MetroTextBox();
            this.btNovaNota = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // listViewListaNotas
            // 
            this.listViewListaNotas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNumeroNota,
            this.clmCliente,
            this.clmModelo,
            this.clmPlaca,
            this.clmData,
            this.clmObs});
            this.listViewListaNotas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listViewListaNotas.FullRowSelect = true;
            this.listViewListaNotas.Location = new System.Drawing.Point(13, 131);
            this.listViewListaNotas.Name = "listViewListaNotas";
            this.listViewListaNotas.OwnerDraw = true;
            this.listViewListaNotas.Size = new System.Drawing.Size(975, 340);
            this.listViewListaNotas.TabIndex = 0;
            this.listViewListaNotas.UseCompatibleStateImageBehavior = false;
            this.listViewListaNotas.UseSelectable = true;
            this.listViewListaNotas.View = System.Windows.Forms.View.Details;
            // 
            // clmNumeroNota
            // 
            this.clmNumeroNota.Text = "Número";
            this.clmNumeroNota.Width = 127;
            // 
            // clmCliente
            // 
            this.clmCliente.Text = "Cliente";
            this.clmCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmCliente.Width = 242;
            // 
            // clmModelo
            // 
            this.clmModelo.Text = "Modelo/Cor";
            this.clmModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmModelo.Width = 133;
            // 
            // clmPlaca
            // 
            this.clmPlaca.Text = "Placa";
            this.clmPlaca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPlaca.Width = 131;
            // 
            // clmData
            // 
            this.clmData.Text = "Data";
            this.clmData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmData.Width = 128;
            // 
            // clmObs
            // 
            this.clmObs.Text = "OBS";
            this.clmObs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmObs.Width = 209;
            // 
            // tbPesquisaNumero
            // 
            // 
            // 
            // 
            this.tbPesquisaNumero.CustomButton.Image = null;
            this.tbPesquisaNumero.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tbPesquisaNumero.CustomButton.Name = "";
            this.tbPesquisaNumero.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisaNumero.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisaNumero.CustomButton.TabIndex = 1;
            this.tbPesquisaNumero.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisaNumero.CustomButton.UseSelectable = true;
            this.tbPesquisaNumero.CustomButton.Visible = false;
            this.tbPesquisaNumero.Lines = new string[0];
            this.tbPesquisaNumero.Location = new System.Drawing.Point(13, 64);
            this.tbPesquisaNumero.MaxLength = 32767;
            this.tbPesquisaNumero.Name = "tbPesquisaNumero";
            this.tbPesquisaNumero.PasswordChar = '\0';
            this.tbPesquisaNumero.PromptText = "Número";
            this.tbPesquisaNumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisaNumero.SelectedText = "";
            this.tbPesquisaNumero.SelectionLength = 0;
            this.tbPesquisaNumero.SelectionStart = 0;
            this.tbPesquisaNumero.ShortcutsEnabled = true;
            this.tbPesquisaNumero.Size = new System.Drawing.Size(134, 23);
            this.tbPesquisaNumero.TabIndex = 1;
            this.tbPesquisaNumero.UseSelectable = true;
            this.tbPesquisaNumero.WaterMark = "Número";
            this.tbPesquisaNumero.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisaNumero.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(774, 93);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(103, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Listar Todas";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btPesquisarModelo
            // 
            this.btPesquisarModelo.Location = new System.Drawing.Point(153, 93);
            this.btPesquisarModelo.Name = "btPesquisarModelo";
            this.btPesquisarModelo.Size = new System.Drawing.Size(103, 23);
            this.btPesquisarModelo.TabIndex = 4;
            this.btPesquisarModelo.Text = "Pesquisar";
            this.btPesquisarModelo.UseSelectable = true;
            this.btPesquisarModelo.Click += new System.EventHandler(this.btPesquisarModelo_Click);
            // 
            // tbPesquisaModelo
            // 
            // 
            // 
            // 
            this.tbPesquisaModelo.CustomButton.Image = null;
            this.tbPesquisaModelo.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tbPesquisaModelo.CustomButton.Name = "";
            this.tbPesquisaModelo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisaModelo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisaModelo.CustomButton.TabIndex = 1;
            this.tbPesquisaModelo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisaModelo.CustomButton.UseSelectable = true;
            this.tbPesquisaModelo.CustomButton.Visible = false;
            this.tbPesquisaModelo.Lines = new string[0];
            this.tbPesquisaModelo.Location = new System.Drawing.Point(13, 93);
            this.tbPesquisaModelo.MaxLength = 32767;
            this.tbPesquisaModelo.Name = "tbPesquisaModelo";
            this.tbPesquisaModelo.PasswordChar = '\0';
            this.tbPesquisaModelo.PromptText = "Modelo/Cor";
            this.tbPesquisaModelo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisaModelo.SelectedText = "";
            this.tbPesquisaModelo.SelectionLength = 0;
            this.tbPesquisaModelo.SelectionStart = 0;
            this.tbPesquisaModelo.ShortcutsEnabled = true;
            this.tbPesquisaModelo.Size = new System.Drawing.Size(134, 23);
            this.tbPesquisaModelo.TabIndex = 3;
            this.tbPesquisaModelo.UseSelectable = true;
            this.tbPesquisaModelo.WaterMark = "Modelo/Cor";
            this.tbPesquisaModelo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisaModelo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisarData
            // 
            this.btPesquisarData.Location = new System.Drawing.Point(494, 93);
            this.btPesquisarData.Name = "btPesquisarData";
            this.btPesquisarData.Size = new System.Drawing.Size(103, 23);
            this.btPesquisarData.TabIndex = 6;
            this.btPesquisarData.Text = "Pesquisar";
            this.btPesquisarData.UseSelectable = true;
            this.btPesquisarData.Click += new System.EventHandler(this.btPesquisarData_Click);
            // 
            // tbPesquisaData
            // 
            // 
            // 
            // 
            this.tbPesquisaData.CustomButton.Image = null;
            this.tbPesquisaData.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tbPesquisaData.CustomButton.Name = "";
            this.tbPesquisaData.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisaData.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisaData.CustomButton.TabIndex = 1;
            this.tbPesquisaData.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisaData.CustomButton.UseSelectable = true;
            this.tbPesquisaData.CustomButton.Visible = false;
            this.tbPesquisaData.Lines = new string[0];
            this.tbPesquisaData.Location = new System.Drawing.Point(354, 93);
            this.tbPesquisaData.MaxLength = 32767;
            this.tbPesquisaData.Name = "tbPesquisaData";
            this.tbPesquisaData.PasswordChar = '\0';
            this.tbPesquisaData.PromptText = "Data";
            this.tbPesquisaData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisaData.SelectedText = "";
            this.tbPesquisaData.SelectionLength = 0;
            this.tbPesquisaData.SelectionStart = 0;
            this.tbPesquisaData.ShortcutsEnabled = true;
            this.tbPesquisaData.Size = new System.Drawing.Size(134, 23);
            this.tbPesquisaData.TabIndex = 5;
            this.tbPesquisaData.UseSelectable = true;
            this.tbPesquisaData.WaterMark = "Data";
            this.tbPesquisaData.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisaData.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisarPlaca
            // 
            this.btPesquisarPlaca.Location = new System.Drawing.Point(494, 63);
            this.btPesquisarPlaca.Name = "btPesquisarPlaca";
            this.btPesquisarPlaca.Size = new System.Drawing.Size(103, 23);
            this.btPesquisarPlaca.TabIndex = 8;
            this.btPesquisarPlaca.Text = "Pesquisar";
            this.btPesquisarPlaca.UseSelectable = true;
            this.btPesquisarPlaca.Click += new System.EventHandler(this.btPesquisarPlaca_Click);
            // 
            // tbPesquisaPlaca
            // 
            // 
            // 
            // 
            this.tbPesquisaPlaca.CustomButton.Image = null;
            this.tbPesquisaPlaca.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tbPesquisaPlaca.CustomButton.Name = "";
            this.tbPesquisaPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisaPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisaPlaca.CustomButton.TabIndex = 1;
            this.tbPesquisaPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisaPlaca.CustomButton.UseSelectable = true;
            this.tbPesquisaPlaca.CustomButton.Visible = false;
            this.tbPesquisaPlaca.Lines = new string[0];
            this.tbPesquisaPlaca.Location = new System.Drawing.Point(354, 63);
            this.tbPesquisaPlaca.MaxLength = 32767;
            this.tbPesquisaPlaca.Name = "tbPesquisaPlaca";
            this.tbPesquisaPlaca.PasswordChar = '\0';
            this.tbPesquisaPlaca.PromptText = "Placa";
            this.tbPesquisaPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisaPlaca.SelectedText = "";
            this.tbPesquisaPlaca.SelectionLength = 0;
            this.tbPesquisaPlaca.SelectionStart = 0;
            this.tbPesquisaPlaca.ShortcutsEnabled = true;
            this.tbPesquisaPlaca.Size = new System.Drawing.Size(134, 23);
            this.tbPesquisaPlaca.TabIndex = 7;
            this.tbPesquisaPlaca.UseSelectable = true;
            this.tbPesquisaPlaca.WaterMark = "Placa";
            this.tbPesquisaPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisaPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisarNumero
            // 
            this.btPesquisarNumero.Location = new System.Drawing.Point(153, 63);
            this.btPesquisarNumero.Name = "btPesquisarNumero";
            this.btPesquisarNumero.Size = new System.Drawing.Size(103, 23);
            this.btPesquisarNumero.TabIndex = 9;
            this.btPesquisarNumero.Text = "Pesquisar";
            this.btPesquisarNumero.UseSelectable = true;
            this.btPesquisarNumero.Click += new System.EventHandler(this.btPesquisarNumero_Click);
            // 
            // btPesquisarCliente
            // 
            this.btPesquisarCliente.Location = new System.Drawing.Point(774, 63);
            this.btPesquisarCliente.Name = "btPesquisarCliente";
            this.btPesquisarCliente.Size = new System.Drawing.Size(103, 23);
            this.btPesquisarCliente.TabIndex = 11;
            this.btPesquisarCliente.Text = "Pesquisar";
            this.btPesquisarCliente.UseSelectable = true;
            this.btPesquisarCliente.Click += new System.EventHandler(this.btPesquisarCliente_Click);
            // 
            // tbPesquisarCliente
            // 
            // 
            // 
            // 
            this.tbPesquisarCliente.CustomButton.Image = null;
            this.tbPesquisarCliente.CustomButton.Location = new System.Drawing.Point(112, 1);
            this.tbPesquisarCliente.CustomButton.Name = "";
            this.tbPesquisarCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisarCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisarCliente.CustomButton.TabIndex = 1;
            this.tbPesquisarCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisarCliente.CustomButton.UseSelectable = true;
            this.tbPesquisarCliente.CustomButton.Visible = false;
            this.tbPesquisarCliente.Lines = new string[0];
            this.tbPesquisarCliente.Location = new System.Drawing.Point(634, 63);
            this.tbPesquisarCliente.MaxLength = 32767;
            this.tbPesquisarCliente.Name = "tbPesquisarCliente";
            this.tbPesquisarCliente.PasswordChar = '\0';
            this.tbPesquisarCliente.PromptText = "Cliente";
            this.tbPesquisarCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisarCliente.SelectedText = "";
            this.tbPesquisarCliente.SelectionLength = 0;
            this.tbPesquisarCliente.SelectionStart = 0;
            this.tbPesquisarCliente.ShortcutsEnabled = true;
            this.tbPesquisarCliente.Size = new System.Drawing.Size(134, 23);
            this.tbPesquisarCliente.TabIndex = 10;
            this.tbPesquisarCliente.UseSelectable = true;
            this.tbPesquisarCliente.WaterMark = "Cliente";
            this.tbPesquisarCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisarCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btNovaNota
            // 
            this.btNovaNota.Location = new System.Drawing.Point(13, 477);
            this.btNovaNota.Name = "btNovaNota";
            this.btNovaNota.Size = new System.Drawing.Size(103, 29);
            this.btNovaNota.TabIndex = 12;
            this.btNovaNota.Text = "NOVO";
            this.btNovaNota.UseSelectable = true;
            this.btNovaNota.Click += new System.EventHandler(this.btNovaNota_Click);
            // 
            // Form_ListaNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 516);
            this.Controls.Add(this.btNovaNota);
            this.Controls.Add(this.btPesquisarCliente);
            this.Controls.Add(this.tbPesquisarCliente);
            this.Controls.Add(this.btPesquisarNumero);
            this.Controls.Add(this.btPesquisarPlaca);
            this.Controls.Add(this.tbPesquisaPlaca);
            this.Controls.Add(this.btPesquisarData);
            this.Controls.Add(this.tbPesquisaData);
            this.Controls.Add(this.btPesquisarModelo);
            this.Controls.Add(this.tbPesquisaModelo);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbPesquisaNumero);
            this.Controls.Add(this.listViewListaNotas);
            this.Name = "Form_ListaNota";
            this.Text = "Notas";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView listViewListaNotas;
        private System.Windows.Forms.ColumnHeader clmNumeroNota;
        private System.Windows.Forms.ColumnHeader clmCliente;
        private System.Windows.Forms.ColumnHeader clmModelo;
        private System.Windows.Forms.ColumnHeader clmPlaca;
        private System.Windows.Forms.ColumnHeader clmData;
        private System.Windows.Forms.ColumnHeader clmObs;
        private MetroFramework.Controls.MetroTextBox tbPesquisaNumero;
        private MetroFramework.Controls.MetroButton btPesquisar;
        private MetroFramework.Controls.MetroButton btPesquisarModelo;
        private MetroFramework.Controls.MetroTextBox tbPesquisaModelo;
        private MetroFramework.Controls.MetroButton btPesquisarData;
        private MetroFramework.Controls.MetroTextBox tbPesquisaData;
        private MetroFramework.Controls.MetroButton btPesquisarPlaca;
        private MetroFramework.Controls.MetroTextBox tbPesquisaPlaca;
        private MetroFramework.Controls.MetroButton btPesquisarNumero;
        private MetroFramework.Controls.MetroButton btPesquisarCliente;
        private MetroFramework.Controls.MetroTextBox tbPesquisarCliente;
        private MetroFramework.Controls.MetroButton btNovaNota;
    }
}