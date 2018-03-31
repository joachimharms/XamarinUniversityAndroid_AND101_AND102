using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace E002_TipCalculator
{
    [Activity(Label = "E002_TipCalculator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private Button buttonCalculate;
        private EditText editTextBill;
        private TextView textViewTip;
        private TextView textViewTotal;
        private TextView textViewTipValue;
        private TextView textViewTotalValue;

        // lieber lokale Variablen verwenden.
        //private double bill;
        //private double tip;
        //private double total;
        //private double tipRate = 0.15;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            buttonCalculate = FindViewById<Button>(Resource.Id.button_calculate);
            editTextBill = FindViewById<EditText>(Resource.Id.edit_input_bill);
            textViewTip = FindViewById<TextView>(Resource.Id.text_tip);
            textViewTotal = FindViewById<TextView>(Resource.Id.text_total);
            textViewTipValue = FindViewById<TextView>(Resource.Id.text_tip_value);
            textViewTotalValue = FindViewById<TextView>(Resource.Id.text_total_value);

            buttonCalculate.Click += OnCalculateClick;


        }

        private void OnCalculateClick(object sender, EventArgs e)
        {
            string text = editTextBill.Text;
            var bill = double.Parse(text);

            // Verwende nun offizielle Lösung:
            //bill = Convert.ToDouble(editTextBill.Text);
            //textViewTipValue.Text = CalculateTip(this.bill).ToString();
            //textViewTotalValue.Text = CalculateTotal(this.bill, this.tip).ToString();

            var tip = bill * 0.15;
            var total = bill + tip;

            textViewTipValue.Text = tip.ToString();
            textViewTotalValue.Text = total.ToString();
        }

        //double CalculateTotal(double bill, double tip)
        //{
        //    return bill + tip;
        //}

        //double CalculateTip(double bill)
        //{
        //    this.tip = bill * this.tipRate;
        //    return this.tip;
        //}

    }
}

