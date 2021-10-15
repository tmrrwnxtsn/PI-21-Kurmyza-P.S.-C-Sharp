
namespace ShipsApp
{
    partial class FormParking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParking));
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkShip = new System.Windows.Forms.Button();
            this.buttonParkContainerShip = new System.Windows.Forms.Button();
            this.groupBoxGetShip = new System.Windows.Forms.GroupBox();
            this.buttonGetShip = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelParkings = new System.Windows.Forms.Label();
            this.textBoxInputParkingName = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonRemoveParking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBoxGetShip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(1331, 713);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkShip
            // 
            this.buttonParkShip.Location = new System.Drawing.Point(1349, 327);
            this.buttonParkShip.Name = "buttonParkShip";
            this.buttonParkShip.Size = new System.Drawing.Size(130, 47);
            this.buttonParkShip.TabIndex = 1;
            this.buttonParkShip.Text = "Припарковать корабль";
            this.buttonParkShip.UseVisualStyleBackColor = true;
            this.buttonParkShip.Click += new System.EventHandler(this.buttonParkShip_Click);
            // 
            // buttonParkContainerShip
            // 
            this.buttonParkContainerShip.Location = new System.Drawing.Point(1349, 380);
            this.buttonParkContainerShip.Name = "buttonParkContainerShip";
            this.buttonParkContainerShip.Size = new System.Drawing.Size(130, 63);
            this.buttonParkContainerShip.TabIndex = 2;
            this.buttonParkContainerShip.Text = "Припарковать контейнеровоз";
            this.buttonParkContainerShip.UseVisualStyleBackColor = true;
            this.buttonParkContainerShip.Click += new System.EventHandler(this.buttonParkContainerShip_Click);
            // 
            // groupBoxGetShip
            // 
            this.groupBoxGetShip.Controls.Add(this.buttonGetShip);
            this.groupBoxGetShip.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxGetShip.Controls.Add(this.labelPlace);
            this.groupBoxGetShip.Location = new System.Drawing.Point(1349, 449);
            this.groupBoxGetShip.Name = "groupBoxGetShip";
            this.groupBoxGetShip.Size = new System.Drawing.Size(130, 110);
            this.groupBoxGetShip.TabIndex = 3;
            this.groupBoxGetShip.TabStop = false;
            this.groupBoxGetShip.Text = "Забрать судно";
            // 
            // buttonGetShip
            // 
            this.buttonGetShip.Location = new System.Drawing.Point(10, 71);
            this.buttonGetShip.Name = "buttonGetShip";
            this.buttonGetShip.Size = new System.Drawing.Size(104, 33);
            this.buttonGetShip.TabIndex = 2;
            this.buttonGetShip.Text = "Забрать";
            this.buttonGetShip.UseVisualStyleBackColor = true;
            this.buttonGetShip.Click += new System.EventHandler(this.buttonGetShip_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(66, 37);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(48, 22);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(7, 37);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(1379, 12);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(75, 17);
            this.labelParkings.TabIndex = 4;
            this.labelParkings.Text = "Парковки:";
            // 
            // textBoxInputParkingName
            // 
            this.textBoxInputParkingName.Location = new System.Drawing.Point(1352, 34);
            this.textBoxInputParkingName.Name = "textBoxInputParkingName";
            this.textBoxInputParkingName.Size = new System.Drawing.Size(130, 22);
            this.textBoxInputParkingName.TabIndex = 5;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(1352, 63);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(130, 47);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.ItemHeight = 16;
            this.listBoxParkings.Location = new System.Drawing.Point(1352, 117);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(127, 100);
            this.listBoxParkings.TabIndex = 7;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxShowParkings_SelectedIndexChanged);
            // 
            // buttonRemoveParking
            // 
            this.buttonRemoveParking.Location = new System.Drawing.Point(1352, 224);
            this.buttonRemoveParking.Name = "buttonRemoveParking";
            this.buttonRemoveParking.Size = new System.Drawing.Size(127, 46);
            this.buttonRemoveParking.TabIndex = 8;
            this.buttonRemoveParking.Text = "Удалить парковку";
            this.buttonRemoveParking.UseVisualStyleBackColor = true;
            this.buttonRemoveParking.Click += new System.EventHandler(this.buttonRemoveParking_Click);
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 731);
            this.Controls.Add(this.buttonRemoveParking);
            this.Controls.Add(this.listBoxParkings);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.textBoxInputParkingName);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.groupBoxGetShip);
            this.Controls.Add(this.buttonParkContainerShip);
            this.Controls.Add(this.buttonParkShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormParking";
            this.Text = "Парковка кораблей";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBoxGetShip.ResumeLayout(false);
            this.groupBoxGetShip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkShip;
        private System.Windows.Forms.Button buttonParkContainerShip;
        private System.Windows.Forms.GroupBox groupBoxGetShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonGetShip;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.MaskedTextBox textBoxInputParkingName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonRemoveParking;
    }
}