drop table postuler;
drop table Stages;
drop table etudiants;
drop table entreprises;
-----------------------------------------
--Xavier Brosseau 
-----------------------------------------
CREATE SEQUENCE SEQEMP INCREMENT BY 1
START WITH 20;

CREATE
  TABLE ENTREPRISES
  (
    NUMENT     CHAR (6) NOT NULL ,
    NOMENT     VARCHAR2 (30) ,
    ADRESSEENT VARCHAR2 (50) ,
    TELENT     VARCHAR2 (20)
  ) ;
ALTER TABLE ENTREPRISES ADD CONSTRAINT ENTREPRISE_PK PRIMARY KEY ( NUMENT ) ;

CREATE
  TABLE Etudiants
  (
    NUMAD  NUMBER NOT NULL ,
    NOM    VARCHAR2 (30) ,
    PRENOM VARCHAR2 (30)
  ) ;
ALTER TABLE Etudiants ADD CONSTRAINT Etudiant_PK PRIMARY KEY ( NUMAD ) ;

CREATE
  TABLE POSTULER
  (
    NUMAD    NUMBER NOT NULL ,
    NUMSTAGE NUMBER NOT NULL ,
    PRIORITE NUMBER
  ) ;
ALTER TABLE POSTULER ADD CONSTRAINT POSTULER_PK PRIMARY KEY ( NUMAD, NUMSTAGE )
;

CREATE
  TABLE STAGES
  (
    NUMSTAGE    NUMBER NOT NULL ,
    Description VARCHAR2 (100) ,
    TYPESTG     CHAR (3)
  ) ;
ALTER TABLE STAGES ADD CONSTRAINT STAGES_PK PRIMARY KEY ( NUMSTAGE ) ;
ALTER TABLE POSTULER ADD CONSTRAINT POSTULER_Etudiants_FK FOREIGN KEY ( NUMAD )
REFERENCES Etudiants ( NUMAD ) ;
ALTER TABLE POSTULER ADD CONSTRAINT POSTULER_STAGES_FK FOREIGN KEY ( NUMSTAGE )
REFERENCES STAGES ( NUMSTAGE ) ;

-------------------------------------------------------------------------------------------------------------------
--Insertion
-------------------------------------------------------------------------------------------------------------------
insert into etudiants values (12,'proulx', 'william');
insert into etudiants values (13,'martin','jonathan');
insert into etudiants values (14,'valente','olivier');
insert into etudiants values (15,'leroy','mathieu');
insert into etudiants values (20,'beaulieu','martin');
select * from etudiants;

insert into entreprises values ('xper','xperdoc inc','24 rue de l espoir, Laval','(450) 345-5678');
insert into entreprises values ('zens','zensol automation','420 rue de la paix Montréal','(514) 230-4523');
insert into entreprises values ('comac','comactoptimisation','210 grand allée boisbriand','(450) 530-1223');
insert into entreprises values ('exa','systemes exa','222 cote vertu Montréal','(514) 111-1223');
select * from entreprises;

insert into stages values (100,'gestion d''une école hotelière','ges');
insert into stages values (101,'Mise à jour du site web de la bibliothèque','ges');
insert into stages values (200,'automatisation d''une serre','ind');
insert into stages values (102,'application Android pour faire les courses','ges');
insert into stages values (103,'application Android Clavardage','ges');
select * from stages;

insert into postuler values (20,102,3);
insert into postuler values (12,100,1);
insert into postuler values (12,103,2);
insert into postuler values (14,103,1);
insert into postuler values (14,100,3);
insert into postuler values (14,101,2);
insert into postuler values (14,102,4);
insert into postuler values (20,101,2);
insert into postuler values (20,100,1);
select * from postuler;
-----------------------------------------------------------------------
-- 3
ALTER table ETUDIANTS ADD Telephone varchar2(14);

--4
update ETUDIANTS 
set Telephone= '(450) 858 8585'
where NUMAD = 15;

--5
select * from etudiants order by nom, prenom;

--6
Alter table stages add NUMENT char(6);

--7
ALTER TABLE stages ADD CONSTRAINT Entreprises_STAGES_FK FOREIGN KEY ( NUMENT )
REFERENCES Entreprises ( NUMENT ) ;

--8
update Stages set Nument= 'comac' where NUMSTAGE =100 ;
update Stages set Nument= 'comac' where NUMSTAGE =101 ;
update Stages set Nument= 'exa' where NUMSTAGE =200 ;
update Stages set Nument= 'zens' where NUMSTAGE =102 ;
update Stages set Nument= 'zens' where NUMSTAGE =103 ;
select * from stages;

--9
select * from ENTREPRISES where ADRESSEENT like '%Montréal%'order by NOMENT;

--10
select * from stages where nument = 
(select nument from ENTREPRISES 
where noment = 'zensol automation');

--11
select s.numstage, s.description, e.noment 
from stages s
inner join entreprises e on s.nument = e.nument;

--12
select s.numstage, s.description, e.noment 
from stages s
right outer join entreprises e on s.nument = e.nument;

--13
select e.nom, e.prenom, s.description
from etudiants e inner join postuler p on e.numad = p.numad
inner join stages s on p.numstage = s.numstage
order by p.PRIORITE;

--14
select e.nom, e.prenom
from etudiants e inner join postuler p on e.numad = p.numad
inner join stages s on p.numstage = s.numstage
where s.description = 'application Android Clavardage';

--15
select e.nument, count(e.NUMENT) as NOMBREDESTAGEPARENTREPRISE
from stages s  inner join ENTREPRISES e on e.NUMENT = s.NUMENT
group by e.NUMENT;

--16
select s.description, count(s.DESCRIPTION) as NBRESTAGESPARENTREPRISE
from stages s inner join postuler p on s.NUMSTAGE = p.NUMSTAGE
group by s.DESCRIPTION;

--17
select s.description, count(s.DESCRIPTION) as NBRESTAGESPARENTREPRISE
from stages s inner join postuler p on s.NUMSTAGE = p.NUMSTAGE
where s.Description = 'application Android Clavardage'
group by s.DESCRIPTION ;

--18
select e.nom, e.prenom, p.NUMSTAGE  from etudiants e
left outer join postuler p on e.NUMAD = p.NUMAD
where p.NUMSTAGE is null;

--19
select e.nom, e.prenom, p.NUMSTAGE  from etudiants e
inner join postuler p on e.NUMAD = p.NUMAD
where p.NUMSTAGE in (
select p.numstage 
from etudiants e 
inner join postuler p on e.NUMAD = p.NUMAD 
where e.nom='valente');

--20
drop table etudiants;

--21
select count(p.numstage) as NombreDeStage
from etudiants e 
inner join postuler p on e.NUMAD = p.NUMAD
where e.nom='valente' and e.PRENOM = 'olivier';





