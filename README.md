# .NET Standard project with DDD patterns covered with Unit Tests

Design the **Virtual Wallet** using Aggregate Roots, Entities and Value Objects and cover the uses cases with Unit Tests. At the Clean Architecture Manga you could learn the [DDD patterns](https://github.com/ivanpaulovich/clean-architecture-manga/wiki/Domain-Driven-Design-Patterns) and TDD at [TheThreeRulesOfTdd](http://butunclebob.com/ArticleS.UncleBob.TheThreeRulesOfTdd).

## :gem: Compiling from source

Clone this repository to your machine, compile and test it:

```sh
git clone https://github.com/ivanpaulovich/ddd-tdd-rich-domain.git
cd ddd-tdd-rich-domain
dotnet test
```

## :construction_worker: Use cases

This project was designed do cover the following use cases and requirements:

1. A Customer could register a new Checking Account using its personal details.
1. Allow a customer to deposit funds into an existing account.
1. Allow the customer to withdraw funds from an existing account.
1. Allow the customer to close a Checking Account only if the balance is zero.
1. Do not allow the Customer to Withdraw more than the existing funds.
1. Allow to get the account details.
1. Allow to get the customer details.

## :memo: The Domain Model

![Domain Model](https://raw.githubusercontent.com/ivanpaulovich/ddd-tdd-rich-domain/kata-initial/docs/ddd-tdd-rich-domain-model.png)

## :computer: Tech stuff

* .NET Core 3.1
* xUnit

## :alien: Kata

Build a Rich Domain from tests using DDD Building Blocks like Aggregate Roots, Entities and Value Objects with the help of `kata-initial` folder files.

### :alien: The expected Model has

* Customer and Checking Account Aggregate Roots.
* Credit and Debit Entities.
* Amount, Name and SSN Value Objects.

### :alien: Create a Test Class for the Register use case.
### :alien: Then begin with the domain implementation.
### :alien: Refactor the code.
### :alien: Add more tests and continue with the implementation.
### :alien: Refactor and Repeat.