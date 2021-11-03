namespace ShipsApp.Forms
{
    partial class FormShipConfig
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShipConfig));
            this.pictureBoxShowShip = new System.Windows.Forms.PictureBox();
            this.groupBoxShipType = new System.Windows.Forms.GroupBox();
            this.labelContainerShip = new System.Windows.Forms.Label();
            this.labelShip = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.checkBoxContainers = new System.Windows.Forms.CheckBox();
            this.checkBoxCrane = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.panelShowShip = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelViolet = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelAdditionalColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonParkShip = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowShip)).BeginInit();
            this.groupBoxShipType.SuspendLayout();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelShowShip.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxShowShip
            // 
            this.pictureBoxShowShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShowShip.Location = new System.Drawing.Point(5, 7);
            this.pictureBoxShowShip.Name = "pictureBoxShowShip";
            this.pictureBoxShowShip.Size = new System.Drawing.Size(314, 300);
            this.pictureBoxShowShip.TabIndex = 0;
            this.pictureBoxShowShip.TabStop = false;
            // 
            // groupBoxShipType
            // 
            this.groupBoxShipType.Controls.Add(this.labelContainerShip);
            this.groupBoxShipType.Controls.Add(this.labelShip);
            this.groupBoxShipType.Location = new System.Drawing.Point(11, 12);
            this.groupBoxShipType.Name = "groupBoxShipType";
            this.groupBoxShipType.Size = new System.Drawing.Size(215, 118);
            this.groupBoxShipType.TabIndex = 1;
            this.groupBoxShipType.TabStop = false;
            this.groupBoxShipType.Text = "Тип судна";
            // 
            // labelContainerShip
            // 
            this.labelContainerShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelContainerShip.Location = new System.Drawing.Point(6, 73);
            this.labelContainerShip.Name = "labelContainerShip";
            this.labelContainerShip.Size = new System.Drawing.Size(203, 32);
            this.labelContainerShip.TabIndex = 1;
            this.labelContainerShip.Text = "Контейнеровоз";
            this.labelContainerShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelContainerShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelContainerShip_MouseDown);
            // 
            // labelShip
            // 
            this.labelShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShip.Location = new System.Drawing.Point(6, 32);
            this.labelShip.Name = "labelShip";
            this.labelShip.Size = new System.Drawing.Size(203, 32);
            this.labelShip.TabIndex = 0;
            this.labelShip.Text = "Обычное судно";
            this.labelShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelShip_MouseDown);
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.checkBoxContainers);
            this.groupBoxSettings.Controls.Add(this.checkBoxCrane);
            this.groupBoxSettings.Controls.Add(this.numericUpDownWeight);
            this.groupBoxSettings.Controls.Add(this.labelWeight);
            this.groupBoxSettings.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxSettings.Controls.Add(this.labelMaxSpeed);
            this.groupBoxSettings.Location = new System.Drawing.Point(11, 136);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(215, 158);
            this.groupBoxSettings.TabIndex = 2;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Параметры";
            // 
            // checkBoxContainers
            // 
            this.checkBoxContainers.AutoSize = true;
            this.checkBoxContainers.Checked = true;
            this.checkBoxContainers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxContainers.Location = new System.Drawing.Point(14, 125);
            this.checkBoxContainers.Name = "checkBoxContainers";
            this.checkBoxContainers.Size = new System.Drawing.Size(112, 21);
            this.checkBoxContainers.TabIndex = 5;
            this.checkBoxContainers.Text = "Контейнеры";
            this.checkBoxContainers.UseVisualStyleBackColor = true;
            // 
            // checkBoxCrane
            // 
            this.checkBoxCrane.AutoSize = true;
            this.checkBoxCrane.Checked = true;
            this.checkBoxCrane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCrane.Location = new System.Drawing.Point(14, 98);
            this.checkBoxCrane.Name = "checkBoxCrane";
            this.checkBoxCrane.Size = new System.Drawing.Size(63, 21);
            this.checkBoxCrane.TabIndex = 4;
            this.checkBoxCrane.Text = "Кран";
            this.checkBoxCrane.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(134, 61);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(11, 63);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(78, 17);
            this.labelWeight.TabIndex = 2;
            this.labelWeight.Text = "Вес судна:";
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(134, 32);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(61, 22);
            this.numericUpDownMaxSpeed.TabIndex = 1;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(11, 32);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(116, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макc. скорость: ";
            // 
            // panelShowShip
            // 
            this.panelShowShip.AllowDrop = true;
            this.panelShowShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShowShip.Controls.Add(this.pictureBoxShowShip);
            this.panelShowShip.Location = new System.Drawing.Point(462, 12);
            this.panelShowShip.Name = "panelShowShip";
            this.panelShowShip.Size = new System.Drawing.Size(326, 315);
            this.panelShowShip.TabIndex = 3;
            this.panelShowShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShowShip_DragDrop);
            this.panelShowShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShowShip_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelViolet);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelAdditionalColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(232, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(224, 282);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(170, 205);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 6;
            // 
            // panelViolet
            // 
            this.panelViolet.BackColor = System.Drawing.Color.Violet;
            this.panelViolet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelViolet.Location = new System.Drawing.Point(118, 205);
            this.panelViolet.Name = "panelViolet";
            this.panelViolet.Size = new System.Drawing.Size(40, 40);
            this.panelViolet.TabIndex = 5;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Pink;
            this.panelPink.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPink.Location = new System.Drawing.Point(66, 205);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(40, 40);
            this.panelPink.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(13, 205);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 3;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(170, 144);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 5;
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(118, 144);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(66, 144);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(13, 144);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 2;
            // 
            // labelAdditionalColor
            // 
            this.labelAdditionalColor.AllowDrop = true;
            this.labelAdditionalColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdditionalColor.Location = new System.Drawing.Point(13, 73);
            this.labelAdditionalColor.Name = "labelAdditionalColor";
            this.labelAdditionalColor.Size = new System.Drawing.Size(197, 32);
            this.labelAdditionalColor.TabIndex = 1;
            this.labelAdditionalColor.Text = "Дополнительный цвет";
            this.labelAdditionalColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdditionalColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelAdditionalColor_DragDrop);
            this.labelAdditionalColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(13, 32);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(197, 32);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // buttonParkShip
            // 
            this.buttonParkShip.Location = new System.Drawing.Point(106, 301);
            this.buttonParkShip.Name = "buttonParkShip";
            this.buttonParkShip.Size = new System.Drawing.Size(120, 26);
            this.buttonParkShip.TabIndex = 5;
            this.buttonParkShip.Text = "Припарковать";
            this.buttonParkShip.UseVisualStyleBackColor = true;
            this.buttonParkShip.Click += new System.EventHandler(this.buttonParkShip_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(232, 301);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 26);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonParkShip);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelShowShip);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.groupBoxShipType);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormShipConfig";
            this.Text = "Выбор судна";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShowShip)).EndInit();
            this.groupBoxShipType.ResumeLayout(false);
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelShowShip.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBoxShowShip;

        private System.Windows.Forms.GroupBox groupBoxShipType;

        private System.Windows.Forms.GroupBox groupBoxSettings;

        private System.Windows.Forms.CheckBox checkBoxContainers;

        private System.Windows.Forms.CheckBox checkBoxCrane;

        private System.Windows.Forms.NumericUpDown numericUpDownWeight;

        private System.Windows.Forms.Label labelWeight;

        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;

        private System.Windows.Forms.Label labelMaxSpeed;

        private System.Windows.Forms.Label labelShip;

        private System.Windows.Forms.Label labelContainerShip;

        private System.Windows.Forms.Panel panelShowShip;

        private System.Windows.Forms.GroupBox groupBoxColors;

        private System.Windows.Forms.Label labelMainColor;

        private System.Windows.Forms.Label labelAdditionalColor;

        private System.Windows.Forms.Panel panelRed;

        private System.Windows.Forms.Panel panelGreen;

        private System.Windows.Forms.Panel panelBlue;

        private System.Windows.Forms.Panel panelOrange;

        private System.Windows.Forms.Panel panelYellow;

        private System.Windows.Forms.Panel panelPink;

        private System.Windows.Forms.Panel panelViolet;

        private System.Windows.Forms.Panel panelWhite;

        private System.Windows.Forms.Button buttonParkShip;

        private System.Windows.Forms.Button buttonCancel;
    }
}
