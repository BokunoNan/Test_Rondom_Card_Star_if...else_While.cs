using System;
					
public class Program
{
    
	public static void Main()
	{
        bool CardRandom = true;
        //ประกาศตัวแปร สุ่ม
        Random dice = new Random();       
        //สร้างลูป while เพื่อให้สามารถสุ่มการ์ดได้เรื่อยๆ จนกว่าผู้ใช้จะกดปุ่มอื่นที่ไม่ใช่ Spacebar
        while (CardRandom)
        {
        //เขียนกำหนดหัวข้อ
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("[ Richard I : มาสุ่มการ์ดกันเถอะ Master! ]");
        Console.WriteLine("---------------------------------------------");
        Console.ResetColor();
          //เขียน loop for เพื่อสุ่มการ์ด 5 ใบ
        for (int i = 1; i <= 5; i++){
            //สุ่มการ์ด 1-3
             int card = dice.Next(1,4);
              //สุ่มดวงคริติคอล 1-10
             int Critical = dice.Next(1,11);
             //สร้างตัวแปรเก็บประเภทการ์ด
             string cardType = "";

        if (card == 1 ){
            //เปลี่ยนสีข้อความ เป็นสีน้ำเงิน
            {cardType = "Art"; Console.ForegroundColor = ConsoleColor.Blue; }
            // Console.ResetColor();
        }
        else if (card == 2){
            //เปลี่ยนสีข้อความ เป็นสีเขียว
           {cardType = "Quick"; Console.ForegroundColor = ConsoleColor.Green;}
            // Console.ResetColor();
        }
        else{
            //เปลี่ยนสีข้อความ เป็นสีแดง
            {cardType = "Buster"; Console.ForegroundColor = ConsoleColor.Red; }
            // Console.ResetColor();
        }
        //พิมพ์ผลลัพธ์
        Console.Write($"Card : {cardType,-6}");
        //ล้างสีข้อความ กลับเป็นค่าเริ่มต้น
        Console.ResetColor();
        
        Console.ForegroundColor = ConsoleColor.Yellow;
        //พิมพ์ผลลัพธ์ ดวงคริติคอล
        Console.Write(" \b Star : ");
        // วนลูปเพื่อพิมพ์ดาวคริติคอล
        for(int s = 0; s < Critical; s++)
            {
              Console.Write(" ★ ");   
            }
        //พิมพ์ค่าเปอร์เซ็นต์คริติคอล
        Console.WriteLine($" \b {Critical * 10}%");
        Console.ResetColor();
    }
       //พิมพ์ข้อความแนะนำให้ผู้ใช้กดปุ่ม
        Console.ForegroundColor = ConsoleColor. Magenta;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine($"[ Mashu: กดปุ่ม Spacebar เพื่อสุ่มต่อค่ะ Master! / กดปุ่มอื่นเพื่อออก ]");
        Console.WriteLine("-----------------------------------------------------------");
        //ตรวจสอบว่าผู้ใช้กดปุ่ม Spacebar หรือไม่ หากไม่ใช่จะเปลี่ยนค่า CardRandom เป็น false เพื่อออกจากลูป
        if (Console.ReadKey(true).Key != ConsoleKey.Spacebar) CardRandom = false;
        //ล้างหน้าจอคอนโซล
       Console.Clear();
}      
}
    //ฟังก์ชันรอการกดปุ่มที่ระบุ
    public
   static void WaitForKey(ConsoleKey targetKey)
    {
        //รอจนกว่าผู้ใช้จะกดปุ่มที่ระบุ
        while (Console.ReadKey(true).Key != targetKey);
    }
}