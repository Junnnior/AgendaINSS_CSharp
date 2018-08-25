namespace Agendamento
{
    partial class AgendamentoFm
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
            this.btnAgendar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbxQuinta = new System.Windows.Forms.CheckBox();
            this.cbxTerca = new System.Windows.Forms.CheckBox();
            this.txtDiaSemana = new System.Windows.Forms.TextBox();
            this.btnGerarData = new System.Windows.Forms.Button();
            this.txtData = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgendar
            // 
            this.btnAgendar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgendar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgendar.CausesValidation = false;
            this.btnAgendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgendar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgendar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgendar.Location = new System.Drawing.Point(557, 557);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(550, 55);
            this.btnAgendar.TabIndex = 2;
            this.btnAgendar.Text = "SALVAR";
            this.btnAgendar.UseVisualStyleBackColor = false;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(243, 146);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(630, 30);
            this.txtNome.TabIndex = 1;
            this.txtNome.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(239, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(239, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "NB";
            // 
            // txtNb
            // 
            this.txtNb.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNb.Location = new System.Drawing.Point(241, 298);
            this.txtNb.Name = "txtNb";
            this.txtNb.Size = new System.Drawing.Size(286, 30);
            this.txtNb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(581, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "DATA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(239, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "FONE";
            // 
            // txtFone
            // 
            this.txtFone.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFone.Location = new System.Drawing.Point(241, 221);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(286, 30);
            this.txtFone.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.CausesValidation = false;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 557);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(558, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.cbxQuinta);
            this.panel1.Controls.Add(this.cbxTerca);
            this.panel1.Controls.Add(this.txtDiaSemana);
            this.panel1.Controls.Add(this.btnGerarData);
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txtFone);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtNb);
            this.panel1.Controls.Add(this.btnAgendar);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 612);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cbxQuinta
            // 
            this.cbxQuinta.AutoSize = true;
            this.cbxQuinta.Checked = true;
            this.cbxQuinta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxQuinta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxQuinta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbxQuinta.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxQuinta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxQuinta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxQuinta.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.cbxQuinta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxQuinta.Location = new System.Drawing.Point(715, 263);
            this.cbxQuinta.Name = "cbxQuinta";
            this.cbxQuinta.Size = new System.Drawing.Size(103, 27);
            this.cbxQuinta.TabIndex = 21;
            this.cbxQuinta.Text = "Quintas";
            this.cbxQuinta.UseVisualStyleBackColor = true;
            // 
            // cbxTerca
            // 
            this.cbxTerca.AutoSize = true;
            this.cbxTerca.Checked = true;
            this.cbxTerca.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxTerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxTerca.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbxTerca.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxTerca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxTerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbxTerca.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.cbxTerca.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cbxTerca.Location = new System.Drawing.Point(585, 263);
            this.cbxTerca.Name = "cbxTerca";
            this.cbxTerca.Size = new System.Drawing.Size(94, 27);
            this.cbxTerca.TabIndex = 20;
            this.cbxTerca.Text = "Terças";
            this.cbxTerca.UseVisualStyleBackColor = true;
            // 
            // txtDiaSemana
            // 
            this.txtDiaSemana.Enabled = false;
            this.txtDiaSemana.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaSemana.Location = new System.Drawing.Point(715, 221);
            this.txtDiaSemana.Name = "txtDiaSemana";
            this.txtDiaSemana.Size = new System.Drawing.Size(158, 30);
            this.txtDiaSemana.TabIndex = 19;
            // 
            // btnGerarData
            // 
            this.btnGerarData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGerarData.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnGerarData.CausesValidation = false;
            this.btnGerarData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarData.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGerarData.FlatAppearance.BorderSize = 0;
            this.btnGerarData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerarData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGerarData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGerarData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerarData.Location = new System.Drawing.Point(585, 298);
            this.btnGerarData.Name = "btnGerarData";
            this.btnGerarData.Size = new System.Drawing.Size(288, 40);
            this.btnGerarData.TabIndex = 18;
            this.btnGerarData.Text = "GERAR DATA";
            this.btnGerarData.UseVisualStyleBackColor = false;
            this.btnGerarData.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("HelveticaNeueLT Com 43 LtEx", 14.25F);
            this.txtData.Location = new System.Drawing.Point(585, 221);
            this.txtData.Mask = "00/00/0000";
            this.txtData.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(124, 30);
            this.txtData.TabIndex = 3;
            this.txtData.ValidatingType = typeof(System.DateTime);
            // 
            // AgendamentoFm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1106, 610);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgendamentoFm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agendamento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtData;
        private System.Windows.Forms.TextBox txtDiaSemana;
        private System.Windows.Forms.Button btnGerarData;
        private System.Windows.Forms.CheckBox cbxQuinta;
        private System.Windows.Forms.CheckBox cbxTerca;
    }
}

