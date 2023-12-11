//uint Bigvalue = 4294967294;
//int Smallvalue = (int)Bigvalue;

//int test = -10;
//int test2 = 10;
//bool Mybool = Convert.ToBoolean(test2);

/*bool passwordSecurized = false;

string password = "secured";

string readfromconsole = Console.ReadLine();


if (password == readfromconsole) 
{
    passwordSecurized = true;         
}
else 
{
    passwordSecurized = false;
}
if (passwordSecurized == true) 
{
    Console.WriteLine("passwordSecurized");
}
else 
{
    Console.WriteLine("bad password");
}*/

/*uint remaningDistance = 0;
uint hotelDistance = 2;
bool reachDistance = false;

if (remaningDistance <  hotelDistance)
{
    reachDistance = true;
}
else
{
    remaningDistance = remaningDistance++;

    if (hotelDistance < remaningDistance)
    {
        reachDistance = true;
    }
}*/


/*int nbMaxProjectiles = 5;

for(int Projectiles = 0;Projectiles <= nbMaxProjectiles;Projectiles++) 
{
    Console.WriteLine(Projectiles);
}*/

/*int projectiles = 0;
int nbMaxProjectiles = 5;
while(projectiles < nbMaxProjectiles)
{
    Console.WriteLine(projectiles);
    projectiles++;
}*/
/*int nbMaxProjectiles = 5;
for ( int Projectiles = 0; Projectiles<= nbMaxProjectiles;Projectiles++)
{
    Console.WriteLine(Projectiles);
    if (Projectiles == 3) 
    {
        Console.WriteLine("cool");
    }
}*/

/*int Projectiles = 0;
int nbMaxProjectiles = 5;
while (Projectiles < nbMaxProjectiles) 
{
    Console.WriteLine(Projectiles);
    if (Projectiles == 3)
    {
        Console.WriteLine("cool");
    }
    Projectiles++;
}*/

/*bool emetteur = false;
bool recepteur = true;

if (emetteur && recepteur == true)
{
    Console.WriteLine("Communication");
}
else
{
    Console.WriteLine("Pas en Communication");
}*/
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Carte
    {
        public Carte(string p_CarteName) 
        {
            CarteName = p_CarteName; 
        }
        private string CarteName;
    }
    class Deck 
    {
        /*public Carte? SearchCard(Carte toFind)
        {
            for (int i = 0;i<carteList.Count;i++)
            {

            }
        }*/
        public Carte? DrawCard() 
        {
            Carte? temp;
            if (carteList.Count != 0) 
            {
                temp = carteList.Last();
                RemoveCard(temp);
                return temp;
            }
            else 
            {
                return null;
            }
            
        }
        public void RemoveCard(Carte carte) 
        {
            carteList.Remove(carte);
        }
        public void AddCard(Carte carte) 
        {
            if (carteList.Count == CardNumber) 
            {
                return;
            }
            carteList.Add(carte);
        }
        public Deck(string p_DeckName, int CardNumber) 
        {
            DeckName = p_DeckName;
        }
        private List<Carte> carteList = new List<Carte>();
        private string DeckName ;
        private int CardNumber ;
    }
    internal class Program
    {

        static bool Contains(List<string> list , string toFind) 
        {
            
            
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == toFind)
                {
                    return true;
                }

            }
            return false;
        }
        static int Mutiply(int number1, int number2)
        {
            return number1* number2;
        }
        static void Main(string[] args)
        {
            
            
            
            
            
            
            /*Deck myDeck = new Deck(" Satoru Gojo",60);

            Carte myCarte1 = new Carte("expansion du territoire, Sphere de l'Espace Infini");
            Carte myCarte2 = new Carte("sort inversé, Rouge");
            Carte myCarte3 = new Carte("equation imaginaire, Violet");
            Carte myCarte4 = new Carte("sort originel, Bleu");
            myDeck.AddCard(myCarte1);
            myDeck.AddCard(myCarte2);
            myDeck.AddCard(myCarte3);
            myDeck.AddCard(myCarte4);

            Deck myDeck2 = new Deck("Megumi Fushiguro", 60);

            Carte myCarte5 = new Carte("lapin d'evasion");
            Carte myCarte6 = new Carte("technique des Dix Ombres");
            Carte myCarte7 = new Carte("elephant de Plenitude");
            Carte myCarte8 = new Carte("chien de jade");

            myDeck2.AddCard(myCarte5);
            myDeck2.AddCard(myCarte6);
            myDeck2.AddCard(myCarte7);
            myDeck2.AddCard(myCarte8);

            Deck myDeck3 = new Deck("Ryomen Sukuna", 60);

            Carte myCarte9 = new Carte("dissection");
            Carte myCarte10 = new Carte("laceration");
            Carte myCarte11 = new Carte("extension du territoire, Autel Demoniaque");
            Carte myCarte12 = new Carte("makora, le General Celeste Impie");

            myDeck3.AddCard(myCarte9);
            myDeck3.AddCard(myCarte10);
            myDeck3.AddCard(myCarte11);
            myDeck3.AddCard(myCarte12);*/


            /*int result = Mutiply(3, 2);
             */
            /*int[] myArrayOfInt = {3, 4, 5};

            for (int i = 0; i< myArrayOfInt.Length; i++)
            {
                Console.WriteLine(myArrayOfInt[i]);
            } */

            /*int[] myArrayOfInt = new int[10];

            for (int i = 0; i < myArrayOfInt.Length; i++) 
            {
                Console.WriteLine(myArrayOfInt[i]);
            }*/

            /*List<string> list = new List<string>();
            list.Add("toto");
            list.Add("tata");
            list.Add(("titi"));
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
            }*/

            /*List<string> list = new List<string>();
            list.Add("toto");
            list.Add("tata");
            list.Add("titi");
            list.Add("tutu");
            list.Add("dodo");
            string toFind = "tutu";
            for (int i = 0; i < list.Count; i++) 
            {
                Console.WriteLine(list[i]);
                if (list[i] == toFind)
                {
                    Console.WriteLine("VariableFound");
                }
                
            }*/

            /*List<string> list = new List<string>();
            list.Add("toto");
            list.Add("tata");
            list.Add("titi");
            list.Add("tutu");
            list.Add("dodo");
            string toFind = "tutu";

            if(Contains(list , toFind)) 
            {
                Console.WriteLine("found");
            }
            else 
            {
                Console.WriteLine("not found");
            }*/

            /*List<string> data = new List<string>
            { "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            int successes = 0;
            List<string> answers = new List<string>
            {"r","o","i","z","c"};


            while (successes < answers.Count)
            {
                Console.WriteLine("Trouve la lettre");
                string result = Console.ReadLine();
                if (Contains(answers, result)) 
                {
                    if (result == answers[successes])
                    {
                        Console.WriteLine(" bien joué");
                        successes++;
                    }
                    else
                    {
                        Console.WriteLine("mauvaise réponse");
                    }
                }
                
                    
            }*/









            Console.ReadLine();
            Console.ReadKey();

        }
    }
}
