-- -----------------------------------------------------
-- Script : 03_CreationVues.sql
-- Objet  : Création des vues utiles à l'application
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Affichage des utilisateurs
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_utilisateurs (Prénom, Date_Naissance, Autorisation) AS
       SELECT INITCAP(mem_prenom), mem_naissance, mem_autorisation
       FROM onm_membre
       ORDER BY mem_naissance DESC;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_utilisateurs TO onMange_user;

-- -----------------------------------------------------
-- Affichage des plats
-- -----------------------------------------------------
-- CREATE OR REPLACE VIEW vw_plats (Nom, Origine) AS
--        SELECT INITCAP(pla_nom), INITCAP(ori_continent)
--        FROM onm_plat
--        JOIN onm_origine ON pla_ori_no = ori_no
--        LEFT 
--        ORDER BY pla_nom;
       
-- GRANT SELECT, INSERT, UPDATE, DELETE ON vw_plats TO onMange_user;

-- -----------------------------------------------------
-- Affichage des repas regroupés par plats
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_plats (Plat, Origine, Mange_le, Note_moyenne) AS
       SELECT INITCAP(pla_nom), INITCAP(ori_continent), MAX(rep_date), ROUND(AVG(not_note))
       FROM onm_repas
            JOIN onm_plat ON rep_pla_no = pla_no
            JOIN onm_note ON rep_no = not_rep_no
            JOIN onm_origine ON pla_ori_no = ori_no
       GROUP BY INITCAP(pla_nom), INITCAP(ori_continent);
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_plats TO onMange_user;

-- -----------------------------------------------------
-- Affichage des aliments
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_aliments (Aliment) AS
       SELECT INITCAP(ali_nom)
       FROM onm_aliment;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_aliments TO onMange_user;

-- -----------------------------------------------------
-- Affichage des composants de plats (pour être utilisé avec WHERE plat = x)
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_composants (Plat, Aliment) AS
       SELECT INITCAP(pla_nom), INITCAP(ali_nom)
       FROM onm_compose
       JOIN onm_aliment ON com_ali_no = ali_no
       RIGHT JOIN onm_plat ON com_pla_no = pla_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_composants TO onMange_user;

-- SELECT * FROM vw_utilisateurs;
-- SELECT * FROM vw_plats;
-- SELECT * FROM vw_repas;
-- SELECT * FROM vw_aliments;
-- SELECT * FROM vw_composants WHERE plat = 'Enchiladas';
