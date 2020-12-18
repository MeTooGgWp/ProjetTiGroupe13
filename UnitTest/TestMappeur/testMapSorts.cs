using API;
using AutoMapper;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapSorts
    {
        private IMapper _mapper;
        private Sort _sortDomain;
        private Models.FicheModel.Sort _sort;
        
        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();
            
            _sortDomain = new Sort();
            _sort = new Models.FicheModel.Sort
            {
                DescriptionSort = "",NiveauSort = 0,NomSort = ""
            };
            
        }

        [Test]
        public void map_sortDomain_returnSort()
        {
            var result = _mapper.Map<Models.FicheModel.Sort>(_sortDomain);
            
            Assert.AreEqual(_sortDomain.DescriptionSort ,result.DescriptionSort);
            Assert.AreEqual(_sortDomain.NiveauSort ,result.NiveauSort);
            Assert.AreEqual(_sortDomain.NomSort ,result.NomSort);
        }
        
        [Test]
        public void map_sort_returnSortDomain()
        {
            var result = _mapper.Map<Sort>(_sort);
            
            Assert.AreEqual(_sort.DescriptionSort ,result.DescriptionSort);
            Assert.AreEqual(_sort.NiveauSort ,result.NiveauSort);
            Assert.AreEqual(_sort.NomSort ,result.NomSort);
        }
    }
}