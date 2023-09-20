using BusinessLogic.Services;
using Domain.Interfaces;
using Domain.Models;
using Moq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Tests
{
    public class UserServiceTest
    {
        private readonly UserService service;
        private readonly Mock<IUserRepository> userRepositoryMoq;

        public UserServiceTest()
        {
            var repositoryWrapperMoq = new Mock<IRepositoryWrapper>();
            userRepositoryMoq = new Mock<IUserRepository>();

            repositoryWrapperMoq.Setup(x => x.User)
                .Returns(userRepositoryMoq.Object);



            service = new UserService(repositoryWrapperMoq.Object);
        }

        [Fact]
        public async Task CreateAsync_NullUser_ShouldThrowNullArgumentException()
        {
            // act
            var ex = await Assert.ThrowsAsync<ArgumentNullException>(() => service.Create(null));

            // assert
            Assert.IsType<ArgumentNullException>(ex);
            userRepositoryMoq.Verify(x => x.Create(It.IsAny<User>()), Times.Never);
        }

        public static IEnumerable<object[]> GetIncorrectUsers()
        {
            return new List<object[]> {
                new object[] { new User() { UserLogin = "f", UserPassword = "", RegDate = DateTime.Now, IsDeleted = true, IdRole = 0 } },
                new object[] { new User() { UserLogin = "", UserPassword = "12345", RegDate = DateTime.Now, IsDeleted = true, IdRole = 0 } },
                new object[] { new User() { UserLogin = "", UserPassword = "", RegDate = DateTime.Now, IsDeleted = true, IdRole = 15 } },
                new object[] { new User() { UserLogin = "f", UserPassword = "f", RegDate = DateTime.Now, IsDeleted = true, IdRole = 234 } },
            };
        }


        [Theory]
        [MemberData(nameof(GetIncorrectUsers))]
        public async Task CreateAsyncNewUserShouldNotCreateNewUser()
        {

            // arrange
            var newUser = new User() {
                UserLogin = "",
                UserPassword = "",
                RegDate = DateTime.Now,
               

                IsDeleted = false,
                IdRole = 0,

            };
            // act
            var ex = await Assert.ThrowsAsync<ArgumentException>(() => service.Create(newUser));

            // assert
           
            userRepositoryMoq.Verify(x => x.Create(It.IsAny<User>()), Times.Never);
            Assert.IsType<ArgumentException>(ex);
        }


        [Fact]
        public async Task CreateAsyncNewUserShouldCreateNewUser()
        {
            var newUser = new User() 
            {
                UserLogin = "Test",
                UserPassword = "Test",
                RegDate = DateTime.Now,


                IsDeleted = false,
                IdRole = 0,

            };


            // act
            await service.Create(newUser);

            // assert
            userRepositoryMoq.Verify(x => x.Create(It.IsAny<User>()), Times.Once);
        }

    }


}
