namespace HideAndSeek
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxInstructions = new System.Windows.Forms.TextBox();
            this.comboBoxExist = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.buttonOpenDoor = new System.Windows.Forms.Button();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInstructions
            // 
            this.textBoxInstructions.Enabled = false;
            this.textBoxInstructions.Location = new System.Drawing.Point(12, 308);
            this.textBoxInstructions.Multiline = true;
            this.textBoxInstructions.Name = "textBoxInstructions";
            this.textBoxInstructions.Size = new System.Drawing.Size(590, 43);
            this.textBoxInstructions.TabIndex = 1;
            // 
            // comboBoxExist
            // 
            this.comboBoxExist.FormattingEnabled = true;
            this.comboBoxExist.Location = new System.Drawing.Point(312, 357);
            this.comboBoxExist.Name = "comboBoxExist";
            this.comboBoxExist.Size = new System.Drawing.Size(290, 21);
            this.comboBoxExist.TabIndex = 5;
            // 
            // buttonStart
            // 
            this.buttonStart.Image = global::HideAndSeek.Properties.Resources.round_error_symbol;
            this.buttonStart.Location = new System.Drawing.Point(112, 357);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(94, 90);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "Iniciar Juego";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPC.BackgroundImage = global::HideAndSeek.Properties.Resources.farmer;
            this.pictureBoxPC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPC.Location = new System.Drawing.Point(312, 135);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(27, 31);
            this.pictureBoxPC.TabIndex = 7;
            this.pictureBoxPC.TabStop = false;
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxPlayer.BackgroundImage = global::HideAndSeek.Properties.Resources.boss;
            this.pictureBoxPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(32, 135);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(27, 31);
            this.pictureBoxPlayer.TabIndex = 6;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // buttonOpenDoor
            // 
            this.buttonOpenDoor.Image = global::HideAndSeek.Properties.Resources.login1;
            this.buttonOpenDoor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOpenDoor.Location = new System.Drawing.Point(312, 384);
            this.buttonOpenDoor.Name = "buttonOpenDoor";
            this.buttonOpenDoor.Size = new System.Drawing.Size(290, 63);
            this.buttonOpenDoor.TabIndex = 4;
            this.buttonOpenDoor.Text = "Abrir Puerta";
            this.buttonOpenDoor.UseVisualStyleBackColor = true;
            this.buttonOpenDoor.Click += new System.EventHandler(this.buttonOpenDoor_Click);
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Image = global::HideAndSeek.Properties.Resources.forward_arrow;
            this.buttonGoTo.Location = new System.Drawing.Point(212, 357);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(94, 90);
            this.buttonGoTo.TabIndex = 3;
            this.buttonGoTo.Text = "Ir";
            this.buttonGoTo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.Image = global::HideAndSeek.Properties.Resources.placeholder;
            this.buttonHelp.Location = new System.Drawing.Point(12, 357);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(94, 90);
            this.buttonHelp.TabIndex = 2;
            this.buttonHelp.Text = "Ayuda";
            this.buttonHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.BackgroundImage = global::HideAndSeek.Properties.Resources.Map2;
            this.pictureBoxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMap.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(590, 290);
            this.pictureBoxMap.TabIndex = 0;
            this.pictureBoxMap.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 459);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.pictureBoxPlayer);
            this.Controls.Add(this.comboBoxExist);
            this.Controls.Add(this.buttonOpenDoor);
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.textBoxInstructions);
            this.Controls.Add(this.pictureBoxMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.TextBox textBoxInstructions;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonGoTo;
        private System.Windows.Forms.Button buttonOpenDoor;
        private System.Windows.Forms.ComboBox comboBoxExist;
        private System.Windows.Forms.PictureBox pictureBoxPlayer;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.Button buttonStart;
    }
}

