# Classe-G-n-rique-PileLimit-e-T-
Classes Génériques

- Cours de Méthodologies de programmation
- Cegep de Saint-Jean-sur-Richelieu A2017
- Objectif : Mettre en pratique les bons principes de l'orienté objet vus dans le cours, ainsi que les patrons de conception
- Auteurs : Younes Rabdi et Jérémie Fortin
- Date : 2017 - 03 - 26

# Consignes

En C#6, faites et testez correctement une classe générique PileLimitée<T> qui laisse tomber les plus
anciennes valeurs lorsque qu'on dépasse un certain nombre d'éléments.

Le contructeur par défaut permet 100 entrées, mais un autre permet de fournir une autre limite (qui
devient la taille d'un tableau de base).

   PileLimitée<int> p = new PileLimitée<int>(10);

La pile fournira les propriétés (en lecture seule) et fonctions suivantes :

int NbÉléments   : donne le nombre d'éléments

int Capacité     : donne le nombre d'éléments

bool Pleine      : si NbÉléments == Capacité

bool Vide	    : si NbÉléments == 0

bool Empiler(T)  : renvoie false si on a perdu une valeur à cause de la nouvelle à conserver.

T Dépiler()      : renvoie la valeur empilée la plus récente. Lève une exception si pile vide.

void Vider()     : ne devrait que remettre le NbÉléments à 0...

On ne veut jamais faire de recopie d'éléments, on doit donc considérer le vecteur comme circulaire.
