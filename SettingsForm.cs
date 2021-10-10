using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static SKRandomCharGenerator.Generation.ConfigurationHandler;

namespace SKRandomCharGenerator
{
    public partial class SettingsForm : Form
    {
        ICallingForm callingForm;

        public SettingsForm(ICallingForm caller)
        {
            InitializeComponent();

            callingForm = caller;
            GetConfig();
        }

        private void GetConfig()
        {
            majorUpDown.Value = ReadSetting("MajorSkillCount").AsInt();
            minorUpDown.Value = ReadSetting("MinorSkillCount").AsInt();

            conflictCheckBox.Checked = ReadSetting("PreventSkillConflict").AsBool();

            atronachUpDown.Value = (decimal)ReadSetting("AtronachChance").AsFloat() * 100;
            serpentUpDown.Value = (decimal)ReadSetting("SerpentChance").AsFloat() * 100;
            enchantUpDown.Value = (decimal)ReadSetting("EnchantingChance").AsFloat() * 100;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();

            callingForm.Finished();
        }

        private void SaveSettings()
        {
            AddUpdateSetting("MajorSkillCount", majorUpDown.Value.ToString());
            AddUpdateSetting("MinorSkillCount", minorUpDown.Value.ToString());

            UpdateBoolSetting("PreventSkillConflict", conflictCheckBox.Checked);

            AddUpdateSetting("AtronachChance", (atronachUpDown.Value / 100).ToString());
            AddUpdateSetting("SerpentChance", (serpentUpDown.Value / 100).ToString());
            AddUpdateSetting("EnchantingChance", (enchantUpDown.Value / 100).ToString());
        }
    }
}
