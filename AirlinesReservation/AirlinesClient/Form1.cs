using AirlinesClient.FlightService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            var client = new FlightService.FlightServiceClient();
            ListView.Items.Clear();
            foreach (var item in client.GetAllFlights())
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
            // zrobic wyszukiwanie
            var client = new FlightService.FlightServiceClient();
            
        }

        private void buyTicket_Click(object sender, EventArgs e)
        {
            if (selectedItem != null && buyTicket.Visible == true)
            {

            }
        }
    }
}
