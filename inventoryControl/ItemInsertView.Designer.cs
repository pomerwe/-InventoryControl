namespace inventoryControl
{
    partial class ItemInsertView
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.codItemInput = new System.Windows.Forms.TextBox();
            this.nomeInput = new System.Windows.Forms.TextBox();
            this.codItemLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.ultimoLancamentoLabel = new System.Windows.Forms.Label();
            this.ultimoLancamentoDatePicker = new System.Windows.Forms.DateTimePicker();
            this.quantidadeInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(499, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(282, 59);
            this.title.TabIndex = 1;
            this.title.Text = "Inserir Item";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(1109, 603);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(137, 49);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancelar";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(947, 603);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 49);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Salvar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // codItemInput
            // 
            this.codItemInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codItemInput.Location = new System.Drawing.Point(392, 159);
            this.codItemInput.Name = "codItemInput";
            this.codItemInput.Size = new System.Drawing.Size(474, 48);
            this.codItemInput.TabIndex = 4;
            this.codItemInput.TextChanged += new System.EventHandler(this.OnCodChange);
            // 
            // nomeInput
            // 
            this.nomeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeInput.Location = new System.Drawing.Point(392, 262);
            this.nomeInput.Name = "nomeInput";
            this.nomeInput.Size = new System.Drawing.Size(474, 48);
            this.nomeInput.TabIndex = 5;
            this.nomeInput.TextChanged += new System.EventHandler(this.nomeInput_TextChanged);
            // 
            // codItemLabel
            // 
            this.codItemLabel.AutoSize = true;
            this.codItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codItemLabel.Location = new System.Drawing.Point(388, 127);
            this.codItemLabel.Name = "codItemLabel";
            this.codItemLabel.Size = new System.Drawing.Size(178, 29);
            this.codItemLabel.TabIndex = 8;
            this.codItemLabel.Text = "Código do Item";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(387, 230);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(79, 29);
            this.itemNameLabel.TabIndex = 9;
            this.itemNameLabel.Text = "Nome";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(387, 333);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(138, 29);
            this.quantityLabel.TabIndex = 10;
            this.quantityLabel.Text = "Quantidade";
            // 
            // ultimoLancamentoLabel
            // 
            this.ultimoLancamentoLabel.AutoSize = true;
            this.ultimoLancamentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoLancamentoLabel.Location = new System.Drawing.Point(387, 436);
            this.ultimoLancamentoLabel.Name = "ultimoLancamentoLabel";
            this.ultimoLancamentoLabel.Size = new System.Drawing.Size(284, 29);
            this.ultimoLancamentoLabel.TabIndex = 11;
            this.ultimoLancamentoLabel.Text = "Ultimo Lançamento(Data)";
            // 
            // ultimoLancamentoDatePicker
            // 
            this.ultimoLancamentoDatePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ultimoLancamentoDatePicker.Location = new System.Drawing.Point(392, 468);
            this.ultimoLancamentoDatePicker.Name = "ultimoLancamentoDatePicker";
            this.ultimoLancamentoDatePicker.Size = new System.Drawing.Size(474, 26);
            this.ultimoLancamentoDatePicker.TabIndex = 12;
            this.ultimoLancamentoDatePicker.ValueChanged += new System.EventHandler(this.ultimoLancamentoDatePicker_ValueChanged);
            // 
            // quantidadeInput
            // 
            this.quantidadeInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantidadeInput.Location = new System.Drawing.Point(393, 365);
            this.quantidadeInput.Name = "quantidadeInput";
            this.quantidadeInput.Size = new System.Drawing.Size(144, 48);
            this.quantidadeInput.TabIndex = 13;
            this.quantidadeInput.ValueChanged += new System.EventHandler(this.quantidadeInput_ValueChanged);
            // 
            // ItemInsertView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.quantidadeInput);
            this.Controls.Add(this.ultimoLancamentoDatePicker);
            this.Controls.Add(this.ultimoLancamentoLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.itemNameLabel);
            this.Controls.Add(this.codItemLabel);
            this.Controls.Add(this.nomeInput);
            this.Controls.Add(this.codItemInput);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.title);
            this.Name = "ItemInsertView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Control - Item Insert";
            ((System.ComponentModel.ISupportInitialize)(this.quantidadeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox codItemInput;
        private System.Windows.Forms.TextBox nomeInput;
        private System.Windows.Forms.Label codItemLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label ultimoLancamentoLabel;
        private System.Windows.Forms.DateTimePicker ultimoLancamentoDatePicker;
        private System.Windows.Forms.NumericUpDown quantidadeInput;
    }
}