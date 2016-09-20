using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HumpDay {
    public partial class Form1 : Form {
        private billSplitter currentBill = new billSplitter();

        public Form1() {
            InitializeComponent();
            MoesPanel.Visible = false;
            ResultPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        /*************************** MAIN PANEL ******************************/
        //Moe's CheckBox
        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            //when checked, uncheck everything else
            if (checkBox1.Checked) {
                checkBox2.Checked = checkBox3.Checked = checkBox4.Checked = checkBox5.Checked = false;
            }
        }

        //Chinese CheckBox
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {
            //when checked, uncheck everything else
            if (checkBox2.Checked) {
                checkBox1.Checked = checkBox3.Checked =
                    checkBox4.Checked = checkBox5.Checked = false;
            }
        }

        //Pizza CheckBox
        private void checkBox3_CheckedChanged(object sender, EventArgs e) {
            //when checked, uncheck everything else
            if (checkBox3.Checked) {
                checkBox1.Checked = checkBox2.Checked =
                    checkBox4.Checked = checkBox5.Checked = false;
            }
        }

        //Chicken & Rib Crib CheckBox
        private void checkBox4_CheckedChanged(object sender, EventArgs e) {
            //when checked, uncheck everything else
            if (checkBox4.Checked) {
                checkBox1.Checked = checkBox2.Checked =
                    checkBox3.Checked = checkBox5.Checked = false;
            }
        }

        //Other CheckBox
        private void checkBox5_CheckedChanged(object sender, EventArgs e) {
            //when checked, uncheck everything else
            if (checkBox5.Checked) {
                checkBox1.Checked = checkBox2.Checked =
                    checkBox3.Checked = checkBox4.Checked = false;
            }
        }

        //Next button
        private void button1_Click(object sender, EventArgs e) {
            double fee = 0;

            ResultPanel.Visible = false;

            if (checkBox1.Checked) {
                MoesPanel.Visible = true;
                this.MoesTitle.Location = new System.Drawing.Point(230, 10);
                MoesTitle.Text = "MOE'S";
                fee = 3.0;
            }
            else if (checkBox2.Checked) {
                MoesPanel.Visible = true;
                this.MoesTitle.Location = new System.Drawing.Point(210, 10);
                MoesTitle.Text = "CHINESE";
                fee = 3.0;
            }
            else if (checkBox3.Checked) {
                MoesPanel.Visible = true;
                this.MoesTitle.Location = new System.Drawing.Point(200, 10);
                MoesTitle.Text = "SONNY && TONY'S";
                fee = 2.5;
            }
            else if (checkBox4.Checked) {
                MoesPanel.Visible = true;
                this.MoesTitle.Location = new System.Drawing.Point(190, 10);
                MoesTitle.Text = "CHICKEN && RIB CRIB";
                fee = 2.0;
            }
            else if (checkBox5.Checked) {
                MoesPanel.Visible = true;
                MoesTitle.Text = " ";
            }
            else {
                showError("Check a box!");
                return;
            }

            tipBox.Text = "20";
            delBox.Text = Convert.ToString(fee);

            //Always empty the boxes when clicking next
            Name1.Clear();  price1.Clear();
            Name2.Clear();  price2.Clear();
            Name3.Clear();  price3.Clear();
            Name4.Clear();  price4.Clear();
            Name5.Clear();  price5.Clear();
            Name6.Clear();  price6.Clear();
            Name7.Clear();  price7.Clear();
            Name8.Clear();  price8.Clear();
            Name9.Clear();  price9.Clear();
            Name10.Clear(); price10.Clear();
        }
        /**********************************************************************/



        /*************************** MOE'S PANEL ******************************/
        private void moesPrevious_Click(object sender, EventArgs e) {
            MoesPanel.Visible = false;
            ResultPanel.Visible = false;
        }

        //CALCULATE Button
        private void moesNext_Click(object sender, EventArgs e) {
            //first clear the billSplitter since user cn go back
            currentBill.clear();
            
            double tip = Convert.ToDouble(tipBox.Text);
            double fee, temp;

            fee = Convert.ToDouble(delBox.Text);
            tipBox.Text = Convert.ToString(tip);

            List<string> names = new List<string>();
            List<double> prices = new List<double>();

            if (!string.IsNullOrWhiteSpace(this.Name1.Text)) {
                if (!parseIt(price1.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name1.Text);
                prices.Add(Convert.ToDouble(price1.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name2.Text)) {
                if (!parseIt(price2.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name2.Text);
                prices.Add(Convert.ToDouble(price2.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name3.Text)) {
                if (!parseIt(price3.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name3.Text);
                prices.Add(Convert.ToDouble(price3.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name4.Text)) {
                if (!parseIt(price4.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name4.Text);
                prices.Add(Convert.ToDouble(price4.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name5.Text)) {
                if (!parseIt(price5.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name5.Text);
                prices.Add(Convert.ToDouble(price5.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name6.Text)) {
                if (!parseIt(price6.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name6.Text);
                prices.Add(Convert.ToDouble(price6.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name7.Text)) {
                if (!parseIt(price7.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name7.Text);
                prices.Add(Convert.ToDouble(price7.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name8.Text)) {
                if (!parseIt(price8.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name8.Text);
                prices.Add(Convert.ToDouble(price8.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name9.Text)) {
                if (!parseIt(price9.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name9.Text);
                prices.Add(Convert.ToDouble(price9.Text));
            }

            if (!string.IsNullOrWhiteSpace(this.Name10.Text)) {
                if (!parseIt(price10.Text)) {
                    showError("Wrong data!");
                    return;
                }
                names.Add(Name10.Text);
                prices.Add(Convert.ToDouble(price10.Text));                
            }

            currentBill.setValues(tip, fee);
            currentBill.addBuyers(names, prices);

            if (currentBill.empty()) {
                showError("No data entered!");
                return;
            }
            
            ResultPanel.Visible = true;

            //Print the results to the panel
            printResults.Text = "";
            printResults.Text = "Subtotal: $" + currentBill.getSubTotal();
            printResults.Text += "\nTax: $" + currentBill.getTax();
            printResults.Text += "\nTip: $" + currentBill.getTip();
            printResults.Text += "\nTotal: $" + currentBill.getTotal()
                + "\n\n" + "Total per person:\n";

            currentBill.getFinalIndPrices(prices);

            for (int i = 0; i < names.Count; i++) {
                printResults.Text += names[i] + ": $" + prices[i] + "\n";
            }
        }
        /**********************************************************************/



        /*************************** RESULT PANEL *****************************/

        private void previousResultsPan_Click(object sender, EventArgs e) {
            ResultPanel.Visible = false;
            MoesPanel.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e) {
            DialogResult exitConfirm = MessageBox.Show("Exit program?", "Exiting Program",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (exitConfirm == DialogResult.Yes) {
                this.Close();
            }
        } 
        /**********************************************************************/


        /********** PARSER ********/
        private bool parseIt(string box) {
            double temp = 0;
            if (!double.TryParse(box, out temp)) { return false; }
            return true;
        }
        /******************/

        /********** PARSER ********/
        private void showError(string message) {
            MessageBox.Show(message, "Error!",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /******************/
    }



    class billSplitter {
        private double tipPer;
        private double delFee;
        private List<string> namesList = new List<string>();
        private List<double> priceList = new List<double>();

        ~billSplitter() {
            this.namesList.Clear();
            this.priceList.Clear();
        }

        public bool empty() {
            if (namesList.Count == 0) { return true; }
            return false;     
        }

        public void clear() {
            this.namesList.Clear();
            this.priceList.Clear();
        }

        public void setValues(double tipping, double fee) {
            tipPer = tipping;
            delFee = fee;
        }

        public void addBuyers(List<string> name, List<double> price) {
            this.namesList = name;
            this.priceList = price;
        }

        public double getSubTotal() {
            double sub = 0;
            for (int i = 0; i < priceList.Count; i++) {
                sub += priceList[i];
            }
            return sub;
        }

        public double getTax() {
            return getSubTotal() * 0.07;
        }

        public double getTip() {
            return getSubTotal() * (tipPer / 100.0);
        }

        public double getTotal() {
            return getSubTotal() + getTax() + getTip() + delFee;
        }

        public void getFinalIndPrices(List<double> price) {
            for (int i = 0; i < price.Count; i++) {
                price[i] = price[i] * (1 + (tipPer / 100.0) + 0.07) + (delFee / price.Count);
            }
        }
    }
}