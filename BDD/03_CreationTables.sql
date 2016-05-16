-- -----------------------------------------------------
-- Script : 03_CreationTables.sql
-- Objet  : Création et suppression des tables onMange 
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Suppression des tables
-- -----------------------------------------------------
DROP TABLE onm_membre CASCADE CONSTRAINT;
DROP TABLE onm_origine CASCADE CONSTRAINT;
DROP TABLE onm_plat CASCADE CONSTRAINT;
DROP TABLE onm_repas CASCADE CONSTRAINT;
DROP TABLE onm_aliment CASCADE CONSTRAINT;
DROP TABLE onm_note CASCADE CONSTRAINT;
DROP TABLE onm_compose CASCADE CONSTRAINT;
DROP TABLE onm_vote CASCADE CONSTRAINT;

-- -----------------------------------------------------
-- Table onm_membre
-- -----------------------------------------------------
CREATE TABLE onm_membre (
  mem_no NUMBER(10) NOT NULL,
  mem_prenom VARCHAR2(45) NULL,
  mem_nom VARCHAR2(45) NULL,
  mem_naissance DATE NULL,
  mem_autorisation VARCHAR2(1) NULL, -- A = Noter + Ajouter ; N = Noter
  PRIMARY KEY (mem_no))
;

-- -----------------------------------------------------
-- Table onm_origine
-- -----------------------------------------------------
CREATE TABLE onm_origine (
  ori_no NUMBER(10) NOT NULL,
  ori_continent VARCHAR2(100) NULL,
  PRIMARY KEY (ori_no))
;

-- -----------------------------------------------------
-- Table onm_plat
-- -----------------------------------------------------
CREATE TABLE onm_plat (
  pla_no NUMBER(10) NOT NULL,
  pla_nom VARCHAR2(45) NULL,
  pla_ori_no NUMBER(10) NOT NULL,
  PRIMARY KEY (pla_no)
 ,
  CONSTRAINT fk_onm_plat_origine
    FOREIGN KEY (pla_ori_no)
    REFERENCES onm_origine (ori_no)
   )
;

-- -----------------------------------------------------
-- Table onm_repas
-- -----------------------------------------------------
CREATE TABLE onm_repas (
  rep_no NUMBER(10) NOT NULL,
  rep_moment VARCHAR2(1) NULL, -- M = Midi ; S = Soir
  rep_date DATE NULL,
  rep_pla_no NUMBER(10) NOT NULL,
  PRIMARY KEY (rep_no)
 ,
  CONSTRAINT fk_onm_repas_plat
    FOREIGN KEY (rep_pla_no)
    REFERENCES onm_plat (pla_no)
   )
;

-- -----------------------------------------------------
-- Table onm_aliment
-- -----------------------------------------------------
CREATE TABLE onm_aliment (
  ali_no NUMBER(10) NOT NULL,
  ali_nom VARCHAR2(45) NULL,
  PRIMARY KEY (ali_no))
;

-- -----------------------------------------------------
-- Table onm_note
-- -----------------------------------------------------
CREATE TABLE onm_note (
  not_rep_no NUMBER(10) NOT NULL,
  not_mem_no NUMBER(10) NOT NULL,
  not_note NUMBER(10) NULL, -- Note entre 1 et 5
  PRIMARY KEY (not_mem_no, not_rep_no)
 ,
  CONSTRAINT fk_onm_note_membre
    FOREIGN KEY (not_mem_no)
    REFERENCES onm_membre (mem_no)
   ,
  CONSTRAINT fk_onm_note_repas
    FOREIGN KEY (not_rep_no)
    REFERENCES onm_repas (rep_no)
   )
;

-- -----------------------------------------------------
-- Table onm_compose
-- -----------------------------------------------------
CREATE TABLE onm_compose (
  com_pla_no NUMBER(10) NOT NULL,
  com_ali_no NUMBER(10) NOT NULL,
  PRIMARY KEY (com_pla_no, com_ali_no)
 ,
  CONSTRAINT fk_onm_compose_plat
    FOREIGN KEY (com_pla_no)
    REFERENCES onm_plat (pla_no)
   ,
  CONSTRAINT fk_onm_compose_aliment
    FOREIGN KEY (com_ali_no)
    REFERENCES onm_aliment (ali_no)
   )
;

-- -----------------------------------------------------
-- Table onm_vote
-- -----------------------------------------------------
CREATE TABLE onm_vote (
  vot_no NUMBER(10) NOT NULL,
  vot_mem_no NUMBER(10) NOT NULL,
  vot_pla_no NUMBER(10) NOT NULL,
  vot_dat DATE NULL,
  PRIMARY KEY (vot_no)
 ,
  CONSTRAINT fk_onm_vote_membre
    FOREIGN KEY (vot_mem_no)
    REFERENCES onm_membre (mem_no)
   ,
  CONSTRAINT fk_onm_vote_plat
    FOREIGN KEY (vot_pla_no)
    REFERENCES onm_plat (pla_no)
   )
;

