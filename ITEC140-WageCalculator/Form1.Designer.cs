namespace ITEC140_WageCalculator
{
    partial class frmPayCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpProvince = new System.Windows.Forms.GroupBox();
            this.radioOntario = new System.Windows.Forms.RadioButton();
            this.radioAlberta = new System.Windows.Forms.RadioButton();
            this.radioPrinceEdwardIsland = new System.Windows.Forms.RadioButton();
            this.radioNunavut = new System.Windows.Forms.RadioButton();
            this.radioBritishColumbia = new System.Windows.Forms.RadioButton();
            this.radioQuebec = new System.Windows.Forms.RadioButton();
            this.radioNovaScotia = new System.Windows.Forms.RadioButton();
            this.radioYukon = new System.Windows.Forms.RadioButton();
            this.radioManitoba = new System.Windows.Forms.RadioButton();
            this.radioNorthwestTerritories = new System.Windows.Forms.RadioButton();
            this.radioNewBrunswick = new System.Windows.Forms.RadioButton();
            this.radioSaskatchewan = new System.Windows.Forms.RadioButton();
            this.radioNewfoundlandAndLabrador = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblRegWeeklyHours = new System.Windows.Forms.Label();
            this.txtRegWeeklyHours = new System.Windows.Forms.TextBox();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.lblRegWage = new System.Windows.Forms.Label();
            this.txtOvertimeWage = new System.Windows.Forms.TextBox();
            this.lblOvertimeWage = new System.Windows.Forms.Label();
            this.txtOvertimeWeeklyHours = new System.Windows.Forms.TextBox();
            this.lblOvertimeWeeklyHours = new System.Windows.Forms.Label();
            this.btnCalculateWeeklyPay = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblRegularHours = new System.Windows.Forms.Label();
            this.lblOvertimeHours = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblOvertimePay = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblRegularPay = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTotalPay = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lblYearlyPay = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lblYearlyTax = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblYearlyPayAfterTax = new System.Windows.Forms.Label();
            this.grpProvince.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProvince
            // 
            this.grpProvince.Controls.Add(this.radioOntario);
            this.grpProvince.Controls.Add(this.radioAlberta);
            this.grpProvince.Controls.Add(this.radioPrinceEdwardIsland);
            this.grpProvince.Controls.Add(this.radioNunavut);
            this.grpProvince.Controls.Add(this.radioBritishColumbia);
            this.grpProvince.Controls.Add(this.radioQuebec);
            this.grpProvince.Controls.Add(this.radioNovaScotia);
            this.grpProvince.Controls.Add(this.radioYukon);
            this.grpProvince.Controls.Add(this.radioManitoba);
            this.grpProvince.Controls.Add(this.radioNorthwestTerritories);
            this.grpProvince.Controls.Add(this.radioNewBrunswick);
            this.grpProvince.Controls.Add(this.radioSaskatchewan);
            this.grpProvince.Controls.Add(this.radioNewfoundlandAndLabrador);
            this.grpProvince.Location = new System.Drawing.Point(12, 12);
            this.grpProvince.Name = "grpProvince";
            this.grpProvince.Size = new System.Drawing.Size(188, 350);
            this.grpProvince.TabIndex = 0;
            this.grpProvince.TabStop = false;
            this.grpProvince.Text = "Province";
            // 
            // radioOntario
            // 
            this.radioOntario.AutoSize = true;
            this.radioOntario.Location = new System.Drawing.Point(6, 222);
            this.radioOntario.Name = "radioOntario";
            this.radioOntario.Size = new System.Drawing.Size(65, 19);
            this.radioOntario.TabIndex = 9;
            this.radioOntario.TabStop = true;
            this.radioOntario.Text = "Ontario";
            this.radioOntario.UseVisualStyleBackColor = true;
            this.radioOntario.CheckedChanged += new System.EventHandler(this.radioOntario_CheckedChanged);
            // 
            // radioAlberta
            // 
            this.radioAlberta.AutoSize = true;
            this.radioAlberta.Location = new System.Drawing.Point(6, 22);
            this.radioAlberta.Name = "radioAlberta";
            this.radioAlberta.Size = new System.Drawing.Size(63, 19);
            this.radioAlberta.TabIndex = 1;
            this.radioAlberta.TabStop = true;
            this.radioAlberta.Text = "Alberta";
            this.radioAlberta.UseVisualStyleBackColor = true;
            this.radioAlberta.CheckedChanged += new System.EventHandler(this.radioAlberta_CheckedChanged);
            // 
            // radioPrinceEdwardIsland
            // 
            this.radioPrinceEdwardIsland.AutoSize = true;
            this.radioPrinceEdwardIsland.Location = new System.Drawing.Point(6, 247);
            this.radioPrinceEdwardIsland.Name = "radioPrinceEdwardIsland";
            this.radioPrinceEdwardIsland.Size = new System.Drawing.Size(134, 19);
            this.radioPrinceEdwardIsland.TabIndex = 10;
            this.radioPrinceEdwardIsland.TabStop = true;
            this.radioPrinceEdwardIsland.Text = "Prince Edward Island";
            this.radioPrinceEdwardIsland.UseVisualStyleBackColor = true;
            this.radioPrinceEdwardIsland.CheckedChanged += new System.EventHandler(this.radioPrinceEdwardIsland_CheckedChanged);
            // 
            // radioNunavut
            // 
            this.radioNunavut.AutoSize = true;
            this.radioNunavut.Location = new System.Drawing.Point(6, 197);
            this.radioNunavut.Name = "radioNunavut";
            this.radioNunavut.Size = new System.Drawing.Size(71, 19);
            this.radioNunavut.TabIndex = 8;
            this.radioNunavut.TabStop = true;
            this.radioNunavut.Text = "Nunavut";
            this.radioNunavut.UseVisualStyleBackColor = true;
            this.radioNunavut.CheckedChanged += new System.EventHandler(this.radioNunavut_CheckedChanged);
            // 
            // radioBritishColumbia
            // 
            this.radioBritishColumbia.AutoSize = true;
            this.radioBritishColumbia.Location = new System.Drawing.Point(6, 47);
            this.radioBritishColumbia.Name = "radioBritishColumbia";
            this.radioBritishColumbia.Size = new System.Drawing.Size(113, 19);
            this.radioBritishColumbia.TabIndex = 2;
            this.radioBritishColumbia.TabStop = true;
            this.radioBritishColumbia.Text = "British Columbia";
            this.radioBritishColumbia.UseVisualStyleBackColor = true;
            this.radioBritishColumbia.CheckedChanged += new System.EventHandler(this.radioBritishColumbia_CheckedChanged);
            // 
            // radioQuebec
            // 
            this.radioQuebec.AutoSize = true;
            this.radioQuebec.Location = new System.Drawing.Point(6, 272);
            this.radioQuebec.Name = "radioQuebec";
            this.radioQuebec.Size = new System.Drawing.Size(66, 19);
            this.radioQuebec.TabIndex = 11;
            this.radioQuebec.TabStop = true;
            this.radioQuebec.Text = "Quebec";
            this.radioQuebec.UseVisualStyleBackColor = true;
            this.radioQuebec.CheckedChanged += new System.EventHandler(this.radioQuebec_CheckedChanged);
            // 
            // radioNovaScotia
            // 
            this.radioNovaScotia.AutoSize = true;
            this.radioNovaScotia.Location = new System.Drawing.Point(6, 172);
            this.radioNovaScotia.Name = "radioNovaScotia";
            this.radioNovaScotia.Size = new System.Drawing.Size(88, 19);
            this.radioNovaScotia.TabIndex = 7;
            this.radioNovaScotia.TabStop = true;
            this.radioNovaScotia.Text = "Nova Scotia";
            this.radioNovaScotia.UseVisualStyleBackColor = true;
            this.radioNovaScotia.CheckedChanged += new System.EventHandler(this.radioNovaScotia_CheckedChanged);
            // 
            // radioYukon
            // 
            this.radioYukon.AutoSize = true;
            this.radioYukon.Location = new System.Drawing.Point(6, 322);
            this.radioYukon.Name = "radioYukon";
            this.radioYukon.Size = new System.Drawing.Size(59, 19);
            this.radioYukon.TabIndex = 13;
            this.radioYukon.TabStop = true;
            this.radioYukon.Text = "Yukon";
            this.radioYukon.UseVisualStyleBackColor = true;
            this.radioYukon.CheckedChanged += new System.EventHandler(this.radioYukon_CheckedChanged);
            // 
            // radioManitoba
            // 
            this.radioManitoba.AutoSize = true;
            this.radioManitoba.Location = new System.Drawing.Point(6, 72);
            this.radioManitoba.Name = "radioManitoba";
            this.radioManitoba.Size = new System.Drawing.Size(76, 19);
            this.radioManitoba.TabIndex = 3;
            this.radioManitoba.TabStop = true;
            this.radioManitoba.Text = "Manitoba";
            this.radioManitoba.UseVisualStyleBackColor = true;
            this.radioManitoba.CheckedChanged += new System.EventHandler(this.radioManitoba_CheckedChanged);
            // 
            // radioNorthwestTerritories
            // 
            this.radioNorthwestTerritories.AutoSize = true;
            this.radioNorthwestTerritories.Location = new System.Drawing.Point(6, 147);
            this.radioNorthwestTerritories.Name = "radioNorthwestTerritories";
            this.radioNorthwestTerritories.Size = new System.Drawing.Size(134, 19);
            this.radioNorthwestTerritories.TabIndex = 6;
            this.radioNorthwestTerritories.TabStop = true;
            this.radioNorthwestTerritories.Text = "Northwest Territories";
            this.radioNorthwestTerritories.UseVisualStyleBackColor = true;
            this.radioNorthwestTerritories.CheckedChanged += new System.EventHandler(this.radioNorthwestTerritories_CheckedChanged);
            // 
            // radioNewBrunswick
            // 
            this.radioNewBrunswick.AutoSize = true;
            this.radioNewBrunswick.Location = new System.Drawing.Point(6, 97);
            this.radioNewBrunswick.Name = "radioNewBrunswick";
            this.radioNewBrunswick.Size = new System.Drawing.Size(106, 19);
            this.radioNewBrunswick.TabIndex = 4;
            this.radioNewBrunswick.TabStop = true;
            this.radioNewBrunswick.Text = "New Brunswick";
            this.radioNewBrunswick.UseVisualStyleBackColor = true;
            this.radioNewBrunswick.CheckedChanged += new System.EventHandler(this.radioNewBrunswick_CheckedChanged);
            // 
            // radioSaskatchewan
            // 
            this.radioSaskatchewan.AutoSize = true;
            this.radioSaskatchewan.Location = new System.Drawing.Point(6, 297);
            this.radioSaskatchewan.Name = "radioSaskatchewan";
            this.radioSaskatchewan.Size = new System.Drawing.Size(99, 19);
            this.radioSaskatchewan.TabIndex = 12;
            this.radioSaskatchewan.TabStop = true;
            this.radioSaskatchewan.Text = "Saskatchewan";
            this.radioSaskatchewan.UseVisualStyleBackColor = true;
            this.radioSaskatchewan.CheckedChanged += new System.EventHandler(this.radioSaskatchewan_CheckedChanged);
            // 
            // radioNewfoundlandAndLabrador
            // 
            this.radioNewfoundlandAndLabrador.AutoSize = true;
            this.radioNewfoundlandAndLabrador.Location = new System.Drawing.Point(6, 122);
            this.radioNewfoundlandAndLabrador.Name = "radioNewfoundlandAndLabrador";
            this.radioNewfoundlandAndLabrador.Size = new System.Drawing.Size(177, 19);
            this.radioNewfoundlandAndLabrador.TabIndex = 5;
            this.radioNewfoundlandAndLabrador.TabStop = true;
            this.radioNewfoundlandAndLabrador.Text = "Newfoundland and Labrador";
            this.radioNewfoundlandAndLabrador.UseVisualStyleBackColor = true;
            this.radioNewfoundlandAndLabrador.CheckedChanged += new System.EventHandler(this.radioNewfoundlandAndLabrador_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblComment);
            this.panel1.Location = new System.Drawing.Point(12, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 123);
            this.panel1.TabIndex = 1;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComment.Location = new System.Drawing.Point(6, 9);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(71, 30);
            this.lblComment.TabIndex = 0;
            this.lblComment.Text = "label1";
            this.lblComment.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRegWeeklyHours
            // 
            this.lblRegWeeklyHours.AutoSize = true;
            this.lblRegWeeklyHours.Location = new System.Drawing.Point(229, 36);
            this.lblRegWeeklyHours.Name = "lblRegWeeklyHours";
            this.lblRegWeeklyHours.Size = new System.Drawing.Size(122, 15);
            this.lblRegWeeklyHours.TabIndex = 2;
            this.lblRegWeeklyHours.Text = "Regular weekly hours:";
            // 
            // txtRegWeeklyHours
            // 
            this.txtRegWeeklyHours.Location = new System.Drawing.Point(374, 33);
            this.txtRegWeeklyHours.Name = "txtRegWeeklyHours";
            this.txtRegWeeklyHours.Size = new System.Drawing.Size(146, 23);
            this.txtRegWeeklyHours.TabIndex = 6;
            this.txtRegWeeklyHours.Text = "40";
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(374, 62);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(146, 23);
            this.txtWage.TabIndex = 8;
            // 
            // lblRegWage
            // 
            this.lblRegWage.AutoSize = true;
            this.lblRegWage.Location = new System.Drawing.Point(229, 65);
            this.lblRegWage.Name = "lblRegWage";
            this.lblRegWage.Size = new System.Drawing.Size(129, 15);
            this.lblRegWage.TabIndex = 7;
            this.lblRegWage.Text = "Regular wage per hour:";
            // 
            // txtOvertimeWage
            // 
            this.txtOvertimeWage.Location = new System.Drawing.Point(374, 120);
            this.txtOvertimeWage.Name = "txtOvertimeWage";
            this.txtOvertimeWage.Size = new System.Drawing.Size(146, 23);
            this.txtOvertimeWage.TabIndex = 12;
            this.txtOvertimeWage.TextChanged += new System.EventHandler(this.txtOvertimeWage_TextChanged);
            // 
            // lblOvertimeWage
            // 
            this.lblOvertimeWage.AutoSize = true;
            this.lblOvertimeWage.Location = new System.Drawing.Point(229, 123);
            this.lblOvertimeWage.Name = "lblOvertimeWage";
            this.lblOvertimeWage.Size = new System.Drawing.Size(138, 15);
            this.lblOvertimeWage.TabIndex = 11;
            this.lblOvertimeWage.Text = "Overtime wage per hour:";
            // 
            // txtOvertimeWeeklyHours
            // 
            this.txtOvertimeWeeklyHours.Location = new System.Drawing.Point(374, 91);
            this.txtOvertimeWeeklyHours.Name = "txtOvertimeWeeklyHours";
            this.txtOvertimeWeeklyHours.Size = new System.Drawing.Size(146, 23);
            this.txtOvertimeWeeklyHours.TabIndex = 10;
            this.txtOvertimeWeeklyHours.Text = "0";
            // 
            // lblOvertimeWeeklyHours
            // 
            this.lblOvertimeWeeklyHours.AutoSize = true;
            this.lblOvertimeWeeklyHours.Location = new System.Drawing.Point(229, 94);
            this.lblOvertimeWeeklyHours.Name = "lblOvertimeWeeklyHours";
            this.lblOvertimeWeeklyHours.Size = new System.Drawing.Size(131, 15);
            this.lblOvertimeWeeklyHours.TabIndex = 9;
            this.lblOvertimeWeeklyHours.Text = "Overtime weekly hours:";
            // 
            // btnCalculateWeeklyPay
            // 
            this.btnCalculateWeeklyPay.Location = new System.Drawing.Point(374, 149);
            this.btnCalculateWeeklyPay.Name = "btnCalculateWeeklyPay";
            this.btnCalculateWeeklyPay.Size = new System.Drawing.Size(146, 23);
            this.btnCalculateWeeklyPay.TabIndex = 13;
            this.btnCalculateWeeklyPay.Text = "&Calculate Weekly Pay";
            this.btnCalculateWeeklyPay.UseVisualStyleBackColor = true;
            this.btnCalculateWeeklyPay.Click += new System.EventHandler(this.btnCalculateWeeklyPay_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(374, 188);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 15);
            this.lbl1.TabIndex = 14;
            this.lbl1.Text = "Regular Hours:";
            // 
            // lblRegularHours
            // 
            this.lblRegularHours.AutoSize = true;
            this.lblRegularHours.Location = new System.Drawing.Point(483, 188);
            this.lblRegularHours.Name = "lblRegularHours";
            this.lblRegularHours.Size = new System.Drawing.Size(13, 15);
            this.lblRegularHours.TabIndex = 15;
            this.lblRegularHours.Text = "0";
            this.lblRegularHours.Visible = false;
            // 
            // lblOvertimeHours
            // 
            this.lblOvertimeHours.AutoSize = true;
            this.lblOvertimeHours.Location = new System.Drawing.Point(483, 213);
            this.lblOvertimeHours.Name = "lblOvertimeHours";
            this.lblOvertimeHours.Size = new System.Drawing.Size(13, 15);
            this.lblOvertimeHours.TabIndex = 17;
            this.lblOvertimeHours.Text = "0";
            this.lblOvertimeHours.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(374, 213);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(94, 15);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "Overtime Hours:";
            // 
            // lblOvertimePay
            // 
            this.lblOvertimePay.AutoSize = true;
            this.lblOvertimePay.Location = new System.Drawing.Point(483, 263);
            this.lblOvertimePay.Name = "lblOvertimePay";
            this.lblOvertimePay.Size = new System.Drawing.Size(13, 15);
            this.lblOvertimePay.TabIndex = 21;
            this.lblOvertimePay.Text = "0";
            this.lblOvertimePay.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(374, 263);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(81, 15);
            this.lbl4.TabIndex = 20;
            this.lbl4.Text = "Overtime Pay:";
            // 
            // lblRegularPay
            // 
            this.lblRegularPay.AutoSize = true;
            this.lblRegularPay.Location = new System.Drawing.Point(483, 238);
            this.lblRegularPay.Name = "lblRegularPay";
            this.lblRegularPay.Size = new System.Drawing.Size(13, 15);
            this.lblRegularPay.TabIndex = 19;
            this.lblRegularPay.Text = "0";
            this.lblRegularPay.Visible = false;
            this.lblRegularPay.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(374, 238);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(72, 15);
            this.lbl3.TabIndex = 18;
            this.lbl3.Text = "Regular Pay:";
            // 
            // lblTotalPay
            // 
            this.lblTotalPay.AutoSize = true;
            this.lblTotalPay.Location = new System.Drawing.Point(483, 288);
            this.lblTotalPay.Name = "lblTotalPay";
            this.lblTotalPay.Size = new System.Drawing.Size(13, 15);
            this.lblTotalPay.TabIndex = 23;
            this.lblTotalPay.Text = "0";
            this.lblTotalPay.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(374, 288);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(57, 15);
            this.lbl5.TabIndex = 22;
            this.lbl5.Text = "Total Pay:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(374, 313);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(63, 15);
            this.lbl6.TabIndex = 24;
            this.lbl6.Text = "Yearly Pay:";
            this.lbl6.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblYearlyPay
            // 
            this.lblYearlyPay.AutoSize = true;
            this.lblYearlyPay.Location = new System.Drawing.Point(483, 313);
            this.lblYearlyPay.Name = "lblYearlyPay";
            this.lblYearlyPay.Size = new System.Drawing.Size(13, 15);
            this.lblYearlyPay.TabIndex = 25;
            this.lblYearlyPay.Text = "0";
            this.lblYearlyPay.Visible = false;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(374, 336);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(61, 15);
            this.lbl7.TabIndex = 26;
            this.lbl7.Text = "Yearly Tax:";
            // 
            // lblYearlyTax
            // 
            this.lblYearlyTax.AutoSize = true;
            this.lblYearlyTax.Location = new System.Drawing.Point(483, 336);
            this.lblYearlyTax.Name = "lblYearlyTax";
            this.lblYearlyTax.Size = new System.Drawing.Size(13, 15);
            this.lblYearlyTax.TabIndex = 27;
            this.lblYearlyTax.Text = "0";
            this.lblYearlyTax.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(607, 336);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Yearly Pay After Tax:";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblYearlyPayAfterTax
            // 
            this.lblYearlyPayAfterTax.AutoSize = true;
            this.lblYearlyPayAfterTax.Location = new System.Drawing.Point(725, 336);
            this.lblYearlyPayAfterTax.Name = "lblYearlyPayAfterTax";
            this.lblYearlyPayAfterTax.Size = new System.Drawing.Size(13, 15);
            this.lblYearlyPayAfterTax.TabIndex = 29;
            this.lblYearlyPayAfterTax.Text = "0";
            this.lblYearlyPayAfterTax.Visible = false;
            // 
            // frmPayCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 518);
            this.Controls.Add(this.lblYearlyPayAfterTax);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblYearlyTax);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.lblYearlyPay);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lblTotalPay);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lblOvertimePay);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblRegularPay);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblOvertimeHours);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblRegularHours);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnCalculateWeeklyPay);
            this.Controls.Add(this.txtOvertimeWage);
            this.Controls.Add(this.lblOvertimeWage);
            this.Controls.Add(this.txtOvertimeWeeklyHours);
            this.Controls.Add(this.lblOvertimeWeeklyHours);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.lblRegWage);
            this.Controls.Add(this.txtRegWeeklyHours);
            this.Controls.Add(this.lblRegWeeklyHours);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpProvince);
            this.Name = "frmPayCalculator";
            this.Text = "Pay Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpProvince.ResumeLayout(false);
            this.grpProvince.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grpProvince;
        private RadioButton radioOntario;
        private RadioButton radioAlberta;
        private RadioButton radioPrinceEdwardIsland;
        private RadioButton radioNunavut;
        private RadioButton radioBritishColumbia;
        private RadioButton radioQuebec;
        private RadioButton radioNovaScotia;
        private RadioButton radioYukon;
        private RadioButton radioManitoba;
        private RadioButton radioNorthwestTerritories;
        private RadioButton radioNewBrunswick;
        private RadioButton radioSaskatchewan;
        private RadioButton radioNewfoundlandAndLabrador;
        private Panel panel1;
        private Label lblRegWeeklyHours;
        private TextBox txtRegWeeklyHours;
        private TextBox txtWage;
        private Label lblRegWage;
        private TextBox txtOvertimeWage;
        private Label lblOvertimeWage;
        private TextBox txtOvertimeWeeklyHours;
        private Label lblOvertimeWeeklyHours;
        private Button btnCalculateWeeklyPay;
        private Label lbl1;
        private Label lblRegularHours;
        private Label lblOvertimeHours;
        private Label lbl2;
        private Label lblOvertimePay;
        private Label lbl4;
        private Label lblRegularPay;
        private Label lbl3;
        private Label lblTotalPay;
        private Label lbl5;
        private Label lblComment;
        private Label lbl6;
        private Label lblYearlyPay;
        private Label lbl7;
        private Label lblYearlyTax;
        private Label label1;
        private Label lblYearlyPayAfterTax;
    }
}