using exercise.main;
using exercise.main.Exceptions;
using exercise.main.Items;

namespace exercise.tests;

public class Tests
{
    [Test]
    public void AddItemToBasketTask()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());

        var basketProducts = basket.Products.ToList();

        Assert.That(basketProducts.Count, Is.EqualTo(1));
        Assert.That(basketProducts.FirstOrDefault().SKU, Is.EqualTo("BGLO"));
    }

    [Test]
    public void Add3ItemsToBasketTask()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());

        var basketProducts = basket.Products.ToList();

        Assert.That(basketProducts.Count, Is.EqualTo(3));
        Assert.That(basketProducts.FirstOrDefault().SKU, Is.EqualTo("BGLO"));
    }

    [Test]
    public void RemoveItemFromBasketTask()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());

        basket.Remove("BGLO");

        var basketProducts = basket.Products.ToList();

        Assert.That(basketProducts.Count, Is.EqualTo(0));
    }

    [Test]
    public void RemoveItemFromBasketTask2()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLP());

        basket.Remove("BGLO");

        var basketProducts = basket.Products.ToList();

        Assert.That(basketProducts.Count, Is.EqualTo(1));
        Assert.That(basketProducts.FirstOrDefault().SKU, Is.EqualTo("BGLP"));
    }

    [Test]
    public void RemoveItemNotInBasketFromBasketTask()
    {
        var basket = new Basket(3);

        var basketProducts = basket.Products.ToList();

        Assert.Throws<ItemNotInBasketException>(() => basket.Remove("BGLO"));
    }

    [Test]
    public void OverfillBasketGetExceptionTask()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());

        var bagel = Products.BGLO();

        Assert.Throws<BasketFullException>(() => basket.Add(bagel));
    }

    [Test]
    public void ChangeBasketCapacityTask()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());

        basket.ChangeCapacity(4);

        basket.Add(Products.BGLO());

        var basketProducts = basket.Products.ToList();
        Assert.That(basketProducts.Count, Is.EqualTo(4));
    }

    [Test]
    public void CheckBasketPriceTest()
    {
        var basket = new Basket(3);
        basket.Add(Products.BGLO());

        var price = basket.GetTotalCost();

        Assert.That(price, Is.EqualTo(Products.BGLO().Price));
    }

    [Test]
    public void CheckBasketPriceTest2()
    {
        var basket = new Basket(6);
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLP());

        var price = basket.GetTotalCost();

        Assert.That(price, Is.EqualTo(Products.BGLO().Price + Products.BGLP().Price));
    }


    [Test]
    public void AddFillingToBagelTest()
    {
        var basket = new Basket(6);

        var bagel = Products.BGLO();
        var filling = Products.FILS();
        bagel.AddFillings(filling);

        basket.Add(bagel);

        var price = basket.GetTotalCost();

        Assert.That(price, Is.EqualTo(Products.BGLO().Price + Products.FILS().Price));
    }

    [Test]
    public void AddBagelDiscount()
    {
        var basket = new Basket(6);

        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());
        basket.Add(Products.BGLO());

        var price = basket.GetTotalCost();

        Assert.That(price, Is.EqualTo(Discounts.BgloDiscount().NewTotalPrice));
    }
}