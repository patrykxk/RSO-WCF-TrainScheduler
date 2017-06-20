using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Windows.Forms;
using WcfServiceLibrary1;

namespace TrainSchedulerClient
{
    public partial class Form1 : Form
    {
        private ScheduleService proxy;
        public Form1()
        {
            try
            {
                proxy = new ScheduleService();
            }
            catch (CommunicationException)
            {
                ShowMessageBox("No connection to service", "Connection error");
            }

            InitializeComponent();
            try
            {
                proxy.GetData();
            }catch (EndpointNotFoundException)
            {
                ShowMessageBox("Connection to service lost", "Connection error");
            }
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
                
                try
                {
                    var list = proxy.GetTrainsFromTo(startingCity, endCity, from, to);
                    ShowTrainsInTextsAreas(list);
                }
                catch (FaultException ex)
                {
                    ShowMessageBox(ex.Message, "City not found");
                }
                catch (EndpointNotFoundException)
                {
                    ShowMessageBox("Connection to service lost", "Connection error");
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
