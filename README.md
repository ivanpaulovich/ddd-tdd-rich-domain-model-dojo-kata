# Small .NET Standard solution with DDD Building Blocks covered with Unit Tests [![Build status](https://ci.appveyor.com/api/projects/status/ujilt0luhnvpm4to?svg=true)](https://ci.appveyor.com/project/ivanpaulovich/ddd-tdd-rich-domain) [![codecov](https://codecov.io/gh/ivanpaulovich/ddd-tdd-rich-domain/branch/master/graph/badge.svg)](https://codecov.io/gh/ivanpaulovich/ddd-tdd-rich-domain)

We desined the Finance Domain using Aggregate Roots, Entities and Value Objects and we covered the uses cases with Unit Tests, try running them. The Domain and Unit Tests projects were implemented with .NET, the classes are as closed as possible.

## Compiling from source

To run Acerola from source, clone this repository to your machine, compile and test it:

```sh
git clone https://github.com/ivanpaulovich/ddd-tdd-rich-domain.git
./build.sh
```

## Use cases

This project was designed do cover the following use cases:

1. The customer should be able to register a new account.
2. Allow to deposit on an account.
3. Allow to withdra on an account.
4. Accounts can be closed only if they have zero balance.
5. We can't withdraw more than the balance.

The following diagram shows the bounded contexts:

## Good to know

Aggregate Roots
1. Customer
2. Account

Entities
1. Customer
2. Account
3. Credit
3. Debit

Value Objects
1. SSN
2. Name
3. Amount

## Tech stuff

* .NET Core / Standard
* xUnit
* Moq
