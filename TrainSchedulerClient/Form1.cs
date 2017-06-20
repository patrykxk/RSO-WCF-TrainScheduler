using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
using WcfServiceLibrary1;

namespace TrainSchedulerClient
{
    public partial class Form1 : Form
    {
        private ScheduleService proxy = new ScheduleService();
        public Form1()
        {
            InitializeComponent();
            proxy.GetData();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            directTextArea.Text = "";
            indirectTextArea.Text = "";
            string startingCity = startCityTextBox.Text;
            string endCity = endCityTextBox.Text;
            Boolean isAnyEmptyField = false;
            if (startingCity == "") {
                ShowMessageBox("Enter starting city!", "Empty field");
                isAnyEmptyField = true;
            }
            if (endCity == "")
            {
                ShowMessageBox("Enter end city!", "Empty field");
                isAnyEmptyField = true;
            }
            if (!isAnyEmptyField)
            {
                DateTime from = fromDatePicker.Value + fromTimePicker.Value.TimeOfDay;
                DateTime to = toDatePicker.Value + toTimePicker.Value.TimeOfDay;
                //List<List<string>> list = new List<List<string>>();
                try
                {
                    var list = proxy.GetTrainsFromTo(startingCity, endCity, from, to);
                    ShowTrainsInTextsAreas(list);
                }
                catch (FaultException ex)
                {
                    ShowMessageBox(ex.Message, "City not found");
                }
            }
        }

        private void ShowTrainsInTextsAreas(List<List<string>> list)
        {
            var directTrains = list[0];
            var indirectTrains = list[1];
            if (directTrains.Count != 0)
            {
                foreach (var train in directTrains)
                {
                    directTextArea.Text += train;
                    directTextArea.Text += System.Environment.NewLine;
                }
            }
            else
            {
                directTextArea.Text = "Trains not found";
            }
            if (indirectTrains.Count != 0)
            {
                foreach (var train in indirectTrains)
                {
                    indirectTextArea.Text += train;
                    indirectTextArea.Text += System.Environment.NewLine;
                }
            }
            else
            {
                indirectTextArea.Text = @"Trains not found";
            }
        }


        private DialogResult ShowMessageBox(string message, string caption)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            return MessageBox.Show(message, caption, buttons);
        }
    }
}
