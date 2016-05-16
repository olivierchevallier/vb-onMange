-- -----------------------------------------------------
-- Script : 02_CreationUtilisateurs.sql
-- Objet  : Cr�ation des utilisateurs BDD onMange sur SGBD Oracle en Local (HEGLOCAL)
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Suppression des utilisateur, r�les et profils
-- -----------------------------------------------------
-- Suppression des utilisateurs
DROP USER onMange_data CASCADE;
DROP USER onMange_user CASCADE;

-- Suppression des r�les
DROP ROLE role_onMange_data CASCADE;
DROP ROLE role_onMange_user CASCADE;

-- Suppression du profil
DROP PROFILE onMange_profil;

-- -----------------------------------------------------
-- Cr�ation du profil 
-- -----------------------------------------------------
-- Cr�ation du profil onMange_profil
CREATE PROFILE onMange_profil LIMIT
  SESSIONS_PER_USER 3
  FAILED_LOGIN_ATTEMPTS 3 
  PASSWORD_LOCK_TIME 1/24
  PASSWORD_LIFE_TIME 180 
  PASSWORD_REUSE_TIME 180 
  PASSWORD_REUSE_MAX UNLIMITED
  PASSWORD_GRACE_TIME 7;

-- -----------------------------------------------------
-- Cr�ation du r�le role_onMange_data (r�le de l'utilisateur propri�taire des objets de la base)
-- -----------------------------------------------------
-- Creation du r�le role_onMange_data
CREATE ROLE role_onMange_data;

-- droit de se connecter � la BDD
GRANT CONNECT TO role_onMange_data;

-- droit de cr�er des triggers, s�quence, tables, packages, ...
GRANT RESOURCE TO role_onMange_data;

-- droit de cr�er des vues
GRANT CREATE VIEW TO role_onMange_data;

-- -----------------------------------------------------
-- Cr�ation du r�le role_onMange_user (r�le de l'utilisateur de l'application)
-- -----------------------------------------------------
-- Creation du r�le role_onMange_user
CREATE ROLE role_onMange_user;

-- droit de se connecter � la BDD
GRANT CREATE SESSION TO role_onMange_user;

-- -----------------------------------------------------
-- Cr�ation de l'utilisateur onMange_data (propri�taire des objets de sch�ma de la base)
-- -----------------------------------------------------
-- Creation de l'utilisateur onMange_data 
CREATE USER onMange_data
  PROFILE onMange_profil
  IDENTIFIED BY onMange_data
  DEFAULT TABLESPACE USERS
  TEMPORARY TABLESPACE TEMP
;
GRANT role_onMange_data TO onMange_data;
ALTER USER onMange_data quota unlimited ON USERS;

-- -----------------------------------------------------
-- Cr�ation de l'utilisateur onMange_user (utilisateur de l'application)
-- -----------------------------------------------------
CREATE USER onMange_user
  PROFILE onMange_profil
  IDENTIFIED BY onMange_user
;
GRANT role_onMange_user TO onMange_user;
