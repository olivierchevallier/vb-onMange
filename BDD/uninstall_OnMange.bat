kREM Fichier		: uninstall_OnMange.bat
REM Objet		: Désinstallation de la BDD OnMange 

mkdir .\Logs

REM Lancement du script uninstall_EasyCooking.sql dans SQL*PLUS
REM le %1 permet de demander le mot de passe lors du lancement du script
sqlplus SYSTEM/%1 @uninstall_OnMange.sql