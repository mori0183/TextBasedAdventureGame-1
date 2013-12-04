﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TextBasedAdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game theGame = new Game();
            theGame.reset();

            theGame.StartGame();

            while (theGame.getPlaying() == true)
            {
                theGame.checkIfValid(Console.ReadLine());
            }
        }
    }

    public class Game
    {
        bool m_Playing = true;
        Location location = new Location();
        Inventory inventory = new Inventory();

        public void reset()
        {
            location.reset();
            inventory.reset();
        }

        private void setPlaying(bool playing)
        {
            m_Playing = playing;
        }

        public bool getPlaying()
        {
            return m_Playing;
        }

        public void checkIfValid(string toCheck)
        {
            location.whereTo(toCheck);
        }

        public void StartGame()
        {
            Console.WriteLine("Fail Corp Presents....");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();

            Console.Beep(200, 400);
            Console.Beep(100, 400);
            Console.Beep(400, 900);

            Console.WriteLine(" _______  _______ _________ _ ");
            Console.WriteLine("|  ____ \\(  ___  )\\__   __/( \\");
            Console.WriteLine("| (    \\/| (   ) |   ) (   | (");
            Console.WriteLine("| (__    | (___) |   | |   | | ");
            Console.WriteLine("|  __)   |  ___  |   | |   | |");
            Console.WriteLine("| (      | (   ) |   | |   | |  ");
            Console.WriteLine("| )      | )   ( |___) (___| (____/\\");
            Console.WriteLine("|/       |/     \\|\\_______/(_______/");

            System.Threading.Thread.Sleep(500);

            Console.WriteLine(" _______           _______  _______ _________");
            Console.WriteLine("(  ___  )|\\     /|(  ____ \\(  ____ \\__   __/");
            Console.WriteLine("| (   ) || )   ( || (    \\/| (    \\/   ) (   ");
            Console.WriteLine("| |   | || |   | || (__    | (_____    | |  ");
            Console.WriteLine("| |   | || |   | ||  __)   (_____  )   | |  ");
            Console.WriteLine("| | /\\| || |   | || (            ) |   | |  ");
            Console.WriteLine("| (_\\ \\ || (___) || (____/\\/\\____) |   | |  ");
            Console.WriteLine("(____\\/_)(_______)(_______/\\_______)   )_(  ");
            Console.Beep(200, 400);
            Console.Beep(100, 400);
            Console.Beep(400, 900);

            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Made by Joel Cright, Nikolai Morin Cull, Andy Lovett, and Greg Coghill");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();

            Console.Clear();
            Console.WriteLine("          Welcome to FAIL QUEST.\nThis text based adventure will test your failure awesomenessness.\n\nYou have just exited the TOWN of Seckly, ");
            Console.WriteLine("it is a hot summer day with a nice cool wind blowing east and everything is ");
            Console.WriteLine("perfect. All of a sudden a shriek comes from the north east of your position.");
            Console.WriteLine("Quickly you spin around and witness a massive DEMON carring a princess to the ");
            Console.WriteLine("castle behind the TOWN you just left.");
            Console.WriteLine("You feel you must do what you can to save the princess from her fate,\nbut you must aquire itams to aid you on your quest.");
            Console.WriteLine("You are facing a path that leads to a beautiful FIELD of tall grass.");
            Console.WriteLine("Behind you is the TOWN of Seckly from which you have just exited.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the TOWN.");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
            Console.WriteLine("");
        }
    }

    public class Location
    {
        string m_Location = string.Empty;
        Inventory inventory = new Inventory();
        bool lookedAround = false;

        public void reset()
        {

        }

        public void setLocation(string location)
        {
            m_Location = location;
        }

        public string getLocation()
        {
            return m_Location;
        }

        public void whereTo(string toHere)
        {
            string action = toHere.ToUpper();
            switch (action)
            {
                case "LOOK AROUND":
                    LookAround();
                    break;

                case "TEST INVENTORY":
                    inventory.testInventory();
                    break;

                case "TEST INVENTORY REMOVE":
                    inventory.testInventoryRemoval();
                    break;

                case "INVENTORY":
                    inventory.printInventory();
                    break;

                case "MILL":
                case "GO TO THE MILL":
                case "GO TO MILL":
                    Mill();
                    break;

                case "BASEMENT":
                case "GO TO BASEMENT":
                case "GO TO THE BASEMENT":
                    Basement();
                    break;

                case "BLACKSMITH":
                case "GO TO THE BLACKSMITH":
                case "GO TO BLACKSMITH":
                    Blacksmith();
                    break;

                case "FIELD":
                case "GO TO FIELD":
                case "GO TO THE FIELD":
                    Field();
                    break;

                case "RIVER":
                case "GO TO THE RIVER":
                case "GO TO RIVER":
                    River();
                    break;

                case "QUARRY":
                case "GO TO QUARRY":
                case "GO TO THE QUARRY":
                    Quarry();
                    break;

                case "FOREST":
                case "GO TO FOREST":
                case "GO TO THE FOREST":
                    Forest();
                    break;

                case "CASTLE":
                case "GO TO CASTLE":
                case "GO TO THE CASTLE":
                    Castle();
                    break;

                case "EXIT":
                    break;

            }
        }

        private void LookAround()
        {
            if (lookedAround == false)
            {
                Console.WriteLine("You look around, and find a rope on the ground nearby!");
                foreach (string inventoryItem in inventory.getInventory())
                {
                    if (inventoryItem == null)
                    {
                        //inventory.Add("Rope");
                        lookedAround = true;
                        return;
                    }

                    else if (inventoryItem == "EndOfInv")
                    {
                        inventory.inventoryFull("Rope");
                        lookedAround = true;
                        return;
                    }
                }
            }

            else
            {
                Console.WriteLine("You've already looked around. There is nothing interesting anymore");
            }
        }

        private void Field()
        {
            Console.Clear();
            Console.WriteLine("As you approach the field you take a deep breath, the fresh air ");
            Console.WriteLine("is relaxing and reminds you of home. The field is covered in daisies, ");
            Console.WriteLine("dandy lions and other miscellaneous flowers. Insects roam the tops of ");
            Console.WriteLine("flowers pollinating, while dragon flies go through their ranks. It is ");
            Console.WriteLine("quite peaceful so you stand and relish in the harmonious atmoshoere. ");
            Console.WriteLine("As you come back to reality you are unsure of the time lost and decide ");
            Console.WriteLine("it's time to continue your quest. You gaze across the field. ");
            Console.WriteLine("Looking across the field, you can see a paths leading East, South and West.");
            Console.WriteLine("To the east lies the RIVER,\nto the south, the MILL,\nand to the west is the FOREST.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the RIVER.");
            Console.WriteLine("Go to the MILL.");
            Console.WriteLine("Go to the FOREST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void River()
        {
            Console.Clear();

            Console.WriteLine("Walking down the path you begin to hear rushing water. As you get ");
            Console.WriteLine("closer the rushing water sounds dangerous. You come out of the woods ");
            Console.WriteLine("and you can finally see the river. The river is flowing at lethal ");
            Console.WriteLine("speed, rapids and white caps deter from trying to cross it. You see ");
            Console.WriteLine("a couple of makeshift tomb stones and this makes the river seem even ");
            Console.WriteLine("more daunting. You can see a tree with a rope that had been cut or ");
            Console.WriteLine("snapped on the other side of the river. You think to yourself \"A ");
            Console.WriteLine(" ROPE would be quite handy right now.\".");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Go to the QUARRY.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");

            //Add an if statement that checks for rope, if rope is in inventory you may cross the river
        }

        private void Quarry()
        {
            bool inQuarry = true;
            bool pickaxe = false;
            bool menDead = false;
            Console.Clear();
            Console.WriteLine("You arrive at the quarry. It is very rocky. You see to quarry workers playing with some rocks, and a man standing over a pulley.\n There is a pickaxe on the ground");

            while (inQuarry == true)
            {
                Console.WriteLine("\nWhat will you do?\n");

                Console.WriteLine("Talk to Workers");
                Console.WriteLine("Talk to Man");
                Console.WriteLine("Search Rocks");
                Console.WriteLine("Take PICKAXE");
                Console.WriteLine("Leave");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "Talk to Workers":
                    case "Talk to workers":
                    case "talk to workers":
                        {
                            if (menDead == true)
                            {
                                Console.WriteLine("The men are dead. This makes it difficult to talk to them.");
                            }
                            else
                            {
                                Console.WriteLine("You approach the working men.\nThey ignore you and maintain their focus on the rocks.");
                            }
                            break;
                        }

                    case "Talk to Man":
                    case "talk to man":
                    case "Talk to man":
                        {
                            if (pickaxe == true)
                            {
                                Console.WriteLine("You approach the strange man...");
                                Console.WriteLine("He sees the pickaxe you are carrying and panics.\n He cuts the pulley and runs,dropping a hammer as he flees.\nThe pulley drops a boudler on the working men, crushing them.\nYou take the hammer");
                                pickaxe = false;
                                menDead = true;
                            }
                            else
                            {
                                Console.WriteLine("You approach the strange man...");
                                Console.WriteLine("He looks over your puny form and chuckles to himself. \nYou are no threat to him. He ignores you.");
                            }
                            break;
                        }
                    case "Search Rocks":
                        {
                            Console.WriteLine("You search through a pile of rocks. \nFoolishly, you disrupt a much larger pile, which is actually a small part\n of an even bigger pile. They tumble onto you, crushing you.");
                            System.Threading.Thread.Sleep(3000);
                            inQuarry = false;
                            gameOver();
                            break;
                        }

                    case "Take pickaxe":
                    case "Take Pickaxe":
                    case "take pickaxe":
                    case "Take PICKAXE":
                    case "take PICKAXE":
                    case "PICKAXE":
                        {
                            Console.WriteLine("You take the pickaxe. It is rather hefty, considering you are so weak and puny.");
                            System.Threading.Thread.Sleep(4000);
                            pickaxe = true;
                            break;
                        }

                    case "Leave":
                    case "leave":
                        {
                            Console.WriteLine("You exit the quarry. On your way back across the river, you lose your rope.");
                            System.Threading.Thread.Sleep(4000);
                            inQuarry = false;
                            Console.Clear();
                            break;
                        }
                    default:
                        Console.WriteLine("Thy does not compute. Try again");
                        break;
                }
            }
        }

        private void Mill()
        {
            Console.Clear();
            Console.WriteLine("A path from the field leads into a thin lining of trees. Behind the trees ");
            Console.WriteLine("you see an old MILL factory, it is very frail from wheather and time. you ");
            Console.WriteLine("walk to the old door that is barely hanging on to it's hinges, and slowly ");
            Console.WriteLine("push it open. The door opens half way then falls flat on the ground making ");
            Console.WriteLine("a loud BANG! Dust fills the air, but settles quickly. There is some old ");
            Console.WriteLine("equipment scattered about, and some remains of animals. There is an intact ");
            Console.WriteLine("door that leads to the BASEMENT to your left and a CHEST to your right.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Go to the BASEMENT.");
            Console.WriteLine("Open the CHEST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "Open the chest":
            //        if(you got da key nigga)
            //        {
            //            //OPEN DAT MUFUCKIN CHIEST
            //            Chest();
            //            break;
            //        }
            //}
        }

        private void Chest()
        {
            Console.Clear();
            Console.WriteLine("You find a gypsy and a rope");
            Console.ReadLine();
            Mill();
        }

        private void Forest()
        {
            Console.Clear();
            Console.WriteLine("The FOREST is dark and crawling with danger. There is a small narrow ");
            Console.WriteLine("path leading into the arbour of death. As you enter, you hear something ");
            Console.WriteLine("scamper across the root riden ground ten feet in front of you, but you ");
            Console.WriteLine("cannot see what is was as it is dark as shit. You continue your trek ");
            Console.WriteLine("into the woods when you come across an opening. A small field of short ");
            Console.WriteLine("grass and blue sky over head from the lack of trees.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Basement()
        {
            Console.Clear();
            Console.WriteLine("You open the door and head down the old rickety stairs to the BASEMENT.");
            Console.WriteLine("The further down you go the less you can see until nothing is visible.");
            Console.WriteLine("When you reach the last step you hear loud laboured breathing. The ");
            Console.WriteLine("breathing becomes louder and louder until it sounds like it is directly ");
            Console.WriteLine("in front of you. All of a sudden you hear a deafening hiss, then big red ");
            Console.WriteLine("eyes appear in font of you. Out of complete shock you wet your pants, shriek ");
            Console.WriteLine("and run back up the stairs and slam the door behind you. You can hear the ");
            Console.WriteLine("stairs cumble and fall apart behind the door. This calms you a little, but now ");
            Console.WriteLine("you have wet pants and reek of urine.\n");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the FIELD.");
            Console.WriteLine("Open the CHEST.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Town()
        {
            Console.Clear();
            Console.WriteLine("You enter the town and the smell of baked goods and leather assult ");
            Console.WriteLine("your nostrils. The pleasant and familiar smell relaxes you and calms ");
            Console.WriteLine("you. The market is packed with people at every shop and commotion fills ");
            Console.WriteLine("air. To your left is the BLACKSMITH's, to your right is the TAVERN and ");
            Console.WriteLine("in front of you lies the gates to the CASTLE.");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Go to the BLACKSMITH.");
            Console.WriteLine("Go to the TAVERN.");
            Console.WriteLine("Go to the CASTLE.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
        }

        private void Blacksmith()
        {
            bool inBlacksmith = false;
            bool gotGem = false;
            bool angryBlacksmith = true;
            Console.Clear();
            Console.WriteLine("You walk through the town and approach the BLACKSMITH's corner, the smell ");
            Console.WriteLine("of hot metal and smoke destroy the previous smell of baked goods from your ");
            Console.WriteLine("nostrils. You walk up to the BLACKSMITH and he glares at you with his one ");
            Console.WriteLine("eye, the other eye is covered with an eye patch from a recent accident.");
            Console.WriteLine("The BLACKSMITH grumbly asks you what you want.\n");
            while (inBlacksmith == true)
            {
                Console.WriteLine("What will you do?\n");

                Console.WriteLine("Tell the BLACKSMITH you don't like his face");
                Console.WriteLine("Talk to Blacksmith");
                Console.WriteLine("Look around");
                Console.WriteLine("Check INVENTORY");
                Console.WriteLine("Go to the TOWN");
                string input = Console.ReadLine();

                switch (input)
                {
                        //You are an idiot. Have fun dying
                    case "Tell the BLACKSMITH you don't like his face":
                    case "Tell the Blacksmith you don't like his face":
                    case "tell the blacksmith you dont like his face":
                    case "tell the blacksmith you don't like his face":
                        {
                            Console.Clear();
                            Console.WriteLine("The already miserable blacksmith, insulted by your words, is clearly not happy.He hurls his white-hot hammer across the room,\n and the hammer-head collides with your forehead, cracking your head wide open. ");
                            System.Threading.Thread.Sleep(4000);
                            inBlacksmith = false;
                            gameOver();
                            break;
                        }

                        //Got the gem? He lets you keep it
                    case "Talk to Blacksmith":
                    case "Talk to blacksmith":
                    case "talk to Blacksmith":
                    case "talk to blacksmith":
                        {
                            Console.WriteLine("");
                            break;
                        }

                        //You find a gem. Its pretty
                    case "look around":
                    case "Look around":

                        {

                            Console.WriteLine("You take a look around the blacksmith's workplace.\n After rudely sifting through various piles of stuff, you find a large, shiny gemstone.\nYou take it.");
                            
                            break;
                        }

                        //You check your stuff
                    case "Check INVENTORY":
                    case "Check inventory":
                    case "Check Inventory":
                    case "check INVENTORY":
                        {

                            break;
                        }

                        //Got the gem? If you didnt talk to the blacksmith after finding it, he kills you. Otherwise you're fine
                    case "Go to the TOWN":
                    case "go to the town":
                    case "go to the Town":
                    case "go to the TOWN":
                    case "Go to the Town":
                    case "Go to the town":
                        {
                            if (angryBlacksmith == true)
                            {
                                Console.WriteLine("You attempt to leave with the gem in hand when the blacksmith accuses you of theivery, which you are guilty of.\n He hurls a spear across the room, impaling your weak body.");
                                System.Threading.Thread.Sleep(4000);
                                gameOver();
                                inBlacksmith = false;
                                break;
                            }
                            else
                            {
                                Town();
                                inBlacksmith = false;
                                break;
                            }
                        }


                }
            }
        }

        private void Tavern()
        {
            int broseph = 0;
            bool inTavern = true;
            //Required bools
            //TODO: Item from drunk man
            Console.WriteLine("You walk into a tavern. You see many patrons and wenches. You notice a large man at the bar\n");

            while (inTavern == true)
            {
                Console.WriteLine("What will you do?\n");
                Console.WriteLine("Fight Man");
                Console.WriteLine("Talk to Man");
                Console.WriteLine("Drink with Man");
                Console.WriteLine("Leave");
                Console.WriteLine(": ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "Fight Man":
                    case "Fight man":
                    case "fight man":
                        {
                            Console.WriteLine("You point to the man and challenge his manliness.He immediately gets up,\nbrandishes an large axe, and removes your head from your shoulders.");
                            System.Threading.Thread.Sleep(3000);
                            inTavern = false;
                            gameOver();
                            break;
                        }
                    case "Talk to Man":
                    case "talk to man":
                    case "Talk to man":
                        {
                            Console.WriteLine("You approach the man and attempt to initiate a meaningful conversation...\n");
                            if (broseph > 1)
                            {
                                Console.Beep(300, 300);
                                Console.Beep(200, 300);
                                Console.Beep(300, 800);
                                Console.WriteLine("After a few minutes of chatting about wenches and alcohol.");
                                Console.WriteLine("He then passes out and falls to the ground.\n A key falls from his pocket. You take it.");
                                //Shit happens. Aw yiss
                                break;
                            }
                            else
                            {
                                Console.WriteLine("He scoffs at your scrawny form and turns his attention to something in the room that isn't as puny as you.\n");
                                //Nothing happens. Must be more bro-like
                                break;
                            }
                        }
                    case "Drink with Man":
                    case "drink with man":
                    case "Drink with man":
                        {
                            Console.WriteLine("You walk up to the bar and order a drink for the man with the fine,\n sculpted muscles. He gives you a heavy pat on the back and thanks you.");
                            broseph += 1;
                            //You become bros
                            break;
                        }

                    case "Leave":
                    case "leave":
                        {
                            Console.Clear();
                            inTavern = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Thy does not compute. Try again, fool!");
                            break;
                        }
                }
            }
        }

        private void Castle()
        {
            bool enchantedHammer = true;
            Console.Clear();
            Console.WriteLine("You unlock the gates and they open slow, but steadily. You walk up to the castle");
            Console.WriteLine("door and knock using the skull door knocker. You can hear the sound echoing ");
            Console.WriteLine("behind the door. The door suddenly swings open and a cold wind blows past you ");
            Console.WriteLine("from inside. The wind is cold and smells of rotton corpses. You muster the ");
            Console.WriteLine("courage and enter the castle. When you enter you can see the main hall and the ");
            Console.WriteLine("dusty dinning table, indicating the lack of use for a long period of time. ");
            Console.WriteLine("Suddenly a shriek coming from up stairs startles you. You sprint up the stairs and");
            Console.WriteLine("you see a door with a light source coming from the bottom of the door. You run to ");
            Console.WriteLine("the door and barge in. You seethe DEMON from the beginning of the game. It ");
            Console.WriteLine("smirkingly glares at you as if it was expecting you. ");
            Console.WriteLine("What do you choose to do?");
            Console.WriteLine("Challenge the DEMON toa duel, YU GI OH style!");
            Console.WriteLine("Bitch slap the DEMON and take the princess home to make sticky.");
            Console.WriteLine("Look around.");
            Console.WriteLine("Check Inventory.");
            string input = Console.ReadLine();


            switch (input.ToUpper())
            {
                case "CHALLENGE DEMON":
                    Console.WriteLine("The Demon laughs at you, then bites your head off!");
                    gameOver();
                    break;

                case "HAMMER":
                    if (enchantedHammer == true)
                    {
                        Console.Clear();
                        Console.WriteLine("You throw the hammer at the DEMON, it catches the HAMMER ");
                        Console.WriteLine("and throws it back at you. You explode.");
                        gameOver();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You do not possess the HAMMER.");
                        Castle();
                        break;
                    }

                case "BITCH SLAP THE DEMON":
                case "SLAP DEMON":
                    Console.Clear();
                    Console.WriteLine("You bitch slap the DEMON, point your finger at it and growl ");
                    Console.WriteLine("NO!, BAD DEMON! The DEMON bows it's head in shame and flies ");
                    Console.WriteLine("away.");
                    System.Threading.Thread.Sleep(4000);
                    gameWin();
                    break;
            }
        }

        private void gameWin()
        {
            Console.Clear();
            Console.WriteLine("You have defeated the DEMON and rescued the princess from her grizzly fate. ");
            Console.WriteLine("YAY!");
            Console.WriteLine("          _______                     _________ _       ");
            Console.WriteLine("|\\     /|(  ___  )|\\     /|  |\\     /|\\__   __/( (    /|");
            Console.WriteLine("( \\   / )| (   ) || )   ( |  | )   ( |   ) (   |  \\  ( |");
            Console.WriteLine(" \\ (_) / | |   | || |   | |  | | _ | |   | |   |   \\ | |");
            Console.WriteLine("  \\   /  | |   | || |   | |  | |( )| |   | |   | (\\ \\) |");
            Console.WriteLine("   ) (   | |   | || |   | |  | || || |   | |   | | \\   |");
            Console.WriteLine("   | |   | (___) || (___) |  | () () |___) (___| )  \\  |");
            Console.WriteLine("   \\_/   (_______)(_______)  (_______)\\_______/|/    )_)");
        }

        private void gameOver()
        {
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine("======= You have died =======");
            Console.WriteLine("         _,.-------.,_");
            Console.WriteLine("     ,;~'             '~;,");
            Console.WriteLine("   ,;                     ;,");
            Console.WriteLine("  ;                         ;");
            Console.WriteLine(" ,'                         ',");
            Console.WriteLine(",;                           ;,");
            Console.WriteLine("; ;      .           .      ; ;");
            Console.WriteLine("| ;   ______       ______   ; |");
            Console.WriteLine("|  `/~*     ~* . *~     *~\\'  |");
            Console.WriteLine("|  ~  ,-~~~^~, | ,~^~~~-,  ~  |");
            Console.WriteLine(" |   |        }:{        |   |");
            Console.WriteLine(" |   l       / | \\       !   |");
            Console.WriteLine(" .~  (__,.--* .^. *--.,__)  ~.");
            Console.WriteLine(" |     ---;' / | \\ `;---     |");
            Console.WriteLine("  \\__.       \\/^\\/       .__/");
            Console.WriteLine("   V| \\                 / |V");
            Console.WriteLine("    | |T~\\___!___!___/~T| |");
            Console.WriteLine("    | |`IIII_I_I_I_IIII'| |");
            Console.WriteLine("    |  \\,III I I I III,/  |");
            Console.WriteLine("     \\   `~~~~~~~~~~'    /");
            Console.WriteLine("       \\   .       .   /   ");
            Console.WriteLine("         \\.    ^    ./");
            Console.WriteLine("           ^~~~^~~~^");
            Console.Beep(300, 300);
            Console.Beep(200, 300);
            Console.Beep(100, 800);
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            reset();
        }
    }

    public class Inventory
    {
        Hashtable inventory = new Hashtable();
        string inventoryItem = string.Empty;
        int inventoryKey = 0;

        public void reset()
        {

        }

        public void printInventory()
        {
            Console.WriteLine("INVENTORY");
            foreach (string inventoryitem in inventory.Keys)
            {
                Console.WriteLine(inventoryitem.ToUpper());
            }
        }

        public void testInventory()
        {
            for ( ; inventoryKey < 3; inventoryKey++)
            {
                inventory.Add("Item " + inventoryKey, inventoryKey);
            }
        }

        public void testInventoryRemoval()
        {
            for ( int i = 0; i < inventoryKey; i++)
            {
                inventory.Remove("Item " + i);
            }

            inventoryKey = 0;
        }

        public void addToInventory(string item)
        {
            if (inventoryKey >= 3)
            {
                inventoryFull(item);
            }
            else
            {
                inventory.Add(item, inventoryKey);
                inventoryKey++;
            }
        }

        public Hashtable getInventory()
        {
            return inventory;
        }

        public void inventoryFull(string itemToGet)
        {
            Console.WriteLine("Your inventory is full. You'll have to drop an item to pick up that " + itemToGet + ".");
            foreach (DictionaryEntry inventoryitem in inventory)
            {
                Console.WriteLine(inventoryitem.Value as string);
            }

            string thingToDrop = Console.ReadLine();

            foreach (string inventoryitem in inventory)
            {
                if (inventoryitem == thingToDrop)
                {
                    inventory.Remove(thingToDrop);

                }

                else
                {
                    continue;
                }
            }
        }

        public void removeFromInventory(string itemToRemove)
        {
            inventory.Remove(itemToRemove);
        }
    }
}

