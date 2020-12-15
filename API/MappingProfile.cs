using AutoMapper;
using Models.FicheModel;
using ProjetctTiGr13.Domain;
using ProjetctTiGr13.Domain.FicheComponent;
using Attaque = ProjetctTiGr13.Domain.FicheComponent.Attaque;
using CharacterStatus = ProjetctTiGr13.Domain.FicheComponent.CharacterStatus;
using Competence = ProjetctTiGr13.Domain.FicheComponent.Competence;
using HealthPointManager = ProjetctTiGr13.Domain.FicheComponent.HealthPointManager;
using MoneyManager = ProjetctTiGr13.Domain.FicheComponent.MoneyManager;
using PersonalityAndBackground = ProjetctTiGr13.Domain.FicheComponent.PersonalityAndBackground;
using Sort = ProjetctTiGr13.Domain.FicheComponent.Sort;

namespace API
{
    public class MappingProfile : Profile
    {
        
        //On définit le mapping (quel classe devra être "mappée" (convertie) dans une autre)
        public MappingProfile()
        {
            CreateMap<Fiche, FicheDomain>()
                .ForMember(dest => dest.Note,
                    act => act.MapFrom(src => src.NoteJoueur))
                .ForMember(dest => dest.Caracteristics,
                    act => act.MapFrom(src => src.CaracteristicManager))
                .ForMember(dest => dest.Masteries,
                    act => act.MapFrom(src => src.CharacterMastery))
                .ForMember(dest => dest.Status,
                    act => act.MapFrom(src => src.CharacterStatus))
                .ForMember(dest => dest.DeathRolls,
                    act => act.MapFrom(src => src.DeathrollManager))
                .ForMember(dest => dest.HpManager,
                    act => act.MapFrom(src => src.HealthPointManager))
                .ForMember(dest => dest.Wallet,
                    act => act.MapFrom(src => src.MoneyManager))
                .ForMember(dest => dest.BackgroundAndTrait,
                    act => act.MapFrom(src => src.PersonalityAndBackground))
                .ForMember(dest => dest.SaveRolls,
                    act => act.MapFrom(src => src.SaveRollsManager))
                .ForMember(dest => dest.Competences,
                    act => act.MapFrom(src => src.CompetencesFiches));
            CreateMap<FicheDomain, Fiche>()
                .ForMember(dest => dest.NoteJoueur,
                    act => act.MapFrom(src => src.Note))
                .ForMember(dest => dest.CaracteristicManager,
                    act => act.MapFrom(src => src.Caracteristics))
                .ForMember(dest => dest.CharacterMastery,
                    act => act.MapFrom(src => src.Masteries))
                .ForMember(dest => dest.CharacterStatus,
                    act => act.MapFrom(src => src.Status))
                .ForMember(dest => dest.DeathrollManager,
                    act => act.MapFrom(src => src.DeathRolls))
                .ForMember(dest => dest.HealthPointManager,
                    act => act.MapFrom(src => src.HpManager))
                .ForMember(dest => dest.MoneyManager,
                    act => act.MapFrom(src => src.Wallet))
                .ForMember(dest => dest.PersonalityAndBackground,
                    act => act.MapFrom(src => src.BackgroundAndTrait))
                .ForMember(dest => dest.SaveRollsManager,
                    act => act.MapFrom(src => src.SaveRolls))
                .ForMember(dest=>dest.CompetencesFiches,
                    act=>act.MapFrom(src=>src.Competences))
                .ForMember(dest => dest.IdFiche, act => act.Ignore());

            //Pour que les noms concorde

            CreateMap<BasicInfo, BasicCharacterInfo>();
            CreateMap<BasicCharacterInfo, BasicInfo>()
                .ForMember(dest => dest.IdFiche, act => act.Ignore());
            
            CreateMap<CaracteristicManager, CaracteristicsManager>();
            CreateMap<CaracteristicsManager,CaracteristicManager>();
            
            CreateMap<CharacterMastery, CharacterMasteries>();
            CreateMap<CharacterMasteries,CharacterMastery>();

            CreateMap<Models.FicheModel.CharacterStatus, CharacterStatus>();
            CreateMap<CharacterStatus, Models.FicheModel.CharacterStatus>();
                
                
            //Différence nom classe r:R
            CreateMap<DeathrollManager, DeathRollManager>()
                .ForMember(dest => dest.SuccessRoll,
                    act => act.MapFrom(src => src.SuccesJdsContreMort))
                .ForMember(dest => dest.FailRoll,
                    act => act.MapFrom(src => src.EchecJdsContreMort));
            CreateMap<DeathRollManager, DeathrollManager>()
                .ForMember(dest => dest.SuccesJdsContreMort,
                    act => act.MapFrom(src => src.SuccessRoll))
                .ForMember(dest => dest.EchecJdsContreMort,
                    act => act.MapFrom(src => src.FailRoll));

            
            
            
            CreateMap<Models.FicheModel.HealthPointManager, HealthPointManager>()
                .ForMember(dest => dest.CurrentHp,
                    act => act.MapFrom(src => src.PvActuel))
                .ForMember(dest => dest.MaxHp,
                    act => act.MapFrom(src => src.PvMax))
                .ForMember(dest => dest.TemporaryHp,
                    act => act.MapFrom(src => src.PvTemporaire))
                .ForMember(dest => dest.HpDice,
                    act => act.MapFrom(src => src.DesDeVie));
            CreateMap<HealthPointManager,Models.FicheModel.HealthPointManager>()
                .ForMember(dest=>dest.PvActuel,
                    act=>act.MapFrom(src=>src.CurrentHp))
                .ForMember(dest=>dest.PvMax,
                    act=>act.MapFrom(src=>src.MaxHp))
                .ForMember(dest=>dest.PvTemporaire,
                    act=>act.MapFrom(src=>src.TemporaryHp))
                .ForMember(dest => dest.DesDeVie,
                    act => act.MapFrom(src => src.HpDice));

            CreateMap<Models.FicheModel.MoneyManager, MoneyManager>()
                .ForMember(dest => dest.Cuivre,
                    act => act.MapFrom(src => src.PieceCuivre))
                .ForMember(dest => dest.Argent,
                    act => act.MapFrom(src => src.PieceArgent))
                .ForMember(dest => dest.Or,
                    act => act.MapFrom(src => src.PieceOr))
                .ForMember(dest => dest.Platine,
                    act => act.MapFrom(src => src.PiecePlatine))
                .ForMember(dest => dest.Electrum,
                    act => act.MapFrom(src => src.PieceElectrum));
            CreateMap<MoneyManager, Models.FicheModel.MoneyManager>()
                .ForMember(dest => dest.PieceCuivre,
                    act => act.MapFrom(src => src.Cuivre))
                .ForMember(dest => dest.PieceArgent,
                    act => act.MapFrom(src => src.Argent))
                .ForMember(dest => dest.PieceOr,
                    act => act.MapFrom(src => src.Or))
                .ForMember(dest => dest.PiecePlatine,
                    act => act.MapFrom(src => src.Platine))
                .ForMember(dest => dest.PieceElectrum,
                    act => act.MapFrom(src => src.Electrum));
            
            CreateMap<Models.FicheModel.PersonalityAndBackground,PersonalityAndBackground>();
            CreateMap<PersonalityAndBackground,Models.FicheModel.PersonalityAndBackground>();
            //Différence nom classe : s
            CreateMap<SaveRollsManager, SaveRollManager>()
                .ForMember(dest => dest.ForceSave,
                    act => act.MapFrom(src => src.JdsForce))
                .ForMember(dest => dest.DexteriteSave,
                    act => act.MapFrom(src => src.JdsDexterite))
                .ForMember(dest => dest.ConstitutionSave,
                    act => act.MapFrom(src => src.JdsConstitution))
                .ForMember(dest => dest.IntelligenceSave,
                    act => act.MapFrom(src => src.JdsIntelligence))
                .ForMember(dest => dest.SagesseSave,
                    act => act.MapFrom(src => src.JdsSagesse))
                .ForMember(dest => dest.CharismeSave,
                    act => act.MapFrom(src => src.JdsCharisme));
            CreateMap<SaveRollManager, SaveRollsManager>()
                .ForMember(dest => dest.JdsForce,
                    act => act.MapFrom(src => src.ForceSave))
                .ForMember(dest => dest.JdsDexterite,
                    act => act.MapFrom(src => src.DexteriteSave))
                .ForMember(dest => dest.JdsConstitution,
                    act => act.MapFrom(src => src.ConstitutionSave))
                .ForMember(dest => dest.JdsIntelligence,
                    act => act.MapFrom(src => src.IntelligenceSave))
                .ForMember(dest => dest.JdsSagesse,
                    act => act.MapFrom(src => src.SagesseSave))
                .ForMember(dest => dest.JdsCharisme,
                    act => act.MapFrom(src => src.CharismeSave));


            CreateMap<Models.FicheModel.Attaque, Attaque>();
            CreateMap<Attaque, Models.FicheModel.Attaque>();

            CreateMap<Models.FicheModel.Sort, Sort>();
            CreateMap<Sort, Models.FicheModel.Sort>();

            CreateMap<CompetencesFiche, Competence>();
            CreateMap<Competence, CompetencesFiche>();

        }
    }
}