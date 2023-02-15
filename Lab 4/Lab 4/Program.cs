//start main 
int userChoice = GetUserChoice();
RouteEm(userChoice);
 //end main

static int GetUserChoice(){
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if(IsValidChoice(userChoice)){
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    System.Console.WriteLine("Enter 1 for a full triangle");
    System.Console.WriteLine("Enter 2 for a partial triangle");
    System.Console.WriteLine("Enter 3 to exit");
}

static bool IsValidChoice(String userInput){
    if(userInput == "1"|| userInput == "2"||userInput == "3"){
         return true;
    }
    return false;

}

static void GetFull(){
    Random rnd = new Random();
    int rows = rnd.Next(4,10);
    for(int a = 0; a < rows; a++){
        for(int b = 0; b < a; b++){
        System.Console.Write("O");
        }
    System.Console.WriteLine("\n");
    }

}

static void GetPartial(){
    Random rnd = new Random();
    int rows = rnd.Next(4,10);
    for(int a = 0; a < rows; a++){
        for(int b = 0; b < a; b++){
            int d = rnd.Next(2);
            if(Random(d)){
                System.Console.Write("O");
            }
            else{
                System.Console.Write(" ");
            }
        }
    System.Console.WriteLine("\n");
    }
}

static bool Random(int c){
    if(c == 0){
        return true;
    }
    else{
        return false;
    }
}

static void Exit(){
 Console.Clear();
}

static void SayInvalid(){
        System.Console.WriteLine("Sorry your choice is invalid");
        PauseAction();
}

static void RouteEm(int menuChoice){
    if(menuChoice == 1){
        GetFull();
    }
    else if(menuChoice == 2){
        GetPartial();
    }
    else if(menuChoice == 3){
        Exit();
    }
    else{
        SayInvalid();
    }
}

static void PauseAction(){
    System.Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
}
