using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapPersonalityAndBackground
    {
        private IMapper _mapper;
        private PersonalityAndBackground _personalityAndBackgroundDomain;
        private Models.FicheModel.PersonalityAndBackground _personalityAndBackground;
        
        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
            
            _personalityAndBackgroundDomain = new PersonalityAndBackground();
            _personalityAndBackground = new Models.FicheModel.PersonalityAndBackground
            {
                Age = 0, Alignement = 5, Apparence = "", Background = "", Defauts = "", Historique = "", Ideaux = "",
                Liens = "", AllieEtOrganisation = "", TraitDePersonnalite = ""
            };
        }

        [Test]
        public void map_personalityAndBackgroundDomain_returnPersonalityAndBackground()
        {
            var result = _mapper.Map<Models.FicheModel.PersonalityAndBackground>(_personalityAndBackgroundDomain);
            
            Assert.AreEqual(_personalityAndBackgroundDomain.Age,result.Age);
            Assert.AreEqual(_personalityAndBackgroundDomain.Alignement,result.Alignement);
            Assert.AreEqual(_personalityAndBackgroundDomain.Apparence,result.Apparence);
            Assert.AreEqual(_personalityAndBackgroundDomain.Background,result.Background);
            Assert.AreEqual(_personalityAndBackgroundDomain.Defauts,result.Defauts);
            Assert.AreEqual(_personalityAndBackgroundDomain.Historique,result.Historique);
            Assert.AreEqual(_personalityAndBackgroundDomain.Ideaux,result.Ideaux);
            Assert.AreEqual(_personalityAndBackgroundDomain.Liens,result.Liens);
            Assert.AreEqual(_personalityAndBackgroundDomain.AllieEtOrganisation,result.AllieEtOrganisation);
            Assert.AreEqual(_personalityAndBackgroundDomain.TraitDePersonnalite,result.TraitDePersonnalite);
            
            
        }
        
        [Test]
        public void map_personalityAndBackground_returnPersonalityAndBackgroundDomain()
        {
            var result = _mapper.Map<PersonalityAndBackground>(_personalityAndBackground);
            
            Assert.AreEqual(_personalityAndBackground.Age,result.Age);
            Assert.AreEqual(_personalityAndBackground.Alignement,result.Alignement);
            Assert.AreEqual(_personalityAndBackground.Apparence,result.Apparence);
            Assert.AreEqual(_personalityAndBackground.Background,result.Background);
            Assert.AreEqual(_personalityAndBackground.Defauts,result.Defauts);
            Assert.AreEqual(_personalityAndBackground.Historique,result.Historique);
            Assert.AreEqual(_personalityAndBackground.Ideaux,result.Ideaux);
            Assert.AreEqual(_personalityAndBackground.Liens,result.Liens);
            Assert.AreEqual(_personalityAndBackground.AllieEtOrganisation,result.AllieEtOrganisation);
            Assert.AreEqual(_personalityAndBackground.TraitDePersonnalite,result.TraitDePersonnalite);
            
            
        }
    }
}