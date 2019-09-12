namespace MegaSena
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnN2 = new System.Windows.Forms.RadioButton();
            this.rbtnN1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnJogardenovo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini Mega Sena";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 55);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnN2);
            this.groupBox1.Controls.Add(this.rbtnN1);
            this.groupBox1.Location = new System.Drawing.Point(57, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o Nível:";
            // 
            // rbtnN2
            // 
            this.rbtnN2.AutoSize = true;
            this.rbtnN2.Location = new System.Drawing.Point(7, 43);
            this.rbtnN2.Name = "rbtnN2";
            this.rbtnN2.Size = new System.Drawing.Size(159, 17);
            this.rbtnN2.TabIndex = 1;
            this.rbtnN2.TabStop = true;
            this.rbtnN2.Text = "Nível 2 - Números de 1 a 60";
            this.rbtnN2.UseVisualStyleBackColor = true;
            // 
            // rbtnN1
            // 
            this.rbtnN1.AutoSize = true;
            this.rbtnN1.Checked = true;
            this.rbtnN1.Location = new System.Drawing.Point(7, 20);
            this.rbtnN1.Name = "rbtnN1";
            this.rbtnN1.Size = new System.Drawing.Size(159, 17);
            this.rbtnN1.TabIndex = 0;
            this.rbtnN1.TabStop = true;
            this.rbtnN1.Text = "Nível 1 - Números de 1 a 30";
            this.rbtnN1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtN6);
            this.groupBox2.Controls.Add(this.txtN5);
            this.groupBox2.Controls.Add(this.txtN4);
            this.groupBox2.Controls.Add(this.txtN3);
            this.groupBox2.Controls.Add(this.txtN2);
            this.groupBox2.Controls.Add(this.txtN1);
            this.groupBox2.Location = new System.Drawing.Point(57, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 61);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Escolha 6 Números:";
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(142, 23);
            this.txtN6.MaxLength = 2;
            this.txtN6.Name = "txtN6";
            this.txtN6.Size = new System.Drawing.Size(20, 20);
            this.txtN6.TabIndex = 23;
            this.txtN6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(116, 23);
            this.txtN5.MaxLength = 2;
            this.txtN5.Name = "txtN5";
            this.txtN5.Size = new System.Drawing.Size(20, 20);
            this.txtN5.TabIndex = 22;
            this.txtN5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(90, 23);
            this.txtN4.MaxLength = 2;
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(20, 20);
            this.txtN4.TabIndex = 21;
            this.txtN4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(64, 23);
            this.txtN3.MaxLength = 2;
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(20, 20);
            this.txtN3.TabIndex = 20;
            this.txtN3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(38, 23);
            this.txtN2.MaxLength = 2;
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(20, 20);
            this.txtN2.TabIndex = 19;
            this.txtN2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(12, 23);
            this.txtN1.MaxLength = 2;
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(20, 20);
            this.txtN1.TabIndex = 18;
            this.txtN1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtN_KeyPress);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(105, 236);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 5;
            this.btnSort.Text = "SORTEAR";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnJogardenovo
            // 
            this.btnJogardenovo.Enabled = false;
            this.btnJogardenovo.Location = new System.Drawing.Point(88, 236);
            this.btnJogardenovo.Name = "btnJogardenovo";
            this.btnJogardenovo.Size = new System.Drawing.Size(114, 23);
            this.btnJogardenovo.TabIndex = 21;
            this.btnJogardenovo.Text = "Jogar Novamente";
            this.btnJogardenovo.UseVisualStyleBackColor = true;
            this.btnJogardenovo.Visible = false;
            this.btnJogardenovo.Click += new System.EventHandler(this.btnJogardenovo_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 271);
            this.Controls.Add(this.btnJogardenovo);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Mega Sena";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnN2;
        private System.Windows.Forms.RadioButton rbtnN1;
        private System.Windows.Forms.GroupBox groupBox2;
        
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnJogardenovo;
    }
}

