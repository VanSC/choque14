using choque14.DataContext;
using System;
using System.Collections.Generic;
using System.Text;
using choque14.Models;
using System.Linq;

namespace choque14.Services
{
    public class CompraServices
    {
        private readonly AppDbContext _context;

        public CompraServices() => _context = App.GetContext();

        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Compras.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            if (string.IsNullOrEmpty(text))
                return _context.Compras.ToList();


            return _context.Compras.Where(x => x.client.Contains(text) || x.seller.Contains(text)).ToList();
        }

    }
}
