﻿using System.Collections.Generic;
using ProjetctTiGr13.Domain.FicheComponent;

namespace ProjetctTiGr13.Domain
{
    public class FicheDomain : IFiche
    {
        public int IdFiche { get; set; }
        public string IdJoueur { get; set; }
        public string Equipement { get; set; }
        public string CapaciteEtTrait { get; set; }
        public string Note { get; set; }
        public bool Inspiration { get; set; }
        
        //Composants basés sur des listes :

        public List<Attaque> Attaques { get; set; }
        public List<Competence> Competences { get; set; } //Ne garde que l'id de la compétence
        public List<Sort> Sorts { get; set; }

        //*********************************
        
        //Composant de la fiche 
        public BasicCharacterInfo BasicInfo { get; set; }
        public HealthPointManager HpManager { get; set; }
        public SaveRollManager SaveRolls { get; set; }
        public DeathRollManager DeathRolls { get; set; }
        public MoneyManager Wallet { get; set; }
        public PersonalityAndBackground BackgroundAndTrait { get; set; }
        public CharacterMasteries Masteries { get; set; }
        public CaracteristicsManager Caracteristics { get; set; }
        public CharacterStatus Status { get; set; }


        public FicheDomain()
        {
            IdJoueur = "";
            Equipement = "";
            CapaciteEtTrait = "";
            Note = "";
            Inspiration = false;
            
            //Instanciation des liste (vide par défaut)
            Sorts = new List<Sort>();
            Attaques = new List<Attaque>();
            Competences = new List<Competence>();
            
            
            BasicInfo = new BasicCharacterInfo();
            HpManager = new HealthPointManager();
            SaveRolls = new SaveRollManager();
            DeathRolls = new DeathRollManager();
            Wallet = new MoneyManager();
            BackgroundAndTrait = new PersonalityAndBackground();
            Masteries = new CharacterMasteries();
            Caracteristics = new CaracteristicsManager();
            Status = new CharacterStatus();
        }




    }
}