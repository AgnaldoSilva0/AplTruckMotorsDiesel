
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Amalcaburio));
            this.ListViewProdutos = new MetroFramework.Controls.MetroListView();
            this.clmCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmPreco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIpi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPesquisar = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPrecoVenda = new System.Windows.Forms.Label();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.cbMostrarValorCompra = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ListViewProdutos
            // 
            this.ListViewProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmCodigo,
            this.clmDescricao,
            this.clmPreco,
            this.clmIpi});
            this.ListViewProdutos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ListViewProdutos.FullRowSelect = true;
            this.ListViewProdutos.Location = new System.Drawing.Point(23, 123);
            this.ListViewProdutos.Name = "ListViewProdutos";
            this.ListViewProdutos.OwnerDraw = true;
            this.ListViewProdutos.Size = new System.Drawing.Size(691, 301);
            this.ListViewProdutos.TabIndex = 0;
            this.ListViewProdutos.UseCompatibleStateImageBehavior = false;
            this.ListViewProdutos.UseSelectable = true;
            this.ListViewProdutos.View = System.Windows.Forms.View.Details;
            this.ListViewProdutos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewProdutos_MouseClick);
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Código";
            this.clmCodigo.Width = 82;
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
            this.clmPreco.Width = 0;
            // 
            // clmIpi
            // 
            this.clmIpi.Text = "IPI";
            this.clmIpi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmIpi.Width = 65;
            // 
            // tbPesquisar
            // 
            // 
            // 
            // 
            this.tbPesquisar.CustomButton.Image = null;
            this.tbPesquisar.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.tbPesquisar.CustomButton.Name = "";
            this.tbPesquisar.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.tbPesquisar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPesquisar.CustomButton.TabIndex = 1;
            this.tbPesquisar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPesquisar.CustomButton.UseSelectable = true;
            this.tbPesquisar.CustomButton.Visible = false;
            this.tbPesquisar.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.tbPesquisar.Lines = new string[0];
            this.tbPesquisar.Location = new System.Drawing.Point(23, 85);
            this.tbPesquisar.MaxLength = 100;
            this.tbPesquisar.Name = "tbPesquisar";
            this.tbPesquisar.PasswordChar = '\0';
            this.tbPesquisar.PromptText = "Font";
            this.tbPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPesquisar.SelectedText = "";
            this.tbPesquisar.SelectionLength = 0;
            this.tbPesquisar.SelectionStart = 0;
            this.tbPesquisar.ShortcutsEnabled = true;
            this.tbPesquisar.Size = new System.Drawing.Size(150, 35);
            this.tbPesquisar.TabIndex = 1;
            this.tbPesquisar.UseSelectable = true;
            this.tbPesquisar.WaterMark = "Font";
            this.tbPesquisar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPesquisar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesquisar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPesquisar_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 458);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Preço Venda:";
            // 
            // lbPrecoVenda
            // 
            this.lbPrecoVenda.AutoSize = true;
            this.lbPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoVenda.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbPrecoVenda.Location = new System.Drawing.Point(175, 459);
            this.lbPrecoVenda.Name = "lbPrecoVenda";
            this.lbPrecoVenda.Size = new System.Drawing.Size(38, 24);
            this.lbPrecoVenda.TabIndex = 4;
            this.lbPrecoVenda.Text = "0.0";
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDescricao.Location = new System.Drawing.Point(19, 431);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(25, 24);
            this.lbDescricao.TabIndex = 5;
            this.lbDescricao.Text = "...";
            // 
            // cbMostrarValorCompra
            // 
            this.cbMostrarValorCompra.AutoSize = true;
            this.cbMostrarValorCompra.Location = new System.Drawing.Point(505, 103);
            this.cbMostrarValorCompra.Name = "cbMostrarValorCompra";
            this.cbMostrarValorCompra.Size = new System.Drawing.Size(150, 17);
            this.cbMostrarValorCompra.TabIndex = 6;
            this.cbMostrarValorCompra.Text = "Monstrar preço de compra";
            this.cbMostrarValorCompra.UseVisualStyleBackColor = true;
            this.cbMostrarValorCompra.CheckedChanged += new System.EventHandler(this.cbMostrarValorCompra_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(140, 454);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(179, 85);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(126, 36);
            this.btPesquisar.TabIndex = 8;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btPesquisar.UseVisualStyleBackColor = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // Form_Amalcaburio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 490);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbMostrarValorCompra);
            this.Controls.Add(this.lbDescricao);
            this.Controls.Add(this.lbPrecoVenda);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPesquisar);
            this.Controls.Add(this.ListViewProdutos);
            this.Name = "Form_Amalcaburio";
            this.Text = "Amalcaburio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView ListViewProdutos;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ColumnHeader clmDescricao;
        private System.Windows.Forms.ColumnHeader clmPreco;
        private System.Windows.Forms.ColumnHeader clmIpi;
        private MetroFramework.Controls.MetroTextBox tbPesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPrecoVenda;
        private System.Windows.Forms.Label lbDescricao;
        private System.Windows.Forms.CheckBox cbMostrarValorCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btPesquisar;
    }
}