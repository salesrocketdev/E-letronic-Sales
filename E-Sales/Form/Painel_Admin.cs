﻿using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Sales.Code.ClienteBLL;

namespace E_Sales
{
    public partial class Painel_Admin : MaterialSkin.Controls.MaterialForm
    {
        public Painel_Admin()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário.

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;

            // Definindo um esquema de Cor para formulário com tom Azul:
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        bool PanelOn;
        bool PanelOff;

        //Ao abrir:
        private void Painel_Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbsalesDataSet1.dbsales' table. You can move, or remove it, as needed.
            this.dbsalesTableAdapter1.Fill(this.dbsalesDataSet1.dbsales);

            //Define fonte:
            groupBoxStatus.Font = new Font("Roboto", 12, FontStyle.Regular);

            panelLogado.Enabled = false;
            panelLogado.Visible = false;
            
        }

        //Painel Adm:
        private void lblSair_MouseHover(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.Black;
        }

        private void lblSair_MouseLeave(object sender, EventArgs e)
        {
            lblSair.ForeColor = System.Drawing.Color.White;
        }

        private void picAdm_Click(object sender, EventArgs e)
        {     
            //Se a variável for true:
            if (PanelOn == true)
            {
                panelLogado.Enabled = false;
                panelLogado.Visible = false;
                panelLogado.Size = new Size(330, 180);
                PanelOn = false;       
            }
            else 
            {
                panelLogado.Enabled = true;
                panelLogado.Visible = true;
                lblConf.ForeColor = System.Drawing.Color.White;
                lblSobre.ForeColor = System.Drawing.Color.White;
                lblCalc.ForeColor = System.Drawing.Color.White;
                PanelOn = true;
            }            
        }
       
        private void Painel_Admin_Click(object sender, EventArgs e)
        {
            PanelOn = false;
        }

            //Configurações:
        private void lblConf_MouseHover(object sender, EventArgs e)
        {
            lblConf.ForeColor = System.Drawing.Color.Black;
        }

        private void lblConf_Click(object sender, EventArgs e)
        {
            //Ação click
            (new Configs()).Show();
        }

        private void lblConf_MouseLeave(object sender, EventArgs e)
        {
            lblConf.ForeColor = System.Drawing.Color.White;
        }

            //Sobre:
        private void lblSobre_MouseHover(object sender, EventArgs e)
        {
            lblSobre.ForeColor = System.Drawing.Color.Black;
        }

        private void lblSobre_Click(object sender, EventArgs e)
        {
            //Ação click
            (new Sobre()).Show();
        }

        private void lblSobre_MouseLeave(object sender, EventArgs e)
        {
            lblSobre.ForeColor = System.Drawing.Color.White;
        }

            //Calculadora:
        private void lblCalc_MouseHover(object sender, EventArgs e)
        {
            lblCalc.ForeColor = System.Drawing.Color.Black;
        }

        private void lblCalc_Click(object sender, EventArgs e)
        {
            //Ação click
            System.Diagnostics.Process p = System.Diagnostics.Process.Start("calc.exe");
            p.WaitForInputIdle();
        }

        private void lblCalc_MouseLeave(object sender, EventArgs e)
        {
            lblCalc.ForeColor = System.Drawing.Color.White;
        }

        //ToolStrip - Sair:
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Exibe o formulário Sobre:
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new Sobre()).Show();
        }
       
        //Status Trip:
        private void Painel_Admin_KeyDown(object sender, KeyEventArgs e)
        {
            lblStatus.Text = "Processando...";
        }
        
        //Botões:
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridViewRecentes.CurrentCell.RowIndex;
            dataGridViewRecentes.Rows.RemoveAt(rowindex);
        }
        
            //Limpar:
        public void btnLimpar_Click(object sender, EventArgs e)
        {
            ClienteBLL bll = new ClienteBLL();
            bll.LimparCampos(//Parametros
                             txtCliente, txtEndereco, txtMarca, txtOrcamento,
                             txtProduto, txtSearchId, txtSerie, txtTelefone);
                             richTextBoxDescricao.Text = "";
        }

            //Inserir:
        private void btnInserir_Click(object sender, EventArgs e)
        {

        }
            
            //Pesquisar:
        private void btnPesquisar_Click(object sender, EventArgs e)
        {

        }

        //DataGrid Mostrar as Celulas no TXT:
        private void dataGridViewRecentes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = this.dataGridViewRecentes.Rows[e.RowIndex];

            txtCliente.Text = row.Cells[1].Value.ToString();
            txtEndereco.Text = row.Cells[2].Value.ToString();
            txtProduto.Text = row.Cells[3].Value.ToString();
            txtMarca.Text = row.Cells[4].Value.ToString();
            txtSerie.Text = row.Cells[5].Value.ToString();
            txtTelefone.Text = row.Cells[6].Value.ToString();
        }

        //MenuStrip Limpar Campos
        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteBLL bll = new ClienteBLL();

            bll.LimparCampos(txtCliente, txtEndereco, txtMarca, txtOrcamento,
                             txtProduto, txtSearchId, txtSerie, txtTelefone);
        }
        //Sair
        private void lblSair_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
