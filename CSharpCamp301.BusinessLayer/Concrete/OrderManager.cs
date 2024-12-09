using CSharpCamp301.BusinessLayer.Abstract;
using CSharpCamp301.DataAccessLayer.Abstract;
using CSharpCamp301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCamp301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order t)
        {
            _orderDal.Delete(t);
        }

        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public void TInsert(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TUpdate(Order t)
        {
            _orderDal.Update(t);
        }
    }
}
