namespace ConsumirApiPloomes
{
    partial class Init
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Init));
            this.create_contact = new System.Windows.Forms.Button();
            this.create_interaction = new System.Windows.Forms.Button();
            this.finish_task = new System.Windows.Forms.Button();
            this.create_task = new System.Windows.Forms.Button();
            this.update_deal = new System.Windows.Forms.Button();
            this.create_deal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // create_contact
            // 
            this.create_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_contact.Location = new System.Drawing.Point(12, 12);
            this.create_contact.Name = "create_contact";
            this.create_contact.Size = new System.Drawing.Size(245, 33);
            this.create_contact.TabIndex = 21;
            this.create_contact.Text = "Criar Cliente";
            this.create_contact.UseVisualStyleBackColor = true;
            this.create_contact.Click += new System.EventHandler(this.create_contact_Click);
            // 
            // create_interaction
            // 
            this.create_interaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_interaction.Location = new System.Drawing.Point(284, 90);
            this.create_interaction.Name = "create_interaction";
            this.create_interaction.Size = new System.Drawing.Size(245, 33);
            this.create_interaction.TabIndex = 24;
            this.create_interaction.Text = "Registrar Interação";
            this.create_interaction.UseVisualStyleBackColor = true;
            this.create_interaction.Click += new System.EventHandler(this.create_interaction_Click);
            // 
            // finish_task
            // 
            this.finish_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finish_task.Location = new System.Drawing.Point(284, 51);
            this.finish_task.Name = "finish_task";
            this.finish_task.Size = new System.Drawing.Size(245, 33);
            this.finish_task.TabIndex = 27;
            this.finish_task.Text = "Finalizar Tarefa";
            this.finish_task.UseVisualStyleBackColor = true;
            this.finish_task.Click += new System.EventHandler(this.finish_task_Click);
            // 
            // create_task
            // 
            this.create_task.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_task.Location = new System.Drawing.Point(12, 90);
            this.create_task.Name = "create_task";
            this.create_task.Size = new System.Drawing.Size(245, 33);
            this.create_task.TabIndex = 23;
            this.create_task.Text = "Criar Tarefa";
            this.create_task.UseVisualStyleBackColor = true;
            this.create_task.Click += new System.EventHandler(this.create_task_Click);
            // 
            // update_deal
            // 
            this.update_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_deal.Location = new System.Drawing.Point(284, 12);
            this.update_deal.Name = "update_deal";
            this.update_deal.Size = new System.Drawing.Size(245, 33);
            this.update_deal.TabIndex = 25;
            this.update_deal.Text = "Atualizar / Vencer Negociação";
            this.update_deal.UseVisualStyleBackColor = true;
            this.update_deal.Click += new System.EventHandler(this.update_deal_Click);
            // 
            // create_deal
            // 
            this.create_deal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_deal.Location = new System.Drawing.Point(12, 51);
            this.create_deal.Name = "create_deal";
            this.create_deal.Size = new System.Drawing.Size(245, 33);
            this.create_deal.TabIndex = 22;
            this.create_deal.Text = "Criar Negociação";
            this.create_deal.UseVisualStyleBackColor = true;
            this.create_deal.Click += new System.EventHandler(this.create_deal_Click);
            // 
            // Init
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(547, 139);
            this.Controls.Add(this.finish_task);
            this.Controls.Add(this.update_deal);
            this.Controls.Add(this.create_interaction);
            this.Controls.Add(this.create_task);
            this.Controls.Add(this.create_deal);
            this.Controls.Add(this.create_contact);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Init";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ploomes API - Bem-vindo!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button create_contact;
        private System.Windows.Forms.Button create_interaction;
        private System.Windows.Forms.Button finish_task;
        private System.Windows.Forms.Button create_task;
        private System.Windows.Forms.Button update_deal;
        private System.Windows.Forms.Button create_deal;
    }
}

