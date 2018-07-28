using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neuroshima {
    public partial class InfoFillWindow : Form {

        public InfoFillWindow() {
            InitializeComponent();
            Choroba.DataSource=Choroby.ChorobyList;
        }

        private void PochodzenieSelectedIndexChanged(object sender, EventArgs e) {
            if (Pochodzenie.SelectedItem.ToString() == "Nowy Jork") {
                PochodzenieCecha.DataSource = Neuroshima.Pochodzenie.NJCechy;
            }

            if (Pochodzenie.SelectedItem.ToString() == "Federacja Apallachów") {
                PochodzenieCecha.DataSource = Neuroshima.Pochodzenie.FACechy;
            }
        }

        private void ProfesjaSelectedIndexChanged(object sender, EventArgs e) {
            if (Profesja.SelectedItem.ToString() == "Kaznodzieja") {
                ProfesjaCecha.DataSource = Neuroshima.Profesja.KaznodziejaCechy;
            }
        }

        private void SubmitClick(object sender, EventArgs e) {

            if (!IsEveryThingFilled()) {
                Warning.Visible = true;
            }
            else {
                Bohater.FillInfo(NazwaBohatera.Text, Pochodzenie.SelectedItem.ToString(),
                                 PochodzenieCecha.SelectedItem.ToString(),Profesja.SelectedItem.ToString(),
                                 ProfesjaCecha.SelectedItem.ToString(), Choroba.SelectedItem.ToString());

                //Create main window hide and close this window
                var mainWindow = new MainWindow();
                this.Hide();
                mainWindow.Show();
                this.Close();
            }
        }

        bool IsEveryThingFilled() {
            return !IsAnyFieldEmpty();
        }

        bool IsAnyFieldEmpty() {
            if (NazwaBohatera.Text == "" ||
                 Spec.SelectedItem == null ||
                 PochodzenieCecha.SelectedItem == null ||
                 ProfesjaCecha.SelectedItem == null ||
                 Choroba.SelectedItem == null) {

                return true;
            }
            else
                return false;
        }
    }
}
