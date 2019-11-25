using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotoElectronico.Models;
using VotoElectronico.View;
using VotoElectronico.ViewModels;

namespace VotoElectronico
{
    public partial class FrmPrincipal : Form
    {
        VotoElectronicoContext db;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pnlPrincipal_Paint(object sender, PaintEventArgs e)
        {
            pnlMenuCategoria.Visible = false;
        }

        private void btnVotar_Click(object sender, EventArgs e)
        {
            db = new VotoElectronicoContext();
            pnlMenuCategoria.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            GetDatos();
        }

        private void tbPresidente_Click(object sender, EventArgs e)
        {

        }

        private void pnlMenuCategoria_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMarcarVoto_Click(object sender, EventArgs e)
        {
            FrmVotosInforme frmVotosInforme = new FrmVotosInforme();
            frmVotosInforme.ShowDialog();

        }

        private void tabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void chkPresindente1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void GetDatos()
        {
            db = new VotoElectronicoContext();
            List<CandidatoViewModel> candidatoViewModels = new List<CandidatoViewModel>();
            var presidentes = db.Candidatos.Where(
                p => p.CargoCandidato.Contains("Presidente") ||
                p.IdCandidato.ToString().Trim().Contains("Presidente")).ToList();

            foreach (var presidente in presidentes)
            {
                candidatoViewModels.Add(
                    new CandidatoViewModel(
                        presidente.CargoCandidato,
                        presidente.NombreCandidato

                    ));
            }
            foreach (var presidente in candidatoViewModels)
            {
                chkPresidente.Items.Add(presidente.Nombre);
            }
        var secretarios = db.Candidatos.Where(
                s => s.CargoCandidato.Contains("Secretario") ||
                s.IdCandidato.ToString().Trim().Contains("Secretario")).ToList();

            foreach (var secretario in secretarios)
            {
                chkSecretario.Items.Add(secretario.NombreCandidato);
            }
            var tesoreros = db.Candidatos.Where(
                t => t.CargoCandidato.Contains("Tesorero") ||
                t.IdCandidato.ToString().Trim().Contains("Tesorero")).ToList();

            foreach (var tesorero in tesoreros)
            {
                chkTesorero.Items.Add(tesorero.NombreCandidato);
            }
            var vocales = db.Candidatos.Where(
                v => v.CargoCandidato.Contains("Vocal") ||
                v.IdCandidato.ToString().Trim().Contains("Vocal")).ToList();

            foreach (var vocal in vocales)
            {
                chkVocal.Items.Add(vocal.NombreCandidato);
            }
        }

        private void chkPresidente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkTesorero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkVocal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            FrmRegistro frmRegistro = new FrmRegistro();
            frmRegistro.ShowDialog();

        }
    }
    
}
