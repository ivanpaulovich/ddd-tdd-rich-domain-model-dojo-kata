# Small .NET Standard solution with DDD Building Blocks covered with Unit Tests [![Build status](https://ci.appveyor.com/api/projects/status/ujilt0luhnvpm4to?svg=true)](https://ci.appveyor.com/project/ivanpaulovich/ddd-tdd-rich-domain) [![codecov](https://codecov.io/gh/ivanpaulovich/ddd-tdd-rich-domain/branch/master/graph/badge.svg)](https://codecov.io/gh/ivanpaulovich/ddd-tdd-rich-domain)

We designed the Finance Domain using Aggregate Roots, Entities and Value Objects and we covered the uses cases with Unit Tests, run them in your first time here. The Domain and Unit Tests projects were implemented with .NET, the classes are as closed as possible.

## :gem: Compiling from source

Clone this repository to your machine, compile and test it:

```sh
git clone https://github.com/ivanpaulovich/ddd-tdd-rich-domain.git
cd ddd-tdd-rich-domain
./build.sh
```

## :construction_worker: Use cases

This project was designed do cover the following use cases and requirements:

1. The customer can register a new account.
2. Allow to deposit into an existing account.
3. Allow to withdraw from an existing account.
4. Accounts can be closed only if they have zero balance.
5. Accounts does not allow to withdraw more than the current account balance.
6. Allow to get the account details.
7. Allow to get the customer details.

## :memo: Good to know

![Domain Model](https://raw.githubusercontent.com/ivanpaulovich/ddd-tdd-rich-domain/master/docs/ddd-tdd-rich-domain-model.png)

## :computer: Tech stuff

* .NET Core / Standard
* xUnit
* Moq
