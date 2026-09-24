using MyStaticClass;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

/*
Змінні спеціально мають бути вище тексту, де виводиться
їх загальна к-ть через GetCountItems(). Якщо вони будуть
під текстом, то виведеться значення '0' (за замовчуванням)
*/

// У консоль виведеться інфа з конструктора за замовчуванням
Laptops laptop1 = new Laptops();

// У консоль виведеться інфа з конструктора з параметрами
Laptops laptop2 = new Laptops("Lenovo LOQ 15AHP10", 144, 300, 1);
Laptops laptop3 = new Laptops("ASUS TUF Gaming F16", 144, 250, 1);
Laptops laptop4 = new Laptops("Acer Extensa 15", 60, 250, 1);

// У консоль виведеться інша зі статичного конструктора
Laptops laptop5 = new Laptops();
laptop5.Model = "MSI Cyborg 15";
laptop5.ScreenFrequency = 144;
laptop5.MatrixLight = 250;
laptop5.SSDSize = 1;

// Сам текст, основна мета якого вказати кількість наших об'єктів
Console.WriteLine($"--- ТОП {Laptops.GetCountItems()} хороших ноутбуків ---");

// А тепер це все добро можна вивести. Можна таким способ, а можна окремо
Console.WriteLine($"{laptop1}\n{laptop2}\n{laptop3}\n{laptop4}\n{laptop5}");
