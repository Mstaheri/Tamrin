// See https://aka.ms/new-console-template for more information
using ConsoleApp1.Cart;
using ConsoleApp1.SMS;

Console.WriteLine("Hello, World!");

// update
var CartUpdate = new CartUpdateLinq();
var product = new Product("سیب", 13000);
CartUpdate.Update(product);



//sms
SmsSender Sms = new SmsSender(new KaveNegar());
Sms.Send("اپدیت شد", "09306994906");
