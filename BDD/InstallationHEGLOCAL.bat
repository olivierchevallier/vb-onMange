REM Fichier		: Installation.bat
REM Objet		: Création de la BDD OnMange

mkdir .\Logs

REM Lancement du script 01_BDD.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM@HEGLOCAL/%1 @01_BDD_HEGLOCAL.sql