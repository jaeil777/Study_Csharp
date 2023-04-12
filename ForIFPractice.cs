using System;

public class ForIfPractice
{
	public ForIfPractice()
	{
		int n= 9
            //기본 조건문
		if (n == 9)
			Console.WriteLine("입력된값은 9 맞음")

            //기본 조건문 괄호
        if (n == 9) {
            Console.WriteLine("입력된값은 9 맞음")
        }

        //if else 조건문
        if (n == 10)
        {
            Console.WriteLine("입력된값은 10임")
        }
        else
        {
            Console.WriteLine("입력된값은 일단 10은 아님")
        }



        //if else if 조건문
        if (n == 10)
        {
            Console.WriteLine("입력된값은 10임")
        }
        else if(n == 11)
        {
            Console.WriteLine("입력된값은 일단 11임")
        }
        else
        {
            Console.Write("입력된 값은 10이랑 11은 아님"+n"임")

        }




        //반복문

        //선언형
        for (int i = 1; 1 < 11; i++)
        {

            Console.WriteLine(i);

        }
        //비선언형
        int j = 1;
        for (int j; 1 < 11; i++)
        {

            Console.WriteLine(i);

        }

        //중첩 반복문

        int m = 1;
        int x = 1;
        for (int m; 1 < 11; m++)
        {

            Console.WriteLine(i);
            for (int x; 1 < 11; x++)
            {
                Console.WriteLine(m","x);
                
            }





        int k = 1;

        while (k < 11)
        {

            Console.WriteLine("지금 숫자는"k"입니다")
        
k++
        
}



        int k = 1;

        while (k < 11)
        {

            Console.WriteLine("지금 숫자는"k"입니다")
        
k++
        
}



        int k = 1;

        while (k < 11)
        {

            Console.WriteLine("지금 숫자는"k"입니다")
        
k++
        


if (k > 7)
            {

                Console.WriteLine("지금 숫자는"k"인데 break문을 이용해서 멈출 겁니다")

break;

            }

        }







    }
}
