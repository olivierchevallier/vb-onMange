-- -----------------------------------------------------
-- Script : 07_Synonymes.sql
-- Objet  : Création des synonymes de la base OnMange
-- -----------------------------------------------------
CREATE OR REPLACE SYNONYM onMange_user.vw_utilisateurs FOR onMange_data.vw_utilisateurs;
CREATE OR REPLACE SYNONYM onMange_user.vw_plats FOR onMange_data.vw_plats;
CREATE OR REPLACE SYNONYM onMange_user.vw_repas FOR onMange_data.vw_repas;
CREATE OR REPLACE SYNONYM onMange_user.vw_aliments FOR onMange_data.vw_aliments;
CREATE OR REPLACE SYNONYM onMange_user.vw_composants FOR onMange_data.vw_composants;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_aliment FOR onMange_data.vw_onm_aliment;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_compose FOR onMange_data.vw_onm_compose;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_membre FOR onMange_data.vw_onm_membre;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_note FOR onMange_data.vw_onm_note;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_origine FOR onMange_data.vw_onm_origine;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_plat FOR onMange_data.vw_onm_plat;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_repas FOR onMange_data.vw_onm_repas;
CREATE OR REPLACE SYNONYM onMange_user.vw_onm_vote FOR onMange_data.vw_onm_vote;

CREATE OR REPLACE SYNONYM onMange_user.sq_membre FOR onMange_data.sq_membre;
CREATE OR REPLACE SYNONYM onMange_user.sq_plat FOR onMange_data.sq_plat;
CREATE OR REPLACE SYNONYM onMange_user.sq_repas FOR onMange_data.sq_repas;
CREATE OR REPLACE SYNONYM onMange_user.sq_aliment FOR onMange_data.sq_aliment;
CREATE OR REPLACE SYNONYM onMange_user.sq_vote FOR onMange_data.sq_vote;
