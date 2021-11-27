// See https://aka.ms/new-console-template for more information


#region Declare array   
/// <summary>
/// declaring new array 
/// datatype +square practes [] + name of array;
/// nameofarray = new {222,111};
/// datatype +square practes [] + name of array = new + datatype [length of array] { values}
/// </summary>
//index     // 0  ,1  ,2  ,3  ,4
//int[] ages = new int[5] { 19, 16, 20, 21, 22 };
//Console.WriteLine("orginal array");

////looping
//foreach (int age in ages)//loop for item , chach every single item
//{
//    Console.WriteLine(age);
//}
//                                     //arrayname.length
//Console.WriteLine("Array lenth is " + ages.Length);//output is 5 
//ages[2] = 30;
//Console.WriteLine("value of index: 2 = " + ages[2]);

//string[] usernames = new string[5];

//for (int i = 0; i < usernames.Length; i++)
//{
//    Console.WriteLine("enter name of index " + i);
//    usernames[i] = Console.ReadLine();
//}
//for (int i = 0; i < usernames.Length; i++)
//{ 
//    Console.WriteLine($"value of index {i} is {usernames[i]}");
//}
//for (int i = 0; i < ages.Length; i++) // loop on index, chach every single index
//{
//    string MSG;

//    if (ages[i] >= 20)
//    {
//        MSG = "";
//    }

//    else
//    {
//        MSG = "";
//    }

//    Console.WriteLine("ages is " + ages[i] + MSG);
//}
#endregion

#region Copy()


#endregion

#region sort()


#endregion


#region index()


#endregion

#region Indices

#endregion

#region slice
//first two

//last two

//between
#endregion

#region Multidimensional Arrays (Matrix)


#endregion


#region Jagged Array

#endregion

#region Switch
string Password=Console.ReadLine();

switch (Password.ToLower())
{
    case "hoopoe":
        Console.WriteLine("70% correct");
        break;
    case "hoopoe20":
        Console.WriteLine("80% correct");
        break;
    case "hoopoe2021":
        Console.WriteLine("100% correct");
        break;
    default:
        Console.WriteLine("0% correct");
        break;
}
#endregion
