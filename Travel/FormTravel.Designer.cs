namespace Zadacha
{
    partial class GUI
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
            this.lblProfil = new System.Windows.Forms.Label();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.radSputnik = new System.Windows.Forms.RadioButton();
            this.radSakvoyz = new System.Windows.Forms.RadioButton();
            this.radGrandoTur = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblVolumeFirm = new System.Windows.Forms.Label();
            this.lblGermany = new System.Windows.Forms.Label();
            this.lblEngland = new System.Windows.Forms.Label();
            this.lblSpain = new System.Windows.Forms.Label();
            this.lblItaly = new System.Windows.Forms.Label();
            this.lblGreece = new System.Windows.Forms.Label();
            this.lblTurkey = new System.Windows.Forms.Label();
            this.txtGermany = new System.Windows.Forms.TextBox();
            this.txtEngland = new System.Windows.Forms.TextBox();
            this.txtSpain = new System.Windows.Forms.TextBox();
            this.txtItaly = new System.Windows.Forms.TextBox();
            this.txtGreece = new System.Windows.Forms.TextBox();
            this.txtTurkey = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.lblFirm = new System.Windows.Forms.Label();
            this.lblTypes = new System.Windows.Forms.Label();
            this.ptcZem = new System.Windows.Forms.PictureBox();
            this.lblSold = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnMaxVolume = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcZem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfil
            // 
            this.lblProfil.AutoSize = true;
            this.lblProfil.BackColor = System.Drawing.Color.Transparent;
            this.lblProfil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblProfil.ForeColor = System.Drawing.Color.Transparent;
            this.lblProfil.Location = new System.Drawing.Point(12, 9);
            this.lblProfil.Name = "lblProfil";
            this.lblProfil.Size = new System.Drawing.Size(56, 15);
            this.lblProfil.TabIndex = 0;
            this.lblProfil.Text = "ФИРМА";
            // 
            // grpType
            // 
            this.grpType.BackColor = System.Drawing.Color.Transparent;
            this.grpType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpType.Controls.Add(this.radSputnik);
            this.grpType.Controls.Add(this.radSakvoyz);
            this.grpType.Controls.Add(this.radGrandoTur);
            this.grpType.ForeColor = System.Drawing.Color.Transparent;
            this.grpType.Location = new System.Drawing.Point(12, 27);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(105, 125);
            this.grpType.TabIndex = 1;
            this.grpType.TabStop = false;
            // 
            // radSputnik
            // 
            this.radSputnik.AutoSize = true;
            this.radSputnik.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radSputnik.Location = new System.Drawing.Point(8, 78);
            this.radSputnik.Name = "radSputnik";
            this.radSputnik.Size = new System.Drawing.Size(74, 19);
            this.radSputnik.TabIndex = 2;
            this.radSputnik.Text = "Спутник";
            this.radSputnik.UseVisualStyleBackColor = true;
            this.radSputnik.CheckedChanged += new System.EventHandler(this.radSputnik_CheckedChanged);
            // 
            // radSakvoyz
            // 
            this.radSakvoyz.AutoSize = true;
            this.radSakvoyz.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radSakvoyz.Location = new System.Drawing.Point(8, 51);
            this.radSakvoyz.Name = "radSakvoyz";
            this.radSakvoyz.Size = new System.Drawing.Size(77, 19);
            this.radSakvoyz.TabIndex = 1;
            this.radSakvoyz.Text = "Саквояж";
            this.radSakvoyz.UseVisualStyleBackColor = true;
            this.radSakvoyz.CheckedChanged += new System.EventHandler(this.radSakvoyz_CheckedChanged);
            // 
            // radGrandoTur
            // 
            this.radGrandoTur.AutoSize = true;
            this.radGrandoTur.Checked = true;
            this.radGrandoTur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radGrandoTur.Location = new System.Drawing.Point(8, 23);
            this.radGrandoTur.Name = "radGrandoTur";
            this.radGrandoTur.Size = new System.Drawing.Size(83, 19);
            this.radGrandoTur.TabIndex = 0;
            this.radGrandoTur.TabStop = true;
            this.radGrandoTur.Text = "ГрандоТур";
            this.radGrandoTur.UseVisualStyleBackColor = true;
            this.radGrandoTur.CheckedChanged += new System.EventHandler(this.radGrandoTur_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(389, 164);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 27);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalculate.Location = new System.Drawing.Point(209, 164);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(174, 27);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Рассчитать объём продаж";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblVolumeFirm
            // 
            this.lblVolumeFirm.AutoSize = true;
            this.lblVolumeFirm.BackColor = System.Drawing.Color.Transparent;
            this.lblVolumeFirm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolumeFirm.Location = new System.Drawing.Point(224, 19);
            this.lblVolumeFirm.Name = "lblVolumeFirm";
            this.lblVolumeFirm.Size = new System.Drawing.Size(0, 15);
            this.lblVolumeFirm.TabIndex = 4;
            this.lblVolumeFirm.Click += new System.EventHandler(this.lblVolumeFirm_Click);
            // 
            // lblGermany
            // 
            this.lblGermany.AutoSize = true;
            this.lblGermany.BackColor = System.Drawing.Color.Transparent;
            this.lblGermany.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGermany.ForeColor = System.Drawing.Color.Transparent;
            this.lblGermany.Location = new System.Drawing.Point(4, 322);
            this.lblGermany.Name = "lblGermany";
            this.lblGermany.Size = new System.Drawing.Size(77, 15);
            this.lblGermany.TabIndex = 6;
            this.lblGermany.Text = "ГЕРМАНИЯ";
            this.lblGermany.Visible = false;
            this.lblGermany.Click += new System.EventHandler(this.lblGermany_Click);
            // 
            // lblEngland
            // 
            this.lblEngland.AutoSize = true;
            this.lblEngland.BackColor = System.Drawing.Color.Transparent;
            this.lblEngland.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEngland.ForeColor = System.Drawing.Color.Transparent;
            this.lblEngland.Location = new System.Drawing.Point(22, 360);
            this.lblEngland.Name = "lblEngland";
            this.lblEngland.Size = new System.Drawing.Size(59, 15);
            this.lblEngland.TabIndex = 7;
            this.lblEngland.Text = "АНГЛИЯ";
            this.lblEngland.Visible = false;
            this.lblEngland.Click += new System.EventHandler(this.lblEngland_Click);
            // 
            // lblSpain
            // 
            this.lblSpain.AutoSize = true;
            this.lblSpain.BackColor = System.Drawing.Color.Transparent;
            this.lblSpain.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSpain.ForeColor = System.Drawing.Color.Transparent;
            this.lblSpain.Location = new System.Drawing.Point(11, 170);
            this.lblSpain.Name = "lblSpain";
            this.lblSpain.Size = new System.Drawing.Size(70, 15);
            this.lblSpain.TabIndex = 8;
            this.lblSpain.Text = "ИСПАНИЯ";
            this.lblSpain.Click += new System.EventHandler(this.lblSpain_Click);
            // 
            // lblItaly
            // 
            this.lblItaly.AutoSize = true;
            this.lblItaly.BackColor = System.Drawing.Color.Transparent;
            this.lblItaly.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblItaly.ForeColor = System.Drawing.Color.Transparent;
            this.lblItaly.Location = new System.Drawing.Point(21, 207);
            this.lblItaly.Name = "lblItaly";
            this.lblItaly.Size = new System.Drawing.Size(60, 15);
            this.lblItaly.TabIndex = 9;
            this.lblItaly.Text = "ИТАЛИЯ";
            this.lblItaly.Click += new System.EventHandler(this.lblItaly_Click);
            // 
            // lblGreece
            // 
            this.lblGreece.AutoSize = true;
            this.lblGreece.BackColor = System.Drawing.Color.Transparent;
            this.lblGreece.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreece.ForeColor = System.Drawing.Color.Transparent;
            this.lblGreece.Location = new System.Drawing.Point(24, 243);
            this.lblGreece.Name = "lblGreece";
            this.lblGreece.Size = new System.Drawing.Size(57, 15);
            this.lblGreece.TabIndex = 10;
            this.lblGreece.Text = "ГРЕЦИЯ";
            this.lblGreece.Click += new System.EventHandler(this.lblGreece_Click);
            // 
            // lblTurkey
            // 
            this.lblTurkey.AutoSize = true;
            this.lblTurkey.BackColor = System.Drawing.Color.Transparent;
            this.lblTurkey.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTurkey.ForeColor = System.Drawing.Color.Transparent;
            this.lblTurkey.Location = new System.Drawing.Point(21, 283);
            this.lblTurkey.Name = "lblTurkey";
            this.lblTurkey.Size = new System.Drawing.Size(60, 15);
            this.lblTurkey.TabIndex = 11;
            this.lblTurkey.Text = "ТУРЦИЯ";
            this.lblTurkey.Click += new System.EventHandler(this.lblTurkey_Click);
            // 
            // txtGermany
            // 
            this.txtGermany.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtGermany.Location = new System.Drawing.Point(87, 319);
            this.txtGermany.Name = "txtGermany";
            this.txtGermany.Size = new System.Drawing.Size(116, 22);
            this.txtGermany.TabIndex = 12;
            this.txtGermany.Visible = false;
            // 
            // txtEngland
            // 
            this.txtEngland.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEngland.Location = new System.Drawing.Point(87, 357);
            this.txtEngland.Name = "txtEngland";
            this.txtEngland.Size = new System.Drawing.Size(116, 22);
            this.txtEngland.TabIndex = 13;
            this.txtEngland.Visible = false;
            // 
            // txtSpain
            // 
            this.txtSpain.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtSpain.Location = new System.Drawing.Point(87, 167);
            this.txtSpain.Name = "txtSpain";
            this.txtSpain.Size = new System.Drawing.Size(116, 22);
            this.txtSpain.TabIndex = 14;
            // 
            // txtItaly
            // 
            this.txtItaly.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtItaly.Location = new System.Drawing.Point(87, 204);
            this.txtItaly.Name = "txtItaly";
            this.txtItaly.Size = new System.Drawing.Size(116, 22);
            this.txtItaly.TabIndex = 15;
            // 
            // txtGreece
            // 
            this.txtGreece.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtGreece.Location = new System.Drawing.Point(87, 240);
            this.txtGreece.Name = "txtGreece";
            this.txtGreece.Size = new System.Drawing.Size(116, 22);
            this.txtGreece.TabIndex = 16;
            // 
            // txtTurkey
            // 
            this.txtTurkey.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTurkey.Location = new System.Drawing.Point(87, 280);
            this.txtTurkey.Name = "txtTurkey";
            this.txtTurkey.Size = new System.Drawing.Size(116, 22);
            this.txtTurkey.TabIndex = 17;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.BackColor = System.Drawing.Color.Transparent;
            this.lblVolume.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVolume.ForeColor = System.Drawing.Color.Transparent;
            this.lblVolume.Location = new System.Drawing.Point(209, 247);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(117, 15);
            this.lblVolume.TabIndex = 18;
            this.lblVolume.Text = "ОБЪЁМ ПРОДАЖ:";
            this.lblVolume.Click += new System.EventHandler(this.lblVolume_Click);
            // 
            // lblFirm
            // 
            this.lblFirm.AutoSize = true;
            this.lblFirm.BackColor = System.Drawing.Color.Transparent;
            this.lblFirm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFirm.ForeColor = System.Drawing.Color.Transparent;
            this.lblFirm.Location = new System.Drawing.Point(209, 223);
            this.lblFirm.Name = "lblFirm";
            this.lblFirm.Size = new System.Drawing.Size(134, 15);
            this.lblFirm.TabIndex = 19;
            this.lblFirm.Text = "НАЗВАНИЕ ФИРМЫ:";
            this.lblFirm.Click += new System.EventHandler(this.lblFirm_Click);
            // 
            // lblTypes
            // 
            this.lblTypes.AutoSize = true;
            this.lblTypes.BackColor = System.Drawing.Color.Transparent;
            this.lblTypes.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTypes.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTypes.Location = new System.Drawing.Point(257, 4);
            this.lblTypes.Name = "lblTypes";
            this.lblTypes.Size = new System.Drawing.Size(126, 22);
            this.lblTypes.TabIndex = 5;
            this.lblTypes.Text = "ГРАНДОТУР";
            this.lblTypes.Click += new System.EventHandler(this.lblTypes_Click);
            // 
            // ptcZem
            // 
            this.ptcZem.BackColor = System.Drawing.Color.Black;
            this.ptcZem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptcZem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcZem.Image = global::Zadacha.Properties.Resources._470x0_WZStXGbod9aXSG1A34nAufsiabtTAYLd___jpg____4_1ea5f39d;
            this.ptcZem.Location = new System.Drawing.Point(128, 34);
            this.ptcZem.Name = "ptcZem";
            this.ptcZem.Size = new System.Drawing.Size(348, 118);
            this.ptcZem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcZem.TabIndex = 21;
            this.ptcZem.TabStop = false;
            // 
            // lblSold
            // 
            this.lblSold.AutoSize = true;
            this.lblSold.BackColor = System.Drawing.Color.Transparent;
            this.lblSold.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSold.ForeColor = System.Drawing.Color.Transparent;
            this.lblSold.Location = new System.Drawing.Point(209, 275);
            this.lblSold.Name = "lblSold";
            this.lblSold.Size = new System.Drawing.Size(214, 15);
            this.lblSold.TabIndex = 22;
            this.lblSold.Text = "КОЛ-ВО ПРОДАННЫХ БИЛЕТОВ:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtList
            // 
            this.txtList.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtList.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtList.Location = new System.Drawing.Point(212, 300);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ReadOnly = true;
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtList.Size = new System.Drawing.Size(264, 79);
            this.txtList.TabIndex = 25;
            // 
            // btnMaxVolume
            // 
            this.btnMaxVolume.BackColor = System.Drawing.Color.White;
            this.btnMaxVolume.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaxVolume.Location = new System.Drawing.Point(209, 193);
            this.btnMaxVolume.Name = "btnMaxVolume";
            this.btnMaxVolume.Size = new System.Drawing.Size(267, 27);
            this.btnMaxVolume.TabIndex = 26;
            this.btnMaxVolume.Text = "Общий объём продаж";
            this.btnMaxVolume.UseVisualStyleBackColor = false;
            this.btnMaxVolume.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.BackgroundImage = global::Zadacha.Properties.Resources._238bf0ee0222c7e50b7048117f92bbbf;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 386);
            this.Controls.Add(this.btnMaxVolume);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.lblSold);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblFirm);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtTurkey);
            this.Controls.Add(this.txtGreece);
            this.Controls.Add(this.txtItaly);
            this.Controls.Add(this.txtSpain);
            this.Controls.Add(this.txtEngland);
            this.Controls.Add(this.txtGermany);
            this.Controls.Add(this.lblTurkey);
            this.Controls.Add(this.lblGreece);
            this.Controls.Add(this.lblItaly);
            this.Controls.Add(this.lblSpain);
            this.Controls.Add(this.lblEngland);
            this.Controls.Add(this.lblGermany);
            this.Controls.Add(this.lblTypes);
            this.Controls.Add(this.lblVolumeFirm);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.lblProfil);
            this.Controls.Add(this.ptcZem);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "РАСЧЁТ ОБЪЁМА ПРОДАЖ";
            this.Load += new System.EventHandler(this.FormTravel_Load);
            this.grpType.ResumeLayout(false);
            this.grpType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptcZem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProfil;
        private System.Windows.Forms.GroupBox grpType;
        private System.Windows.Forms.RadioButton radSputnik;
        private System.Windows.Forms.RadioButton radSakvoyz;
        private System.Windows.Forms.RadioButton radGrandoTur;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblVolumeFirm;
        private System.Windows.Forms.Label lblGermany;
        private System.Windows.Forms.Label lblEngland;
        private System.Windows.Forms.Label lblSpain;
        private System.Windows.Forms.Label lblItaly;
        private System.Windows.Forms.Label lblGreece;
        private System.Windows.Forms.Label lblTurkey;
        private System.Windows.Forms.TextBox txtGermany;
        private System.Windows.Forms.TextBox txtEngland;
        private System.Windows.Forms.TextBox txtSpain;
        private System.Windows.Forms.TextBox txtItaly;
        private System.Windows.Forms.TextBox txtGreece;
        private System.Windows.Forms.TextBox txtTurkey;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Label lblFirm;
        private System.Windows.Forms.Label lblTypes;
        private System.Windows.Forms.PictureBox ptcZem;
        private System.Windows.Forms.Label lblSold;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnMaxVolume;
    }
}