using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    class ProgramUI
    {
        public void Run()
        {
            string buildNumber = "6.8.9";
            string author = "Sharif and Ian";

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("{0}    {1}", author, buildNumber);
            Console.ResetColor();

            Console.WriteLine("Hello and welcome to Sharif and Ian's Wacky MadLib! \n" +
                "Hit 'Enter' to enter the wonderful world of MadLibs!\n" +
                "<------------------------------------------------------------------>");
            Console.ReadLine();
            Menu();
        }
        public void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                Console.Clear();
                Console.WriteLine("Please select a MadLib!\n" +
                    "1. A Weird Vacation\n" +
                    "2. Cold as Ice \n" +
                    "3. Hamilton\n" +
                    "4. Borger\n" +
                    "5. Bless the rains\n" +
                    "6. Exit Application");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        MadLibOne();
                        break;

                    case "2":
                        MadLibTwo();
                        break;

                    case "3":
                        MadLibThree();
                        break;

                    case "4":
                        MadLibFour();
                        break;

                    case "5":
                        BlessTheRains();
                        break;

                    case "6":
                        Console.Clear();
                        Console.WriteLine("Sorry to see you go!\n" +
                            "Press 'Enter' to exit");
                        Console.ReadLine();
                        keepRunning = false;
                        break;

                    default:
                        Console.WriteLine("Please enter a valid menu option.");
                        break;
                }
            }
        }
        private void MadLibOne()
        {
            Console.Clear();

            string adjective, adjective1, noun, noun1, pluralNoun, game, pluralNoun1, verbIng, verbIng1, pluralNoun2, verbIng2, noun2, plant, bodyPart, aPlace, verbIng3, adjective2, number, pluralNoun3;

            Console.WriteLine("Give me an adjective:");
            adjective = Console.ReadLine();

            Console.WriteLine("Give me a word that can refer a person:");
            adjective1 = Console.ReadLine();

            Console.WriteLine("Give me a noun:");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a noun:");
            noun1 = Console.ReadLine();

            Console.WriteLine("Enter a plural noun:");
            pluralNoun = Console.ReadLine();

            Console.WriteLine("Tell me your favorite game:");
            game = Console.ReadLine();

            Console.WriteLine("Enter a plural noun:");
            pluralNoun1 = Console.ReadLine();

            Console.WriteLine("Enter a verb ending in 'ing':");
            verbIng = Console.ReadLine();

            Console.WriteLine("Enter another verb ending in 'ing':");
            verbIng1 = Console.ReadLine();

            Console.WriteLine("Enter a plural noun:");
            pluralNoun2 = Console.ReadLine();

            Console.WriteLine("Enter another verb ending in 'ing':");
            verbIng2 = Console.ReadLine();

            Console.WriteLine("Enter another noun:");
            noun2 = Console.ReadLine();

            Console.WriteLine("Enter your favorite plant:");
            plant = Console.ReadLine();

            Console.WriteLine("Give me a body part:");
            bodyPart = Console.ReadLine();

            Console.WriteLine("Enter a vacation location:");
            aPlace = Console.ReadLine();

            Console.WriteLine("Enter another verb ending in 'ing:");
            verbIng3 = Console.ReadLine();

            Console.WriteLine("Enter an adjective:");
            adjective2 = Console.ReadLine();

            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();

            Console.WriteLine("Finally, give me a plural noun:");
            pluralNoun3 = Console.ReadLine();

            Console.WriteLine(
                "<---------------------------------------------------------------------------------------------------------->\n" +
                "A vacation is when you take a trip to some [" + adjective + "] place with your [" + adjective1 + "] family\n" +
                "Usually you go to some place that is near a / an [" + noun + "] or up on a / an [" + noun1 + "] \n" +
                "A good vacation place is one where you can ride [" + pluralNoun + "] or play [" + game + "]  or go hunting for [" + pluralNoun1 + "] \n" +
                "I like to spend my time [" + verbIng + "] or [" + verbIng1 + "]\n" +
                "When parents go on a vacation, they spend their time eating three [" + pluralNoun2 + "] a day, and\n" +
                "fathers play golf, and mothers sit around [" + verbIng2 + "] \n" +
                "Last summer, my little brother fell in a / an [" + noun2 + "] and got poison [" + plant + "] all over his [" + bodyPart + "] \n" +
                "My family is going to go to(the) [" + aPlace + "] , and I will practice [" + verbIng3 + "] \n" +
                "Parents need vacations more than kids because parents are always very [" + adjective2 + "] and\n" +
                "because they have to work[" + number + "] hours every day all year making enough [" + pluralNoun3 + "] to pay\n" +
                "for the vacation\n" +
                "\n" +
                "\n" +
                "Written By Roger Price & Leonard Stern, MadLibbed by Sharif \n" +
                "\n" +
                "<---------------------------------------------------------------------------------------------------------->\n" +
                "Press 'Enter' to go back to the main menu");
            Console.ReadLine();

        }

        private void MadLibTwo()
        {
            Console.Clear();

            string singularNoun1, pluralNoun1, verb, bodyPart1, singularNoun2, thingNoun, bodyPart2;

            Console.WriteLine("Please enter a singular noun:");
            singularNoun1 = Console.ReadLine();

            Console.WriteLine("Please enter a plural noun:");
            pluralNoun1 = Console.ReadLine();

            Console.WriteLine("Please enter a verb:");
            verb = Console.ReadLine();

            Console.WriteLine("Now, give a body part");
            bodyPart1 = Console.ReadLine();

            Console.WriteLine("Now give me another singular noun:");
            singularNoun2 = Console.ReadLine();

            Console.WriteLine("Type any singular object that comes to mind:");
            thingNoun = Console.ReadLine();

            Console.WriteLine("Finally, give me a body part:");
            bodyPart2 = Console.ReadLine();

            Console.WriteLine(
                "<----------------------------------------------------------------------->\n" +
                "Straight outta Compton, crazy [" + singularNoun1 + "] named Ice Cube\n" +
                "From the gang called [" + pluralNoun1 + "] With Attitudes\n" +
                "When I'm called off, I got a sawed off\n" +
                "Squeeze the trigger, and bodies are hauled off\n" +
                "You too, boy, if ya [" + verb + "] with me\n" +
                "The police are gonna hafta come and get me\n" +
                "Off yo [" + bodyPart1 + "] thats how Im goin out\n" +
                "For the punk [" + pluralNoun1 + "] thats showin out\n" +
                "[" + pluralNoun1 + "] start to mumble, they wanna rumble\n" +
                "Mix em and cook em in a pot like gumbo\n" +
                "Goin off on a [" + singularNoun2 + "]like that\n" +
                "With a" + thingNoun + "thats pointed at yo [" + bodyPart2 + "]!!\n" +
                "\n" +
                "\n" +
                "Written By Ice Cube, MadLibbed by Ian\n" +
                "\n" +
                "<----------------------------------------------------------------------->\n" +
                "Press 'Enter' to go back to the main menu");
            Console.ReadLine();
        }

        private void MadLibThree()
        {
            Console.Clear();

            string adjective, celebrity, noun1, noun2, noun3, noun4, pluralNoun1, pluralNoun2, drink, verb1, verb2;

            Console.WriteLine("Please enter an adjective:");
            adjective = Console.ReadLine();

            Console.WriteLine("Enter a celebrities name:");
            celebrity = Console.ReadLine();

            Console.WriteLine("Enter the first of four nouns:");
            noun1 = Console.ReadLine();

            Console.WriteLine("Enter a second noun:");
            noun2 = Console.ReadLine();

            Console.WriteLine("Enter a third noun:");
            noun3 = Console.ReadLine();

            Console.WriteLine("Enter a fourth noun:");
            noun4 = Console.ReadLine();

            Console.WriteLine("Enter a plural noun:");
            pluralNoun1 = Console.ReadLine();

            Console.WriteLine("Enter a second plural noun:");
            pluralNoun2 = Console.ReadLine();

            Console.WriteLine("Enter a drink:");
            drink = Console.ReadLine();

            Console.WriteLine("Enter a verb:");
            verb1 = Console.ReadLine();

            Console.WriteLine("Lastly, enter a verb:");
            verb2 = Console.ReadLine();

            Console.WriteLine("<----------------------------------------------------------------------->\n" +
                "This is the soliloquy from the play 'Hamlet,' written by [" + celebrity + "].\n" +
                "In the third act of this [" + adjective + "] play, Hamlet, who is sometimes\n" +
                "called 'The Melancholy [" + noun1 + "]' has become suspicious of his stepfather\n" +
                "and hires some actors to act out a scene in which a king is killed\n" +
                "when someone pours [" + noun2 + "] into his [" + drink + "].\n" +
                "First, however, he declaims: To be or not to be: that is the [" + noun3 + "]:\n" +
                "Whether 'tis nobler in the mind to suffer the [" + noun4 + "] and\n" +
                "[" + pluralNoun1 + "] of outrageous fortune, or to take arms against a sea of\n" +
                ", [" + pluralNoun2 + "] and by opposing end them. To die: to sleep; no more;\n" +
                "and by a sleep to say we end the heartache and the thousand natural\n" +
                "[" + pluralNoun1 + "] that flesh is heir to, 'tis a consumation devoutly to\n" +
                "be wish'd. To die, to [" + verb1 + "]; to a: perchance to\n" +
                "[" + verb2 + "] ay, there's the a.\n" +
                "\n" +
                "\n" +
                "Written By William Shakespeare, MadLibbed by Ian\n" +
                "\n" +
                "<----------------------------------------------------------------------->\n" +
                "Press 'Enter' to go back to the main menu");
            Console.ReadLine();

        }

        private void MadLibFour()
        {
            string adjective, adjective2, adjective3, adjective4, verb, sensory, celebrity;

            Console.WriteLine("You are about to enter 4 different adjectives:\n" +
                "Enter the first adjective:");
            adjective = Console.ReadLine();

            Console.WriteLine("Enter the second adjective:");
            adjective2 = Console.ReadLine();

            Console.WriteLine("Enter the third adjective:");
            adjective3 = Console.ReadLine();

            Console.WriteLine("Enter the fourth adjective:");
            adjective4 = Console.ReadLine();

            Console.WriteLine("Enter a verb:");
            verb = Console.ReadLine();

            Console.WriteLine("Enter a sensory (taste, smell, sound, touch)");
            sensory = Console.ReadLine();

            Console.WriteLine("Who is your favorite celebrity?");
            celebrity = Console.ReadLine();

            Console.WriteLine("Oh boy! I can't wait to eat my " + celebrity + " burger!\n" +
                "It looks so " + adjective + ", " + adjective2 + ", " + adjective3 + ", and " + adjective4 + ".\n" +
                "I cant wait to " + verb + "this " + adjective3 + " borger, it " + sensory + "so " + adjective + "!!!!!!!" +
                "\n" +
                "\n" +
                "Who knows, maybe you'll hit the jackpot...Cooked and served by Ian\n" +
                "\n" +
                "<----------------------------------------------------------------------->\n" +
                "Press 'Enter' to go back to the main menu");
            Console.ReadLine();


        }

        private void BlessTheRains()
        {
            string verb, noun, number, mammal, verb2, nounThing;

            Console.WriteLine("Enter a verb:");
            verb = Console.ReadLine();

            Console.WriteLine("Enter a noun, thing, OR person:");
            noun = Console.ReadLine();

            Console.WriteLine("Enter a number:");
            number = Console.ReadLine();

            Console.WriteLine("Enter a noun or mammal:");
            mammal = Console.ReadLine();

            Console.WriteLine("Enter a verb:");
            verb2 = Console.ReadLine();

            Console.WriteLine("Finally, a noun or a thing:");
            nounThing = Console.ReadLine();

            Console.WriteLine("It's gonna take a lot to " + verb + " me away from you\n" +
                "There's nothing that [" + number + "] [" + mammal + "] or more could ever do\n" +
                "I " + verb2 + " the rains down in Africa\n" +
                "Gonna take some time to do the [" + nounThing + "] we never had (ooh, ooh)");

            Console.ReadLine();

        }

    }
}