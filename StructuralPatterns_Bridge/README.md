# Bridge  (Structural Pattern)!

This pattern is used when i want to add something new to my existing class but with editing much of its existing functionality.

so i just need to create an instance of that class inside the compsite class which needs it, right?
no no that is wrong in bridge pattern as that is no longer docoupled, and there is no sepration of concerns

so we make an interface which we are going to be use in the composite class and call the method of that interface within a mthod in the composite
after that we can make many variations of that interface and use any one that we need on the client side

In this example, the project is organized into three main components:

1. CompsiteClass: These represent the class that needs to add new logic in our case INotification.
2. ImplementarClasses: the classes that contain the adtional logic and actually implement the new logic.
3. UserClass: This is the main program that interacts with the Compiste and the implementar classes.

have fun!😉
