using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IT151BattingAverages
{
    public partial class Form1 : Form
    {

        ArrayList moAtBats = new ArrayList();
        ArrayList moBaseHits = new ArrayList();
        Int32 miGameCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddValues()
        {
            Int32 iAtBats = 0;
            Int32 iBaseHits = 0;

            if (txtAtBats.Text != String.Empty)
            {
                iAtBats = Convert.ToInt32(txtAtBats.Text);
            }

            if (txtBaseHits.Text != String.Empty)
            {
                iBaseHits = Convert.ToInt32(txtBaseHits.Text);
            }

            moAtBats.Add(iAtBats);
            moBaseHits.Add(iBaseHits);

            UpdateGameCount();
            txtAtBats.Clear();
            txtBaseHits.Clear();
            txtAtBats.Focus();
        }

        private void CalculateAverages()
        {
            //Declare and initialize global variables
            Int32 iAtBatTotal = 0;
            Int32 iBaseHitsTotal = 0;
            Int32 iAtBat = 0;
            Int32 iBaseHit = 0;
            Double dBattingAverage = 0.0;

            //Traverse the AtBats ArrayList, summing the totals
            for (Int32 i = 0; i < moAtBats.Count; i++)
            {
                iAtBat = (Int32)moAtBats[i];
                iAtBatTotal += iAtBat;
            }

            //Traverse the BaseHits ArrayList, summing the total
            for (Int32 i = 0; i < moBaseHits.Count; i++)
            {
                iBaseHit = (Int32)moBaseHits[i];
                iBaseHitsTotal += iBaseHit;
            }

            //Divide total BaseHits by total AtBats
            dBattingAverage = (Double)iBaseHitsTotal / (Double)iAtBatTotal;

            //Display the total for the user
            tslStatus.Text = "The average is " 
                + Math.Round(dBattingAverage, 3).ToString()
                + "in " + moAtBats.Count + " games.";
        }

        private void UpdateGameCount()
        {
            miGameCount++;
            lblGameInfo.Text = "Game #" + miGameCount.ToString() + ":";
            Application.DoEvents();
        }

        private void btnAddStats_Click(object sender, EventArgs e)
        {
            AddValues();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalculateAverages();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGameCount();
        }
    }
}
