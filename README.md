# Patterns.Playground
A playground solution for design patterns in C#.

**Disclaimer:**  
This code is the result of discussions we had within our team at [TechTalk](http://www.techtalk.at). It is our take on the topic, with several things left to discuss and improve.

At the moment, there is just a single sample. More might come.

## Abstract Factory
Another incarnation of a Pizza-example.

We have a **pizza baker** (class `PizzaBaker`) that knows how to make a good Pizza. At that time, he knows just how to make a simple tomato Pizza. For that Pizza, it needs some **ingredients** (implementations of `IIngredient`). These ingredients are provided via an **ingredient provider** (some implementation of the interface `IIngredientProvider`).  At the time being we have implemented two ingredient providers:

* The proud provider **Great Italian Foods** (supplier "GreatItalianFood")
* and the humble **Austrian Basic Ingredients** (supplier "AustrianBasic")

The sample is implemented within a simple console application. It takes the name of a supplier, creates the respective ingredient provider, passes it to the pizza baker which make us a delicious tomato pizza (that's all it can). We then print the name of all the ingredients of our pizza.

### Extension (off-topic)
(Warning: this has _nothing_ to do with the abstract factory) Out of curiosity we wanted to provide the calories for the whole meal. For that we forced the ingredients and the foundation to inform us about that numbers by introducing an additional interface `IHasCalories`. A `CaloryCalculator` takes our pizza and tells us the sad news.