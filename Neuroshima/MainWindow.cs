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
    public partial class MainWindow : Form {
        public MainWindow() {
            InitializeComponent();
        }

        private void ZrecznoscValue_ValueChanged(object sender, EventArgs e) {
            LtwZrecznosc.Text = (ZrecznoscValue.Value+2).ToString();
            PrzecZrecznosc.Text = ZrecznoscValue.Value.ToString();
            ProblZrecznosc.Text = (ZrecznoscValue.Value-2).ToString();
            TrdZrecznosc.Text = (ZrecznoscValue.Value-5).ToString();
            BTrdZrecznosc.Text = (ZrecznoscValue.Value-8).ToString();
            CTrdZrecznosc.Text = (ZrecznoscValue.Value-11).ToString();
            FartZrecznosc.Text = (ZrecznoscValue.Value-15).ToString();
        }

        private void PercepcjaValue_ValueChanged(object sender, EventArgs e) {
            LtwPercepcja.Text = (PercepcjaValue.Value + 2).ToString();
            PrzecPercepcja.Text = PercepcjaValue.Value.ToString();
            ProblPercepcja.Text = (PercepcjaValue.Value - 2).ToString();
            TrdPercepcja.Text = (PercepcjaValue.Value - 5).ToString();
            BTrdPercepcja.Text = (PercepcjaValue.Value - 8).ToString();
            CTrdPercepcja.Text = (PercepcjaValue.Value - 11).ToString();
            FartPercepcja.Text = (PercepcjaValue.Value - 15).ToString();

        }

        private void CharakterValue_ValueChanged(object sender, EventArgs e) {
            LtwCharakter.Text = (CharakterValue.Value + 2).ToString();
            PrzecCharakter.Text = CharakterValue.Value.ToString();
            ProblCharakter.Text = (CharakterValue.Value - 2).ToString();
            TrdCharakter.Text = (CharakterValue.Value - 5).ToString();
            BTrdCharakter.Text = (CharakterValue.Value - 8).ToString();
            CTrdCharakter.Text = (CharakterValue.Value - 11).ToString();
            FartCharakter.Text = (CharakterValue.Value - 15).ToString();
        }

        private void SprytValue_ValueChanged(object sender, EventArgs e){
            LtwSpryt.Text = (SprytValue.Value + 2).ToString();
            PrzecSpryt.Text = SprytValue.Value.ToString();
            ProblSpryt.Text = (SprytValue.Value - 2).ToString();
            TrdSpryt.Text = (SprytValue.Value - 5).ToString();
            BTrdSpryt.Text = (SprytValue.Value - 8).ToString();
            CTrdSpryt.Text = (SprytValue.Value - 11).ToString();
            FartSpryt.Text = (SprytValue.Value - 15).ToString();
        }

        private void BudowaValue_ValueChanged(object sender, EventArgs e) {
            LtwBudowa.Text = (BudowaValue.Value + 2).ToString();
            PrzecBudowa.Text = BudowaValue.Value.ToString();
            ProblBudowa.Text = (BudowaValue.Value - 2).ToString();
            TrdBudowa.Text = (BudowaValue.Value - 5).ToString();
            BTrdBudowa.Text = (BudowaValue.Value - 8).ToString();
            CTrdBudowa.Text = (BudowaValue.Value - 11).ToString();
            FartBudowa.Text = (BudowaValue.Value - 15).ToString();

        }
    }
}
