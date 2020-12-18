using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapAttaque
    {
        private IMapper _mapper;
        private Attaque _attaqueDomain;
        private Models.FicheModel.Attaque _attaque;
        
        
        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
            
            _attaqueDomain = new Attaque();
            _attaque = new Models.FicheModel.Attaque{BonusAuDegat = 0,BonusAuJet = 0,DeDegat = 0,NomAttaque = "",TypeDegat = ""};

        }
    }
}