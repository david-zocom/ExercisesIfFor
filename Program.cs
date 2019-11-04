using System;

namespace ExercisesIfFor
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("** Exercises **");

			/* 3.4 Skriv ett program som frågar användaren efter ett lösenord. Hitta på ett hemligt lösenord och spara det i en variabel. När användaren har skrivit in ett ord ska programmet jämföra med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats. */

			//string secretPassword = "1234";
			//Console.WriteLine("Please enter your password: ");
			//string password = Console.ReadLine();
			//if(password == secretPassword)
			//{
			//	Console.WriteLine("Rätt lösenord!");
			//}
			//else
			//{
			//	Console.WriteLine("Fel lösenord :(");
			//}


			/* 4.1 Skriv ett program som skriver ut strängen "Hej!" tre gånger, med hjälp av en loop.
			*/
			//for(int index=0; index < 3; index++)
			//{
			//	Console.WriteLine("Hej!");
			//}

			/* 2 Skriv ett program som skriver ut strängen "Hallå?" och frågar användaren efter en sträng. Detta ska göras om så länge som användaren inte skriver "hej". Dvs om användaren skriver "hej" så ska programmet avslutas. */
			//string inputHello = "";
			//while (inputHello != "hej")
			//{
			//	Console.WriteLine("Hallå?");
			//	inputHello = Console.ReadLine();
			//}
			
			/* 4.4a Skriv ett program som skriver ut de jämna talen 2 till 20, med hjälp av en loop.
			4b Ändra så att programmet skriver ut talen i omvänd ordning, alltså med 20 först. */
			//for (int index=20; index >= 2; index -= 2)
			//{
			//	Console.WriteLine(index);
			//}
			//// foreach( int x in array )


			/* 4.6 Skriv ett program som loopar och frågar användaren efter en sträng. Så länge som strängen inte är en tom sträng eller en punkt så ska programmet lägga ihop den med tidigare strängar, med ett mellanrum. Om användaren t.ex. har skrivit "ord1" tidigare och skriver "ord2" ska den nya strängen bli "ord1 ord2". (Det ska alltså vara ett mellanrum mellan orden.) Fortsätt loopa tills användaren skickar en tom sträng eller en punkt. */

			//Console.WriteLine("Please input words. Empty string or . (dot) to end");
			//string inputWord = Console.ReadLine();
			//string answer = inputWord;
			//while(inputWord != "" && inputWord != ".")
			//{
			//	inputWord = Console.ReadLine();
			//	answer = answer + " " + inputWord;
			//}
			//Console.WriteLine("User input: <" + answer + ">");


			/* 8 Skriv ett program som skriver ut följande rektanglar på konsolen med hjälp av loopar.
			(Uppgifterna med * är lite svårare)
				a			b		c			d		e
			  #-------  #---#---  ##------  --#--#--  #---#---
			  -#------  -#---#--  --##----  --#--#--  -#-#----
			  --#-----  --#---#-  ----##--  ########  --#-----
			  ---#----  ---#---#  ------##  --#--#--  -#-#---- 
			 */
			string outputA = "";
			for(int row=0; row<4; row++)
			{
				outputA = "";
				for ( int column=0; column<8; column++)
				{  // column==4, row==0
					if (column == row)
						outputA += "#";
					else if (column == row + 4)
						outputA += "#";
					else
						outputA += "-";
				}
				//outputA += "\n";
				Console.WriteLine(outputA);
			}
		}
	}
}
