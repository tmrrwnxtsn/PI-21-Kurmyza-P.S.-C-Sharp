namespace ContainerShipApp
{
    partial class FormContainerShip
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormContainerShip));
            this.pictureBoxContainerShip = new System.Windows.Forms.PictureBox();
            this.buttonCreateContainerShip = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContainerShip)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxContainerShip
            // 
            this.pictureBoxContainerShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxContainerShip.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxContainerShip.Name = "pictureBoxContainerShip";
            this.pictureBoxContainerShip.Size = new System.Drawing.Size(982, 553);
            this.pictureBoxContainerShip.TabIndex = 0;
            this.pictureBoxContainerShip.TabStop = false;
            // 
            // buttonCreateContainerShip
            // 
            this.buttonCreateContainerShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateContainerShip.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateContainerShip.Name = "buttonCreateContainerShip";
            this.buttonCreateContainerShip.Size = new System.Drawing.Size(101, 32);
            this.buttonCreateContainerShip.TabIndex = 1;
            this.buttonCreateContainerShip.Text = "Создать";
            this.buttonCreateContainerShip.UseVisualStyleBackColor = true;
            this.buttonCreateContainerShip.Click += new System.EventHandler(this.buttonCreateContainerShip_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::ContainerShipApp.Properties.Resources.arrowUp;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(904, 475);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::ContainerShipApp.Properties.Resources.arrowDown;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(904, 511);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::ContainerShipApp.Properties.Resources.arrowRight;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(940, 511);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::ContainerShipApp.Properties.Resources.arrowLeft;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(868, 511);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // FormContainerShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonCreateContainerShip);
            this.Controls.Add(this.pictureBoxContainerShip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormContainerShip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Контейнеровоз";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContainerShip)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pictureBoxContainerShip;

        private System.Windows.Forms.Button buttonCreateContainerShip;

        private System.Windows.Forms.Button buttonUp;

        private System.Windows.Forms.Button buttonDown;

        private System.Windows.Forms.Button buttonRight;

        private System.Windows.Forms.Button buttonLeft;
    }
}
