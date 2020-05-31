namespace ConsumirApiPloomes
{
    partial class CreateContact
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateContact));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.criarCliente = new System.Windows.Forms.Button();
            this.pessoaBox = new System.Windows.Forms.CheckBox();
            this.empresaBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Criar Novo Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome: ";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // criarCliente
            // 
            this.criarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.criarCliente.Location = new System.Drawing.Point(316, 125);
            this.criarCliente.Name = "criarCliente";
            this.criarCliente.Size = new System.Drawing.Size(133, 31);
            this.criarCliente.TabIndex = 5;
            this.criarCliente.Text = "Criar";
            this.criarCliente.UseVisualStyleBackColor = true;
            this.criarCliente.Click += new System.EventHandler(this.criarCliente_Click);
            // 
            // pessoaBox
            // 
            this.pessoaBox.AutoSize = true;
            this.pessoaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pessoaBox.Location = new System.Drawing.Point(77, 46);
            this.pessoaBox.Name = "pessoaBox";
            this.pessoaBox.Size = new System.Drawing.Size(81, 24);
            this.pessoaBox.TabIndex = 6;
            this.pessoaBox.Text = "Pessoa";
            this.pessoaBox.UseVisualStyleBackColor = true;
            this.pessoaBox.CheckedChanged += new System.EventHandler(this.pessoaBox_CheckedChanged);
            // 
            // empresaBox
            // 
            this.empresaBox.AutoSize = true;
            this.empresaBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empresaBox.Location = new System.Drawing.Point(164, 46);
            this.empresaBox.Name = "empresaBox";
            this.empresaBox.Size = new System.Drawing.Size(92, 24);
            this.empresaBox.TabIndex = 7;
            this.empresaBox.Text = "Empresa";
            this.empresaBox.UseVisualStyleBackColor = true;
            this.empresaBox.CheckedChanged += new System.EventHandler(this.empresaBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tipo: ";
            // 
            // CreateContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 168);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empresaBox);
            this.Controls.Add(this.pessoaBox);
            this.Controls.Add(this.criarCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateContact";
            this.Text = "NovoCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button criarCliente;
        private System.Windows.Forms.CheckBox pessoaBox;
        private System.Windows.Forms.CheckBox empresaBox;
        private System.Windows.Forms.Label label2;
    }
}