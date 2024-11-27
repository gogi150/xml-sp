using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vozila
{
    public partial class Form1 : Form
    {
        private List<Vozilo> vozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
            cmbSortiranje.Items.AddRange(new string[] { "Marka", "Model", "GodinaProizvodnje", "Kilometraza" });
            cmbSortiranje.SelectedIndex = 0;
            UcitajIzXML();
        }
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            {
                Vozilo novoVozilo = new Vozilo
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    GodinaProizvodnje = int.Parse(txtGodinaProizvodnje.Text),
                    Kilometraza = int.Parse(txtKilometraza.Text)
                };
                vozila.Add(novoVozilo);
                UpdateVozilaList();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Unesite ispravne podatke.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void UpdateVozilaList()
        {
            lstVozila.Items.Clear();
            foreach (var vozilo in vozila)
            {
                lstVozila.Items.Add(vozilo.ToString());
            }
            MessageBox.Show($"Broj vozila u listi: {vozila.Count}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ClearInputs()
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMarka.Text) || string.IsNullOrWhiteSpace(txtModel.Text))
                return false;
            if (!int.TryParse(txtKilometraza.Text, out int kilometraza) || kilometraza < 0)
                return false;
            if (!int.TryParse(txtGodinaProizvodnje.Text, out int godina) || godina <= 0)
                return false;

            return true;
        }

        private void btnSortiraj_Click(object sender, EventArgs e)
        {
            IEnumerable<Vozilo> sortedVozila;
                switch (cmbSortiranje.SelectedItem.ToString())
                {
                    case "Marka":
                    sortedVozila = vozila.OrderBy(v => v.Marka).ToList();
                        break;

                    case "Model":
                    sortedVozila = vozila.OrderBy(v => v.Model).ToList();
                        break;

                    case "Godina Proizvodnje":
                    sortedVozila = vozila.OrderBy(v => v.GodinaProizvodnje).ToList();
                        break;

                    case "Kilometraza":
                    sortedVozila = vozila.OrderBy(v => v.Kilometraza).ToList();
                        break;

                    default:
                    sortedVozila = vozila;
                        break;
                }
            
            txtSortiranaLista.Clear();

            foreach (Vozilo v in sortedVozila)
            {
                txtSortiranaLista.AppendText(v.ToString() + Environment.NewLine);
            }

        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            txtMarka.Clear();
            txtModel.Clear();
            txtGodinaProizvodnje.Clear();
            txtKilometraza.Clear();
            txtSortiranaLista.Clear();
        }
        private void SpremiUXML()
        {

            try
            {
                var xmlDoc = new XDocument(
                    new XElement("Vozila",
                        vozila.Select(v =>
                            new XElement("Vozilo",
                                new XElement("Marka", v.Marka),
                                new XElement("Model", v.Model),
                                new XElement("GodinaProizvodnje", v.GodinaProizvodnje),
                                new XElement("Kilometraza", v.Kilometraza)
                            )
                        )
                    )
                );

                xmlDoc.Save("vozila.xml");
                MessageBox.Show("Podaci su uspješno spremljeni u XML datoteku.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom spremanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UcitajIzXML()
        {

            try
            {
                if (File.Exists("vozila.xml"))
                {
                    var xmlDoc = XDocument.Load("vozila.xml");
                    vozila = xmlDoc.Descendants("Vozilo")
                        .Select(v => new Vozilo
                        {
                            Marka = v.Element("Marka")?.Value,
                            Model = v.Element("Model")?.Value,
                            GodinaProizvodnje = int.Parse(v.Element("GodinaProizvodnje")?.Value ?? "0"),
                            Kilometraza = int.Parse(v.Element("Kilometraza")?.Value ?? "0")
                        }).ToList();

                    UpdateVozilaList();
                    MessageBox.Show("Podaci su uspješno učitani iz XML datoteke.", "Uspjeh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("XML datoteka ne postoji.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Greška prilikom učitavanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSpremiXML_Click(object sender, EventArgs e)
        {
            SpremiUXML();
        }

        private void btnUcitajXML_Click(object sender, EventArgs e)
        {
            UcitajIzXML();
        }

        private void txtMarka_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstVozila_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
