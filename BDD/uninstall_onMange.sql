-- -----------------------------------------------------
-- Script : uninstall_OnMange.sql
-- Objet  : D�sinstallation de la base de donn�es OnMange
-- -----------------------------------------------------

SPOOL .\Logs\uninstall_OnMange.log

--Suppression des utilisateurs
DROP USER OnMange_data CASCADE;
DROP USER OnMange_user CASCADE;

--Suppression des r�les
DROP ROLE role_OnMange_data CASCADE;
DROP ROLE role_OnMange_user CASCADE;

--Suppression du profil
DROP PROFILE OnMange_profil;

SPOOL OFF

EXIT;
