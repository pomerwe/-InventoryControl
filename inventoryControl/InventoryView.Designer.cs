namespace inventoryControl
{
    partial class InventoryView
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
            this.title = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.TableLayoutPanel();
            this.codLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.quantitadeLabel = new System.Windows.Forms.Label();
            this.ultimoLancamentoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(532, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(216, 59);
            this.title.TabIndex = 2;
            this.title.Text = "Estoque";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(1109, 603);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(137, 49);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Voltar";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // grid
            // 
            this.grid.AutoScroll = true;
            this.grid.AutoSize = true;
            this.grid.ColumnCount = 4;
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.84498F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.38602F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.65147F));
            this.grid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.32016F));
            this.grid.Location = new System.Drawing.Point(47, 126);
            this.grid.MaximumSize = new System.Drawing.Size(1013, 507);
            this.grid.Name = "grid";
            this.grid.RowCount = 1;
            this.grid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.grid.Size = new System.Drawing.Size(1013, 40);
            this.grid.TabIndex = 5;
            // 
            // codLabel
            // 
            this.codLabel.AutoSize = true;
            this.codLabel.Location = new System.Drawing.Point(43, 93);
            this.codLabel.Name = "codLabel";
            this.codLabel.Size = new System.Drawing.Size(59, 20);
            this.codLabel.TabIndex = 6;
            this.codLabel.Text = "Código";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(233, 93);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(51, 20);
            this.nomeLabel.TabIndex = 7;
            this.nomeLabel.Text = "Nome";
            // 
            // quantitadeLabel
            // 
            this.quantitadeLabel.AutoSize = true;
            this.quantitadeLabel.Location = new System.Drawing.Point(601, 93);
            this.quantitadeLabel.Name = "quantitadeLabel";
            this.quantitadeLabel.Size = new System.Drawing.Size(92, 20);
            this.quantitadeLabel.TabIndex = 8;
            this.quantitadeLabel.Text = "Quantidade";
            // 
            // ultimoLancamentoLabel
            // 
            this.ultimoLancamentoLabel.AutoSize = true;
            this.ultimoLancamentoLabel.Location = new System.Drawing.Point(719, 93);
            this.ultimoLancamentoLabel.Name = "ultimoLancamentoLabel";
            this.ultimoLancamentoLabel.Size = new System.Drawing.Size(147, 20);
            this.ultimoLancamentoLabel.TabIndex = 9;
            this.ultimoLancamentoLabel.Text = "Ultimo Lançamento";
            // 
            // InventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.ultimoLancamentoLabel);
            this.Controls.Add(this.quantitadeLabel);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.codLabel);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.title);
            this.Name = "InventoryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control - Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel grid;
        private System.Windows.Forms.Label codLabel;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label quantitadeLabel;
        private System.Windows.Forms.Label ultimoLancamentoLabel;
    }
}