using System;

class Program
{
    public static void Main(string[] args)
    {
        int room = 1; //This keeps track of what room the player is in. 
        string response = ""; //This keeps track of what the player wants to do
        bool gameFinished = false;
        bool hasKeys = false;
        bool PunchDog = false;
        bool PunchZombie = false;
        Console.WriteLine(" The objective of this game is to find the two keys and escape the house before you die.");

        //While they are still playing let them type in new responses
        while (gameFinished == false)
        {
            Console.WriteLine(" What would you like to do?");
            response = Console.ReadLine();

            if (response.Equals("help"))
            {

            }
            else if (response.Equals("i"))
            {

            }
            else
            {
                switch (room)
                {
                    case 1:
                        switch (response)
                        {
                            case "go north":

                                Console.WriteLine("You go to the north. You hear a growling noise.");
                                room = 4;
                                break;

                            case "go east":
                                Console.WriteLine("You go to the east.");
                                room = 2;
                                break;

                            case "go up":
                                Console.WriteLine("You go up the stairs.");
                                room = 5;
                                break;

                            case "see":
                                Console.WriteLine("You are in a room with a door to the north, a door to the east, a staircase that goes up, and an escape door.");
                                room = 1;
                                break;

                            default:
                                Console.WriteLine("I no understand.");
                                break;

                            case "go to escape door":
                                Console.WriteLine("You went to the escape door.");
                                room = 6;
                                break;
                        }
                        break;
                    case 2:
                        switch (response)
                        {
                            case "See":
                                Console.WriteLine("You are in a room with a door in front of you.");
                                break;

                            case "go through door":
                                Console.WriteLine("You went through the door. You see the last key across the room but there is a gaurd dog in front of it.");
                                room = 3;
                                break;
                        }
                        break;

                    case 3:
                        switch (response)
                        {
                            case "turn around":
                                Console.WriteLine("You leave the east room.");
                                room = 1;
                                break;

                            case "fight dog":
                                Console.WriteLine("punch or kick?");
                                room = 3;
                                break;

                            case "punch":
                                Console.WriteLine("You punch the gaurd dog and knock him out.");
                                room = 3;
                                PunchDog = true;
                                break;

                            case "leave east room":
                                Console.WriteLine("You have left the east room.");
                                room = 1;
                                break;

                            case "get key":
                                if (PunchDog)
                                {
                                    Console.WriteLine(" You get the key");
                                    hasKeys = true;
                                }
                                else
                                {
                                    Console.WriteLine("You need to fight the dog.");
                                }
                                break;

                            case "kick":
                                Console.WriteLine("You kick the dog but he bites you back and you die.");
                                room = 3;
                                gameFinished = true;
                                break;

                            default:
                                Console.WriteLine("I no understand.");
                                break;
                        }
                        break;
                    case 4:
                        switch (response)
                        {
                            case "continue":
                                Console.WriteLine("You continue through the north room. The growling gets louder. You see a key on the other side of the room.");
                                room = 4;
                                break;

                            case "go to key":
                                Console.WriteLine("You begin walking to the other side of the room when you see something out of the corner of your eye. It's a Zombie. ");
                                room = 4;
                                break;

                            case "run away":
                                Console.WriteLine("You run out of the North room slamming the door behind you.");
                                room = 1;
                                break;
                            
                            case "fight zombie":
                                Console.WriteLine("Punch or Kick.");
                                room = 4;
                                break;

                            case "Kick":
                                Console.WriteLine("You kick the Zombie but he grabs you and strangles you. You die.");
                                room = 4;
                                gameFinished = true;
                                break;

                            case "Punch":
                                Console.WriteLine("You punch the Zombie, killing him.");
                                PunchZombie = true;
                                break;

                            case "pick up key":
                                if (PunchZombie)
                                {
                                    Console.WriteLine(" You pick up the key");
                                    hasKeys = true;
                                }
                                else
                                {
                                    Console.WriteLine("You need to fight the zombie.");
                                }
                                break;

                            case "exit north room":
                                Console.WriteLine("You exit the North room.");
                                room = 1;
                                break;

                            default:
                                Console.WriteLine("I no understand.");
                                break;
                        }
                        break;
                    case 5:
                        switch (response)
                        {
                            case "look":
                                Console.WriteLine("You are in a room with a window and stairs that go down.");
                                room = 5;
                                break;

                            case "go down":
                                Console.WriteLine("You go back down the stairs.");
                                room = 1;
                                break;

                            case "jump out window":
                                Console.WriteLine("You jumped out the window and died.");
                                room = 5;
                                gameFinished = true;
                                break;

                            default:
                                Console.WriteLine("I no understand.");
                                break;
                        }
                        break;


                    case 6:
                        switch (response)
                        {
                            case "unlock escape door":
                                if (hasKeys)
                                {
                                    Console.WriteLine(" You have escaped congratulations!");
                                    hasKeys = true;
                                    gameFinished = true;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("You need to find the two keys before you can unlock the escape door.");
                                    room = 1;
                                }
                                break;

                        }
                        break;

                        Console.WriteLine("You WIN!");
                        gameFinished = true;
                        break;


                }//Room Switch
            }//Help/Inv else
        } //Game Finished Loop

    }

}