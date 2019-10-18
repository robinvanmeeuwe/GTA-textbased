using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myadventure1 : MonoBehaviour
{
    private enum States
    {
        start,
        ShowMainMenu,
        character,
        begin,
        car,
        drive,
        cops,
        ontsnapping,
        settings,
        characters,
        frontdoor,
        backdoor,
        OnUserInput,
        bank,
        bank1,
        bank2,
        robbingdead,
        fence,
        randomshit,
        gunshop,
        won
        
        

    }

    private string character = "(Trevor Philips)";
      
    


    private States currentState = States.start;
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }


void OnUserInput(string input)
    {
    switch(currentState)
    {
        case States.ShowMainMenu: 
        if(input =="start")
        {
            begin();
        }
                       
        else if(input =="settings")
        {
            settings();
        }
        else if(input == "characters")
        {
            characters();
        }
        else
        {
            ShowMainMenu();
        }
        break;
     
        case States.character:

        if (input == "trevor philips")
        {
            Terminal.WriteLine("good choice");
            character = "Trevor Philips";
        }

        else if (input == "carl johnson")
        {
            Terminal.WriteLine("good choice");
            character = "Carl Johnson";
        }

        else if (input == "michael de santa")
        {
             Terminal.WriteLine("good choice");
             character = "Michael De Santa";
        }
     

        else if(input == "back")
        {
            ShowMainMenu();
        }
        
        break;
            
    
    
    
        case States.settings:
        if(input =="back")
        {
            ShowMainMenu();
        }
        break;

    
    
        case States.begin:
        if(input =="go through the frontdoor")
        {
            frontdoor();
        }

        else if(input == "go through the backdoor")
        {
            backdoor();
        }
        

        else if(input =="get the dog")
        {
            Terminal.WriteLine("you have the dog on a leash now.");
        }
        break;
        
    
    
        case States.frontdoor:
        if(input == "steal a car") 
        {
            car();
        }

        else if(input =="go walking to the bank")
        {
            bank();
        }
        break;
    
    
    
        case States.backdoor:
        if(input == "climb over your garden fence")
          {
              fence();
          }

        else if(input=="start shooting at random shit")
        
        
        {
            randomshit();
        }
        break;
    
    
    
        case States.car:
        if(input == "shoot at the cops")
        {
            cops();
        }

        else if(input=="try to drive away")
        {
            drive();
        }
        break;
    
    
    
        case States.bank:
        if(input == "go back home")
        
        {
            frontdoor();
        }

        else if(input =="rob the bank")
        {
            robbingdead();
        }
        break;
    
    
    
        case States.fence:
        if(input == "play again")
        {
            begin();
        }
        else
        {
            begin();
        }
        break;   
    
        case States.randomshit:
        if(input == "play again")
        {
            begin();
        }
        else
        {
            begin();
        }
        break;
    
    
    
        case States.cops:
        if(input == "play again")
        {
            begin();
        }
        else
        {
            begin();
        }
        break;

        case States.robbingdead:
        if(input== "play again")
        {
            begin();
        }
        else
        {
            begin();
        }
        break;

        case States.drive:
        if( input== "drive to the bank")
        {
            bank1();
        }
        else if(input=="drive to the gunshop")
        {
            gunshop();
        }
        break;

        case States.bank1:
        if(input=="rob the bank")
        {
            robbingdead();
        }
        else if(input == "drive back to the gun shop")
        {
            gunshop();
        }
        break;

        case States.gunshop:
        if(input=="buy an ak-47")
        {
             Terminal.WriteLine("");
             Terminal.WriteLine("succesfully bought the ak-47");
            Terminal.WriteLine("-400$ balance");
        }
        else if(input=="drive to the bank")
        {
            bank2();
        }
        break;
        case States.bank2:
        if(input=="rob the bank")
        {
            won();
        }
        else if(input=="drive back to the gun shop")
        {
            gunshop();
        }
        break;

        case States.won:
        if(input=="play again")
        {
            ShowMainMenu();
        }
        break;
    }
    }
    
void ShowMainMenu()
{
    currentState =  States.ShowMainMenu;
    Terminal.ClearScreen();
    Terminal.WriteLine("GTA textbased");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices");
    Terminal.WriteLine("");
    Terminal.WriteLine("start   characters  settings");
    Terminal.WriteLine("");
    
}
void characters()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("characters:");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("Trevor Philips,  Carl Johnson,  Micheal De Santa,");
    Terminal.WriteLine("");
    Terminal.WriteLine("back");
    Terminal.WriteLine("");
    currentState = States.character;
}
void settings()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("settings");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("back");
    Terminal.WriteLine ("");
    currentState = States.settings;

}
void begin()
{   
    Terminal.ClearScreen();
    Terminal.WriteLine("welcome in the hood " + character + "!");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("1.go through the frontdoor 2.go through the backdoor, 3.get the dog,");
    Terminal.WriteLine("");
    currentState = States.begin;
}

void frontdoor()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("your mission is to succesfully rob the bank.");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("1.steal a car 2. go walking to the bank");
    currentState = States.frontdoor;
}
void backdoor()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("welcome in your garden.");
    Terminal.WriteLine ("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine ("");
    Terminal.WriteLine ("1. climb over your garden fence. 2.start shooting at random shit.");
    currentState = States.backdoor;
    
}
void car()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("you have succefully stolen the car but the police are on to you.");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("1.shoot at the cops 2.try to drive away ");
    currentState = States.car;
} 
void bank()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("welcome at the bank");
    Terminal.WriteLine("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine("");
    Terminal.WriteLine("1.rob the bank 2.go back home");
    currentState = States.bank;
}
void fence()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you stept in your neihbors garden, he shot you dead.");
    Terminal.WriteLine("you died");
    Terminal.WriteLine ("");
    Terminal.WriteLine("type: play again");
    Terminal.WriteLine ("");
    currentState =States.fence;
}
void randomshit()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you have shot yourself");
    Terminal.WriteLine ("you died");
    Terminal.WriteLine("");
    Terminal.WriteLine ("type: play again");
    Terminal.WriteLine ("");
    currentState =States.randomshit ;
    
}
void cops()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you lose the fight");
    Terminal.WriteLine ("you died");
    Terminal.WriteLine("");
    Terminal.WriteLine ("type: play again");
    Terminal.WriteLine ("");
    currentState =States.cops ;
    
}
void drive()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you have escaped the police");
    Terminal.WriteLine ("");
    Terminal.WriteLine("choice:");
    Terminal.WriteLine ("");
    Terminal.WriteLine ("1. drive to the bank 2.drive to the gunshop");
    currentState = States.drive;
    
}
void bank1()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("welcome at the bank");
    Terminal.WriteLine ("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine ("");
    Terminal.WriteLine ("1. rob the bank 2.drive back to the gun shop");
    currentState = States.bank1;
    
}
void robbingdead()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you have been shot by the bankgaurd cause your gun refused.");
    Terminal.WriteLine ("you died");
    Terminal.WriteLine("");
    Terminal.WriteLine ("type: play again");
    Terminal.WriteLine ("");
    currentState = States.robbingdead;
    
}
void gunshop()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("welcome at the gunshop");
    Terminal.WriteLine ("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine ("");
    Terminal.WriteLine ("1. buy an ak-47 2.drive to the bank");
    currentState = States.gunshop;
}


void bank2()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("welcome at the bank");
    Terminal.WriteLine ("");
    Terminal.WriteLine("choices:");
    Terminal.WriteLine ("");
    Terminal.WriteLine ("1. rob the bank 2.drive back to the gun shop");
    currentState = States.bank2;
}
void won()
{
    Terminal.ClearScreen();
    Terminal.WriteLine ("you have robbed the bank succesfully");
    Terminal.WriteLine ("you won the game");
    Terminal.WriteLine("");
    Terminal.WriteLine ("type: play again");
    Terminal.WriteLine ("");
    currentState = States.won;
}
}