using AirlinesClient.FlightService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlinesClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var client = new FlightService.FlightServiceClient();
            client.Open();
            var f = client.GetAllFlights()[0];
            client.Close();
        }
        Flight[] flights = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new FlightService.FlightServiceClient();
            ListView.Items.Clear();
            flights = client.GetAllFlights();
            foreach (var item in flights)
            {

                var itemList = new ListViewItem(new string[] { item.ToCity, item.FromCity, item.Cost.ToString(), item.Date.ToString() });
                itemList.Tag = item;
                ListView.Items.Add(itemList);
            }
        }
        private Flight selectedItem = null;
        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ListView.SelectedItems.Count > 0)
                {
                    selectedItem = (Flight)ListView.SelectedItems[0].Tag;
                    buyTicket.Visible = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        User user = null;
        private void login_Click(object sender, EventArgs e)
        {
            var client = new FlightService.FlightServiceClient();
            client.Open();
            user = client.Login("Test1");
            client.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ListView.Items.Clear();
            var filterFlights = flights.Where(f => f.ToCity.Contains(searchText.Text));
            foreach (var item in filterFlights)
            {
                var itemList = new ListViewItem(new string[] { item.ToCity, item.FromCity, item.Cost.ToString(), item.Date.ToString() });
                itemList.Tag = item;
                ListView.Items.Add(itemList);
            }
        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            if (selectedItem != null && buyTicket.Visible == true)
            {
                // zrobic kupno
            }
        }

        private void checkReserv_Click(object sender, EventArgs e)
        {
            var client = new ReservationService.ReservationServiceClient();
            client.Open();
            var reserv = client.CheckReservation(Guid.Parse(reservNumber.Text), "Test1");
            MessageBox.Show($"Znaleziono rezerwacje o id: {reserv.Number}, Na lot do: {reserv.Flight.ToCity}, Typ rezerwacji: {reserv.ReservationType.ToString()}");
            client.Close();
        }
    }
}
