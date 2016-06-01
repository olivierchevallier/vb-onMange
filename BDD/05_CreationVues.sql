-- -----------------------------------------------------
-- Script : 03_CreationVues.sql
-- Objet  : Création des vues utiles à l'application
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Affichage des utilisateurs
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_utilisateurs (Prénom, Date_Naissance, Autorisation, Identifiant) AS
       SELECT INITCAP(mem_prenom), mem_naissance, mem_autorisation, mem_no
       FROM onm_membre
       ORDER BY mem_naissance DESC;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_utilisateurs TO onMange_user;

-- -----------------------------------------------------
-- Affichage des repas regroupés par plats
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_plats (Identifiant, Plat, Origine, Mange_le, Note_moyenne) AS
       SELECT pla_no, INITCAP(pla_nom), INITCAP(ori_continent), MAX(rep_date), ROUND(AVG(not_note))
       FROM onm_repas
            JOIN onm_plat ON rep_pla_no = pla_no
            JOIN onm_note ON rep_no = not_rep_no
            JOIN onm_origine ON pla_ori_no = ori_no
       GROUP BY INITCAP(pla_nom), INITCAP(ori_continent), pla_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_plats TO onMange_user;

-- -----------------------------------------------------
-- Affichage des repas
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_repas (Plat, Origine, Mange_le, Moment, Note_moyenne) AS
       SELECT INITCAP(pla_nom), INITCAP(ori_continent), rep_date, UPPER(rep_moment), (SELECT Note_moyenne FROM vw_plats WHERE INITCAP(Plat) = INITCAP(pla_nom))
       FROM onm_repas
            LEFT JOIN onm_plat ON rep_pla_no = pla_no
            LEFT JOIN onm_note ON rep_no = not_rep_no
            LEFT JOIN onm_origine ON pla_ori_no = ori_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_repas TO onMange_user;

-- -----------------------------------------------------
-- Affichage des aliments
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_aliments (Identifant, Aliment) AS
       SELECT ali_no, INITCAP(ali_nom)
       FROM onm_aliment;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_aliments TO onMange_user;

-- -----------------------------------------------------
-- Affichage des composants de plats (pour être utilisé avec WHERE plat = x)
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_composants (Identifiant, Plat, Aliment) AS
       SELECT ali_no, INITCAP(pla_nom), INITCAP(ali_nom)
       FROM onm_compose
       JOIN onm_aliment ON com_ali_no = ali_no
       RIGHT JOIN onm_plat ON com_pla_no = pla_no;

GRANT SELECT, INSERT, UPDATE, DELETE ON vw_composants TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_aliments
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_aliment AS
       SELECT * FROM onm_aliment;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_aliment TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_compose
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_compose AS
       SELECT * FROM onm_compose;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_compose TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_membre 
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_membre AS
       SELECT * FROM onm_membre;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_membre TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_note
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_note AS
       SELECT * FROM onm_note;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_note TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_origine
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_origine AS
       SELECT * FROM onm_origine;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_origine TO onMange_user;

-- -----------------------------------------------------
-- Vue vw_onm_plat
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_plat AS
       SELECT * FROM onm_plat;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_plat TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_repas
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_repas AS
       SELECT * FROM onm_repas;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_repas TO onMange_user;

-- -----------------------------------------------------
-- Vue onm_vote
-- -----------------------------------------------------
CREATE OR REPLACE VIEW vw_onm_vote AS
       SELECT * FROM onm_vote;
       
GRANT SELECT, INSERT, UPDATE, DELETE ON vw_onm_vote TO onMange_user;

-- SELECT * FROM vw_utilisateurs;
-- SELECT * FROM vw_plats;
-- SELECT * FROM vw_repas;
-- SELECT * FROM vw_aliments;
-- SELECT * FROM vw_composants WHERE plat = 'Enchiladas';
