// See https://aka.ms/new-console-template for more information
using exercise.main;
using exercise.main.Collections;
using exercise.main.ReceiptPrinters;

var basket = new Basket(25);

basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());
basket.Add(Products.BGLP());

basket.Add(Products.COFB());

basket.Add(Products.BGLO());
basket.Add(Products.BGLO());
basket.Add(Products.BGLO());
basket.Add(Products.BGLO());
basket.Add(Products.BGLO());
basket.Add(Products.BGLO());

var price = basket.GetTotalCost();

var printer = new ConsoleReceiptPrinter();
basket.PrintReceipt(printer);
