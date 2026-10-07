int quantity;
int price;
int totalPrice = 0;
bool addProduct;
do
{
    Console.Write("Enter price: ");
    price = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter quantity: ");
    quantity = Convert.ToInt32(Console.ReadLine());

    totalPrice += price * quantity;

    Console.WriteLine($"Total = {price * quantity}");
    Console.Write("Add another product? 1 = Yes, 0 = No: ");
    addProduct = Convert.ToBoolean(Convert.ToInt32(Console.ReadLine()));
} while (addProduct != false);

Console.WriteLine($"All Total = {totalPrice}");