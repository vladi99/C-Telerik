using NUnit.Framework;
using ProjectManager.Framework.Services;
using System;

namespace ProjectManager.Tests.Services.CachingServiceTests
{
    [TestFixture]
    public class AddCacheShould
    {
        [Test]
        public void AddCache_WhenParametersAreCorrect()
        {
            // Arrange
            var duration = new TimeSpan(30, 0, 0, 0, 0);
            var className = "Pesho";
            var methodName = "Pesho";
            var cachingService = new CachingService(duration);
            var objectForCaching = new object();

            // Act
            cachingService.AddCacheValue(className, methodName, objectForCaching);
            var result = cachingService.GetCacheValue("Pesho", "Pesho");
            // Assert
            Assert.AreEqual(objectForCaching, result);
            
        }
    }
}
