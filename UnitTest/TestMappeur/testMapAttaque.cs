using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;
using Models.FicheModel;
using Attaque = ProjetctTiGr13.Domain.FicheComponent.Attaque;

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

        [Test]
        public void map_AttaqueDomain_returnAttaque()
        {
            var result = _mapper.Map<Models.FicheModel.Attaque>(_attaqueDomain);
            Assert.AreEqual(_attaqueDomain.DeDegat, result.DeDegat);
            Assert.AreEqual(_attaqueDomain.BonusAuDegat ,result.BonusAuDegat);
            Assert.AreEqual(_attaqueDomain.BonusAuJet ,result.BonusAuJet);
            Assert.AreEqual(_attaqueDomain.NomAttaque ,result.NomAttaque);
            Assert.AreEqual(_attaqueDomain.TypeDegat ,result.TypeDegat);
        }
        
        [Test]
        public void map_Attaque_returnAttaqueDomain()
        {
            var result = _mapper.Map<Attaque>(_attaque);
            Assert.AreEqual(_attaque.DeDegat, result.DeDegat);
            Assert.AreEqual(_attaque.BonusAuDegat ,result.BonusAuDegat);
            Assert.AreEqual(_attaque.BonusAuJet ,result.BonusAuJet);
            Assert.AreEqual(_attaque.NomAttaque ,result.NomAttaque);
            Assert.AreEqual(_attaque.TypeDegat ,result.TypeDegat);
        }
    }
}