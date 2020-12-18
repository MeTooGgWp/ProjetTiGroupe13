using API;
using AutoMapper;
using Models.FicheModel;
using NUnit.Framework;
using ProjetctTiGr13.Domain.FicheComponent;
using Competence = ProjetctTiGr13.Domain.FicheComponent.Competence;

namespace UnitTest.TestMappeur
{
    [TestFixture]
    public class testMapCompetence
    {
        private IMapper _mapper;
        private Competence _CompetenceDomain;
        private Models.FicheModel.CompetencesFiche _Competence;

        [SetUp]
        public void setUp()
        {
            MapperConfiguration mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            _mapper = mapperConfiguration.CreateMapper();

            _CompetenceDomain = new Competence();
            _Competence = new Models.FicheModel.CompetencesFiche()
            {
                IdComp = 0
            };
        }

        [Test]
        public void map_CompetenceDomain_returnCompetence()
        {
            var result = _mapper.Map<Models.FicheModel.CompetencesFiche>(_CompetenceDomain);

            Assert.AreEqual(_CompetenceDomain.IdComp, result.IdComp);

        }

        [Test]
        public void map_Competence_returnCompetenceDomain()
        {
            var result = _mapper.Map<Competence>(_Competence);

            Assert.AreEqual(_Competence.IdComp, result.IdComp);

        }

    }
}