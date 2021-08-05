
namespace Pablo_C_Sharp
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titleLabel = new System.Windows.Forms.Label();
            this.patientBox = new System.Windows.Forms.GroupBox();
            this.patientNumberCombo = new System.Windows.Forms.ComboBox();
            this.patientLetterCombo = new System.Windows.Forms.ComboBox();
            this.roomBox = new System.Windows.Forms.GroupBox();
            this.roomCombo = new System.Windows.Forms.ComboBox();
            this.lastPatientBox = new System.Windows.Forms.GroupBox();
            this.lastPatientLabel = new System.Windows.Forms.Label();
            this.displayButton = new System.Windows.Forms.Button();
            this.patientBox.SuspendLayout();
            this.roomBox.SuspendLayout();
            this.lastPatientBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(307, 62);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(401, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Następny pacjent";
            // 
            // patientBox
            // 
            this.patientBox.Controls.Add(this.patientNumberCombo);
            this.patientBox.Controls.Add(this.patientLetterCombo);
            this.patientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientBox.Location = new System.Drawing.Point(50, 200);
            this.patientBox.Name = "patientBox";
            this.patientBox.Size = new System.Drawing.Size(400, 175);
            this.patientBox.TabIndex = 1;
            this.patientBox.TabStop = false;
            this.patientBox.Text = " Pacjent ";
            // 
            // patientNumberCombo
            // 
            this.patientNumberCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientNumberCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientNumberCombo.FormattingEnabled = true;
            this.patientNumberCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.patientNumberCombo.Location = new System.Drawing.Point(235, 75);
            this.patientNumberCombo.Name = "patientNumberCombo";
            this.patientNumberCombo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.patientNumberCombo.Size = new System.Drawing.Size(80, 50);
            this.patientNumberCombo.TabIndex = 1;
            // 
            // patientLetterCombo
            // 
            this.patientLetterCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patientLetterCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientLetterCombo.FormattingEnabled = true;
            this.patientLetterCombo.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.patientLetterCombo.Location = new System.Drawing.Point(90, 75);
            this.patientLetterCombo.Name = "patientLetterCombo";
            this.patientLetterCombo.Size = new System.Drawing.Size(80, 50);
            this.patientLetterCombo.TabIndex = 0;
            // 
            // roomBox
            // 
            this.roomBox.Controls.Add(this.roomCombo);
            this.roomBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomBox.Location = new System.Drawing.Point(550, 200);
            this.roomBox.Name = "roomBox";
            this.roomBox.Size = new System.Drawing.Size(400, 175);
            this.roomBox.TabIndex = 2;
            this.roomBox.TabStop = false;
            this.roomBox.Text = " Gabinet ";
            // 
            // roomCombo
            // 
            this.roomCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.roomCombo.FormattingEnabled = true;
            this.roomCombo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.roomCombo.Location = new System.Drawing.Point(160, 75);
            this.roomCombo.Name = "roomCombo";
            this.roomCombo.Size = new System.Drawing.Size(80, 50);
            this.roomCombo.TabIndex = 0;
            // 
            // lastPatientBox
            // 
            this.lastPatientBox.Controls.Add(this.lastPatientLabel);
            this.lastPatientBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastPatientBox.Location = new System.Drawing.Point(12, 579);
            this.lastPatientBox.Name = "lastPatientBox";
            this.lastPatientBox.Size = new System.Drawing.Size(958, 112);
            this.lastPatientBox.TabIndex = 3;
            this.lastPatientBox.TabStop = false;
            this.lastPatientBox.Text = " Ostatnio wyświetlony pacjent ";
            // 
            // lastPatientLabel
            // 
            this.lastPatientLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lastPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastPatientLabel.Location = new System.Drawing.Point(3, 26);
            this.lastPatientLabel.Name = "lastPatientLabel";
            this.lastPatientLabel.Size = new System.Drawing.Size(952, 83);
            this.lastPatientLabel.TabIndex = 0;
            this.lastPatientLabel.Text = "brak";
            this.lastPatientLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // displayButton
            // 
            this.displayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.displayButton.Location = new System.Drawing.Point(775, 420);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(175, 60);
            this.displayButton.TabIndex = 4;
            this.displayButton.Text = "Wyświetl";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.displayButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(982, 703);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.lastPatientBox);
            this.Controls.Add(this.roomBox);
            this.Controls.Add(this.patientBox);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wezwanie pacjenta";
            this.patientBox.ResumeLayout(false);
            this.roomBox.ResumeLayout(false);
            this.lastPatientBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox patientBox;
        private System.Windows.Forms.GroupBox roomBox;
        private System.Windows.Forms.GroupBox lastPatientBox;
        private System.Windows.Forms.Label lastPatientLabel;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.ComboBox patientNumberCombo;
        private System.Windows.Forms.ComboBox patientLetterCombo;
        private System.Windows.Forms.ComboBox roomCombo;
    }
}

