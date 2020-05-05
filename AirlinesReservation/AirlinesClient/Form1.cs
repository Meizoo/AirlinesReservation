using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

using AirlinesClient.FlightService;
using AirlinesReservation.Services;

namespace AirlinesClient
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new FlightServiceClient();

            client.Open();

            var f = client.GetAllFlights()[0];
            if (Debugger.IsAttached)
            {
                Debug.WriteLine(f);
                Debugger.Break();
            }

            client.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new FlightServiceClient();
            this.ListView.Items.Clear();
            this.flights = client.GetAllFlights();
            this.ListView.Items.AddRange(this.flights
                .Select(i => new ListViewItem(FlightToArray(i)) { Tag = i })
                .ToArray()
            );
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.ListView.SelectedItems.Count > 0)
                {
                    this.selectedItem = (Flight)this.ListView.SelectedItems[0].Tag;
                    this.buyTicket.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            var client = new FlightServiceClient();
            client.Open();

            this.user = client.Login("Test1");

            client.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.ListView.Items.Clear();
            this.ListView.Items.AddRange(this.flights
                .Where(i => i.ToCity.Contains(this.searchText.Text))
                .Select(i => new ListViewItem { Tag = FlightToArray(i) })
                .ToArray()
            );
        }


        private void buyTicket_Click(object sender, EventArgs e)
        {
            if (this.selectedItem != null && this.buyTicket.Visible == true)
            {
                var client = new TicketService.TicketService();

                if (this.ListView.SelectedItems.Count > 0)
                {
                    this.selectedItem = (Flight)this.ListView.SelectedItems[0].Tag;
                    this.buyTicket.Visible = true;
                    client.BuyTicket(this.user, this.selectedItem, TicketType.BusinessClass);
                }

            }
        }

        private void checkReserv_Click(object sender, EventArgs e)
        {
            var client = new ReservationService.ReservationServiceClient();
            client.Open();

            var reserv = client.CheckReservation(Guid.Parse(this.reservNumber.Text), "Test1");
            MessageBox.Show(
                $"Znaleziono rezerwacje o id: {reserv.Number}, " +
                $"Na lot do: {reserv.Flight.ToCity}, " +
                $"Typ rezerwacji: {reserv.ReservationType.ToString()}"
            );

            client.Close();
        }


        private Flight[] flights;
        private Flight selectedItem;
        private User user;


        private static string[] FlightToArray(Flight f) => new[]
            {
                f.ToCity,
                f.FromCity,
                f.Cost.ToString(),
                f.Date.ToString()
            };
    }
}
