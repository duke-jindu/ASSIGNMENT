Console.WriteLine("Hello, World!");


// 1.  Write a method that does the following
//Given an integer n, return a string array answer with elements starting from 1 to n  where:

//  answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
//  answer[i] == "Fizz" if i is divisible by 3.
//  answer[i] == "Buzz" if i is divisible by 5.
// answer[i] == i(as a string) if none of the above conditions are true.


FizzBuzz(20); //calling the method


//creating a method
static void FizzBuzz(int Lenght)
{


    //{
    //display an instruction message.
    //Console.Write("ENTER ITERATION LENGHT: ");
    //pass in the length of array
    //int l = int.Parse(Console.ReadLine());
    //}


    //using for loop (where i strts from 1)
    for (int i = 1; i < Lenght; i++)
    {
        //using the if statement


        //when number is divisible by both 3 and 5
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.Write("FizzBuzz" + ", ");
        }

        // when number is divisible by 3
        else if (i % 3 == 0)
        {
            Console.Write("Fizz" + ", ");
        }

        //when number is divisible by 5
        else if (i % 5 == 0)
        {
            Console.Write("Buzz" + ", ");
        }

        //when the conditions above are not met
        else
            Console.Write(i + ", ");
    }
}
