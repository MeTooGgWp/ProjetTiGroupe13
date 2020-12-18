using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapMoneyManager
    {
        private IMapper _mapper;
        private MoneyManager _moneyManagerDomain;
        private Models.FicheModel.MoneyManager _moneyManager;
        
        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
            
            _moneyManagerDomain = new MoneyManager();
            _moneyManager = new Models.FicheModel.MoneyManager
            {
                PieceArgent = 0,PieceCuivre = 0,PieceElectrum = 0,PieceOr = 0, PiecePlatine = 0
            };
            
        }

        [Test]
        public void map_MoneyManagerDomain_returnMoneyManager()
        {
            var result = _mapper.Map<Models.FicheModel.MoneyManager>(_moneyManagerDomain);
            
            Assert.AreEqual(_moneyManagerDomain.Argent,result.PieceArgent);
            Assert.AreEqual(_moneyManagerDomain.Cuivre,result.PieceCuivre);
            Assert.AreEqual(_moneyManagerDomain.Electrum,result.PieceElectrum);
            Assert.AreEqual(_moneyManagerDomain.Or,result.PieceOr);
            Assert.AreEqual(_moneyManagerDomain.Platine,result.PiecePlatine);
        }
        
        [Test]
        public void map_MoneyManager_returnMoneyManagerDomain()
        {
            var result = _mapper.Map<MoneyManager>(_moneyManager);
            
            Assert.AreEqual(_moneyManager.PieceArgent,result.Argent);
            Assert.AreEqual(_moneyManager.PieceCuivre,result.Cuivre);
            Assert.AreEqual(_moneyManager.PieceElectrum,result.Electrum);
            Assert.AreEqual(_moneyManager.PieceOr,result.Or);
            Assert.AreEqual(_moneyManager.PiecePlatine,result.Platine);
        }
    }
}