namespace ListaDeNotas
{
    partial class frmListaNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaNotas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.listAlunos = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "RA";
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(100, 58);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(134, 25);
            this.txtRA.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(100, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(380, 25);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(100, 174);
            this.txtP1.Name = "txtP1";
            this.txtP1.Size = new System.Drawing.Size(152, 25);
            this.txtP1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "P1";
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(328, 177);
            this.txtP2.Name = "txtP2";
            this.txtP2.Size = new System.Drawing.Size(152, 25);
            this.txtP2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "P2";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(504, 136);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(107, 40);
            this.btnIncluir.TabIndex = 8;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // listAlunos
            // 
            this.listAlunos.FormattingEnabled = true;
            this.listAlunos.ItemHeight = 17;
            this.listAlunos.Location = new System.Drawing.Point(25, 267);
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.Size = new System.Drawing.Size(586, 208);
            this.listAlunos.TabIndex = 9;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(504, 229);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(106, 32);
            this.btnListar.TabIndex = 10;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(426, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 509);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.listAlunos);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.txtP2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtP1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "frmListaNotas";
            this.Text = "Lista de Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtRA;
        private TextBox txtNome;
        private Label label2;
        private TextBox txtP1;
        private Label label3;
        private TextBox txtP2;
        private Label label4;
        private Button btnIncluir;
        private ListBox listAlunos;
        private Button btnListar;
        private PictureBox pictureBox1;
    }
}