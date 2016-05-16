-- -----------------------------------------------------
-- Script : 04_Insertions.sql
-- Objet  : Insertions de données sur les tables onMange 
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Insertion table : onm_membre
-- -----------------------------------------------------
INSERT INTO onm_membre VALUES (1, 'benoît', 'chevallier', to_date('2006-04-15', 'YYYY-MM-DD'), 'N');
INSERT INTO onm_membre VALUES (2, 'clothilde', 'chevallier', to_date('2001-11-29', 'YYYY-MM-DD'), 'N');
INSERT INTO onm_membre VALUES (3, 'olivier', 'chevallier', to_date('1996-10-23', 'YYYY-MM-DD'), 'A');
INSERT INTO onm_membre VALUES (4, 'ophélie', 'chevallier', to_date('1992-05-17', 'YYYY-MM-DD'), 'A');
INSERT INTO onm_membre VALUES (5, 'romain', 'chevallier', to_date('1992-05-19', 'YYYY-MM-DD'), 'A');
INSERT INTO onm_membre VALUES (6, 'anne', 'chevallier', to_date('1964-09-06', 'YYYY-MM-DD'), 'A');
INSERT INTO onm_membre VALUES (7, 'christian', 'chevallier', to_date('1964-04-13', 'YYYY-MM-DD'), 'A');

COMMIT;

-- -----------------------------------------------------
-- Insertion table : onm_origine
-- -----------------------------------------------------
INSERT INTO onm_origine VALUES (1, 'afrique');
INSERT INTO onm_origine VALUES (2, 'amérique du nord');
INSERT INTO onm_origine VALUES (3, 'amérique du sud');
INSERT INTO onm_origine VALUES (4, 'asie');
INSERT INTO onm_origine VALUES (5, 'europe');
INSERT INTO onm_origine VALUES (6, 'océanie');

COMMIT;

-- -----------------------------------------------------
-- Insertion table : onm_plat
-- -----------------------------------------------------
INSERT INTO onm_plat VALUES (1, 'raclette', 5);
INSERT INTO onm_plat VALUES (2, 'fondue', 5);
INSERT INTO onm_plat VALUES (3, 'tartiflette', 5);
INSERT INTO onm_plat VALUES (4, 'lasagnes', 5);
INSERT INTO onm_plat VALUES (5, 'sushi', 4);
INSERT INTO onm_plat VALUES (6, 'hamburger', 2);
INSERT INTO onm_plat VALUES (7, 'fajitas', 3);
INSERT INTO onm_plat VALUES (8, 'couscous', 1);
INSERT INTO onm_plat VALUES (9, 'ragout de kangourou', 5);
INSERT INTO onm_plat VALUES (10, 'Enchiladas', 3);
INSERT INTO onm_plat VALUES (11, 'hot dog', 2);
INSERT INTO onm_plat VALUES (12, 'Spaghetti bolognaise', 5);

COMMIT;

-- -----------------------------------------------------
-- Insertion table : onm_repas
-- -----------------------------------------------------
INSERT INTO onm_repas VALUES(1, 'm', to_date('2016-04-18', 'YYYY-MM-DD'), 1);
INSERT INTO onm_repas VALUES(2, 's', to_date('2016-04-18', 'YYYY-MM-DD'), 5);
INSERT INTO onm_repas VALUES(3, 'm', to_date('2016-04-19', 'YYYY-MM-DD'), 6);
INSERT INTO onm_repas VALUES(4, 's', to_date('2016-04-19', 'YYYY-MM-DD'), 9);
INSERT INTO onm_repas VALUES(5, 'm', to_date('2016-04-20', 'YYYY-MM-DD'), 4);
INSERT INTO onm_repas VALUES(6, 's', to_date('2016-04-20', 'YYYY-MM-DD'), 3);
INSERT INTO onm_repas VALUES(7, 'm', to_date('2016-04-21', 'YYYY-MM-DD'), 8);
INSERT INTO onm_repas VALUES(8, 's', to_date('2016-04-21', 'YYYY-MM-DD'), 2);
INSERT INTO onm_repas VALUES(9, 'm', to_date('2016-04-22', 'YYYY-MM-DD'), 10);
INSERT INTO onm_repas VALUES(10, 's', to_date('2016-04-22', 'YYYY-MM-DD'), 11);
INSERT INTO onm_repas VALUES(11, 'm', to_date('2016-04-23', 'YYYY-MM-DD'), 8);
INSERT INTO onm_repas VALUES(12, 's', to_date('2016-04-23', 'YYYY-MM-DD'), 5);
INSERT INTO onm_repas VALUES(13, 'm', to_date('2016-04-24', 'YYYY-MM-DD'), 12);
INSERT INTO onm_repas VALUES(14, 's', to_date('2016-04-24', 'YYYY-MM-DD'), 6);
INSERT INTO onm_repas VALUES(15, 'm', to_date('2016-04-25', 'YYYY-MM-DD'), 7);
INSERT INTO onm_repas VALUES(16, 's', to_date('2016-04-25', 'YYYY-MM-DD'), 9);
INSERT INTO onm_repas VALUES(17, 'm', to_date('2016-04-26', 'YYYY-MM-DD'), 8);
INSERT INTO onm_repas VALUES(18, 's', to_date('2016-04-26', 'YYYY-MM-DD'), 10);
INSERT INTO onm_repas VALUES(19, 'm', to_date('2016-04-27', 'YYYY-MM-DD'), 2);
INSERT INTO onm_repas VALUES(20, 's', to_date('2016-04-27', 'YYYY-MM-DD'), 1);
INSERT INTO onm_repas VALUES(21, 'm', to_date('2016-04-28', 'YYYY-MM-DD'), 9);
INSERT INTO onm_repas VALUES(22, 's', to_date('2016-04-28', 'YYYY-MM-DD'), 7);
INSERT INTO onm_repas VALUES(23, 'm', to_date('2016-04-29', 'YYYY-MM-DD'), 6);
INSERT INTO onm_repas VALUES(24, 's', to_date('2016-04-29', 'YYYY-MM-DD'), 3);

COMMIT;
-- -----------------------------------------------------
-- Insertion table : onm_aliment
-- -----------------------------------------------------
INSERT INTO onm_aliment VALUES (1, 'fromage');
INSERT INTO onm_aliment VALUES (2, 'pâtes');
INSERT INTO onm_aliment VALUES (3, 'viande hachée');
INSERT INTO onm_aliment VALUES (4, 'tomate');
INSERT INTO onm_aliment VALUES (5, 'poisson');
INSERT INTO onm_aliment VALUES (6, 'riz');
INSERT INTO onm_aliment VALUES (7, 'pain');
INSERT INTO onm_aliment VALUES (8, 'poulet');
INSERT INTO onm_aliment VALUES (9, 'tortillas');
INSERT INTO onm_aliment VALUES (10, 'couscous');
INSERT INTO onm_aliment VALUES (11, 'kangourou');
INSERT INTO onm_aliment VALUES (12, 'saucisse');
INSERT INTO onm_aliment VALUES (13, 'pomme de terre');

COMMIT;

-- -----------------------------------------------------
-- Insertion table : onm_note
-- -----------------------------------------------------
INSERT INTO onm_note VALUES(1, 1, 4);
INSERT INTO onm_note VALUES(1, 2, 4);
INSERT INTO onm_note VALUES(1, 4, 5);

INSERT INTO onm_note VALUES(2, 1, 3);
INSERT INTO onm_note VALUES(2, 2, 3);
INSERT INTO onm_note VALUES(2, 3, 5);
INSERT INTO onm_note VALUES(2, 4, 2);
INSERT INTO onm_note VALUES(2, 5, 5);
INSERT INTO onm_note VALUES(2, 6, 5);
INSERT INTO onm_note VALUES(2, 7, 4);

INSERT INTO onm_note VALUES(3, 1, 5);
INSERT INTO onm_note VALUES(4, 1, 2);
INSERT INTO onm_note VALUES(5, 1, 5);
INSERT INTO onm_note VALUES(6, 1, 5);
INSERT INTO onm_note VALUES(7, 1, 3);
INSERT INTO onm_note VALUES(8, 1, 2);
INSERT INTO onm_note VALUES(9, 1, 1);
INSERT INTO onm_note VALUES(10, 1, 4);
INSERT INTO onm_note VALUES(11, 1, 4);
INSERT INTO onm_note VALUES(12, 1, 4);
INSERT INTO onm_note VALUES(13, 1, 5);
INSERT INTO onm_note VALUES(14, 1, 3);
INSERT INTO onm_note VALUES(15, 1, 4);
INSERT INTO onm_note VALUES(16, 1, 2);
INSERT INTO onm_note VALUES(17, 1, 2);
INSERT INTO onm_note VALUES(18, 1, 3);
INSERT INTO onm_note VALUES(19, 1, 5);
INSERT INTO onm_note VALUES(20, 1, 5);
INSERT INTO onm_note VALUES(21, 1, 4);
INSERT INTO onm_note VALUES(22, 1, 2);
INSERT INTO onm_note VALUES(23, 1, 3);
INSERT INTO onm_note VALUES(24, 1, 1);

COMMIT;
-- -----------------------------------------------------
-- Insertion table : onm_compose
-- -----------------------------------------------------
-- Raclette
INSERT INTO onm_compose VALUES (1, 1);
INSERT INTO onm_compose VALUES (1, 13);
-- Fondue
INSERT INTO onm_compose VALUES (2, 1);
INSERT INTO onm_compose VALUES (2, 7);
-- Tartiflette
INSERT INTO onm_compose VALUES (3, 1);
INSERT INTO onm_compose VALUES (3, 13);
-- Lasagne
INSERT INTO onm_compose VALUES (4, 2);
INSERT INTO onm_compose VALUES (4, 3);
INSERT INTO onm_compose VALUES (4, 4);
-- Sushi
INSERT INTO onm_compose VALUES (5, 5);
INSERT INTO onm_compose VALUES (5, 6);
-- Hamburger
INSERT INTO onm_compose VALUES (6, 3);
INSERT INTO onm_compose VALUES (6, 7);
-- Couscous
INSERT INTO onm_compose VALUES (8, 10);
-- Hot dog
INSERT INTO onm_compose VALUES (11, 7);
INSERT INTO onm_compose VALUES (11, 12);
-- Spaghetti bolognaise
INSERT INTO onm_compose VALUES (12, 2);
INSERT INTO onm_compose VALUES (12, 3);
INSERT INTO onm_compose VALUES (12, 4);

COMMIT;

-- -----------------------------------------------------
-- Insertion table : onm_vote
-- -----------------------------------------------------
-- Pas d'insertion pour la table vote. Ce sont les utilisateurs de l'application qui effecturont les premiers votes.

-- SELECT * FROM onm_membre;
-- SELECT * FROM onm_origine;
-- SELECT * FROM onm_plat;
-- SELECT * FROM onm_aliment;
-- SELECT * FROM onm_compose;
-- SELECT * FROM onm_repas;
