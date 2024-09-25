namespace GerencadorDePessoas
{
    partial class gerenciadorDePessoas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNome = new Label();
            lblIdade = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            label1 = new Label();
            lblMensagem = new Label();
            btnCriarPessoa = new Button();
            SuspendLayout();
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblNome.ForeColor = SystemColors.HotTrack;
            lblNome.Location = new Point(214, 120);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 0;
            lblNome.Text = "Nome:";
            lblNome.Click += lblNome_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblIdade.ForeColor = SystemColors.HotTrack;
            lblIdade.Location = new Point(214, 185);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(65, 28);
            lblIdade.TabIndex = 1;
            lblIdade.Text = "Idade:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtNome.Location = new Point(285, 120);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(288, 34);
            txtNome.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdade.Location = new Point(285, 182);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(78, 34);
            txtIdade.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "label1";
            // 
            // lblMensagem
            // 
            lblMensagem.AutoSize = true;
            lblMensagem.Location = new Point(70, 365);
            lblMensagem.Name = "lblMensagem";
            lblMensagem.Size = new Size(0, 15);
            lblMensagem.TabIndex = 7;
            // 
            // btnCriarPessoa
            // 
            btnCriarPessoa.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriarPessoa.Location = new Point(285, 263);
            btnCriarPessoa.Name = "btnCriarPessoa";
            btnCriarPessoa.Size = new Size(116, 35);
            btnCriarPessoa.TabIndex = 8;
            btnCriarPessoa.Text = "&Criar Pessoa";
            btnCriarPessoa.UseVisualStyleBackColor = true;
            btnCriarPessoa.Click += btnCriarPessoa_Click;
            // 
            // gerenciadorDePessoas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCriarPessoa);
            Controls.Add(lblMensagem);
            Controls.Add(label1);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Name = "gerenciadorDePessoas";
            Text = "Gerenciador de Pessoas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNome;
        private Label lblIdade;
        private TextBox txtNome;
        private TextBox txtIdade;
        private Label label1;
        private Label lblMensagem;
        private Button btnCriarPessoa;
    }
}