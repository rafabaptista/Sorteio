﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace ULA
{
    public partial class Form1 : Form
    {
        #region .: Constructor :.
        
        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region .: Events :.

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckButtonVisibility();
        }

        private void txtAddList1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.Equals(13))
                    AddInList1();

                CheckButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtAddList2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.Equals(13))
                    AddInList2();

                CheckButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtListRepeat_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyValue.Equals(13))
                    AddInListRepeat();

                CheckButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                DoSorteio();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void btnClearLista1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLista1.SelectedItem != null)
                {
                    lstLista1.Items.Remove(lstLista1.SelectedItem.ToString());
                    txtAddList1.Focus();
                }
                else
                {
                    lstLista1.Items.Clear();
                    txtAddList1.Focus();
                }

                CheckButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClearLista2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstLista2.SelectedItem != null)
                {
                    lstLista2.Items.Remove(lstLista2.SelectedItem.ToString());
                    txtAddList2.Focus();
                }
                else
                {
                    lstLista2.Items.Clear();
                    txtAddList2.Focus();
                }

                CheckButtonVisibility();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        #region .: Methods :.

        private void AddInList1()
        {
            string valueInput = txtAddList1.Text.Trim().ToUpper();

            if (!lstLista1.Items.Contains(valueInput))
            {
                lstLista1.Items.Add(valueInput);
                txtAddList1.Text = "";
                txtAddList1.Focus();
            }
            else
            {
                MessageBox.Show("A Lista 1 Ja contem esse item.");
                txtAddList1.Text = "";
                txtAddList1.Focus();
            }
        }

        private void AddInList2()
        {
            string valueInput = txtAddList2.Text.Trim().ToUpper();

            if (!lstLista2.Items.Contains(valueInput))
            {
                lstLista2.Items.Add(valueInput);
                txtAddList2.Text = "";
                txtAddList2.Focus();
            }
            else
            {
                MessageBox.Show("A Lista 2 Ja contem esse item.");
                txtAddList2.Text = "";
                txtAddList2.Focus();
            }
        }

        private void AddInListRepeat()
        {
            string valueInput = txtListRepeat.Text.Trim().ToUpper();

            if (!listRepeat.Items.Contains(valueInput))
            {
                listRepeat.Items.Add(valueInput);
                txtListRepeat.Text = "";
                txtListRepeat.Focus();
            }
            else
            {
                MessageBox.Show("A Lista de Repetição Ja contem esse item.");
                txtListRepeat.Text = "";
                txtListRepeat.Focus();
            }
        }

        private void DoSorteio()
        {
            List<string> allLista1 = new List<string>();
            List<string> allLista2 = new List<string>();
            List<string> allListaRepeat = new List<string>();
            List<int> ordemLista1 = new List<int>();
            List<int> ordemLista2 = new List<int>();
            List<int> ordemListaRepeat = new List<int>();
            int totalLista1 = lstLista1.Items.Count;
            int totalLista2 = lstLista2.Items.Count;
            int totalListaRepeat = listRepeat.Items.Count;
            int increment = 0;
            string result = "";
            Random rdnGetNumeros = new Random();
            int numeroRamdom;
            int checkListaMenor = ((totalLista1 > totalLista2) ? totalLista2 : totalLista1);
            int numberRepetition;
            
            foreach (string item in lstLista1.Items)
            {
                allLista1.Add(item);
            }

            foreach (string item in lstLista2.Items)
            {
                allLista2.Add(item);
            }

            foreach (string item in listRepeat.Items)
            {
                allListaRepeat.Add(item);
            }

            if (allLista1.Count > 0 && allLista2.Count > 0)
            {
                while (increment < checkListaMenor)
                {
                    numeroRamdom = rdnGetNumeros.Next(totalLista1);

                    if (!ordemLista1.Contains(numeroRamdom))
                    {
                        ordemLista1.Add(numeroRamdom);
                        increment++;
                    }
                }

                increment = 0;

                while (increment < checkListaMenor)
                {
                    numeroRamdom = rdnGetNumeros.Next(totalLista2);

                    if (!ordemLista2.Contains(numeroRamdom))
                    {
                        ordemLista2.Add(numeroRamdom);
                        increment++;
                    }
                }

                if(cbAddListRep.Checked)
                {
                    int.TryParse(txtNumberRepetition.Text, out numberRepetition);

                    increment = 0;

                    while (increment < checkListaMenor)
                    {
                        numeroRamdom = rdnGetNumeros.Next(totalListaRepeat);
                        
                        ordemListaRepeat.Add(numeroRamdom);
                        increment++;
                    }
                }
                
                result = "\nResultado do Sorteio:\n\n";

                for (int i = 0; i < checkListaMenor; i++)
                {
                    result += lstLista1.Items[ordemLista1[i]].ToString() 
                        + " - " + lstLista2.Items[ordemLista2[i]].ToString() 
                        + ((cbAddListRep.Checked) ? " - " + listRepeat.Items[ordemListaRepeat[i]].ToString() : "")
                        + " \n";
                }
            }
            else
            {
                numeroRamdom = rdnGetNumeros.Next((totalLista1 > 0 && totalLista2 == 0) ? totalLista1 : totalLista2);

                result = "\nResultado do Sorteio:\n\n";
                result += (totalLista1 > 0 && totalLista2 == 0) ? lstLista1.Items[numeroRamdom].ToString() : lstLista2.Items[numeroRamdom].ToString();

                result += " !! ";
            }
            
            MessageBox.Show(result, "SORTEIO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lstLista2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstLista2.SelectedItem != null)
                {
                    btnClearLista2.Text = "Remover item selecionado Lista 2";
                }
                else
                {
                    btnClearLista2.Text = "Limpar Lista 2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lstLista1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstLista1.SelectedItem != null)
                {
                    btnClearLista1.Text = "Remover item selecionado Lista 1";
                }
                else
                {
                    btnClearLista1.Text = "Limpar Lista 1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #endregion

        private void CheckButtonVisibility()
        {
            btnClearLista1.Visible = (lstLista1.Items.Count > 0) ? true : false;
            btnClearLista2.Visible = (lstLista2.Items.Count > 0) ? true : false;
            panelListRepeat.Visible = (cbAddListRep.Checked) ? true : false;
        }

        private void cbAddListRep_CheckedChanged(object sender, EventArgs e)
        {
            panelListRepeat.Visible = (cbAddListRep.Checked) ? true : false;
        }
    }
}