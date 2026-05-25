# Strategy Pattern (Behavioral)

### 📌 Implementation Context
This project simulates an E-Commerce checkout component. Instead of using hardcoded conditional structures (`if/switch`) to handle various shipping carriers, the system encapsulates each carrier's pricing logic inside a dedicated strategy class. This allows new carriers to be added without modifying the core checkout engine, adhering strictly to the Open/Closed Principle.

### 📐 Structural Layout
#### Order Checkout Example

```mermaid
classDiagram
    class OrderCheckoutContext {
        -IShippingStrategy _shippingStrategy
        +SetShippingStrategy(IShippingStrategy)
        +ExecuteCheckout() decimal
    }
    class IShippingStrategy {
        <<interface>>
        +CalculateShippingCost() decimal
    }
    class FedexShippingStrategy {
        +CalculateShippingCost() decimal
    }
    class UpsShippingStrategy {
        +CalculateShippingCost() decimal
    }
    OrderCheckoutContext --> IShippingStrategy : maintains reference
    FedexShippingStrategy ..|> IShippingStrategy : implements
    UpsShippingStrategy ..|> IShippingStrategy : implements
```

---
### DuckUSim

```mermaid
classDiagram
    %% Context Tier (Client)
    class Duck {
        <<abstract>>
        -FlyBehavior flyBehavior
        -QuackBehavior quackBehavior
        +swim()
        +display()*
        +performQuack()
        +performFly()
        +setFlyBehavior(FlyBehavior)
        +setQuackBehavior(QuackBehavior)
    }
    
    class MallardDuck { +display() }
    class RedheadDuck { +display() }
    class RubberDuck { +display() }
    class DecoyDuck { +display() }

    Duck <|-- MallardDuck : IS-A
    Duck <|-- RedheadDuck : IS-A
    Duck <|-- RubberDuck : IS-A
    Duck <|-- DecoyDuck : IS-A

    %% Strategies Tier
    class FlyBehavior {
        <<interface>>
        +fly()
    }
    class FlyWithWings { +fly() }
    class FlyNoWay { +fly() }
    
    FlyBehavior <|.. FlyWithWings : IMPLEMENTS
    FlyBehavior <|.. FlyNoWay : IMPLEMENTS

    class QuackBehavior {
        <<interface>>
        +quack()
    }
    class Quack { +quack() }
    class Squeak { +quack() }
    class MuteQuack { +quack() }

    QuackBehavior <|.. Quack : IMPLEMENTS
    QuackBehavior <|.. Squeak : IMPLEMENTS
    QuackBehavior <|.. MuteQuack : IMPLEMENTS

    %% Composition Anchors (HAS-A)
    Duck --> FlyBehavior : HAS-A (flyBehavior)
    Duck --> QuackBehavior : HAS-A (quackBehavior)
```
