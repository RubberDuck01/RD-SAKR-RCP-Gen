namespace RDRCPGen {
    partial class FormMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            lbOriginals = new ListBox();
            lbMods = new ListBox();
            lblLoadedFileText = new Label();
            lblLoadedFile = new Label();
            lblOriginalText = new Label();
            lblModifiedText = new Label();
            gbKWDs = new GroupBox();
            lblHeels = new Label();
            cbHeelsKiller = new CheckBox();
            cbHeelsHigh = new CheckBox();
            lblStockings = new Label();
            cbStockingsTagSheer = new CheckBox();
            cbStockingsTagShiny = new CheckBox();
            cbStockingsLong = new CheckBox();
            cbTopTagTight = new CheckBox();
            cbTopTagSheer = new CheckBox();
            cbTopTagTankTop = new CheckBox();
            lblTop = new Label();
            cbTopTagSideBoob = new CheckBox();
            cbTopTagHalter = new CheckBox();
            cbTopTagCropTop = new CheckBox();
            cbTopLowCutCleavage = new CheckBox();
            cbTopCleavage = new CheckBox();
            cbTopFull = new CheckBox();
            lblSkirt = new Label();
            cbSkirtTagTight = new CheckBox();
            cbSkirtTagSheer = new CheckBox();
            cbSkirtMicro = new CheckBox();
            cbSkirtMini = new CheckBox();
            cbSkirtShort = new CheckBox();
            cbSkirtLong = new CheckBox();
            lblPants = new Label();
            lblPanty = new Label();
            lblArmorBottom = new Label();
            lblBra = new Label();
            lblArmorTop = new Label();
            cbPantyTagSheer = new CheckBox();
            cbPantsTagTight = new CheckBox();
            cbPantsTagSheer = new CheckBox();
            cbPantsThongs = new CheckBox();
            cbPantsHotPants = new CheckBox();
            cbPantsShort = new CheckBox();
            cbPantsLong = new CheckBox();
            cbPantyGString = new CheckBox();
            cbPantyThong = new CheckBox();
            cbPantyNormal = new CheckBox();
            cbBraTagSheer = new CheckBox();
            cbBraMicro = new CheckBox();
            cbBraBikini = new CheckBox();
            cbBraNormal = new CheckBox();
            cbArmorBottomLewd = new CheckBox();
            cbArmorTopLewd = new CheckBox();
            cbArmorBottomButt = new CheckBox();
            cbArmorTopBreast = new CheckBox();
            cbArmorBottomFull = new CheckBox();
            cbArmorTopFull = new CheckBox();
            pbStatus = new PictureBox();
            btnClear = new Button();
            btnApply = new Button();
            btnWrite = new Button();
            lblWatermark = new Label();
            lblVer = new Label();
            btnLoad = new Button();
            lblSelectedItem = new Label();
            lblSelectedItemText = new Label();
            btnRemove = new Button();
            gbKWDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatus).BeginInit();
            SuspendLayout();
            // 
            // lbOriginals
            // 
            lbOriginals.FormattingEnabled = true;
            lbOriginals.ItemHeight = 15;
            lbOriginals.Location = new Point(12, 61);
            lbOriginals.Name = "lbOriginals";
            lbOriginals.Size = new Size(416, 304);
            lbOriginals.TabIndex = 0;
            lbOriginals.SelectedIndexChanged += lbOriginals_SelectedIndexChanged;
            // 
            // lbMods
            // 
            lbMods.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbMods.FormattingEnabled = true;
            lbMods.ItemHeight = 15;
            lbMods.Location = new Point(456, 61);
            lbMods.Name = "lbMods";
            lbMods.Size = new Size(416, 304);
            lbMods.TabIndex = 1;
            // 
            // lblLoadedFileText
            // 
            lblLoadedFileText.AutoSize = true;
            lblLoadedFileText.BackColor = Color.Transparent;
            lblLoadedFileText.Location = new Point(12, 9);
            lblLoadedFileText.Name = "lblLoadedFileText";
            lblLoadedFileText.Size = new Size(49, 15);
            lblLoadedFileText.TabIndex = 2;
            lblLoadedFileText.Text = "Loaded:";
            // 
            // lblLoadedFile
            // 
            lblLoadedFile.AutoSize = true;
            lblLoadedFile.BackColor = Color.Transparent;
            lblLoadedFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblLoadedFile.Location = new Point(67, 4);
            lblLoadedFile.Name = "lblLoadedFile";
            lblLoadedFile.Size = new Size(52, 21);
            lblLoadedFile.TabIndex = 3;
            lblLoadedFile.Text = "[null]";
            // 
            // lblOriginalText
            // 
            lblOriginalText.AutoSize = true;
            lblOriginalText.BackColor = Color.Transparent;
            lblOriginalText.Location = new Point(12, 43);
            lblOriginalText.Name = "lblOriginalText";
            lblOriginalText.Size = new Size(115, 15);
            lblOriginalText.TabIndex = 4;
            lblOriginalText.Text = "Items in loaded CSV:";
            // 
            // lblModifiedText
            // 
            lblModifiedText.AutoSize = true;
            lblModifiedText.BackColor = Color.Transparent;
            lblModifiedText.Location = new Point(456, 43);
            lblModifiedText.Name = "lblModifiedText";
            lblModifiedText.Size = new Size(51, 15);
            lblModifiedText.TabIndex = 5;
            lblModifiedText.Text = "To write:";
            // 
            // gbKWDs
            // 
            gbKWDs.Controls.Add(lblHeels);
            gbKWDs.Controls.Add(cbHeelsKiller);
            gbKWDs.Controls.Add(cbHeelsHigh);
            gbKWDs.Controls.Add(lblStockings);
            gbKWDs.Controls.Add(cbStockingsTagSheer);
            gbKWDs.Controls.Add(cbStockingsTagShiny);
            gbKWDs.Controls.Add(cbStockingsLong);
            gbKWDs.Controls.Add(cbTopTagTight);
            gbKWDs.Controls.Add(cbTopTagSheer);
            gbKWDs.Controls.Add(cbTopTagTankTop);
            gbKWDs.Controls.Add(lblTop);
            gbKWDs.Controls.Add(cbTopTagSideBoob);
            gbKWDs.Controls.Add(cbTopTagHalter);
            gbKWDs.Controls.Add(cbTopTagCropTop);
            gbKWDs.Controls.Add(cbTopLowCutCleavage);
            gbKWDs.Controls.Add(cbTopCleavage);
            gbKWDs.Controls.Add(cbTopFull);
            gbKWDs.Controls.Add(lblSkirt);
            gbKWDs.Controls.Add(cbSkirtTagTight);
            gbKWDs.Controls.Add(cbSkirtTagSheer);
            gbKWDs.Controls.Add(cbSkirtMicro);
            gbKWDs.Controls.Add(cbSkirtMini);
            gbKWDs.Controls.Add(cbSkirtShort);
            gbKWDs.Controls.Add(cbSkirtLong);
            gbKWDs.Controls.Add(lblPants);
            gbKWDs.Controls.Add(lblPanty);
            gbKWDs.Controls.Add(lblArmorBottom);
            gbKWDs.Controls.Add(lblBra);
            gbKWDs.Controls.Add(lblArmorTop);
            gbKWDs.Controls.Add(cbPantyTagSheer);
            gbKWDs.Controls.Add(cbPantsTagTight);
            gbKWDs.Controls.Add(cbPantsTagSheer);
            gbKWDs.Controls.Add(cbPantsThongs);
            gbKWDs.Controls.Add(cbPantsHotPants);
            gbKWDs.Controls.Add(cbPantsShort);
            gbKWDs.Controls.Add(cbPantsLong);
            gbKWDs.Controls.Add(cbPantyGString);
            gbKWDs.Controls.Add(cbPantyThong);
            gbKWDs.Controls.Add(cbPantyNormal);
            gbKWDs.Controls.Add(cbBraTagSheer);
            gbKWDs.Controls.Add(cbBraMicro);
            gbKWDs.Controls.Add(cbBraBikini);
            gbKWDs.Controls.Add(cbBraNormal);
            gbKWDs.Controls.Add(cbArmorBottomLewd);
            gbKWDs.Controls.Add(cbArmorTopLewd);
            gbKWDs.Controls.Add(cbArmorBottomButt);
            gbKWDs.Controls.Add(cbArmorTopBreast);
            gbKWDs.Controls.Add(cbArmorBottomFull);
            gbKWDs.Controls.Add(cbArmorTopFull);
            gbKWDs.Enabled = false;
            gbKWDs.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            gbKWDs.Location = new Point(12, 371);
            gbKWDs.Name = "gbKWDs";
            gbKWDs.Size = new Size(860, 227);
            gbKWDs.TabIndex = 10;
            gbKWDs.TabStop = false;
            // 
            // lblHeels
            // 
            lblHeels.AutoSize = true;
            lblHeels.BackColor = Color.Transparent;
            lblHeels.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblHeels.Location = new Point(91, 134);
            lblHeels.Name = "lblHeels";
            lblHeels.Size = new Size(41, 15);
            lblHeels.TabIndex = 47;
            lblHeels.Text = "Heels:";
            // 
            // cbHeelsKiller
            // 
            cbHeelsKiller.AutoSize = true;
            cbHeelsKiller.Location = new Point(91, 177);
            cbHeelsKiller.Name = "cbHeelsKiller";
            cbHeelsKiller.Size = new Size(81, 19);
            cbHeelsKiller.TabIndex = 46;
            cbHeelsKiller.Tag = "0026B5";
            cbHeelsKiller.Text = "KillerHeels";
            cbHeelsKiller.UseVisualStyleBackColor = true;
            // 
            // cbHeelsHigh
            // 
            cbHeelsHigh.AutoSize = true;
            cbHeelsHigh.Location = new Point(91, 152);
            cbHeelsHigh.Name = "cbHeelsHigh";
            cbHeelsHigh.Size = new Size(81, 19);
            cbHeelsHigh.TabIndex = 45;
            cbHeelsHigh.Tag = "0026B4";
            cbHeelsHigh.Text = "HighHeels";
            cbHeelsHigh.UseVisualStyleBackColor = true;
            // 
            // lblStockings
            // 
            lblStockings.AutoSize = true;
            lblStockings.BackColor = Color.Transparent;
            lblStockings.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblStockings.Location = new Point(6, 134);
            lblStockings.Name = "lblStockings";
            lblStockings.Size = new Size(64, 15);
            lblStockings.TabIndex = 44;
            lblStockings.Text = "Stockings:";
            // 
            // cbStockingsTagSheer
            // 
            cbStockingsTagSheer.AutoSize = true;
            cbStockingsTagSheer.Location = new Point(6, 202);
            cbStockingsTagSheer.Name = "cbStockingsTagSheer";
            cbStockingsTagSheer.Size = new Size(60, 19);
            cbStockingsTagSheer.TabIndex = 43;
            cbStockingsTagSheer.Tag = "0026B3";
            cbStockingsTagSheer.Text = "*Sheer";
            cbStockingsTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbStockingsTagShiny
            // 
            cbStockingsTagShiny.AutoSize = true;
            cbStockingsTagShiny.Location = new Point(6, 177);
            cbStockingsTagShiny.Name = "cbStockingsTagShiny";
            cbStockingsTagShiny.Size = new Size(60, 19);
            cbStockingsTagShiny.TabIndex = 42;
            cbStockingsTagShiny.Tag = "0026B2";
            cbStockingsTagShiny.Text = "*Shiny";
            cbStockingsTagShiny.UseVisualStyleBackColor = true;
            // 
            // cbStockingsLong
            // 
            cbStockingsLong.AutoSize = true;
            cbStockingsLong.Location = new Point(6, 152);
            cbStockingsLong.Name = "cbStockingsLong";
            cbStockingsLong.Size = new Size(52, 19);
            cbStockingsLong.TabIndex = 41;
            cbStockingsLong.Tag = "0026B1";
            cbStockingsLong.Text = "Long";
            cbStockingsLong.UseVisualStyleBackColor = true;
            // 
            // cbTopTagTight
            // 
            cbTopTagTight.AutoSize = true;
            cbTopTagTight.Location = new Point(693, 134);
            cbTopTagTight.Name = "cbTopTagTight";
            cbTopTagTight.Size = new Size(58, 19);
            cbTopTagTight.TabIndex = 40;
            cbTopTagTight.Tag = "000821";
            cbTopTagTight.Text = "*Tight";
            cbTopTagTight.UseVisualStyleBackColor = true;
            // 
            // cbTopTagSheer
            // 
            cbTopTagSheer.AutoSize = true;
            cbTopTagSheer.Location = new Point(778, 112);
            cbTopTagSheer.Name = "cbTopTagSheer";
            cbTopTagSheer.Size = new Size(60, 19);
            cbTopTagSheer.TabIndex = 39;
            cbTopTagSheer.Tag = "000822";
            cbTopTagSheer.Text = "*Sheer";
            cbTopTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbTopTagTankTop
            // 
            cbTopTagTankTop.AutoSize = true;
            cbTopTagTankTop.Location = new Point(778, 87);
            cbTopTagTankTop.Name = "cbTopTagTankTop";
            cbTopTagTankTop.Size = new Size(76, 19);
            cbTopTagTankTop.TabIndex = 38;
            cbTopTagTankTop.Tag = "00081E";
            cbTopTagTankTop.Text = "*TankTop";
            cbTopTagTankTop.UseVisualStyleBackColor = true;
            // 
            // lblTop
            // 
            lblTop.AutoSize = true;
            lblTop.BackColor = Color.Transparent;
            lblTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTop.Location = new Point(693, 19);
            lblTop.Name = "lblTop";
            lblTop.Size = new Size(30, 15);
            lblTop.TabIndex = 37;
            lblTop.Text = "Top:";
            // 
            // cbTopTagSideBoob
            // 
            cbTopTagSideBoob.AutoSize = true;
            cbTopTagSideBoob.Location = new Point(778, 62);
            cbTopTagSideBoob.Name = "cbTopTagSideBoob";
            cbTopTagSideBoob.Size = new Size(79, 19);
            cbTopTagSideBoob.TabIndex = 36;
            cbTopTagSideBoob.Tag = "000820";
            cbTopTagSideBoob.Text = "*SideBoob";
            cbTopTagSideBoob.UseVisualStyleBackColor = true;
            // 
            // cbTopTagHalter
            // 
            cbTopTagHalter.AutoSize = true;
            cbTopTagHalter.Location = new Point(778, 37);
            cbTopTagHalter.Name = "cbTopTagHalter";
            cbTopTagHalter.Size = new Size(64, 19);
            cbTopTagHalter.TabIndex = 35;
            cbTopTagHalter.Tag = "00081F";
            cbTopTagHalter.Text = "*Halter";
            cbTopTagHalter.UseVisualStyleBackColor = true;
            // 
            // cbTopTagCropTop
            // 
            cbTopTagCropTop.AutoSize = true;
            cbTopTagCropTop.Location = new Point(693, 112);
            cbTopTagCropTop.Name = "cbTopTagCropTop";
            cbTopTagCropTop.Size = new Size(75, 19);
            cbTopTagCropTop.TabIndex = 34;
            cbTopTagCropTop.Tag = "00081D";
            cbTopTagCropTop.Text = "*CropTop";
            cbTopTagCropTop.UseVisualStyleBackColor = true;
            // 
            // cbTopLowCutCleavage
            // 
            cbTopLowCutCleavage.AutoSize = true;
            cbTopLowCutCleavage.Location = new Point(693, 87);
            cbTopLowCutCleavage.Name = "cbTopLowCutCleavage";
            cbTopLowCutCleavage.Size = new Size(71, 19);
            cbTopLowCutCleavage.TabIndex = 33;
            cbTopLowCutCleavage.Tag = "00081C";
            cbTopLowCutCleavage.Text = "Low-Cut";
            cbTopLowCutCleavage.UseVisualStyleBackColor = true;
            // 
            // cbTopCleavage
            // 
            cbTopCleavage.AutoSize = true;
            cbTopCleavage.Location = new Point(693, 62);
            cbTopCleavage.Name = "cbTopCleavage";
            cbTopCleavage.Size = new Size(76, 19);
            cbTopCleavage.TabIndex = 32;
            cbTopCleavage.Tag = "00081B";
            cbTopCleavage.Text = "Cleavage";
            cbTopCleavage.UseVisualStyleBackColor = true;
            // 
            // cbTopFull
            // 
            cbTopFull.AutoSize = true;
            cbTopFull.Location = new Point(693, 37);
            cbTopFull.Name = "cbTopFull";
            cbTopFull.Size = new Size(45, 19);
            cbTopFull.TabIndex = 31;
            cbTopFull.Tag = "00081A";
            cbTopFull.Text = "Full";
            cbTopFull.UseVisualStyleBackColor = true;
            // 
            // lblSkirt
            // 
            lblSkirt.AutoSize = true;
            lblSkirt.BackColor = Color.Transparent;
            lblSkirt.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSkirt.Location = new Point(557, 19);
            lblSkirt.Name = "lblSkirt";
            lblSkirt.Size = new Size(37, 15);
            lblSkirt.TabIndex = 30;
            lblSkirt.Text = "Skirt:";
            // 
            // cbSkirtTagTight
            // 
            cbSkirtTagTight.AutoSize = true;
            cbSkirtTagTight.Location = new Point(616, 62);
            cbSkirtTagTight.Name = "cbSkirtTagTight";
            cbSkirtTagTight.Size = new Size(58, 19);
            cbSkirtTagTight.TabIndex = 29;
            cbSkirtTagTight.Tag = "000818";
            cbSkirtTagTight.Text = "*Tight";
            cbSkirtTagTight.UseVisualStyleBackColor = true;
            // 
            // cbSkirtTagSheer
            // 
            cbSkirtTagSheer.AutoSize = true;
            cbSkirtTagSheer.Location = new Point(616, 37);
            cbSkirtTagSheer.Name = "cbSkirtTagSheer";
            cbSkirtTagSheer.Size = new Size(60, 19);
            cbSkirtTagSheer.TabIndex = 28;
            cbSkirtTagSheer.Tag = "000819";
            cbSkirtTagSheer.Text = "*Sheer";
            cbSkirtTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbSkirtMicro
            // 
            cbSkirtMicro.AutoSize = true;
            cbSkirtMicro.Location = new Point(557, 112);
            cbSkirtMicro.Name = "cbSkirtMicro";
            cbSkirtMicro.Size = new Size(54, 19);
            cbSkirtMicro.TabIndex = 27;
            cbSkirtMicro.Tag = "000817";
            cbSkirtMicro.Text = "Micro";
            cbSkirtMicro.UseVisualStyleBackColor = true;
            // 
            // cbSkirtMini
            // 
            cbSkirtMini.AutoSize = true;
            cbSkirtMini.Location = new Point(557, 87);
            cbSkirtMini.Name = "cbSkirtMini";
            cbSkirtMini.Size = new Size(49, 19);
            cbSkirtMini.TabIndex = 26;
            cbSkirtMini.Tag = "000816";
            cbSkirtMini.Text = "Mini";
            cbSkirtMini.UseVisualStyleBackColor = true;
            // 
            // cbSkirtShort
            // 
            cbSkirtShort.AutoSize = true;
            cbSkirtShort.Location = new Point(557, 62);
            cbSkirtShort.Name = "cbSkirtShort";
            cbSkirtShort.Size = new Size(53, 19);
            cbSkirtShort.TabIndex = 25;
            cbSkirtShort.Tag = "000815";
            cbSkirtShort.Text = "Short";
            cbSkirtShort.UseVisualStyleBackColor = true;
            // 
            // cbSkirtLong
            // 
            cbSkirtLong.AutoSize = true;
            cbSkirtLong.Location = new Point(557, 37);
            cbSkirtLong.Name = "cbSkirtLong";
            cbSkirtLong.Size = new Size(52, 19);
            cbSkirtLong.TabIndex = 24;
            cbSkirtLong.Tag = "000814";
            cbSkirtLong.Text = "Long";
            cbSkirtLong.UseVisualStyleBackColor = true;
            // 
            // lblPants
            // 
            lblPants.AutoSize = true;
            lblPants.BackColor = Color.Transparent;
            lblPants.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPants.Location = new Point(399, 19);
            lblPants.Name = "lblPants";
            lblPants.Size = new Size(40, 15);
            lblPants.TabIndex = 23;
            lblPants.Text = "Pants:";
            // 
            // lblPanty
            // 
            lblPanty.AutoSize = true;
            lblPanty.BackColor = Color.Transparent;
            lblPanty.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblPanty.Location = new Point(288, 19);
            lblPanty.Name = "lblPanty";
            lblPanty.Size = new Size(41, 15);
            lblPanty.TabIndex = 22;
            lblPanty.Text = "Panty:";
            // 
            // lblArmorBottom
            // 
            lblArmorBottom.AutoSize = true;
            lblArmorBottom.BackColor = Color.Transparent;
            lblArmorBottom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblArmorBottom.Location = new Point(91, 19);
            lblArmorBottom.Name = "lblArmorBottom";
            lblArmorBottom.Size = new Size(92, 15);
            lblArmorBottom.TabIndex = 21;
            lblArmorBottom.Text = "Armor Bottom:";
            // 
            // lblBra
            // 
            lblBra.AutoSize = true;
            lblBra.BackColor = Color.Transparent;
            lblBra.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblBra.Location = new Point(194, 19);
            lblBra.Name = "lblBra";
            lblBra.Size = new Size(29, 15);
            lblBra.TabIndex = 20;
            lblBra.Text = "Bra:";
            // 
            // lblArmorTop
            // 
            lblArmorTop.AutoSize = true;
            lblArmorTop.BackColor = Color.Transparent;
            lblArmorTop.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblArmorTop.Location = new Point(6, 19);
            lblArmorTop.Name = "lblArmorTop";
            lblArmorTop.Size = new Size(69, 15);
            lblArmorTop.TabIndex = 11;
            lblArmorTop.Text = "Armor Top:";
            // 
            // cbPantyTagSheer
            // 
            cbPantyTagSheer.AutoSize = true;
            cbPantyTagSheer.Location = new Point(288, 112);
            cbPantyTagSheer.Name = "cbPantyTagSheer";
            cbPantyTagSheer.Size = new Size(60, 19);
            cbPantyTagSheer.TabIndex = 19;
            cbPantyTagSheer.Tag = "0026B0";
            cbPantyTagSheer.Text = "*Sheer";
            cbPantyTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbPantsTagTight
            // 
            cbPantsTagTight.AutoSize = true;
            cbPantsTagTight.Location = new Point(480, 62);
            cbPantsTagTight.Name = "cbPantsTagTight";
            cbPantsTagTight.Size = new Size(58, 19);
            cbPantsTagTight.TabIndex = 18;
            cbPantsTagTight.Tag = "000812";
            cbPantsTagTight.Text = "*Tight";
            cbPantsTagTight.UseVisualStyleBackColor = true;
            // 
            // cbPantsTagSheer
            // 
            cbPantsTagSheer.AutoSize = true;
            cbPantsTagSheer.Location = new Point(480, 37);
            cbPantsTagSheer.Name = "cbPantsTagSheer";
            cbPantsTagSheer.Size = new Size(60, 19);
            cbPantsTagSheer.TabIndex = 17;
            cbPantsTagSheer.Tag = "000813";
            cbPantsTagSheer.Text = "*Sheer";
            cbPantsTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbPantsThongs
            // 
            cbPantsThongs.AutoSize = true;
            cbPantsThongs.Location = new Point(399, 112);
            cbPantsThongs.Name = "cbPantsThongs";
            cbPantsThongs.Size = new Size(64, 19);
            cbPantsThongs.TabIndex = 16;
            cbPantsThongs.Tag = "000811";
            cbPantsThongs.Text = "Thongs";
            cbPantsThongs.UseVisualStyleBackColor = true;
            // 
            // cbPantsHotPants
            // 
            cbPantsHotPants.AutoSize = true;
            cbPantsHotPants.Location = new Point(399, 87);
            cbPantsHotPants.Name = "cbPantsHotPants";
            cbPantsHotPants.Size = new Size(75, 19);
            cbPantsHotPants.TabIndex = 15;
            cbPantsHotPants.Tag = "000810";
            cbPantsHotPants.Text = "HotPants";
            cbPantsHotPants.UseVisualStyleBackColor = true;
            // 
            // cbPantsShort
            // 
            cbPantsShort.AutoSize = true;
            cbPantsShort.Location = new Point(399, 62);
            cbPantsShort.Name = "cbPantsShort";
            cbPantsShort.Size = new Size(53, 19);
            cbPantsShort.TabIndex = 14;
            cbPantsShort.Tag = "00080F";
            cbPantsShort.Text = "Short";
            cbPantsShort.UseVisualStyleBackColor = true;
            // 
            // cbPantsLong
            // 
            cbPantsLong.AutoSize = true;
            cbPantsLong.Location = new Point(399, 37);
            cbPantsLong.Name = "cbPantsLong";
            cbPantsLong.Size = new Size(52, 19);
            cbPantsLong.TabIndex = 13;
            cbPantsLong.Tag = "00080E";
            cbPantsLong.Text = "Long";
            cbPantsLong.UseVisualStyleBackColor = true;
            // 
            // cbPantyGString
            // 
            cbPantyGString.AutoSize = true;
            cbPantyGString.Location = new Point(288, 87);
            cbPantyGString.Name = "cbPantyGString";
            cbPantyGString.Size = new Size(65, 19);
            cbPantyGString.TabIndex = 12;
            cbPantyGString.Tag = "00080A";
            cbPantyGString.Text = "GString";
            cbPantyGString.UseVisualStyleBackColor = true;
            // 
            // cbPantyThong
            // 
            cbPantyThong.AutoSize = true;
            cbPantyThong.Location = new Point(288, 62);
            cbPantyThong.Name = "cbPantyThong";
            cbPantyThong.Size = new Size(59, 19);
            cbPantyThong.TabIndex = 11;
            cbPantyThong.Tag = "000809";
            cbPantyThong.Text = "Thong";
            cbPantyThong.UseVisualStyleBackColor = true;
            // 
            // cbPantyNormal
            // 
            cbPantyNormal.AutoSize = true;
            cbPantyNormal.Location = new Point(288, 37);
            cbPantyNormal.Name = "cbPantyNormal";
            cbPantyNormal.Size = new Size(65, 19);
            cbPantyNormal.TabIndex = 10;
            cbPantyNormal.Tag = "000808";
            cbPantyNormal.Text = "Normal";
            cbPantyNormal.UseVisualStyleBackColor = true;
            // 
            // cbBraTagSheer
            // 
            cbBraTagSheer.AutoSize = true;
            cbBraTagSheer.Location = new Point(194, 112);
            cbBraTagSheer.Name = "cbBraTagSheer";
            cbBraTagSheer.Size = new Size(60, 19);
            cbBraTagSheer.TabIndex = 9;
            cbBraTagSheer.Tag = "0026AF";
            cbBraTagSheer.Text = "*Sheer";
            cbBraTagSheer.UseVisualStyleBackColor = true;
            // 
            // cbBraMicro
            // 
            cbBraMicro.AutoSize = true;
            cbBraMicro.Location = new Point(194, 87);
            cbBraMicro.Name = "cbBraMicro";
            cbBraMicro.Size = new Size(54, 19);
            cbBraMicro.TabIndex = 8;
            cbBraMicro.Tag = "00080D";
            cbBraMicro.Text = "Micro";
            cbBraMicro.UseVisualStyleBackColor = true;
            // 
            // cbBraBikini
            // 
            cbBraBikini.AutoSize = true;
            cbBraBikini.Location = new Point(194, 62);
            cbBraBikini.Name = "cbBraBikini";
            cbBraBikini.Size = new Size(55, 19);
            cbBraBikini.TabIndex = 7;
            cbBraBikini.Tag = "00080C";
            cbBraBikini.Text = "Bikini";
            cbBraBikini.UseVisualStyleBackColor = true;
            // 
            // cbBraNormal
            // 
            cbBraNormal.AutoSize = true;
            cbBraNormal.Location = new Point(194, 37);
            cbBraNormal.Name = "cbBraNormal";
            cbBraNormal.Size = new Size(65, 19);
            cbBraNormal.TabIndex = 6;
            cbBraNormal.Tag = "00080B";
            cbBraNormal.Text = "Normal";
            cbBraNormal.UseVisualStyleBackColor = true;
            // 
            // cbArmorBottomLewd
            // 
            cbArmorBottomLewd.AutoSize = true;
            cbArmorBottomLewd.Location = new Point(91, 87);
            cbArmorBottomLewd.Name = "cbArmorBottomLewd";
            cbArmorBottomLewd.Size = new Size(54, 19);
            cbArmorBottomLewd.TabIndex = 5;
            cbArmorBottomLewd.Tag = "000807";
            cbArmorBottomLewd.Text = "Lewd";
            cbArmorBottomLewd.UseVisualStyleBackColor = true;
            // 
            // cbArmorTopLewd
            // 
            cbArmorTopLewd.AutoSize = true;
            cbArmorTopLewd.Location = new Point(6, 87);
            cbArmorTopLewd.Name = "cbArmorTopLewd";
            cbArmorTopLewd.Size = new Size(54, 19);
            cbArmorTopLewd.TabIndex = 4;
            cbArmorTopLewd.Tag = "000804";
            cbArmorTopLewd.Text = "Lewd";
            cbArmorTopLewd.UseVisualStyleBackColor = true;
            // 
            // cbArmorBottomButt
            // 
            cbArmorBottomButt.AutoSize = true;
            cbArmorBottomButt.Location = new Point(91, 62);
            cbArmorBottomButt.Name = "cbArmorBottomButt";
            cbArmorBottomButt.Size = new Size(48, 19);
            cbArmorBottomButt.TabIndex = 3;
            cbArmorBottomButt.Tag = "000806";
            cbArmorBottomButt.Text = "Butt";
            cbArmorBottomButt.UseVisualStyleBackColor = true;
            // 
            // cbArmorTopBreast
            // 
            cbArmorTopBreast.AutoSize = true;
            cbArmorTopBreast.Location = new Point(6, 62);
            cbArmorTopBreast.Name = "cbArmorTopBreast";
            cbArmorTopBreast.Size = new Size(59, 19);
            cbArmorTopBreast.TabIndex = 2;
            cbArmorTopBreast.Tag = "000803";
            cbArmorTopBreast.Text = "Breast";
            cbArmorTopBreast.UseVisualStyleBackColor = true;
            // 
            // cbArmorBottomFull
            // 
            cbArmorBottomFull.AutoSize = true;
            cbArmorBottomFull.Location = new Point(91, 37);
            cbArmorBottomFull.Name = "cbArmorBottomFull";
            cbArmorBottomFull.Size = new Size(45, 19);
            cbArmorBottomFull.TabIndex = 1;
            cbArmorBottomFull.Tag = "000805";
            cbArmorBottomFull.Text = "Full";
            cbArmorBottomFull.UseVisualStyleBackColor = true;
            // 
            // cbArmorTopFull
            // 
            cbArmorTopFull.AutoSize = true;
            cbArmorTopFull.Location = new Point(6, 37);
            cbArmorTopFull.Name = "cbArmorTopFull";
            cbArmorTopFull.Size = new Size(45, 19);
            cbArmorTopFull.TabIndex = 0;
            cbArmorTopFull.Tag = "000802";
            cbArmorTopFull.Text = "Full";
            cbArmorTopFull.UseVisualStyleBackColor = true;
            // 
            // pbStatus
            // 
            pbStatus.BackColor = Color.Transparent;
            pbStatus.BackgroundImageLayout = ImageLayout.Stretch;
            pbStatus.Location = new Point(834, 604);
            pbStatus.Name = "pbStatus";
            pbStatus.Size = new Size(38, 37);
            pbStatus.TabIndex = 50;
            pbStatus.TabStop = false;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(770, 642);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(58, 25);
            btnClear.TabIndex = 49;
            btnClear.Text = "Clear all";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnApply
            // 
            btnApply.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnApply.Location = new Point(705, 604);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(123, 37);
            btnApply.TabIndex = 48;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnWrite.Location = new Point(738, 26);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(134, 29);
            btnWrite.TabIndex = 11;
            btnWrite.Text = "Write Out";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // lblWatermark
            // 
            lblWatermark.AutoSize = true;
            lblWatermark.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblWatermark.Location = new Point(377, 642);
            lblWatermark.Name = "lblWatermark";
            lblWatermark.Size = new Size(135, 21);
            lblWatermark.TabIndex = 12;
            lblWatermark.Text = "By: Rubber Duck";
            // 
            // lblVer
            // 
            lblVer.AutoSize = true;
            lblVer.BackColor = Color.Transparent;
            lblVer.Location = new Point(12, 652);
            lblVer.Name = "lblVer";
            lblVer.Size = new Size(128, 15);
            lblVer.TabIndex = 13;
            lblVer.Text = "v0.7.1 - Beta (07/04/23)";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(598, 26);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(134, 29);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load CSV...";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // lblSelectedItem
            // 
            lblSelectedItem.AutoSize = true;
            lblSelectedItem.BackColor = Color.Transparent;
            lblSelectedItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSelectedItem.Location = new Point(103, 604);
            lblSelectedItem.Name = "lblSelectedItem";
            lblSelectedItem.Size = new Size(61, 21);
            lblSelectedItem.TabIndex = 51;
            lblSelectedItem.Text = "[none]";
            // 
            // lblSelectedItemText
            // 
            lblSelectedItemText.AutoSize = true;
            lblSelectedItemText.BackColor = Color.Transparent;
            lblSelectedItemText.Location = new Point(12, 601);
            lblSelectedItemText.Name = "lblSelectedItemText";
            lblSelectedItemText.Size = new Size(90, 15);
            lblSelectedItemText.TabIndex = 51;
            lblSelectedItemText.Text = "Selected object:";
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemove.Location = new Point(705, 642);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(58, 25);
            btnRemove.TabIndex = 52;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 676);
            Controls.Add(btnRemove);
            Controls.Add(lblSelectedItem);
            Controls.Add(lblSelectedItemText);
            Controls.Add(pbStatus);
            Controls.Add(btnLoad);
            Controls.Add(btnClear);
            Controls.Add(lblVer);
            Controls.Add(btnApply);
            Controls.Add(lblWatermark);
            Controls.Add(btnWrite);
            Controls.Add(gbKWDs);
            Controls.Add(lblModifiedText);
            Controls.Add(lblOriginalText);
            Controls.Add(lblLoadedFile);
            Controls.Add(lblLoadedFileText);
            Controls.Add(lbMods);
            Controls.Add(lbOriginals);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rubber Duck's SAKR / RCP Gen v0.7.1";
            gbKWDs.ResumeLayout(false);
            gbKWDs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbStatus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbOriginals;
        private ListBox lbMods;
        private Label lblLoadedFileText;
        private Label lblLoadedFile;
        private Label lblOriginalText;
        private Label lblModifiedText;
        private GroupBox gbKWDs;
        private CheckBox cbBraTagSheer;
        private CheckBox cbBraMicro;
        private CheckBox cbBraBikini;
        private CheckBox cbBraNormal;
        private CheckBox cbArmorBottomLewd;
        private CheckBox cbArmorTopLewd;
        private CheckBox cbArmorBottomButt;
        private CheckBox cbArmorTopBreast;
        private CheckBox cbArmorBottomFull;
        private CheckBox cbArmorTopFull;
        private Label lblArmorTop;
        private CheckBox cbPantyTagSheer;
        private CheckBox cbPantsTagTight;
        private CheckBox cbPantsTagSheer;
        private CheckBox cbPantsThongs;
        private CheckBox cbPantsHotPants;
        private CheckBox cbPantsShort;
        private CheckBox cbPantsLong;
        private CheckBox cbPantyGString;
        private CheckBox cbPantyThong;
        private CheckBox cbPantyNormal;
        private Label lblBra;
        private Label lblArmorBottom;
        private Label lblPanty;
        private Label lblPants;
        private Label lblHeels;
        private CheckBox cbHeelsKiller;
        private CheckBox cbHeelsHigh;
        private Label lblStockings;
        private CheckBox cbStockingsTagSheer;
        private CheckBox cbStockingsTagShiny;
        private CheckBox cbStockingsLong;
        private CheckBox cbTopTagTight;
        private CheckBox cbTopTagSheer;
        private CheckBox cbTopTagTankTop;
        private Label lblTop;
        private CheckBox cbTopTagSideBoob;
        private CheckBox cbTopTagHalter;
        private CheckBox cbTopTagCropTop;
        private CheckBox cbTopLowCutCleavage;
        private CheckBox cbTopCleavage;
        private CheckBox cbTopFull;
        private Label lblSkirt;
        private CheckBox cbSkirtTagTight;
        private CheckBox cbSkirtTagSheer;
        private CheckBox cbSkirtMicro;
        private CheckBox cbSkirtMini;
        private CheckBox cbSkirtShort;
        private CheckBox cbSkirtLong;
        private PictureBox pbStatus;
        private Button btnClear;
        private Button btnApply;
        private Button btnWrite;
        private Label lblWatermark;
        private Label lblVer;
        private Button btnLoad;
        private Label lblSelectedItem;
        private Label lblSelectedItemText;
        private Button btnRemove;
    }
}