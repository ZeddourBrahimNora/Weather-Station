create table td7_ex1.Domaines(int numDomaine as primary key, text nomDomaine)
create table td7_ex1.Auteur(int numAuteur as primary key, text nomAuteur, int nbliv)
CREATE TABLE td7_ex1.Livres
(
    numLivre INTEGER PRIMARY KEY,
    titre text,
    numDomaine integer,
    FOREIGN key (numDomaine) REFERENCES td7_ex1.Domaines(numDomaine)
);

CREATE TABLE td7_ex1.Ecrire
(
    numAuteur Integer,
    numLivre INTEGER,
    dateEcriture text,
    PRIMARY key(numAuteur, numLivre),
    FOREIGN key (numAuteur) REFERENCES td7_ex1.Auteur(numAuteur),
    FOREIGN key (numLivre) REFERENCES td7_ex1.Livres(numLivre)
);