-- -----------------------------------------------------
-- Script : 01_BDD.sql
-- Objet  : Création BDD OnMange sur SGBD Oracle en Local (HEGLOCAL)
-- -----------------------------------------------------
SET ECHO ON
SET LINESIZE 200
SET PAGESIZE 60

-- Création des utilisateurs en tant que System
SPOOL .\Logs\02_CreationUtilisateurs.log
@.\02_CreationUtilisateurs.sql
SPOOL OFF

-- Connexion à HEGLOCAL en tant que OnMange_data (propirétaires des objets de schéma)
CONNECT OnMange_data/OnMange_data

-- Création des tables
SPOOL .\Logs\03_CreationTables.log
@.\03_CreationTables.sql
SPOOL OFF

-- Chargement des données
SPOOL .\Logs\04_Insertions.log
@.\04_Insertions.sql;
SPOOL OFF

-- Création des vues
SPOOL .\Logs\05_CreationVues.log
@.\05_CreationVues.sql
SPOOL OFF

-- Création des triggers pour les clefs primaires
SPOOL .\Logs\06_CreationTriggers.log
@.\06_CreationTriggers.sql;
SPOOL OFF

-- Connexion à HEGLOCAL en tant que system
CONNECT system/manager

-- Création des synonymes
SPOOL .\Logs\07_Synonymes.log
@.\07_Synonymes.sql;
SPOOL OFF

SET ECHO OFF

EXIT;
