using System;
#nullable disable
{
    // const string haha = "this is a string";
    Console.WriteLine("     /|");
    Console.WriteLine("    / |");
    Console.WriteLine("   /  |");
    Console.WriteLine("  /   |");
    Console.WriteLine(" /____|");

    string name = "jhon";
    int age =  35;
    System.Console.WriteLine($"THe name is {name}");
    System.Console.WriteLine($"the age is {age}");
    
    
    string owo = "this is cool";
    System.Console.WriteLine(owo);
    int num = 32;
    System.Console.WriteLine(num);
    double point = 32.8;
    System.Console.WriteLine(point);
    bool isGood = true;
    bool isBad = false;
    System.Console.WriteLine($"AHMED IS good: {isGood} and Ali is also good {isBad}");
    System.Console.WriteLine(name.Length);

    int add = --num;
    int min2 = ++num;
    
    System.Console.WriteLine(owo[1]);
    System.Console.WriteLine(owo.IndexOf("l"));
    System.Console.WriteLine(owo.Substring(3,8));   
    System.Console.WriteLine($"the nums are: {add} and {min2}");

    System.Console.WriteLine(Math.Max(90 , 4));
    System.Console.WriteLine(Math.Min(90 , 4));

    System.Console.WriteLine(Math.Round(5.6));

    System.Console.WriteLine("enter the name");
    string age2  = Console.ReadLine();
    System.Console.WriteLine(age2);


    //this is a calculator app

    System.Console.WriteLine("enter the 1st num");
    string num1 = Console.ReadLine();
    System.Console.WriteLine("enter the 2nd num");
    string num2 = Console.ReadLine();
    Convert.ToInt32(num1);
    Convert.ToInt32(num2);
    int addnum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
    int subnum = Convert.ToInt32(num1) - Convert.ToInt32(num2);
    int mulnum = Convert.ToInt32(num1) * Convert.ToInt32(num2);
    int divnum = Convert.ToInt32(num1) / Convert.ToInt32(num2);

    System.Console.WriteLine($"The sum is {addnum}");
    System.Console.WriteLine($"The sub is {subnum}");
    System.Console.WriteLine($"The mul is {mulnum}");
    System.Console.WriteLine($"The div is {divnum}");


    //this is a madlib
    System.Console.WriteLine("This is the matlib game");
    string third = Console.ReadLine();
    string first = Console.ReadLine();
    string second = Console.ReadLine();
    System.Console.WriteLine($"{first} are red");
    System.Console.WriteLine($"{second} are blue");
    System.Console.WriteLine($"I {third} you");

    //using an array

    int[] arrNumbers = {1 , 2, 3 ,4};
    arrNumbers[3] = 800;
    System.Console.WriteLine(arrNumbers[1]);

    string[] names2 = {"ahmed", "someone" , "noone"};
    names2[2] = "ahmed";
    System.Console.WriteLine(names2[2]);

    string[] newarr = new string[10];
    newarr[9] = "ahmed";
    System.Console.WriteLine(newarr[9]);

    //vfunctions

    static int squr(int num){
        return num * num;
    }
    System.Console.WriteLine(squr(20));

    static double[] arrret(int num1 , int num2 , int num3){
        double[] arraynum = {num1 , num2 , num3};
        return arraynum;
    }
    System.Console.WriteLine(arrret(0 , 1 ,2));

    //if statement
    bool isnotGood = true;
    bool isdecent = true;
    if(isnotGood && !isdecent){
        System.Console.WriteLine("its not good");
    }
    else if(isnotGood && isdecent){
        System.Console.WriteLine("idk it does something");
    }
    else{
        System.Console.WriteLine("its good");
    }

    static void getmax(){

    int min = 10;
    int max = 20;
    if (min < max){
        System.Console.WriteLine($"{max} is bigger than {min}");
    }
    else if(min > max){
        System.Console.WriteLine($"{min} is bigger than {max}");
    }
    else{
        System.Console.WriteLine("try something valid");
    }
    }
    getmax();

    System.Console.WriteLine("better calculator");
    System.Console.WriteLine("enter 2 numbers");
    string num12 = System.Console.ReadLine();
    string num21 = System.Console.ReadLine();
    System.Console.WriteLine("enter a operation + , - , * , /");
    string operation = Console.ReadLine();
    if(operation == "+"){
        int add2 = Convert.ToInt32(num1) + Convert.ToInt32(num2);
        System.Console.WriteLine(add2);
    }
    else if(operation == "-"){
        int sub2 = Convert.ToInt32(num1) - Convert.ToInt32(num2);
        System.Console.WriteLine(sub2);
    }
    else if(operation == "*"){
        int mul2 = Convert.ToInt32(num1) * Convert.ToInt32(num2);
        System.Console.WriteLine(mul2);
    }
    else if(operation == "/"){
        int div2 = Convert.ToInt32(num1) / Convert.ToInt32(num2);
        System.Console.WriteLine(div2);
    }
    else{
        System.Console.WriteLine("enter a valid input");
    }


    System.Console.WriteLine("the switch statement");

    static void GetDay(){
        System.Console.WriteLine("enter the number");
        string dayName;
        int num = Convert.ToInt32(Console.ReadLine());
        switch(num){
            case 1:
                dayName = "Monday";
                System.Console.WriteLine(dayName);
                break;
            case 2:
                dayName = "Tuesday";
                System.Console.WriteLine(dayName);
                break;      
            case 3:
                dayName = "Wednesday";
                System.Console.WriteLine(dayName);
                break;
            case 4:
                dayName = "Thursday";
                System.Console.WriteLine(dayName);
                break;
            case 5:
                dayName = "Friday";
                System.Console.WriteLine(dayName);
                break;
            case 6:
                dayName = "Saturday";
                System.Console.WriteLine(dayName);
                break;
            case 7:
                dayName = "Sunday";
                System.Console.WriteLine(dayName);
                break;
            default:
                System.Console.WriteLine("enter a valid name");
                break;

        }

    }
    GetDay();   

    System.Console.WriteLine("this is while loop");
    int index = 1;
    while(index <= 5){
        System.Console.WriteLine(index);
        index++;
    }
    System.Console.WriteLine("this is do while loop");
    do{
        System.Console.WriteLine(index);
        index++;
    }while(index <= 10);

    System.Console.WriteLine("The guess game");
    string word = "word";
    string guess = "";
    int numtires = 0;
    while(word != guess && numtires <= 2){
        System.Console.WriteLine("Guess the number:");
        guess = Console.ReadLine(); 
        System.Console.WriteLine(numtires);
        numtires++;
        
    }

    System.Console.WriteLine("this is a for loop");
    for(int i = 10 ; i>=1 ; i--){
        System.Console.WriteLine(i);
    }
    int j = 5;
    System.Console.WriteLine("loop starts");
try{
int[] newarr1 = new int[11];
for(int i = 0; i <= newarr1.Length ; i++){
    newarr1[i] = i;
    System.Console.WriteLine(newarr1[i]);
    j--;
}
}
catch(Exception e){
    System.Console.WriteLine(e.Message);
}

System.Console.WriteLine("2d arrays");


/*this is a comment*/

System.Console.WriteLine("exception handling");
try{
    int name3 = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine(name3/0);
}
catch(Exception e){
    System.Console.WriteLine(e.Message);
}
finally{
    System.Console.WriteLine("exception handled");
}

System.Console.WriteLine("classes and obejcts the real thing");

Book person1 = new Book("owo" ,"lahore" , 10);
Book person2 = new Book("ahmed" , "isl" , 20);
person1.name = ":(";

System.Console.WriteLine( person1.isLegal(person1.age10));
System.Console.WriteLine( person2.isLegal(person2.age10));
System.Console.WriteLine(person1.isReallyLegal());
System.Console.WriteLine(person2.isReallyLegal());


System.Console.WriteLine($"THe name is {person1.name} age is {person1.city} and city is {person1.age10}");
System.Console.WriteLine("using constructors");

Movie movie1 = new Movie("Avengers" , "Marvel" , 2019);
Movie movie2 = new Movie("Hobbit" , "WB" , 2018);
System.Console.WriteLine(movie1.Year);
System.Console.WriteLine(movie2.Year);

System.Console.WriteLine(Math1.sqrt(20));

System.Console.WriteLine("this is inheritance");

lower l = new lower();
l.print();
l.print2();
}

class Book{
    public string name;
    public string city;
    public int age10;
    public Book(string aname , string acity , int aage){
        System.Console.WriteLine($"Cons is called {aname} {acity} {aage}");
        name = aname;
        city = acity;
        age10 = aage;

    
    }

    public string isLegal(int userage){
        if(userage>18){
            return "is legal";
        }
        else{
            return "is not legal";
        }
    }
    public bool isReallyLegal(){
        if(age10<18){
            return false;
        }
        else{
            return true;
        }
    }
}
class Movie{
    public string name;
    public string studio;
    private int year;
    public static int totalMovies = 0;

    public Movie(string aname , string astudio , int ayear){
        name = aname;
        studio = astudio;
        Year = ayear;
        totalMovies++;
        System.Console.WriteLine($"Movie added  and total are {totalMovies}");}

    public int Year{
        get{ return year;}
        set{
           if(value == 2019 || value == 2018){
            year = value;
           }
           else{
            year = 2000;
           }
        }
    }
    }
class Math1{
    public static int sqrt(int number){
        return number * number;
    }
}
class upper{
    public void print(){
        System.Console.WriteLine("Hello");
    }
}
class lower : upper{
    public void print2(){
        System.Console.WriteLine("world");
    }
}



