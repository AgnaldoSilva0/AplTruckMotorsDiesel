
namespace AplTruckMotorsDiesel.View
{
    partial class FichaTecnica
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
            this.lbCodigo = new MetroFramework.Controls.MetroLabel();
            this.lbCodigoOriginal = new MetroFramework.Controls.MetroLabel();
            this.lbMarca = new MetroFramework.Controls.MetroLabel();
            this.lbObservacao = new MetroFramework.Controls.MetroLabel();
            this.lbItem = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.Location = new System.Drawing.Point(23, 60);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(438, 22);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "NULL";
            // 
            // lbCodigoOriginal
            // 
            this.lbCodigoOriginal.Location = new System.Drawing.Point(23, 84);
            this.lbCodigoOriginal.Name = "lbCodigoOriginal";
            this.lbCodigoOriginal.Size = new System.Drawing.Size(438, 23);
            this.lbCodigoOriginal.TabIndex = 1;
            this.lbCodigoOriginal.Text = "NULL";
            // 
            // lbMarca
            // 
            this.lbMarca.Location = new System.Drawing.Point(23, 107);
            this.lbMarca.Name = "lbMarca";
            this.lbMarca.Size = new System.Drawing.Size(438, 23);
            this.lbMarca.TabIndex = 2;
            this.lbMarca.Text = "NULL";
            // 
            // lbObservacao
            // 
            this.lbObservacao.Location = new System.Drawing.Point(23, 130);
            this.lbObservacao.Name = "lbObservacao";
            this.lbObservacao.Size = new System.Drawing.Size(438, 81);
            this.lbObservacao.TabIndex = 3;
            this.lbObservacao.Text = "NULL";
            // 
            // lbItem
            // 
            this.lbItem.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbItem.Location = new System.Drawing.Point(214, 16);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(268, 27);
            this.lbItem.TabIndex = 4;
            this.lbItem.Text = "Item";
            // 
            // FichaTecnica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 228);
            this.Controls.Add(this.lbItem);
            this.Controls.Add(this.lbObservacao);
            this.Controls.Add(this.lbMarca);
            this.Controls.Add(this.lbCodigoOriginal);
            this.Controls.Add(this.lbCodigo);
            this.Name = "FichaTecnica";
            this.Text = "FichaTecnica";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lbCodigo;
        private MetroFramework.Controls.MetroLabel lbCodigoOriginal;
        private MetroFramework.Controls.MetroLabel lbMarca;
        private MetroFramework.Controls.MetroLabel lbObservacao;
        private MetroFramework.Controls.MetroLabel lbItem;
    }
}