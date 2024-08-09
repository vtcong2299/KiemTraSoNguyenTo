using System;


namespace KiemTraSoNguyenTo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            int i;
            while(true)
            {
            int count=0;
            Console.Write("Nhap vao so can kiem tra: ");
            while(true)
            {
                if (Int32.TryParse(Console.ReadLine(),out num))
                {
                    break;
                }
                else 
                {
                    Console.Write("Nhap vao 1 so nguyen duong can kiem tra: ");
                }
            }
            if (num<2)
            {
                Console.WriteLine("So {0} khong phai so nguyen to",num);
            }
            else 
            {
                for (i=2;i<num;i++)
                {
                    if(num%i==0)
                    {
                        count++;
                    }
                }
                if(count==0)
                {
                    Console.WriteLine("So {0} la so nguyen to",num);
                }
                else
                Console.WriteLine("So {0} khong phai so nguyen to",num);
            }
            Console.WriteLine("\nNhap phim [Bat ky] de tiep tuc kiem tra hoac nhap [END] de thoat:");
            string exit;
            exit=Console.ReadLine();
            switch (exit)
            {
                case "end":
                case "END":
                break;
            }
            }
        }
    }
}