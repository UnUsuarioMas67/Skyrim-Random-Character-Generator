
namespace SKRandomCharGenerator
{
    partial class GeneratorForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneratorForm));
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceTextBox = new System.Windows.Forms.TextBox();
            this.sxLabel = new System.Windows.Forms.Label();
            this.sxTextBox = new System.Windows.Forms.TextBox();
            this.birthsignLabel = new System.Windows.Forms.Label();
            this.birthsignTextBox = new System.Windows.Forms.TextBox();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.majorLabel = new System.Windows.Forms.Label();
            this.minorLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.majorListBox = new System.Windows.Forms.ListBox();
            this.minorListBox = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(68, 23);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(145, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 26);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Location = new System.Drawing.Point(13, 62);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(33, 13);
            this.raceLabel.TabIndex = 3;
            this.raceLabel.Text = "Race";
            // 
            // raceTextBox
            // 
            this.raceTextBox.Location = new System.Drawing.Point(68, 59);
            this.raceTextBox.Name = "raceTextBox";
            this.raceTextBox.ReadOnly = true;
            this.raceTextBox.Size = new System.Drawing.Size(100, 20);
            this.raceTextBox.TabIndex = 2;
            // 
            // sxLabel
            // 
            this.sxLabel.AutoSize = true;
            this.sxLabel.Location = new System.Drawing.Point(13, 100);
            this.sxLabel.Name = "sxLabel";
            this.sxLabel.Size = new System.Drawing.Size(25, 13);
            this.sxLabel.TabIndex = 5;
            this.sxLabel.Text = "Sex";
            // 
            // sxTextBox
            // 
            this.sxTextBox.Location = new System.Drawing.Point(68, 97);
            this.sxTextBox.Name = "sxTextBox";
            this.sxTextBox.ReadOnly = true;
            this.sxTextBox.Size = new System.Drawing.Size(100, 20);
            this.sxTextBox.TabIndex = 4;
            // 
            // birthsignLabel
            // 
            this.birthsignLabel.AutoSize = true;
            this.birthsignLabel.Location = new System.Drawing.Point(13, 139);
            this.birthsignLabel.Name = "birthsignLabel";
            this.birthsignLabel.Size = new System.Drawing.Size(47, 13);
            this.birthsignLabel.TabIndex = 7;
            this.birthsignLabel.Text = "Birthsign";
            // 
            // birthsignTextBox
            // 
            this.birthsignTextBox.Location = new System.Drawing.Point(68, 136);
            this.birthsignTextBox.Name = "birthsignTextBox";
            this.birthsignTextBox.ReadOnly = true;
            this.birthsignTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthsignTextBox.TabIndex = 6;
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(268, 23);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.ReadOnly = true;
            this.locationTextBox.Size = new System.Drawing.Size(145, 20);
            this.locationTextBox.TabIndex = 8;
            this.locationTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Location = new System.Drawing.Point(297, 7);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(87, 13);
            this.locationLabel.TabIndex = 9;
            this.locationLabel.Text = "Starting Location";
            // 
            // majorLabel
            // 
            this.majorLabel.AutoSize = true;
            this.majorLabel.Location = new System.Drawing.Point(236, 78);
            this.majorLabel.Name = "majorLabel";
            this.majorLabel.Size = new System.Drawing.Size(60, 13);
            this.majorLabel.TabIndex = 12;
            this.majorLabel.Text = "Major Skills";
            // 
            // minorLabel
            // 
            this.minorLabel.AutoSize = true;
            this.minorLabel.Location = new System.Drawing.Point(351, 78);
            this.minorLabel.Name = "minorLabel";
            this.minorLabel.Size = new System.Drawing.Size(60, 13);
            this.minorLabel.TabIndex = 13;
            this.minorLabel.Text = "Minor Skills";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(165, 191);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(102, 41);
            this.generateButton.TabIndex = 18;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsButton.Image")));
            this.settingsButton.Location = new System.Drawing.Point(273, 191);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(30, 41);
            this.settingsButton.TabIndex = 19;
            this.toolTip1.SetToolTip(this.settingsButton, "Settings");
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // majorListBox
            // 
            this.majorListBox.FormattingEnabled = true;
            this.majorListBox.Location = new System.Drawing.Point(239, 94);
            this.majorListBox.Name = "majorListBox";
            this.majorListBox.Size = new System.Drawing.Size(93, 69);
            this.majorListBox.TabIndex = 20;
            // 
            // minorListBox
            // 
            this.minorListBox.FormattingEnabled = true;
            this.minorListBox.Location = new System.Drawing.Point(354, 94);
            this.minorListBox.Name = "minorListBox";
            this.minorListBox.Size = new System.Drawing.Size(93, 69);
            this.minorListBox.TabIndex = 21;
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 256);
            this.Controls.Add(this.minorListBox);
            this.Controls.Add(this.majorListBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.minorLabel);
            this.Controls.Add(this.majorLabel);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.birthsignLabel);
            this.Controls.Add(this.birthsignTextBox);
            this.Controls.Add(this.sxLabel);
            this.Controls.Add(this.sxTextBox);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.raceTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skyrim Random Character Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.TextBox raceTextBox;
        private System.Windows.Forms.Label sxLabel;
        private System.Windows.Forms.TextBox sxTextBox;
        private System.Windows.Forms.Label birthsignLabel;
        private System.Windows.Forms.TextBox birthsignTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label majorLabel;
        private System.Windows.Forms.Label minorLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.ListBox majorListBox;
        private System.Windows.Forms.ListBox minorListBox;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

