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
            this.cbAddListRep = new System.Windows.Forms.CheckBox();
            this.panelListRepeat = new System.Windows.Forms.Panel();
            this.listRepeat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtListRepeat = new System.Windows.Forms.TextBox();
            this.txtNumberRepetition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelListRepeat.SuspendLayout();
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
            // cbAddListRep
            // 
            this.cbAddListRep.AutoSize = true;
            this.cbAddListRep.Location = new System.Drawing.Point(293, 264);
            this.cbAddListRep.Name = "cbAddListRep";
            this.cbAddListRep.Size = new System.Drawing.Size(166, 17);
            this.cbAddListRep.TabIndex = 9;
            this.cbAddListRep.Text = "Adicionar lista com Repetição";
            this.cbAddListRep.UseVisualStyleBackColor = true;
            this.cbAddListRep.CheckedChanged += new System.EventHandler(this.cbAddListRep_CheckedChanged);
            // 
            // panelListRepeat
            // 
            this.panelListRepeat.Controls.Add(this.label2);
            this.panelListRepeat.Controls.Add(this.txtNumberRepetition);
            this.panelListRepeat.Controls.Add(this.listRepeat);
            this.panelListRepeat.Controls.Add(this.label1);
            this.panelListRepeat.Controls.Add(this.txtListRepeat);
            this.panelListRepeat.Location = new System.Drawing.Point(292, 288);
            this.panelListRepeat.Name = "panelListRepeat";
            this.panelListRepeat.Size = new System.Drawing.Size(165, 460);
            this.panelListRepeat.TabIndex = 10;
            this.panelListRepeat.Visible = false;
            // 
            // listRepeat
            // 
            this.listRepeat.FormattingEnabled = true;
            this.listRepeat.Location = new System.Drawing.Point(3, 79);
            this.listRepeat.Name = "listRepeat";
            this.listRepeat.Size = new System.Drawing.Size(159, 381);
            this.listRepeat.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ADICIONAR LISTA 3\r\n";
            // 
            // txtListRepeat
            // 
            this.txtListRepeat.Location = new System.Drawing.Point(3, 24);
            this.txtListRepeat.Name = "txtListRepeat";
            this.txtListRepeat.Size = new System.Drawing.Size(159, 20);
            this.txtListRepeat.TabIndex = 0;
            this.txtListRepeat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtListRepeat_KeyDown);
            // 
            // txtNumberRepetition
            // 
            this.txtNumberRepetition.Location = new System.Drawing.Point(88, 51);
            this.txtNumberRepetition.Name = "txtNumberRepetition";
            this.txtNumberRepetition.Size = new System.Drawing.Size(74, 20);
            this.txtNumberRepetition.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nº Repetições:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 737);
            this.Controls.Add(this.panelListRepeat);
            this.Controls.Add(this.cbAddListRep);
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
            this.panelListRepeat.ResumeLayout(false);
            this.panelListRepeat.PerformLayout();
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
        private System.Windows.Forms.CheckBox cbAddListRep;
        private System.Windows.Forms.Panel panelListRepeat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtListRepeat;
        private System.Windows.Forms.ListBox listRepeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumberRepetition;
    }
}

