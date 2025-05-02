/******************************************************************************
* Filename    = IMediator.cs
*
* Author      = Thanmayee
* 
* Project     = OrderProcessingSystem
*
* Description =  The IMediator interface represents the mediator in the Mediator pattern.
                It defines methods for registering customers and order processors, as well as
                placing orders and processing orders.
*****************************************************************************/


namespace MediatorPatternDemo
{
    public interface IMediator
    {
        /// <summary>
        /// Registers a customer with the mediator.
        /// </summary>
        void RegisterCustomer(Customer customer);

        /// <summary>
        /// Registers an order processor with the mediator.
        /// </summary>
        void RegisterOrderProcessor(OrderProcessor processor);

        /// <summary>
        /// Places an order on behalf of a customer.
        /// </summary>
        void PlaceOrder(Customer customer, string orderDetails);

        /// <summary>
        /// Processes an order by an order processor for a customer.
        /// </summary>
        void ProcessOrder(OrderProcessor processor, Customer customer, string orderDetails);
    }
}
