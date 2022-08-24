
namespace AplTruckMotorsDiesel
{
    partial class Sistemas
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
            this.btAplicacoesDiesel = new MetroFramework.Controls.MetroButton();
            this.btNotas = new MetroFramework.Controls.MetroButton();
            this.btAmalcaburio = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btAplicacoesDiesel
            // 
            this.btAplicacoesDiesel.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btAplicacoesDiesel.Location = new System.Drawing.Point(23, 115);
            this.btAplicacoesDiesel.Name = "btAplicacoesDiesel";
            this.btAplicacoesDiesel.Size = new System.Drawing.Size(311, 47);
            this.btAplicacoesDiesel.Style = MetroFramework.MetroColorStyle.White;
            this.btAplicacoesDiesel.TabIndex = 0;
            this.btAplicacoesDiesel.Text = "Aplicações Diesel";
            this.btAplicacoesDiesel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btAplicacoesDiesel.UseSelectable = true;
            this.btAplicacoesDiesel.UseStyleColors = true;
            this.btAplicacoesDiesel.Click += new System.EventHandler(this.btAplicacoesDiesel_Click);
            // 
            // btNotas
            // 
            this.btNotas.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btNotas.Location = new System.Drawing.Point(23, 168);
            this.btNotas.Name = "btNotas";
            this.btNotas.Size = new System.Drawing.Size(311, 47);
            this.btNotas.Style = MetroFramework.MetroColorStyle.White;
            this.btNotas.TabIndex = 1;
            this.btNotas.Text = "Notas";
            this.btNotas.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btNotas.UseSelectable = true;
            this.btNotas.UseStyleColors = true;
            this.btNotas.Click += new System.EventHandler(this.btNotas_Click);
            // 
            // btAmalcaburio
            // 
            this.btAmalcaburio.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btAmalcaburio.Location = new System.Drawing.Point(23, 221);
            this.btAmalcaburio.Name = "btAmalcaburio";
            this.btAmalcaburio.Size = new System.Drawing.Size(311, 47);
            this.btAmalcaburio.Style = MetroFramework.MetroColorStyle.White;
            this.btAmalcaburio.TabIndex = 2;
            this.btAmalcaburio.Text = "Amalcaburio";
            this.btAmalcaburio.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btAmalcaburio.UseSelectable = true;
            this.btAmalcaburio.UseStyleColors = true;
            this.btAmalcaburio.Click += new System.EventHandler(this.btAmalcaburio_Click);
            // 
            // Sistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 314);
            this.Controls.Add(this.btAmalcaburio);
            this.Controls.Add(this.btNotas);
            this.Controls.Add(this.btAplicacoesDiesel);
            this.Name = "Sistemas";
            this.Text = "Sistemas";
            this.Load += new System.EventHandler(this.Sistemas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btAplicacoesDiesel;
        private MetroFramework.Controls.MetroButton btNotas;
        private MetroFramework.Controls.MetroButton btAmalcaburio;
    }
}