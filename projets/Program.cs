using System;

namespace projets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            //GÉNÉRATEUR
            Random aleatoire = new Random();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Magenta;
            //VARIABLES
            int PVmax = 10;
            int PV = 10;
            string Hero;
            string P;
            float choix = 4;
            //DÉBUT
            Start1:
            Console.WriteLine("bonjour!!...quel nom dois-je vous donner?");
            Hero = Console.ReadLine();
            if (Hero == "")
            {
                Console.WriteLine("je vous ai posé une question!!");
                System.Threading.Thread.Sleep(2000);
                goto Start1;
            }
            Console.WriteLine("Bonjour! " + Hero + " et bienvenue sur mon programme!");
            Console.ReadLine();
            Console.WriteLine("donc, " + Hero + " ... pourquoi parle tu a une machine?");
            P = Console.ReadLine();
            Console.WriteLine("tu crois vraiment que: ^" + P + "^ est une bonne justification " + Hero + " ?");
            Console.ReadLine();
            Console.WriteLine("ok... ... ... veux tu jouer a un jeux avec moi?");
            Console.ReadLine();
            Console.WriteLine("peux importe XD je ne suis pas sensé te laisser partir tant que le proggramme n'est pas fini donc, XD j'allais t'oubliger a jouer dans tout les cas");
            Console.ReadLine();
            Console.WriteLine("bon on commence! c'est un jeux d'on tu est le héro... tu peux répondre par 1 ou par 0. Dans ce jeu, tu a des PV.. c'est a dire: des points de vie... si ceux-ci tombe à zéro, tu meurt. tu commence la partie avec 10 points de vie...as tu bien compris les règles " + Hero + " ?.. peux importe XD on commence!");
            //DÉBUT DU JEUX
            Console.ReadLine();
            Console.WriteLine("tu marche dans une pyramide égiptienne et tu atteri devans une porte. tu peux tenter d'ouvrir la porte en appuyant sur (0) ou tu peux tenter de passer par le petit trou juste a droite en appuyant sur (1)");
            choix = float.Parse(Console.ReadLine());
            if (choix == 0)
            {
                //CHEMIN DE LA PORTE 1
                Console.WriteLine("tu tente d'ouvrir la porte avec difficulté... mais tu réussi en faisant grincer la porte comme tu n'avais jamais vu une porte grincer autant auparavant! un grondement sourd s'ensuit.. un tremblement de terre!!! tu dois vite choisir entre l'escalier de gauche(0) ou l'escalier de droite(1) qui ce trouve de l'autre coté!!");
                choix = float.Parse(Console.ReadLine());
                //ESCALIER DE GAUCHE
                if (choix == 0)
                {
                    Console.WriteLine("tu cours dans les escaliers de gauche comme un forcené... tu débouche sur une piece vide avecun portail au centre...tu peux traverser le portail(0) ou attendre... et mourrir écrasé(1)");
                    choix = float.Parse(Console.ReadLine());
                    //PORTAIL
                    if (choix == 0)
                    {
                        Console.WriteLine("tu te téléporte completement sombre dans un monde inconnu... tu sens un poids lourd sur tes épaules et tu sufoque... tu est morts!!... meilleure chance la prochaine fois" + Hero + "!");
                        PVmax = PVmax + 1;
                        PV = PV + 1;
                        Console.ReadLine();
                    }
                    //YOU STUPID
                    else
                    {
                        Console.WriteLine("tu attends et tu fini par mourrir écraser par un rocher...désoler" + Hero + "mais je t'avais prévenu");
                        PV = PV - 1000;
                        Console.ReadLine();
                    }
                }
                //ESCALIER DE DROITE
                else
                {
                    Console.WriteLine("tu dessend les marches de l'escalier de droite a toute allure!! tu fini par apercevoir la lumière au loin...tu t'y rend... félicitation!! " + Hero + " tu as terminé mon jeux vraiment court!! XD");
                    Console.ReadLine();
                }
            }
            //CHEMIN DU PETIT TROU
            else
            {
                Console.WriteLine("tu te faufille dans ce trou à peine assez grand pour que tu y entre... tu avance... avance... avance... et tu termine ta route dans une pièce ronde et très sombre...une statue de gargouille est située au milieu de la salle et derrière elle se trouve une porte ouverte...que faites vous? vous pouvez vous approcher de la gargouille(0) ou la contourner et traverser la porte(1)");
                choix = float.Parse(Console.ReadLine());
                if (choix == 0)
                {
                    int wairé = aleatoire.Next(1, 5);
                    //LUCKY YOU!
                    if (wairé == 1)
                    {
                        Console.WriteLine("vous vous approchez de la gargouille et vous examinez celle-ci...hmmm elle a l'air si musclée vous dites vous...tout a coup la gargouille ouvre les yeux et vous regarde avec un air joyeux.. elle vous dis: merci jeune voyageur..cela faisais longtemps que l'on ne m'avais pas fait de tels comopliments!! pour la peine.. je vais vous faire sortir de la pyramide!! alors la gargouille vous escorte jusqu'a la sortie..... Félicitations " + Hero + " vous avez gagné!.........lèche bottes");
                        Console.ReadLine();
                    }
                    //C'ÉTAIT PRÉVISIBLE XD
                    else
                    {
                        Console.WriteLine("vous vous approchez de la gargouille et vous examinez celle-ci...beurk!! comme elle est laide vous dites vous!...tout a coup la gargouille ouvre les yeux et vous regarde avec un air a vous aracher les trippes avec une brindille......et c'est ce qu'elle fit...vous êtes mort " + Hero + " ....cela vous apprendra de vous moquer du physique des gens!");
                        Console.ReadLine();
                    }
                }
                //SPIDER!!
                else
                {
                    Console.WriteLine("tu préfère ne pas t'approcher de la gargouille car tu te rappelle que dans les films, ça se fini toujours mal... donc tu la contourne et traverse la porte... tu marche longement et débouche dans une salle trop sombre pour que tu puisse y voir... tu perçois une odeur épouventable!! ça sens la mort!!tu sens quelques chose se déplacer derière toi...sens t'en rendre compte, une araignée géante t'a bouffé vivant...meilleure chance la prochaine fois " + Hero + " !");
                    Console.ReadLine();
                }
            }
            //FIN
        }
    }
}
