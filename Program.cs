using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saldy_consapp
{

}


class Computer
{
    // Открытые поля
    public int InventoryNumber { get; set; }
    public double ProcessorFrequency { get; set; }
    public int HardDiskCapacity { get; set; }

    // Метод для отображения данных о компьютере
    public void ShowInfo()
    {
        Console.WriteLine($"Инвентарный номер: {InventoryNumber}");
        Console.WriteLine($"Частота процессора: {ProcessorFrequency} ГГц");
        Console.WriteLine($"Объем жесткого диска: {HardDiskCapacity} ГБ");
    }

    // Метод расчета стоимости внешней памяти
    public double CalculateStorageCost(double costPerGigabyte)
    {
        return HardDiskCapacity * costPerGigabyte;
    }
}

class Program
{
    static void Main()
    {
        // Создание объекта Computer
        Computer myComputer = new Computer
        {
            InventoryNumber = 123345,
            ProcessorFrequency = 1.5,
            HardDiskCapacity = 400
        };

        // Вывод значений свойств объекта
        myComputer.ShowInfo();

        // Расчет стоимости внешней памяти
        double costPerGigabyte = 100.0;
        double totalCost = myComputer.CalculateStorageCost(costPerGigabyte);

        // Вывод стоимости на печать
        Console.WriteLine($"Стоимость внешней памяти: {totalCost} рублей");
        Console.WriteLine("Выполнил Сладков Даниил 34ИС");
            Console.ReadKey(); 
    }
}



