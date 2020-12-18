using API;
using AutoMapper;
using Models.FicheModel;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapBasicCharacterInfo
    {
        
        private IMapper _mapper;
        private BasicCharacterInfo _basicCharacterInfoDomain;
        private BasicInfo _basicInfo;

        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();

            _basicCharacterInfoDomain = new BasicCharacterInfo();
            _basicInfo = new BasicInfo {NomPersonnage = "", Classe = "", Experience = 0, Niveau = 0, Race = ""};
        }

        [Test]
        public void map_basicCharacterInfoDomain_returnBasicInfo()
        {
            var result = _mapper.Map<BasicInfo>(_basicCharacterInfoDomain);
            
            Assert.AreEqual(_basicCharacterInfoDomain.NomPersonnage ,result.NomPersonnage );
            Assert.AreEqual(_basicCharacterInfoDomain.Niveau ,result.Niveau );
            Assert.AreEqual(_basicCharacterInfoDomain.Race ,result.Race );
            Assert.AreEqual(_basicCharacterInfoDomain.Experience ,result.Experience );
            Assert.AreEqual(_basicCharacterInfoDomain.Classe ,result.Classe );

        }
        
        [Test]
        public void map_basicInfo_returnBasicCharacterInfoDomain()
        {
            var result = _mapper.Map<BasicCharacterInfo>(_basicInfo);
            
            Assert.AreEqual(_basicInfo.NomPersonnage ,result.NomPersonnage );
            Assert.AreEqual(_basicInfo.Niveau ,result.Niveau );
            Assert.AreEqual(_basicInfo.Race ,result.Race );
            Assert.AreEqual(_basicInfo.Experience ,result.Experience );
            Assert.AreEqual(_basicInfo.Classe ,result.Classe );

        }

    }
}