namespace ITEC140_WageCalculator
{
    public partial class frmPayCalculator : Form
    {
        double MinWage; //Mininmum wage is set when a radio is checked
        double RegularPay; //All other variables are set when calculated
        double IncomeTax;
        double OvertimePay;
        double YearlyPay;
        double YearlyTax;
        double YearlyPayAfterTax;
        
        //Each tax function only calculates up to an income of the 3rd combined marginal tax bracket
        double AlbertaTax()
        {
            if(YearlyPay > 0 || YearlyPay <= 50197)
            {
                return 1.25;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 100392)
            {
                return 1.305;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 134238)
            {
                return 1.36;
            }
            else if (YearlyPay > 134238 || YearlyPay <= 155625)
            {
                return 1.38;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 161086)
            {
                return 1.4138;
            }
            else if (YearlyPay > 161086 || YearlyPay <= 214781)
            {
                return 1.4238;
            }
            else if (YearlyPay > 214781 || YearlyPay <= 221708)
            {
                return 1.4338;
            }
            else if (YearlyPay > 221708 || YearlyPay <= 322171)
            {
                return 1.47;
            }
            else 
            {
                return 1.48;
            }
        }

        double BCTax()
        {
            if (YearlyPay > 0 || YearlyPay <= 43070)
            {
                return 1.2006;
            }
            else if (YearlyPay > 43070 || YearlyPay <= 50197)
            {
                return 1.227;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 86141)
            {
                return 1.282;
            }
            else if (YearlyPay > 86141 || YearlyPay <= 98901)
            {
                return 1.31;
            }
            else if (YearlyPay > 98901 || YearlyPay <= 100392)
            {
                return 1.3279;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 120094)
            {
                return 1.3829;
            }
            else if (YearlyPay > 120094 || YearlyPay <= 155625)
            {
                return 1.4070;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 162832)
            {
                return 1.4408;
            }
            else if (YearlyPay > 162832 || YearlyPay <= 221708)
            {
                return 1.4618;
            }
            else if (YearlyPay > 221708 || YearlyPay <= 227091)
            {
                return 1.498;
            }
            else 
            {
                return 1.535;
            }
        }
        double ManitobaTax()
        {
            if (YearlyPay > 0 || YearlyPay <= 34431)
            {
                return 1.258;
            }
            else if (YearlyPay > 34431 || YearlyPay <= 50197)
            {
                return 1.2775;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 74416)
            {
                return 1.3325;
            }
            else if (YearlyPay > 74416 || YearlyPay <= 100392)
            {
                return 1.379;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 155625)
            {
                return 1.434;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 221708)
            {
                return 1.4678;
            }
            else
            {
                return 1.504;
            }
        }
            double NewBrunswickTax()
        {
            if (YearlyPay > 0 || YearlyPay <= 44887)
            {
                return 1.244;
            }
            else if (YearlyPay > 44887 || YearlyPay <= 50197)
            {
                return 1.2982;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 89775)
            {
                return 1.3532;
            }
            else if (YearlyPay > 89775 || YearlyPay <= 100392)
            {
                return 1.3702;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 145955)
            {
                return 1.4252;
            }
            else if (YearlyPay > 145955 || YearlyPay <= 155625)
            {
                return 1.4384;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 166280)
            {
                return 1.4722;
            }
            else if (YearlyPay > 166280 || YearlyPay <= 221708)
            {
                return 1.4968;
            }
            else
            {
                return 1.533;
            }
        }
        double NewfoundlandAndLabradorTax()
        {
            if (YearlyPay <= 39147)
            {
                return 1.237;
            }
            else if (YearlyPay > 39147 || YearlyPay <= 50197)
            {
                return 1.295;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 78294)
            {
                return 1.35;
            }
            else if (YearlyPay > 78294 || YearlyPay <= 100392)
            {
                return 1.363;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 139780)
            {
                return 1.418;
            }
            else if (YearlyPay > 139780 || YearlyPay <= 155625)
            {
                return 1.438;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 195693)
            {
                return 1.4718;
            }
            else if (YearlyPay > 195693 || YearlyPay <= 221708)
            {
                return 1.4918;
            }
            else if (YearlyPay > 221708 || YearlyPay <= 250000)
            {
                return 1.528;
            }
            else if (YearlyPay > 250000 || YearlyPay <= 500000)
            {
                return 1.538;
            }
            else if (YearlyPay > 500000 || YearlyPay <= 1000000)
            {
                return 1.543;
            }
            else
            {
                return 1.548;
            }
        }
        double NorthwestTerritoriesTax()
        {
            if (YearlyPay <= 45462)
            {
                return 1.209;
            }
            else if (YearlyPay > 45462 || YearlyPay <= 50197)
            {
                return 1.236;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 90927)
            {
                return 1.291;
            }
            else if (YearlyPay > 90927 || YearlyPay <= 100392)
            {
                return 1.327;
            }
            else if (YearlyPay > 100392 || YearlyPay <= 147826)
            {
                return 1.382;
            }
            else if (YearlyPay > 147826 || YearlyPay <= 155625)
            {
                return 1.4005;
            }
            else if (YearlyPay > 155625 || YearlyPay <= 221708)
            {
                return 1.4343;
            }
            else
            {
                return 1.4705;
            }
        }
            double NovaScotiaTax()
        {
            if (YearlyPay <= 25000)
            {
                return 1.2379;
            }
            else if (YearlyPay > 25000 || YearlyPay <= 29590)
            {
                return 1.2432;
            }
            else
            {
                return 1.3048;
            }
        }
        double NunavutTax()
        {
            if (YearlyPay <= 47862)
            {
                return 1.19;
            }
            else if (YearlyPay > 47862 || YearlyPay <= 50197)
            {
                return 1.22;
            }
            else
            {
                return 1.275;
            }
        }
        double OntarioTax()
        {
            if (YearlyPay <= 46226)
            {
                return 1.2005;
            }
            else if (YearlyPay > 46226 || YearlyPay <= 50197)
            {
                return 1.2415;
            }
            else
            {
                return 1.2965;
            }
        }
        double PrinceEdwardIslandTax()
        {
            if (YearlyPay <= 31984)
            {
                return 1.248;
            }
            else if (YearlyPay > 31984 || YearlyPay <= 50197)
            {
                return 1.288;
            }
            else
            {
                return 1.343;
            }
        }

        double QuebecTax()
        {
            if (YearlyPay <= 46295)
            {
                return 1.2753;
            }
            else if (YearlyPay > 46295 || YearlyPay <= 50197)
            {
                return 1.3253;
            }
            else
            {
                return 1.3712;
            }
        }
        double SaskatchewanTax()
        {
            if (YearlyPay <= 46773)
            {
                return 1.255;
            }
            else if (YearlyPay > 46773 || YearlyPay <= 50197)
            {
                return 1.275;
            }
            else
            {
                return 1.33;
            }
        }
        double YukonTax()
        {
            if (YearlyPay <= 50197)
            {
                return 1.214;
            }
            else if (YearlyPay > 50197 || YearlyPay <= 100392)
            {
                return 1.295;
            }
            else
            {
                return 1.369;
            }
        }


        public frmPayCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioAlberta_CheckedChanged(object sender, EventArgs e)
        {   
            MinWage = 15.00;                                                                                            //Minimum wage for the selected province
            txtWage.Text = MinWage.ToString("n");                                                                       //Sets default minimum wage value to MinWage.Text
            txtOvertimeWage.Text = (MinWage*2).ToString("n");                                                           //Sets default overtime wage to MinWage * 2
            lblComment.Text = "The Provincial minimum wage in Alberta is " + MinWage.ToString("C") + " per hour.";      //Sets the panel output to two string + MinWage
            
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);                             //Entered Wage multiplied by hours entered.
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);               //Entered Overtime Wage multiplied by Overtime hours entered.
            YearlyPay = (RegularPay + OvertimePay) * 52;                                                                //Calculates yearly pay by multiplying regular pay and overtime pay after adding them together.
            IncomeTax = AlbertaTax();                                                                                   //Calculates the income tax in the province of alberta
        }

        private void radioBritishColumbia_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 15.65;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in British Columbia is " + MinWage.ToString("C") + " per hour.";

            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);                             
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);               
            YearlyPay = (RegularPay + OvertimePay) * 52;                                                                
            IncomeTax = BCTax();
        }

        private void radioManitoba_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 11.95;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Manitoba is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = ManitobaTax();
        }

        private void radioNewBrunswick_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 12.75;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in New Brunswick is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = NewBrunswickTax();
        }

        private void radioNewfoundlandAndLabrador_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 13.20;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Newfoundland and Labrador is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = NewfoundlandAndLabradorTax();
        }

        private void radioNorthwestTerritories_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 15.20;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Northwest Territories is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = NorthwestTerritoriesTax();
        }

        private void radioNovaScotia_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 13.35;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Nova Scotia is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = NovaScotiaTax();
        }

        private void radioNunavut_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 16;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Nunavut is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = NunavutTax();
        }

        private void radioOntario_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 15;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Ontario is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = OntarioTax();
        }

        private void radioPrinceEdwardIsland_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 13.70;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Prince Edward Island is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = PrinceEdwardIslandTax();
        }

        private void radioQuebec_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 14.25;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Quebec is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = QuebecTax();
        }

        private void radioSaskatchewan_CheckedChanged(object sender, EventArgs e)
        {
            MinWage = 11.81;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Saskatchewan is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = SaskatchewanTax();
        }

        private void radioYukon_CheckedChanged(object sender, EventArgs e)
        {                      
            MinWage = 15.70;
            txtWage.Text = MinWage.ToString("n");
            txtOvertimeWage.Text = (MinWage * 2).ToString("n");
            lblComment.Text = "The Provincial minimum wage in Yukon is " + MinWage.ToString("C") + " per hour.";
            RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);
            OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);
            YearlyPay = (RegularPay + OvertimePay) * 52;
            IncomeTax = YukonTax();
        }

        private void txtOvertimeWage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculateWeeklyPay_Click(object sender, EventArgs e)
        {
            try
            {
                RegularPay = Double.Parse(txtWage.Text) * Double.Parse(txtRegWeeklyHours.Text);                         //Entered Wage multiplied by hours entered.
                OvertimePay = Double.Parse(txtOvertimeWage.Text) * Double.Parse(txtOvertimeWeeklyHours.Text);           //Entered Overtime Wage multiplied by Overtime hours entered.
                YearlyPay = (RegularPay + OvertimePay) * 52;                                                            //Calculates yearly pay by multiplying regular pay and overtime pay after adding them together.
                YearlyTax = (IncomeTax * YearlyPay) - YearlyPay;                                                        //Calculates your tax beased on yearly pay.
                YearlyPayAfterTax = (YearlyPay - YearlyTax);                                                            //Calculates Yearly Pay after tax is deducted.

                lblRegularPay.Text = RegularPay.ToString("C");                                                          //Converts regular pay calculation a string formatted to currency.
                lblOvertimePay.Text = OvertimePay.ToString("C");                                                        //Converts overtime calculation a string formatted to currency.
                lblYearlyPay.Text = YearlyPay.ToString("C");                                                            //Calculates yearly earnings based off of the pay earned this week.

                lblRegularHours.Text = txtWage.Text;                                                                    //Sets label hours to text box entered hours.
                lblOvertimeHours.Text = txtOvertimeWeeklyHours.Text;                                                    //Sets label Overtime hours to entered overtime hours.
                
                
                lblRegularHours.Text = txtRegWeeklyHours.Text;                                                          //Sets the regular hours label to entered weekly hours.
                lblTotalPay.Text = (RegularPay + OvertimePay).ToString("C");                                            //Adds Overtime pay calculation and regular pay calculation together and formats to a currency output.
                lblYearlyTax.Text = YearlyTax.ToString("C");                                                            //Converts yearly tax to a string
                lblYearlyPayAfterTax.Text = YearlyPayAfterTax.ToString("C");


                lblRegularHours.Visible = true;                                                                         //Makes all invisible labels visible when the calculation button is pressed
                lblOvertimePay.Visible = true;
                lblOvertimeHours.Visible = true;
                lblRegularHours.Visible = true;
                lblRegularPay.Visible = true;
                lblTotalPay.Visible = true;
                lblYearlyPay.Visible = true;
                lblYearlyTax.Visible = true;
                lblYearlyPayAfterTax.Visible = true;
            }
            catch
            {
                MessageBox.Show("Please check your inputs, all inputs must be a number.");  //Incase of an exception
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}