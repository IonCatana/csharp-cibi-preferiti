/*
 * Esercizio di oggi sugli Array: Miei cibi preferiti

Create un progetto App Console CibiPreferiti con VS2022.
Nel programma inizializzate un array con la classifica dei vostri cibi preferiti (minimo 5, massimo 10 elementi). 
L’array deve essere già inizializzato nel programma, e i vostri cibi preferiti non vanno chiesti all’utente tramite input.
Una volta dichiarato l’array di cibi preferiti, stampate a video le seguenti informazioni:
La lunghezza della classifica
La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Il vostro cibo top (prima posizione della classifica)
Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Le modalità di consegna sono le solite: repo GitHub, commit e push
*/

Console.WriteLine("I miei cibi preferiti \n");

string[] cibiPreferiti = { "Cioccolato", "Pasta al ragú", "Pizza", "Ravioli", "Lasagne" };

for (var i = 0; i < cibiPreferiti.Length; i++)
{
    Console.WriteLine(cibiPreferiti[i]);
}

Console.WriteLine("\n Classifica con cinque posizioni \n");

Console.WriteLine("1° Classificato = " + cibiPreferiti[1]);
Console.WriteLine("2° Classificato = " + cibiPreferiti[2]);
Console.WriteLine("3° Classificato = " + cibiPreferiti[4]);
Console.WriteLine("4° Classificato = " + cibiPreferiti[3]);
Console.WriteLine("5° Classificato = " + cibiPreferiti[0]);

Console.WriteLine("\n Cibo piu apprezzato: " + cibiPreferiti[1] + "\n Cibo meno apprezzato:" + cibiPreferiti[0]);


//BONUS Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari.
//In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.  
