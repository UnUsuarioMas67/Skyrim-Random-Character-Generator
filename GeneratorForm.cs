using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKRandomCharGenerator
{
    public partial class GeneratorForm : Form, ICallingForm
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var gc = new GeneratedCharacter();

            nameTextBox.Text = gc.Name;
            raceTextBox.Text = gc.Race.ToString();
            sxTextBox.Text = gc.Sex.ToString();
            birthsignTextBox.Text = "The " + gc.Sign.ToString();

            locationTextBox.Text = gc.StartingLocation;

            WireUpLists(gc);
        }

        private void WireUpLists(GeneratedCharacter gc)
        {
            majorListBox.DataSource = null;
            majorListBox.DataSource = gc.CharSkills.Majors;

            minorListBox.DataSource = null;
            minorListBox.DataSource = gc.CharSkills.Minors;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var frm = new SettingsForm(this);
            frm.Show();
            this.Enabled = false;
        }

        public void Finished()
        {
            this.Enabled = true;
        }
    }
}
