-- -----------------------------------------------------
-- Script : 06_CreationTriggers.sql
-- Objet  : Création des triggers onMange sur SGBD Oracle en Local (HEGLOCAL) 
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Suppression des sequences
-- -----------------------------------------------------
DROP SEQUENCE sq_membre;
DROP SEQUENCE sq_origine;
DROP SEQUENCE sq_plat;
DROP SEQUENCE sq_repas;
DROP SEQUENCE sq_aliment;
DROP SEQUENCE sq_vote;

-- -----------------------------------------------------
-- Trigger Membre
-- -----------------------------------------------------
CREATE SEQUENCE sq_membre START WITH 8 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_membre
 BEFORE INSERT ON onm_membre FOR EACH ROW
 WHEN (NEW.mem_no IS NULL)
BEGIN
 SELECT sq_membre.NEXTVAL INTO :NEW.mem_no FROM DUAL;
END;
/

ALTER TRIGGER tr_membre ENABLE
/

-- -----------------------------------------------------
-- Trigger Plat
-- -----------------------------------------------------
CREATE SEQUENCE sq_plat START WITH 13 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_plat
 BEFORE INSERT ON onm_plat FOR EACH ROW
 WHEN (NEW.pla_no IS NULL)
BEGIN
 SELECT sq_plat.NEXTVAL INTO :NEW.pla_no FROM DUAL;
END;
/

ALTER TRIGGER tr_plat ENABLE
/

-- -----------------------------------------------------
-- Trigger Repas
-- -----------------------------------------------------
CREATE SEQUENCE sq_repas START WITH 25 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_repas
 BEFORE INSERT ON onm_repas FOR EACH ROW
 WHEN (NEW.rep_no IS NULL)
BEGIN
 SELECT sq_repas.NEXTVAL INTO :NEW.rep_no FROM DUAL;
END;
/

ALTER TRIGGER tr_repas ENABLE
/

-- -----------------------------------------------------
-- Trigger Aliment
-- -----------------------------------------------------
CREATE SEQUENCE sq_aliment START WITH 14 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_aliment
 BEFORE INSERT ON onm_aliment FOR EACH ROW
 WHEN (NEW.ali_no IS NULL)
BEGIN
 SELECT sq_aliment.NEXTVAL INTO :NEW.ali_no FROM DUAL;
END;
/

ALTER TRIGGER tr_aliment ENABLE
/

-- -----------------------------------------------------
-- Trigger Vote
-- -----------------------------------------------------
CREATE SEQUENCE sq_vote START WITH 1 INCREMENT BY 1;

CREATE OR REPLACE TRIGGER tr_vote
 BEFORE INSERT ON onm_vote FOR EACH ROW
 WHEN (NEW.vot_no IS NULL)
BEGIN
 SELECT sq_vote.NEXTVAL INTO :NEW.vot_no FROM DUAL;
END;
/

ALTER TRIGGER tr_vote ENABLE
/
