
using API;
using AutoMapper;
using Models.FicheModel;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;


namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapDeathRoll
    {
        private IMapper _mapper;
        private DeathRollManager _deathRollManagerDomain;
        private Models.FicheModel.DeathrollManager _deathRollManager;

        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
            
            _deathRollManagerDomain = new DeathRollManager();
            _deathRollManager = new DeathrollManager{EchecJdsContreMort = 0, SuccesJdsContreMort = 0};
        }

        [Test]
        public void map_DeathRollManagerDomain_returnDeathRollManager()
        {
            var result = _mapper.Map<DeathrollManager>(_deathRollManagerDomain);
            
            Assert.AreEqual(_deathRollManagerDomain.FailRoll, result.EchecJdsContreMort);
            Assert.AreEqual(_deathRollManagerDomain.SuccessRoll, result.SuccesJdsContreMort);
        }
        
        [Test]
        public void map_DeathRollManager_returnDeathRollManagerDomain()
        {
            var result = _mapper.Map<DeathRollManager>(_deathRollManager);
            
            Assert.AreEqual(_deathRollManager.EchecJdsContreMort, result.FailRoll);
            Assert.AreEqual(_deathRollManager.SuccesJdsContreMort, result.SuccessRoll);
        }
    }
}