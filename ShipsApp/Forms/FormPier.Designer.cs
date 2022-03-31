
namespace ShipsApp
{
    partial class FormPier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPier));
            this.pictureBoxPier = new System.Windows.Forms.PictureBox();
            this.buttonParkShip = new System.Windows.Forms.Button();
            this.groupBoxGetShip = new System.Windows.Forms.GroupBox();
            this.buttonGetShip = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelPier = new System.Windows.Forms.Label();
            this.textBoxInputPierName = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddPier = new System.Windows.Forms.Button();
            this.listBoxPiers = new System.Windows.Forms.ListBox();
            this.buttonRemovePier = new System.Windows.Forms.Button();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).BeginInit();
            this.groupBoxGetShip.SuspendLayout();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPier
            // 
            this.pictureBoxPier.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxPier.Name = "pictureBoxPier";
            this.pictureBoxPier.Size = new System.Drawing.Size(1331, 713);
            this.pictureBoxPier.TabIndex = 0;
            this.pictureBoxPier.TabStop = false;
            // 
            // buttonParkShip
            // 
            this.buttonParkShip.Location = new System.Drawing.Point(1352, 395);
            this.buttonParkShip.Name = "buttonParkShip";
            this.buttonParkShip.Size = new System.Drawing.Size(130, 47);
            this.buttonParkShip.TabIndex = 1;
            this.buttonParkShip.Text = "Припарковать судно";
            this.buttonParkShip.UseVisualStyleBackColor = true;
            this.buttonParkShip.Click += new System.EventHandler(this.buttonParkShip_Click);
            // 
            // groupBoxGetShip
            // 
            this.groupBoxGetShip.Controls.Add(this.buttonGetShip);
            this.groupBoxGetShip.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxGetShip.Controls.Add(this.labelPlace);
            this.groupBoxGetShip.Location = new System.Drawing.Point(1349, 448);
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
            // labelPier
            // 
            this.labelPier.AutoSize = true;
            this.labelPier.Location = new System.Drawing.Point(1379, 43);
            this.labelPier.Name = "labelPier";
            this.labelPier.Size = new System.Drawing.Size(75, 17);
            this.labelPier.TabIndex = 4;
            this.labelPier.Text = "Пристань:";
            // 
            // textBoxInputPierName
            // 
            this.textBoxInputPierName.Location = new System.Drawing.Point(1352, 65);
            this.textBoxInputPierName.Name = "textBoxInputPierName";
            this.textBoxInputPierName.Size = new System.Drawing.Size(130, 22);
            this.textBoxInputPierName.TabIndex = 5;
            // 
            // buttonAddPier
            // 
            this.buttonAddPier.Location = new System.Drawing.Point(1352, 94);
            this.buttonAddPier.Name = "buttonAddPier";
            this.buttonAddPier.Size = new System.Drawing.Size(130, 49);
            this.buttonAddPier.TabIndex = 6;
            this.buttonAddPier.Text = "Добавить пристань";
            this.buttonAddPier.UseVisualStyleBackColor = true;
            this.buttonAddPier.Click += new System.EventHandler(this.buttonAddPier_Click);
            // 
            // listBoxPiers
            // 
            this.listBoxPiers.FormattingEnabled = true;
            this.listBoxPiers.ItemHeight = 16;
            this.listBoxPiers.Location = new System.Drawing.Point(1352, 149);
            this.listBoxPiers.Name = "listBoxPiers";
            this.listBoxPiers.Size = new System.Drawing.Size(127, 100);
            this.listBoxPiers.TabIndex = 7;
            this.listBoxPiers.SelectedIndexChanged += new System.EventHandler(this.listBoxShowPiers_SelectedIndexChanged);
            // 
            // buttonRemovePier
            // 
            this.buttonRemovePier.Location = new System.Drawing.Point(1352, 255);
            this.buttonRemovePier.Name = "buttonRemovePier";
            this.buttonRemovePier.Size = new System.Drawing.Size(127, 46);
            this.buttonRemovePier.TabIndex = 8;
            this.buttonRemovePier.Text = "Удалить пристань";
            this.buttonRemovePier.UseVisualStyleBackColor = true;
            this.buttonRemovePier.Click += new System.EventHandler(this.buttonRemovePier_Click);
            // 
            // menuStripFile
            // 
            this.menuStripFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(1491, 28);
            this.menuStripFile.TabIndex = 9;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(1352, 323);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(127, 46);
            this.buttonSort.TabIndex = 10;
            this.buttonSort.Text = "Сортировать";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // FormPier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1491, 766);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.buttonRemovePier);
            this.Controls.Add(this.listBoxPiers);
            this.Controls.Add(this.buttonAddPier);
            this.Controls.Add(this.textBoxInputPierName);
            this.Controls.Add(this.labelPier);
            this.Controls.Add(this.groupBoxGetShip);
            this.Controls.Add(this.buttonParkShip);
            this.Controls.Add(this.pictureBoxPier);
            this.Controls.Add(this.menuStripFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "FormPier";
            this.Text = "Коллекция пристаней";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPier)).EndInit();
            this.groupBoxGetShip.ResumeLayout(false);
            this.groupBoxGetShip.PerformLayout();
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPier;
        private System.Windows.Forms.Button buttonParkShip;
        private System.Windows.Forms.GroupBox groupBoxGetShip;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Button buttonGetShip;
        private System.Windows.Forms.Label labelPier;
        private System.Windows.Forms.MaskedTextBox textBoxInputPierName;
        private System.Windows.Forms.Button buttonAddPier;
        private System.Windows.Forms.ListBox listBoxPiers;
        private System.Windows.Forms.Button buttonRemovePier;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonSort;
    }
}