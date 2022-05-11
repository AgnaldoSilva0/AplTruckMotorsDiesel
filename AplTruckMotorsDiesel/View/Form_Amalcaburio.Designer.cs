
namespace AplTruckMotorsDiesel.View
{
    partial class Form_Amalcaburio
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
            this.ListViewItens = new MetroFramework.Controls.MetroListView();
            this.clmCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIpi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.btPesquisar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListViewItens
            // 
            this.ListViewItens.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodigo,
            this.clmDescricao,
            this.clmPreco,
            this.clmIpi});
            this.ListViewItens.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewItens.FullRowSelect = true;
            this.ListViewItens.Location = new System.Drawing.Point(23, 123);
            this.ListViewItens.Name = "ListViewItens";
            this.ListViewItens.OwnerDraw = true;
            this.ListViewItens.Size = new System.Drawing.Size(691, 301);
            this.ListViewItens.TabIndex = 0;
            this.ListViewItens.UseCompatibleStateImageBehavior = false;
            this.ListViewItens.UseSelectable = true;
            this.ListViewItens.View = System.Windows.Forms.View.Details;
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Código";
            this.clmCodigo.Width = 89;
            // 
            // clmDescricao
            // 
            this.clmDescricao.Text = "Descrição";
            this.clmDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmDescricao.Width = 413;
            // 
            // clmPreco
            // 
            this.clmPreco.Text = "Preço Compra";
            this.clmPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmPreco.Width = 123;
            // 
            // clmIpi
            // 
            this.clmIpi.Text = "IPI";
            this.clmIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmIpi.Width = 56;
            // 
            // tbPesquisar
            // 
            // 
            // 
            // 
            this.tbPesquisar.CustomButton.Image = null;
            this.tbPesquisar.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.tbPesquisar.CustomButton.Name = "";
            this.tbPesquisar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisar.CustomButton.TabIndex = 1;
            this.tbPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisar.CustomButton.UseSelectable = true;
            this.tbPesquisar.CustomButton.Visible = false;
            this.tbPesquisar.Lines = new string[0];
            this.tbPesquisar.Location = new System.Drawing.Point(23, 94);
            this.tbPesquisar.MaxLength = 32767;
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.PasswordChar = '\0';
            this.tbPesquisar.PromptText = "Font";
            this.tbPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisar.SelectedText = "";
            this.tbPesquisar.SelectionLength = 0;
            this.tbPesquisar.SelectionStart = 0;
            this.tbPesquisar.ShortcutsEnabled = true;
            this.tbPesquisar.Size = new System.Drawing.Size(144, 23);
            this.tbPesquisar.TabIndex = 1;
            this.tbPesquisar.UseSelectable = true;
            this.tbPesquisar.WaterMark = "Font";
            this.tbPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btPesquisar.Location = new System.Drawing.Point(173, 94);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btPesquisar.TabIndex = 2;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preço Venda:";
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoVenda.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbPrecoVenda.Location = new System.Drawing.Point(155, 446);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(35, 24);
            this.lbPrecoVenda.TabIndex = 4;
            this.lbPrecoVenda.Text = "0.0";
            // 
            // Form_Amalcaburio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 490);
            this.Controls.Add(this.lbPrecoVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.ListViewItens);
            this.Name = "Form_Amalcaburio";
            this.Text = "Amalcaburio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView ListViewItens;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmPreco;
        private System.Windows.Forms.ColumnHeader clmIpi;
        private MetroFramework.Controls.MetroTextBox tbPesquisar;
        private MetroFramework.Controls.MetroButton btPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrecoVenda;
    }
}