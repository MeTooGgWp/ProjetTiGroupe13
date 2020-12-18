using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;
using Models.FicheModel;
namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapSaveRoll
    {

        private IMapper _mapper;
        private SaveRollManager _saveRollManagerDomain;
        private Models.FicheModel.SaveRollsManager _saveRollsManager;




        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            _saveRollManagerDomain = new SaveRollManager();
            _saveRollsManager = new Models.FicheModel.SaveRollsManager
            {
                JdsForce = false, JdsDexterite = false, JdsConstitution = false, JdsIntelligence = false,
                JdsSagesse = false, JdsCharisme = false
            };
        }

        [Test]
        public void map_SaveRollManagerDomain_returnSaveRollsManager()
        {
            var result = _mapper.Map<SaveRollsManager>(_saveRollManagerDomain);

            Assert.AreEqual(_saveRollManagerDomain.ForceSave, result.JdsForce);
            Assert.AreEqual(_saveRollManagerDomain.DexteriteSave, result.JdsDexterite);
            Assert.AreEqual(_saveRollManagerDomain.ConstitutionSave, result.JdsConstitution);
            Assert.AreEqual(_saveRollManagerDomain.IntelligenceSave, result.JdsIntelligence);
            Assert.AreEqual(_saveRollManagerDomain.SagesseSave, result.JdsSagesse);
            Assert.AreEqual(_saveRollManagerDomain.CharismeSave, result.JdsCharisme);
        }

        [Test]
        public void map_SaveRollsManager_returnSaveRollManagerDomain()
        {
            var result = _mapper.Map<SaveRollManager>(_saveRollsManager);

            Assert.AreEqual(_saveRollsManager.JdsForce, result.ForceSave);
            Assert.AreEqual(_saveRollsManager.JdsDexterite, result.DexteriteSave);
            Assert.AreEqual(_saveRollsManager.JdsConstitution, result.ConstitutionSave);
            Assert.AreEqual(_saveRollsManager.JdsIntelligence, result.IntelligenceSave);
            Assert.AreEqual(_saveRollsManager.JdsSagesse, result.SagesseSave);
            Assert.AreEqual(_saveRollsManager.JdsCharisme, result.CharismeSave);
        }
    }
}