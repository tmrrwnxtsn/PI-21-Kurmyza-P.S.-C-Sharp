
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
            this.buttonParkShip.Location = new System.Drawing.Point(1349, 12);
            this.buttonParkShip.Name = "buttonParkShip";
            this.buttonParkShip.Size = new System.Drawing.Size(130, 47);
            this.buttonParkShip.TabIndex = 1;
            this.buttonParkShip.Text = "Припарковать корабль";
            this.buttonParkShip.UseVisualStyleBackColor = true;
            this.buttonParkShip.Click += new System.EventHandler(this.buttonParkShip_Click);
            // 
            // buttonParkContainerShip
            // 
            this.buttonParkContainerShip.Location = new System.Drawing.Point(1349, 65);
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
            this.groupBoxGetShip.Location = new System.Drawing.Point(1349, 134);
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
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 731);
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

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkShip;
        private System.Windows.Forms.Button buttonParkContainerShip;
        private System.Windows.Forms.GroupBox groupBoxGetShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonGetShip;
    }
}