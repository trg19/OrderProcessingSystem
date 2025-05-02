# OrderProcessingSystem
- MediatorDesignPatternDemo

The Mediator design pattern is a behavioural pattern that promotes loose coupling among objects by centralizing their communication. In this pattern, instead of objects directly interacting with each other, they communicate through a central mediator. This mediator encapsulates the interactions between objects and helps reduce dependencies between them.

# Key Components
Mediator: The central component that facilitates communication between objects. It references all objects that need to interact and defines methods to coordinate their communication.\
Colleague Objects: These objects interact with each other through the mediator. Colleague objects are unaware of each other and rely on the mediator to relay messages.

BENEFITS OF MEDIATOR PATTERN
1. Decouples Components
2. Promotes Reusability
3. Centralized Control
4. Enhances Maintainability

The Mediator design pattern finds practical applications in solving real-world problems, one of which is the Order Processing system. This is a simple project and it aims to build a basic order processing system where customers can place orders, and order processors communicate through a central mediator to fulfil these orders.

# Overview and Approach
This project demonstrates the Mediator design pattern to manage customer orders and order processors efficiently. It streamlines order placement and centralizes communication.

Approach:
- Customers initiate orders.
- A centralized mediator manages communication.
- Orders are routed to the appropriate processor.
- Real-time order status updates are provided.
- Error handling ensures robustness.

  # Design
 ![IMG_20230918_012156](https://github.com/thanmayee07/MediatorDesignPatternDemo/assets/114472443/87afc8ac-414d-4f44-bad6-3e032ee671af)

Relationship in the basic dependency diagram:

1.IMediator (Interface):
- Dependencies: None (since it's an interface)
- Implemented by:\
       - Mediator (Class): Represents the implementation of the IMediator interface.

2.Customer (Class):
- Dependencies:\
       - IMediator: Customer relies on the IMediator interface for communication with the mediator.
- Association:\
       - Mediator: Customer has a relationship with the Mediator class, indicating that it interacts with the mediator.

3.OrderProcessor (Class):
- Dependencies:\
       - IMediator: OrderProcessor relies on the IMediator interface for communication with the mediator.
- Association:\
       - Mediator: OrderProcessor has a relationship with the Mediator class, indicating that it interacts with the mediator.

4.Program (Class):
- Dependencies: None (it's the entry point of your application)
- Associations:\
       - Mediator: Program creates an instance of the Mediator class.

# Enhancements

In addition to the core functionality of the Mediator Pattern Demo project, there can be more enhancements which can be incorporated. Some of them include:
1. Real-Time notification
2. Order-Tracking
3. Multiple Order Types
4. User Authentication
5. Payment Integration
...etc.
   
# Environment
The project builds and runs with Visual Studio Community 2022.
