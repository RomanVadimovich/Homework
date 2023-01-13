int numberA = new Random().Next (1, 10); 
Console.WriteLine($"Первое число: {numberA}");
int numberB = new Random().Next (1, 10);
Console.WriteLine($"Второе число: {numberB}");
if (numberA > numberB) {
	Console.WriteLine($"Результат: {numberA} больше, чем число {numberB}");
}
else {
	Console.WriteLine($"Результат: {numberB} больше, чем число {numberA}");
}