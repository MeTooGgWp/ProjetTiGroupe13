using System;
using Entities;
using Microsoft.Extensions.Options;
using Models;
using NUnit.Framework;
using ProjetctTiGr13.Helpers;
using ProjetctTiGr13.Services;

namespace UnitTest.ProjetctTiGr13Test
{
    [TestFixture]
    public class UserServiceTest
    {
        private IUserService _userService;
        private AuthenticateRequest _model;
        private AuthenticateResponse _response;
        private User _user;
        
        [SetUp]
        public void SetUp()
        {
            AppSettings appSettings = new AppSettings{
                Secret= "THIS IS A TEST SECRET KEY NEED TO BE CHANGED"
            };
            IOptions<AppSettings> ioptions = new OptionsWrapper<AppSettings>(appSettings);
            _userService = new UserService(ioptions);
            _model = new AuthenticateRequest {Pseudo = "louis", Password = "b7450e4a68d91b267fcff0b1d8a2d51b"};
            _user = new User{mail = "louis14@live.be",Password = "b7450e4a68d91b267fcff0b1d8a2d51b", pseudo = "louis"};
            _response = new AuthenticateResponse (_user, "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJwc2V1ZG8iOiJsb3VpcyIsIm5iZiI6MTYwODMwOTc5MiwiZXhwIjoxNjA4OTE0NTkyLCJpYXQiOjE2MDgzMDk3OTJ9.XrS_Jm2If684oz25UcKJHz11IWWMnSlRZnk4poUCunU");
        }

        [Test]
        [Ignore("test pas fonctionnel")]
        public void Authenticate_AuthenticateRequestValid_returnAuthenticateResponseValid()
        {
            var result = _userService.Authenticate(_model);
            //Nous n'avons pas trouvé comment vérifier les token...
            Assert.AreEqual(_response,result);
        }
    }
}