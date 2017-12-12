namespace ULA
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblAddLista1 = new System.Windows.Forms.Label();
            this.lblAddLista2 = new System.Windows.Forms.Label();
            this.txtAddList1 = new System.Windows.Forms.TextBox();
            this.txtAddList2 = new System.Windows.Forms.TextBox();
            this.lstLista1 = new System.Windows.Forms.ListBox();
            this.lstLista2 = new System.Windows.Forms.ListBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnClearLista2 = new System.Windows.Forms.Button();
            this.btnClearLista1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddLista1
            // 
            this.lblAddLista1.AutoSize = true;
            this.lblAddLista1.Location = new System.Drawing.Point(37, 29);
            this.lblAddLista1.Name = "lblAddLista1";
            this.lblAddLista1.Size = new System.Drawing.Size(108, 13);
            this.lblAddLista1.TabIndex = 0;
            this.lblAddLista1.Text = "ADICIONAR LISTA 1";
            // 
            // lblAddLista2
            // 
            this.lblAddLista2.AutoSize = true;
            this.lblAddLista2.Location = new System.Drawing.Point(460, 29);
            this.lblAddLista2.Name = "lblAddLista2";
            this.lblAddLista2.Size = new System.Drawing.Size(108, 13);
            this.lblAddLista2.TabIndex = 1;
            this.lblAddLista2.Text = "ADICIONAR LISTA 2";
            // 
            // txtAddList1
            // 
            this.txtAddList1.Location = new System.Drawing.Point(40, 56);
            this.txtAddList1.Name = "txtAddList1";
            this.txtAddList1.Size = new System.Drawing.Size(246, 20);
            this.txtAddList1.TabIndex = 2;
            this.txtAddList1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddList1_KeyDown);
            // 
            // txtAddList2
            // 
            this.txtAddList2.Location = new System.Drawing.Point(463, 56);
            this.txtAddList2.Name = "txtAddList2";
            this.txtAddList2.Size = new System.Drawing.Size(246, 20);
            this.txtAddList2.TabIndex = 3;
            this.txtAddList2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAddList2_KeyDown);
            // 
            // lstLista1
            // 
            this.lstLista1.FormattingEnabled = true;
            this.lstLista1.Location = new System.Drawing.Point(40, 100);
            this.lstLista1.Name = "lstLista1";
            this.lstLista1.Size = new System.Drawing.Size(246, 641);
            this.lstLista1.TabIndex = 4;
            this.lstLista1.SelectedIndexChanged += new System.EventHandler(this.lstLista1_SelectedIndexChanged);
            // 
            // lstLista2
            // 
            this.lstLista2.FormattingEnabled = true;
            this.lstLista2.Location = new System.Drawing.Point(463, 100);
            this.lstLista2.Name = "lstLista2";
            this.lstLista2.Size = new System.Drawing.Size(246, 641);
            this.lstLista2.TabIndex = 5;
            this.lstLista2.SelectedIndexChanged += new System.EventHandler(this.lstLista2_SelectedIndexChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(292, 100);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(165, 142);
            this.btnExecute.TabIndex = 6;
            this.btnExecute.Text = "SORTEAR";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnClearLista2
            // 
            this.btnClearLista2.Location = new System.Drawing.Point(463, 777);
            this.btnClearLista2.Name = "btnClearLista2";
            this.btnClearLista2.Size = new System.Drawing.Size(246, 29);
            this.btnClearLista2.TabIndex = 7;
            this.btnClearLista2.Text = "LIMPAR LISTA 2";
            this.btnClearLista2.UseVisualStyleBackColor = true;
            this.btnClearLista2.Click += new System.EventHandler(this.btnClearLista2_Click);
            // 
            // btnClearLista1
            // 
            this.btnClearLista1.Location = new System.Drawing.Point(40, 777);
            this.btnClearLista1.Name = "btnClearLista1";
            this.btnClearLista1.Size = new System.Drawing.Size(246, 29);
            this.btnClearLista1.TabIndex = 8;
            this.btnClearLista1.Text = "LIMPAR LISTA 1";
            this.btnClearLista1.UseVisualStyleBackColor = true;
            this.btnClearLista1.Click += new System.EventHandler(this.btnClearLista1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 836);
            this.Controls.Add(this.btnClearLista1);
            this.Controls.Add(this.btnClearLista2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.lstLista2);
            this.Controls.Add(this.lstLista1);
            this.Controls.Add(this.txtAddList2);
            this.Controls.Add(this.txtAddList1);
            this.Controls.Add(this.lblAddLista2);
            this.Controls.Add(this.lblAddLista1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddLista1;
        private System.Windows.Forms.Label lblAddLista2;
        private System.Windows.Forms.TextBox txtAddList1;
        private System.Windows.Forms.TextBox txtAddList2;
        private System.Windows.Forms.ListBox lstLista1;
        private System.Windows.Forms.ListBox lstLista2;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnClearLista2;
        private System.Windows.Forms.Button btnClearLista1;
    }
}

