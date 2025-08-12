# Domain Modelling

## Interfaces

### IInventoryProduct

| Property/Method | Scenario                                                  | Returns |
| --------------- | --------------------------------------------------------- | ------- |
| Name            | Full item name                                            | string  |
| SKU             | Item code                                                 | string  |
| Price           | Undiscounted base price (with no fillings)                | Decimal |
| GetFinalPrice() | Returns the final item price, with discounts and fillings | Decimal |

### IDiscountable

| Property / Methods              | Scenario                                                        | Returns |
| ------------------------------- | --------------------------------------------------------------- | ------- |
| DiscountedPrice                 | price after discounts                                           | Decimal |
| IsDiscounted                    | is item discounted boolean                                      | bool    |
| SetDiscountPrice(Decimal price) | sets the discount price                                         |         |
| GetSavedAmount()                | returns the difference between<br>original and discounted price | Decimal |

### IFillable

| Property / Method           | Scenario                         | Returns        |
| --------------------------- | -------------------------------- | -------------- |
| Fillings                    | stores all filling on an item    | List\<Fillings> |
| AddFilling(Filling filling) | add a filling to a fillable item |                |

### IReceiptPrinter

| Method                | Scenario           |
| --------------------- | ------------------ |
| Print(string receipt) | Prints the receipt |


## Inheriting Classes

### Bagel : IInventoryProduct, IDiscountable, IFillable
### Coffee : IInventoryProduct, IDiscountable
### Filling : IInventoryProduct

### ConsoleReceiptPrinter : IReceiptPrinter
### TwilioReceiptPrinter : IReceiptPrinter

### BasketFullException : Exception
### ItemNotInBasketException : Exception


## Other classes

### Basket

| Property / method                     | Scenario                                                               | Returns               |
| ------------------------------------- | ---------------------------------------------------------------------- | --------------------- |
| Capacity                              | shows basket's capacity                                                | int                   |
| Products                              | shows the content of the basket                                        | List\<IDiscountable> |
| Remove(string SKU)                    | remove product in the basket                                           |                       |
| ChangeCapacity(int capacity)          | Changes basket's capacity                                              |                       |
| GetTotalCost()                        | Get Final cost of all items in the basket                              | Decimal               |
| PrintReceipt(IReceiptPrinter printer) | prints receipt                                                         |                       |
| private CalculateDiscounts()          | calculates discounts when adding and removing products from the basket |                       |

### Discount

| Property / Method         | Scenario                                                                                    | Returns                     |
| ------------------------- | ------------------------------------------------------------------------------------------- | --------------------------- |
| ItemRequirementAmountDict | stores requirements for a discount to be eligible,<br>in a format of <SKU, required amount> | Dictionary<string, int>     |
| ItemDiscountedPriceDict   | stores discounted price for item, mapped to SKU                                             | Dictionary<string, Decimal> |
| SavedAmount               | Amount the discount saved                                                                   | Decimal                     |
| CalculateSavedAmount()    | Calculated saved amount   


## Static classes

### Discounts

| Property / Method | Scenario                          | Returns        |
| ----------------- | --------------------------------- | -------------- |
| List              | stores a list of active discounts | List<Discount> |
| BgloDiscount()    |                                   | Discount       |
| BglpDiscount()    |                                   | Discount       |
| BgleDiscount()    |                                   | Discount       |
| CofbDiscount()    |                                   | Discount       |

### Prices

| Property      | scenario                             | returns                     |
| ------------- | ------------------------------------ | --------------------------- |
| SkuToPriceMap | Dictionary mapping SKU to base price | Dictionary<string, decimal> |

### Products

| Method | Returns |
| ------ | ------- |
| BGLO() | Bagel   |
| BGLP() | Bagel   |
| BGLE() | Bagel   |
| BGLS() | Bagel   |
| COFB() | Coffee  |
| COFW() | Coffee  |
| COFC() | Coffee  |
| COFL() | Coffee  |
| FILB() | Filling |
| FILE() | Filling |
| FILC() | Filling |
| FILX() | Filling |
| FILS() | Filling |
| FILH() | Filling |
