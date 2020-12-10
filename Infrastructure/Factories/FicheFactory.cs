using System.Data.SqlClient;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Infrastructure;

namespace Infrastructure.Factories
{
    public class FicheFactory : IInstanceFromReaderFactory<IFiche>
    {
        
        public IFiche CreateFromReader(SqlDataReader readert)
        {
            var reader = readert;
            return new FicheDomain
            {
                IdFiche = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colId_fiche)),
                IdJoueur = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colId_joueur)),
                Equipement = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colEquipement)),
                CapaciteEtTrait = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colCapacite_et_trait)),
                Note = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colNote_joueur)),
                Inspiration = reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colInspiration))
//remettre virgule après inspi

                // BasicInfo = new Domain.FicheComponent.BasicCharacterInfo
                // {
                //     Classe = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colClasse)),
                //     Niveau = reader.GetByte(reader.GetOrdinal(IFicheColumnsName.colNiveau)),
                //     Race = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colRace)),
                //     NomPersonnage = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colNom_personnage)),
                //     Experience = (long)reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colExperience))
                // },
                //
                //
                // HpManager = new Domain.FicheComponent.HealthPointManager
                // {
                //     CurrentHp = reader.GetInt16(reader.GetOrdinal(IFicheColumnsName.colPv_actuel)),
                //     HpDice = reader.GetByte(reader.GetOrdinal(IFicheColumnsName.colDes_de_vie)),
                //     MaxHp = reader.GetInt16(reader.GetOrdinal(IFicheColumnsName.colPv_max)),
                //     TemporaryHp = reader.GetInt16(reader.GetOrdinal(IFicheColumnsName.colPv_temporaire))
                // },
                //
                //
                // SaveRolls = new Domain.FicheComponent.SaveRollManager
                // {
                //     ForceSave = reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_force)),
                //     DexteriteSave = reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_dexterite)),
                //     ConstitutionSave =
                //         reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_constitution)),
                //     IntelligenceSave =
                //         reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_intelligence)),
                //     SagesseSave = reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_sagesse)),
                //     CharismeSave = reader.GetBoolean(reader.GetOrdinal(IFicheColumnsName.colJds_charisme))
                // },
                //
                //
                // DeathRolls = new Domain.FicheComponent.DeathRollManager
                // {
                //     SuccessRoll =
                //         reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colSucces_jds_contre_mort)),
                //     FailRoll = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colEchec_jds_contre_mort))
                // },
                //
                // Wallet = new Domain.FicheComponent.MoneyManager
                // {
                //     Cuivre = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colPiece_cuivre)),
                //     Argent = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colPiece_argent)),
                //     Or = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colPiece_or)),
                //     Platine = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colPiece_platine)),
                //     Electrum = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colPiece_electrum))
                // },
                //
                // BackgroundAndTrait = new Domain.FicheComponent.PersonalityAndBackground
                // {
                //     TraitDePersonnalite =
                //         reader.GetString(reader.GetOrdinal(IFicheColumnsName.colTrait_de_personnalite)),
                //     Ideaux = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colIdeaux)),
                //     Liens = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colLiens)),
                //     Defauts = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colDefauts)),
                //     Alignement = reader.GetByte(reader.GetOrdinal(IFicheColumnsName.colAlignement)),
                //     Historique = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colHistorique)),
                //     Age = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colAge)),
                //     Apparence = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colApparence)),
                //     AllieEtOrganisation =
                //         reader.GetString(reader.GetOrdinal(IFicheColumnsName.colAllie_et_organisation)),
                //     Background = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colBackground))
                // },
                //
                // Masteries = new Domain.FicheComponent.CharacterMasteries
                // {
                //     Maitrises = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colMaitrises)),
                //     Langues = reader.GetString(reader.GetOrdinal(IFicheColumnsName.colLangues))
                // },
                //
                // Caracteristics = new Domain.FicheComponent.CaracteristicManager
                // {
                //     Force = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colForce_carac)),
                //     Dexterite = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colDexterite_carac)),
                //     Constitution = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colConstition_carac)),
                //     Intelligence = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colIntelligence_carac)),
                //     Sagesse = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colSagesse_carac)),
                //     Charisme = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colCharisme_carac))
                // },
                //
                // Status = new Domain.FicheComponent.CharacterStatus
                // {
                //     ClasseArmure = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colClasse_armure)),
                //     Initiative = reader.GetInt32(reader.GetOrdinal(IFicheColumnsName.colInitiative)),
                //     Vitesse = reader.GetFloat(reader.GetOrdinal(IFicheColumnsName.colVitesse))
                // }
            };

        }
    }
}