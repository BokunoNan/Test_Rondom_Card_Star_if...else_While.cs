using System;
					
public class Program
{
    
	public static void Main()
	{
        //ประกาศตัวแปร สุ่ม
        Random dice = new Random();
        // bool CardRandom = true;
        //เอาไว้เคลียร์หน้าจอ
        Console.Clear();
        //เขียนกำหนดหัวข้อ
		Console.WriteLine("สุ่ม Card Art/Quick/Buster");
        Console.WriteLine("---->มาสุ่ม Card กันเถอะ!<----");
        //เขียน loop for เพื่อสุ่มการ์ด 5 ใบ
        for (int i = 1; i <= 5; i++){
             int card = dice.Next(1,4);
        if (card == 1 ){
            //เปลี่ยนสีข้อความ เป็นสีน้ำเงิน
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("คุณได้ Card Art");
            Console.ResetColor();
        }
        else if (card == 2){
            //เปลี่ยนสีข้อความ เป็นสีเขียว
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("คุณได้ Card Quick");
            Console.ResetColor();
        }
        else{
            //เปลี่ยนสีข้อความ เป็นสีแดง
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("คุณได้ Card Buster");
            Console.ResetColor();
        }
    }
}
    //  static void WaitForKey(ConsoleKey targetKey)
    // {
    //     Console.WriteLine($"[ Aoko: กดปุ่ม {targetKey} เพื่อกด 10 Roll! ]");
    //     while (Console.ReadKey(true).Key != targetKey);
    // }
}