ESEMPI:

funzione
inserisci vino
inserisci birra
lista di quello che hai in cantina

cosa mettiamo in beverage?
	- nome
	- grado alcolico
	- colore
	- annata
	- tipologia
e poi
	- vino
	- birra
	e poi
costruttore:
	- nome
	- grado alcolico
	- colore
	- annata
	- tipologia


model -> 
3 classi
.bevarage (contiene i dati comuni a tutte le bevande - grado alcolico, etc..)
.vino (estende bevarage)
.birra (estende bevarage)

- implemento il model:
	nome, grado alcolico, colore, annata, tipologia
- tostring con schedina del model su console
- implemento il controller:
	- inserimento vino
	- inserimento birra
	- lista di quello che hai in cantina
	- ricerca per nome
	- ricerca per tipologia
	- ricerca per colore
	- ricerca per annata
	- ricerca per grado alcolico
	- ricerca per tipologia e colore
	- ricerca per tipologia e annata
	- ricerca per tipologia e grado alcolico
	- ricerca per colore e annata
	- ricerca per colore e grado alcolico
	- ricerca per annata e grado alcolico

==============================================================================================

il program lancia uno start che crea tutto querllo che serve alla tui per partire
tui chiede: quale opzione?
opzione 1: inserimento vino
opzione 2: inserimento birra
opzione 3: lista di quello che hai in cantina
opzione 4: esci

se inserisci birra:
	- chiedi nome
	- chiedi grado alcolico
	- chiedi colore/tipo

se inserisci vino:
	- chiedi nome
	- chiedi grado alcolico
	- chiedi annata
	- chiedi tipologia
	- chiedi colore

se lista di quello che hai in cantina:
 	- chiedi tipologia

tui non sa nulla del model, sa solo che c'è qualcuno che gestisce i dati (businesslogic)
- tui chiama il controller
- controller chiama il model
- model fa quello che deve fare
- model restituisce il risultato al controller
- controller restituisce il risultato alla tui
- tui stampa il risultato
- tui chiede: quale opzione?

salvataggio su csv ---> SaveAllBeverages();
- quando chiudo il programma, salvo tutto su un file beverage.csv

LoadAllBeverages(); 
- quando apro il programma, carico tutto da un file beverage.csv
- crea tutti i beverages
- se non lo trova restituisce una lista vuota

==============================================================================================

!!!! le interfacce sono uno strumento molto potente per accoppiare le classi !!!!

==============================================================================================
==============================================================================================


funzione 4
.delete beverages in cui metto il numero del beveraggio che voglio cancellare

funzione 5
.search data una stringa mi da una lista di tutti gli elementi che contengono anche solo in parte la stringa

creare una classe JsonStorage
.che implementa le funzioni save e reload

==============================================================================================
==============================================================================================
