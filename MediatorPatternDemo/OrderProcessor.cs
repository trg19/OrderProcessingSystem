/******************************************************************************
* Filename    = OrderProcessor.cs
*
* Author      = Thanmayee
* 
* Project     = OrderProcessingSystem
*
* Description = This file defines the OrderProcessor class, responsible for 
*               processing orders received through the Mediator.It is responsible 
*               for processing orders and keeping track of whether an order 
*               has been received and processed.
*****************************************************************************/

using System;

namespace MediatorPatternDemo
{
    public class OrderProcessor
    {
        private readonly IMediator mediator; // Reference to the mediator for communication.
        public string Name { get; } // The name of the order processor.

        /// <summary>
        /// Gets or sets a value indicating whether an order has been received and processed by the processor.
        /// </summary>
        public bool OrderReceivedAndProcessed { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrderProcessor"/> class.
        /// </summary>
        public OrderProcessor(IMediator mediator, string name)
        {
            this.mediator = mediator; // Store the mediator reference.
            Name = name; // Set the name of the order processor.
            OrderReceivedAndProcessed = true; // Initialize the order status as received and processed.
        }
    }
}
