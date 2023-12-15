using choque14.Models;
using choque14.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace choque14.ViewModels
{
    public class CompraViewModel : BaseViewModel
    {
        private string client;
        public string Client
        {
            get { return this.client; }
            set { SetValue(ref this.client, value); }
        }

        private double total;
        public double Total
        {
            get { return this.total; }
            set { SetValue(ref this.total, value); }
        }

        private string seller;
        public string Seller
        {
            get { return this.seller; }
            set { SetValue(ref this.seller, value); }
        }

        private DateTime date;
        public DateTime SelectDate
        {
            get { return this.date; }
            set { SetValue(ref this.date, value); }
        }

        private string filter;
        public string Filter
        {
            get { return this.filter; }
            set { SetValue(ref this.filter, value); }
        }

        private List<Compra> compra;
        public List<Compra> Compra
        {
            get { return this.compra; }
            set { SetValue(ref this.compra, value); }
        }

        public ICommand SearchCommand { get; set; }
        public ICommand InsertCommand { get; set; }

        public CompraViewModel()
        {

            SearchCommand = new Command(() =>
            {
                CompraServices services= new CompraServices();
                Compra = services.GetByText(Filter);
            });

            InsertCommand = new Command(() =>
            {
                CompraServices services = new CompraServices();
                int newCompra = services.Get().Count + 1;
                services.Create(new Models.Compra { client = Client, total = Total, seller = Seller, date = SelectDate });
            });
        }

    }
}
