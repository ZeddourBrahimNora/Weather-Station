CREATE table taux (tauxhoraire integer primary key, valeur_taux_H integer)

CREATE TABLE td7_2_ex2.employe
(
    NEmploye INTEGER PRIMARY KEY,
    nom text,
    Departement text,
    Grade text
);

CREATE TABLE td7_2_ex2.date
(
    date1 date PRIMARY KEY,
    semaine text,
    jour text
);

CREATE TABLE td7_2_ex2.projet
(
    NProjet INTEGER PRIMARY KEY,
    Description text
);

CREATE TABLE td7_2_ex2.tache
(
    NProjet INTEGER ,
    tache text,
    primary key (NProjet),
    foreign key (NProjet) references td7_2_ex2.projet(NProjet)
);

CREATE TABLE td7_2_ex2.prix
(
    tache text,
    grade text,
    taux_horaire int,
    primary key (tache, grade)
);


CREATE TABLE td7_2_ex2.travail
(
    date1 date,
    NEmploye int,
    NProjet int,
    nb_heures int,
    primary key (date1, NEmploye, NProjet),
    foreign key (date1) references td7_2_ex2.date(date1),
    foreign key (NEmploye) references td7_2_ex2.employe(NEmploye),
    foreign key (NProjet) references td7_2_ex2.projet(NProjet)
); 


--insert into td7_2_ex2.projet values (1, 'leporjet')
--insert into td7_2_ex2.tache values (1, 'latache')

Create function checkRec() Returns trigger as $checkRec$
    declare 

        begin
        if (select 1  from td7_2_ex2.projet where nprojet = new.nprojet) is null then
		Raise exception 'erreur id parent inexistant'; 
        else 
        return new;
		end if;
    end;
    $checkRec$ Language plpgsql;

Create trigger checkRec
Before insert on td7_2_ex2.tache for each row execute procedure checkRec();
