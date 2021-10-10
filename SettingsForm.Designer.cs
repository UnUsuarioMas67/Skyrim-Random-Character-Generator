
namespace SKRandomCharGenerator
{
    partial class SettingsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.majorLabel = new System.Windows.Forms.Label();
            this.minorLabel = new System.Windows.Forms.Label();
            this.majorUpDown = new System.Windows.Forms.NumericUpDown();
            this.minorUpDown = new System.Windows.Forms.NumericUpDown();
            this.conflictCheckBox = new System.Windows.Forms.CheckBox();
            this.skillsGroupBox = new System.Windows.Forms.GroupBox();
            this.chanceGroupBox = new System.Windows.Forms.GroupBox();
            this.enchantUpDown = new System.Windows.Forms.NumericUpDown();
            this.serpentUpDown = new System.Windows.Forms.NumericUpDown();
            this.enchantLabel = new System.Windows.Forms.Label();
            this.serpentLabel = new System.Windows.Forms.Label();
            this.atronachLabel = new System.Windows.Forms.Label();
            this.atronachUpDown = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.majorUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorUpDown)).BeginInit();
            this.skillsGroupBox.SuspendLayout();
            this.chanceGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atronachUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(6, 29);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(83, 13);
            this.majorLabel.TabIndex = 0;
            this.majorLabel.Text = "Max Major Skills";
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Location = new System.Drawing.Point(6, 66);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(83, 13);
            this.minorLabel.TabIndex = 1;
            this.minorLabel.Text = "Max Minor Skills";
            // 
            // majorUpDown
            // 
            this.majorUpDown.Location = new System.Drawing.Point(95, 29);
            this.majorUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.majorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.majorUpDown.Name = "majorUpDown";
            this.majorUpDown.Size = new System.Drawing.Size(35, 20);
            this.majorUpDown.TabIndex = 2;
            this.majorUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.majorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minorUpDown
            // 
            this.minorUpDown.Location = new System.Drawing.Point(95, 64);
            this.minorUpDown.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.minorUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minorUpDown.Name = "minorUpDown";
            this.minorUpDown.Size = new System.Drawing.Size(35, 20);
            this.minorUpDown.TabIndex = 3;
            this.minorUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minorUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // conflictCheckBox
            // 
            this.conflictCheckBox.AutoSize = true;
            this.conflictCheckBox.Location = new System.Drawing.Point(160, 30);
            this.conflictCheckBox.Name = "conflictCheckBox";
            this.conflictCheckBox.Size = new System.Drawing.Size(120, 17);
            this.conflictCheckBox.TabIndex = 4;
            this.conflictCheckBox.Text = "Prevent skill conflict";
            this.toolTip1.SetToolTip(this.conflictCheckBox, "If checked the generator will try to prevent conflictive skill pairs");
            this.conflictCheckBox.UseVisualStyleBackColor = true;
            // 
            // skillsGroupBox
            // 
            this.skillsGroupBox.Controls.Add(this.minorLabel);
            this.skillsGroupBox.Controls.Add(this.conflictCheckBox);
            this.skillsGroupBox.Controls.Add(this.majorLabel);
            this.skillsGroupBox.Controls.Add(this.minorUpDown);
            this.skillsGroupBox.Controls.Add(this.majorUpDown);
            this.skillsGroupBox.Location = new System.Drawing.Point(15, 12);
            this.skillsGroupBox.Name = "skillsGroupBox";
            this.skillsGroupBox.Size = new System.Drawing.Size(286, 100);
            this.skillsGroupBox.TabIndex = 5;
            this.skillsGroupBox.TabStop = false;
            this.skillsGroupBox.Text = "Skills";
            // 
            // chanceGroupBox
            // 
            this.chanceGroupBox.Controls.Add(this.enchantUpDown);
            this.chanceGroupBox.Controls.Add(this.serpentUpDown);
            this.chanceGroupBox.Controls.Add(this.enchantLabel);
            this.chanceGroupBox.Controls.Add(this.serpentLabel);
            this.chanceGroupBox.Controls.Add(this.atronachLabel);
            this.chanceGroupBox.Controls.Add(this.atronachUpDown);
            this.chanceGroupBox.Location = new System.Drawing.Point(15, 127);
            this.chanceGroupBox.Name = "chanceGroupBox";
            this.chanceGroupBox.Size = new System.Drawing.Size(286, 135);
            this.chanceGroupBox.TabIndex = 6;
            this.chanceGroupBox.TabStop = false;
            this.chanceGroupBox.Text = "Chance Values";
            // 
            // enchantUpDown
            // 
            this.enchantUpDown.DecimalPlaces = 1;
            this.enchantUpDown.Location = new System.Drawing.Point(113, 96);
            this.enchantUpDown.Name = "enchantUpDown";
            this.enchantUpDown.Size = new System.Drawing.Size(51, 20);
            this.enchantUpDown.TabIndex = 7;
            this.enchantUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.enchantUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // serpentUpDown
            // 
            this.serpentUpDown.DecimalPlaces = 1;
            this.serpentUpDown.Location = new System.Drawing.Point(114, 61);
            this.serpentUpDown.Name = "serpentUpDown";
            this.serpentUpDown.Size = new System.Drawing.Size(51, 20);
            this.serpentUpDown.TabIndex = 6;
            this.serpentUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.serpentUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // enchantLabel
            // 
            this.enchantLabel.AutoSize = true;
            this.enchantLabel.Location = new System.Drawing.Point(6, 98);
            this.enchantLabel.Name = "enchantLabel";
            this.enchantLabel.Size = new System.Drawing.Size(101, 13);
            this.enchantLabel.TabIndex = 5;
            this.enchantLabel.Text = "Enchanting Chance";
            this.toolTip1.SetToolTip(this.enchantLabel, "Default: 2.5%");
            // 
            // serpentLabel
            // 
            this.serpentLabel.AutoSize = true;
            this.serpentLabel.Location = new System.Drawing.Point(6, 63);
            this.serpentLabel.Name = "serpentLabel";
            this.serpentLabel.Size = new System.Drawing.Size(84, 13);
            this.serpentLabel.TabIndex = 4;
            this.serpentLabel.Text = "Serpent Chance";
            this.toolTip1.SetToolTip(this.serpentLabel, "Default: 0.5%");
            // 
            // atronachLabel
            // 
            this.atronachLabel.AutoSize = true;
            this.atronachLabel.Location = new System.Drawing.Point(6, 29);
            this.atronachLabel.Name = "atronachLabel";
            this.atronachLabel.Size = new System.Drawing.Size(90, 13);
            this.atronachLabel.TabIndex = 0;
            this.atronachLabel.Text = "Atronach Chance";
            this.toolTip1.SetToolTip(this.atronachLabel, "Default: 1%");
            // 
            // atronachUpDown
            // 
            this.atronachUpDown.DecimalPlaces = 1;
            this.atronachUpDown.Location = new System.Drawing.Point(114, 27);
            this.atronachUpDown.Name = "atronachUpDown";
            this.atronachUpDown.Size = new System.Drawing.Size(51, 20);
            this.atronachUpDown.TabIndex = 2;
            this.atronachUpDown.Tag = "";
            this.atronachUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.atronachUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 279);
            this.Controls.Add(this.chanceGroupBox);
            this.Controls.Add(this.skillsGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.majorUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minorUpDown)).EndInit();
            this.skillsGroupBox.ResumeLayout(false);
            this.skillsGroupBox.PerformLayout();
            this.chanceGroupBox.ResumeLayout(false);
            this.chanceGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enchantUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serpentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atronachUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.NumericUpDown majorUpDown;
        private System.Windows.Forms.NumericUpDown minorUpDown;
        private System.Windows.Forms.CheckBox conflictCheckBox;
        private System.Windows.Forms.GroupBox skillsGroupBox;
        private System.Windows.Forms.GroupBox chanceGroupBox;
        private System.Windows.Forms.Label atronachLabel;
        private System.Windows.Forms.NumericUpDown atronachUpDown;
        private System.Windows.Forms.Label serpentLabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label enchantLabel;
        private System.Windows.Forms.NumericUpDown enchantUpDown;
        private System.Windows.Forms.NumericUpDown serpentUpDown;
    }
}