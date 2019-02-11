namespace PDV
{
    partial class frmPrincipal
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
            this.lblDescricao = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoUni = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbVenda = new System.Windows.Forms.GroupBox();
            this.gpbProduto = new System.Windows.Forms.GroupBox();
            this.colCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.gpbVenda.SuspendLayout();
            this.gpbProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(171, 17);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(297, 39);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição Produto";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDescricao);
            this.panel1.Location = new System.Drawing.Point(35, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 77);
            this.panel1.TabIndex = 1;
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCod,
            this.colQtd,
            this.colPrecoUni,
            this.coltotal});
            this.dgvProduto.Location = new System.Drawing.Point(295, 144);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            this.dgvProduto.Size = new System.Drawing.Size(403, 295);
            this.dgvProduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(18, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(205, 20);
            this.txtCodigo.TabIndex = 5;
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Preço unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(18, 90);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(205, 20);
            this.txtQuantidade.TabIndex = 8;
            // 
            // txtPrecoUni
            // 
            this.txtPrecoUni.Location = new System.Drawing.Point(18, 140);
            this.txtPrecoUni.Name = "txtPrecoUni";
            this.txtPrecoUni.Size = new System.Drawing.Size(205, 20);
            this.txtPrecoUni.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(18, 167);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "&Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(148, 167);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 11;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor recebido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Troco:";
            // 
            // txtTroco
            // 
            this.txtTroco.Location = new System.Drawing.Point(50, 74);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(167, 20);
            this.txtTroco.TabIndex = 15;
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.Location = new System.Drawing.Point(90, 47);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.Size = new System.Drawing.Size(127, 20);
            this.txtValorRecebido.TabIndex = 16;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(9, 123);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(208, 23);
            this.btnFinalizar.TabIndex = 17;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(309, 461);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(374, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(272, 464);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total:";
            // 
            // gpbVenda
            // 
            this.gpbVenda.Controls.Add(this.txtValorRecebido);
            this.gpbVenda.Controls.Add(this.label7);
            this.gpbVenda.Controls.Add(this.label8);
            this.gpbVenda.Controls.Add(this.btnFinalizar);
            this.gpbVenda.Controls.Add(this.txtTroco);
            this.gpbVenda.Location = new System.Drawing.Point(35, 346);
            this.gpbVenda.Name = "gpbVenda";
            this.gpbVenda.Size = new System.Drawing.Size(235, 163);
            this.gpbVenda.TabIndex = 20;
            this.gpbVenda.TabStop = false;
            this.gpbVenda.Text = "Venda";
            // 
            // gpbProduto
            // 
            this.gpbProduto.Controls.Add(this.label3);
            this.gpbProduto.Controls.Add(this.txtCodigo);
            this.gpbProduto.Controls.Add(this.label4);
            this.gpbProduto.Controls.Add(this.txtQuantidade);
            this.gpbProduto.Controls.Add(this.btnAdicionar);
            this.gpbProduto.Controls.Add(this.btnRemover);
            this.gpbProduto.Controls.Add(this.label5);
            this.gpbProduto.Controls.Add(this.txtPrecoUni);
            this.gpbProduto.Location = new System.Drawing.Point(35, 133);
            this.gpbProduto.Name = "gpbProduto";
            this.gpbProduto.Size = new System.Drawing.Size(235, 196);
            this.gpbProduto.TabIndex = 21;
            this.gpbProduto.TabStop = false;
            this.gpbProduto.Text = "Produto";
            // 
            // colCod
            // 
            this.colCod.HeaderText = "Cod";
            this.colCod.Name = "colCod";
            this.colCod.ReadOnly = true;
            // 
            // colQtd
            // 
            this.colQtd.HeaderText = "Quantidade";
            this.colQtd.Name = "colQtd";
            this.colQtd.ReadOnly = true;
            // 
            // colPrecoUni
            // 
            this.colPrecoUni.HeaderText = "Preco unitário";
            this.colPrecoUni.Name = "colPrecoUni";
            this.colPrecoUni.ReadOnly = true;
            // 
            // coltotal
            // 
            this.coltotal.HeaderText = "Total";
            this.coltotal.Name = "coltotal";
            this.coltotal.ReadOnly = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(710, 521);
            this.Controls.Add(this.gpbProduto);
            this.Controls.Add(this.gpbVenda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.panel1);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.gpbVenda.ResumeLayout(false);
            this.gpbVenda.PerformLayout();
            this.gpbProduto.ResumeLayout(false);
            this.gpbProduto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUni;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbVenda;
        private System.Windows.Forms.GroupBox gpbProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltotal;
    }
}

