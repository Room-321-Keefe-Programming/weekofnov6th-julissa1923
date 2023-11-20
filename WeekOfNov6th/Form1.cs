using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeekOfNov6th
{
    public partial class Form1 : Form
    {
        double exchangeRateYen = 150;
        double exchangeRateEuro = 0.93;
        double exchangeRateRupee = 83;
        double exchangeRatePeso = 18;
        double exchangeRatePound = 0.81;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTemp_Click(object sender, EventArgs e)
        {
            if (rdoTempConverter1.Checked)
            {
                double celsius = double.Parse(txtInput1.Text);
                double fahrenheit = (celsius * 9 / 5) + 32;
                rtbOutput.Text = fahrenheit.ToString() + "°F";
            }
            else if (rdoTempConverter2.Checked)
            {
                double fahrenheit = double.Parse(txtInput1.Text);
                double celsius = (fahrenheit - 32) * 5 / 9;
                rtbOutput.Text = celsius.ToString() + "°C";
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            double amount = double.Parse(txtInput1.Text);
            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollars-Yen")
            {
                double yen = amount * exchangeRateYen;
                rtbOutput.Text = yen.ToString() + " yen";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Yen-Dollars")
            {
                double dollars = amount / exchangeRateYen;
                rtbOutput.Text = dollars.ToString() + " dollars";
            }

            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollars-Euros")
            {
                double euro = amount * exchangeRateEuro;
                rtbOutput.Text = euro.ToString() + " Euros";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Euros-Dollars")
            {
                double dollars = amount / exchangeRateEuro;
                rtbOutput.Text = dollars.ToString() + " dollars";
            }

            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollars-Rupees")
            {
                double rupee = amount * exchangeRateRupee;
                rtbOutput.Text = rupee.ToString() + " Rupees";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Rupees-Dollars")
            {
                double dollars = amount / exchangeRateRupee;
                rtbOutput.Text = dollars.ToString() + " dollars";
            }

            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollars-Pesos")
            {
                double peso = amount * exchangeRatePeso;
                rtbOutput.Text = peso.ToString() + " peso";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Pesos-Dollars")
            {
                double dollars = amount / exchangeRatePeso;
                rtbOutput.Text = dollars.ToString() + " dollars";
            }

            if (cmbMoneyConverter.SelectedItem.ToString() == "Dollars-Pounds")
            {
                double pound = amount * exchangeRatePound;
                rtbOutput.Text = pound.ToString() + " pound";
            }
            else if (cmbMoneyConverter.SelectedItem.ToString() == "Pounds-Dollars")
            {
                double dollars = amount / exchangeRatePound;
                rtbOutput.Text = dollars.ToString() + " dollars";
            }


        }

        private void btnDistance_1_Click(object sender, EventArgs e)
        {
            if (chkMileToKilo.Checked)
            {
                double miles = double.Parse(txtInput1.Text);
                double kilometers = miles * 1.609344;
                rtbOutput.Text = kilometers.ToString();
                rtbOutput.Text += "km \r\n(kilometers)";
            }
            else if (chkKiloToMiles.Checked)
            {
                double kilometers = double.Parse(txtInput2.Text);
                double miles = kilometers / 1.609344;
                rtbOutput.Text = miles.ToString();
                rtbOutput.Text += "m \r\n(miles)";
            }
            else if (chkMeterToInch.Checked)
            {
                double meters = double.Parse(txtInput1.Text);
                double inches = meters * 39.3700787;
                rtbOutput.Text = inches.ToString();
                rtbOutput.Text += "in \r\n(inches)";
            }
            else if (chkInchToMeter.Checked)
            {
                double inches = double.Parse(txtInput2.Text);
                double meters = inches / 39.3700787;
                rtbOutput.Text = meters.ToString();
                rtbOutput.Text += "m \r\n(meters)";
            }
        }

        private void btn_file_Click(object sender, EventArgs e)
        {
            string FilePath = "C:\\Users\\Julissa\\web\\test.txt"; 
            string FileConetents = File.ReadAllText(FilePath) ;
            rtbOutput = FileContents; 
            
            
        }
    }
}
