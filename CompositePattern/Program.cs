using CompositePattern;
using System.ComponentModel;

public class Program
{
    public static void Main(string[] args)
    {
        Document document = new Document("Напитки");

        Section sectionMain = new Section("Вкусные энергетики");
        sectionMain.Add(new Paragraph("У каждого свои вкусы"));

        Section sectionCCC = new Section("The Coca-Cola Company");
        sectionCCC.Add(new Paragraph("Дорого, но вкусно"));

        Section sectionMon = new Section("Monster Energy");
        sectionCCC.Add(sectionMon);
        sectionMon.Add(new Paragraph("Ultra - 10/10"));
        sectionMon.Add(new Paragraph("Black - 9/10"));
        sectionMon.Add(new Paragraph("Ultra Strawberry Dreams - ?/10 (еще не приехал)"));

        Section sectionBurn = new Section("Burn");
        sectionCCC.Add(sectionBurn);
        sectionBurn.Add(new Paragraph("Гуава - 10/10"));
        sectionBurn.Add(new Paragraph("Персик - 8/10"));
        sectionBurn.Add(new Paragraph("Сочная энергия - 8/10 (как monster pacific punch)"));

        Section sectionBal = new Section("Балтика");
        sectionBal.Add(new Paragraph("Дешево"));

        Section sectionFL = new Section("Flash Up");
        sectionBal.Add(sectionFL);
        sectionFL.Add(new Paragraph("Киви-карамбола - 10/10"));
        sectionFL.Add(new Paragraph("Лайм - 8/10"));
        sectionFL.Add(new Paragraph("Бабл - 8/10"));
        sectionFL.Add(new Paragraph("Ultra - 2/10"));

        //Paragraph test = new Paragraph("тест");
        //Paragraph test2 = new Paragraph("тест2");
        //test.Add(test2);
        //test.Remove(test2);

        document.Add(sectionMain);
        document.Add(sectionCCC);
        document.Add(sectionBal);
        document.Display();

        Console.WriteLine("После продажи российского бизнеса кока-колы:");

        sectionCCC.Remove(sectionMon);
        document.Display();
    }
}