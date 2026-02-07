namespace Assignment_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q02

            //Console.Write("Enter age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.Write("Enter The Day Of Week (fri=6) (sat=7) : ");
            //int dayInput = int.Parse(Console.ReadLine());


            //Console.Write("Do You Have An ID : ");
            //string hasAnId = Console.ReadLine();

            //bool Student = hasAnId == "yes";

            //int price = 0;
            //if (age < 5)
            //{
            //    price = 0;
            //    Console.WriteLine("This Ticket Is Free");
            //}
            //else if (age >= 5 && age <= 12)
            //{
            //    price = 30;
            //    Console.WriteLine("This Ticket Price Is 30LE");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    price = 50;
            //    Console.WriteLine("This Ticket Price Is 50LE");
            //}
            //else
            //{
            //    price = 25;
            //    Console.WriteLine("This Ticket Price Is 25LE");
            //}


            //if (price>0 && (dayInput == 7 || dayInput==6))
            //{

            //    price += 10;

            //    Console.WriteLine("This is a weekend so any ticket will be +10");



            //}

            //if(price>0 && Student)
            //{
            //    double discount = price * .20;
            //    price -= (int)discount;
            //    Console.WriteLine("The Discount has been Confirmed");
            //}

            //Console.Write($"Final Price Is {price}");


            #endregion

            #region Q03

            //string filExtention = ".pdf";
            //string fileType;

            //switch (filExtention)
            //{
            //    case ".pdf":
            //        fileType = "PDF File";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".doxc":
            //        fileType = "Word Document";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".doc":
            //        fileType = "Word Document";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".xls":
            //        fileType = "Excel SpreadShet";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".xlsx":
            //        fileType = "Excel SpreadShet";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".jpg":
            //        fileType = "Image File";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".Png":
            //        fileType = "Image File";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;

            //    case ".gif":
            //        fileType = "Image File";
            //        Console.WriteLine(filExtention);
            //        Console.WriteLine(fileType);
            //        break;
            //}



            //Using A switch expression
            //string fileType=".xlxs";
            //string fileExtention = fileType switch
            //{
            //    ".pdf" => "PDF Document",
            //    ".docx" or ".doc" => "Word Document",
            //    ".xlsx" or ".xls" => "Excel SpreadSheet",
            //    ".jpg" or ".png" or ".gif" => "Img File",
            //    _ => "Invalid Input"
            //};
            //Console.WriteLine(fileExtention);

            #endregion





            #region Q04

            //int temp = 0;
            //string WeatherInfo = temp <= 0 ? "Freezing" : temp < 15 ? "Cold"
            //: temp < 25 ? "Pleasant Weather" : temp < 35 ? " Warm"
            //: "Hot Avoid The Exposure";
            //Console.WriteLine(WeatherInfo);
            #endregion





            #region Q06

            //int[] scores = { 95, 82, 67, 45, 30, 88, 91, 73, 59, 100, 40 };

            //Console.WriteLine("Failing Score : ");

            //foreach(int score in scores)
            //{
            //    if (score < 50)
            //    {
            //        Console.WriteLine(score);
            //    }
            //}

            //Console.WriteLine("Above 90 Scores : ");

            //foreach(int score in scores)
            //{
            //    if (score >= 90)
            //    {
            //        Console.WriteLine(score);
            //        break;
            //    }
            //}

            //int sum = 0;
            //int count = 0;
            //foreach(int score in scores)
            //{
            //    if (score >= 40)
            //    {
            //        sum += score;
            //        count++;
            //    }
            //}

            //double average=count>0 ? (double)sum/count : 0;
            //Console.WriteLine($"The Average Is : {average}");





            //int a=0; int b=0; int c=0; int d=0; int f=0;

            //foreach (int score in scores)
            //{
            //    if (score >= 90)
            //        a++;
            //    if (score >= 80)
            //        b++;
            //    if (score >= 70)
            //        c++;
            //    if (score >= 60)
            //        d++;
            //    if (score >= 50)
            //        f++;
            //}
            //Console.WriteLine($"The Count Of A Is : {a}");
            //Console.WriteLine($"The Count Of B Is : {b}");
            //Console.WriteLine($"The Count Of C Is : {c}");
            //Console.WriteLine($"The Count Of D Is : {d}");
            //Console.WriteLine($"The Count Of f Is : {f}");

            #endregion
        }
    }
}
