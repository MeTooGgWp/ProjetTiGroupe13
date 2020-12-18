using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class TestMapHealthpoint
    {
        private IMapper _mapper;
        private HealthPointManager _healthPointManagerDomain;
        private Models.FicheModel.HealthPointManager _HealthPointManager;




        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            
            _mapper = mapperConfiguration.CreateMapper();
            

            _healthPointManagerDomain = new HealthPointManager();
            _HealthPointManager = new Models.FicheModel.HealthPointManager()
            {
               PvActuel = 0,PvMax = 0,PvTemporaire = 0,DesDeVie = 0
            };
        }
            [Test]
            public void map_HealthPointManagerDomain_returnHealthPointManager()
            {
                var result = _mapper.Map<Models.FicheModel.HealthPointManager>(_healthPointManagerDomain);

                Assert.AreEqual(_healthPointManagerDomain.CurrentHp, result.PvActuel);
                Assert.AreEqual(_healthPointManagerDomain.MaxHp, result.PvMax);
                Assert.AreEqual(_healthPointManagerDomain.TemporaryHp, result.PvTemporaire);
                Assert.AreEqual(_healthPointManagerDomain.HpDice, result.DesDeVie);
               
            }

            [Test]
            public void map_HealthPointManager_returnHealthPointManagerDomain()
            {
                var result = _mapper.Map<HealthPointManager>(_HealthPointManager);

                Assert.AreEqual(_HealthPointManager.PvActuel, result.CurrentHp);
                Assert.AreEqual(_HealthPointManager.PvMax, result.MaxHp);
                Assert.AreEqual(_HealthPointManager.PvTemporaire, result.TemporaryHp);
                Assert.AreEqual(_HealthPointManager.DesDeVie, result.HpDice);
              
            }
        
    }
}