using DesignPattern.Facade.DAL;

namespace DesignPattern.Facade.FacadeDesignPattern
{
    public class OrderFacede
    {
        Order order = new Order();
        OrderDetail orderDetail = new OrderDetail();
        ProductStock productStock = new ProductStock();
        AddOrder addOrder = new AddOrder();
        AddOrderDetail addOrderDetail = new AddOrderDetail();

        public void CompleteOrderDetail(int customerId, int productId, int orderId, int productCount, decimal productPrice)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);

            orderDetail.CustomerId = customerId;
            orderDetail.ProductId = productId;
            orderDetail.OrderId = orderId;
            orderDetail.ProductCount = productCount;
            orderDetail.ProductPrice = productPrice;
            orderDetail.ProductTotalPrice = productPrice * productCount;
            addOrderDetail.AddNewOrderDetail(orderDetail);

            productStock.StockDecrease(productId, productCount);
        }

        public void CompleteOrder(int customerId)
        {
            order.CustomerId = customerId;
            addOrder.AddNewOrder(order);
        }
    }
}
