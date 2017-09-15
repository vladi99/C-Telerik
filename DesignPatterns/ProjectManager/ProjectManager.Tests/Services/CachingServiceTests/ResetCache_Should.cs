using NUnit.Framework;
using ProjectManager.Framework.Services;
using System;

namespace ProjectManager.Tests.Services.CachingServiceTests
{
    [TestFixture]
    public class ResetCache_Should
    {
        [Test]
        public void ResetCache_WhenParametersAreCorrect()
        {
            // Arrange
            var duration = new TimeSpan(30, 0, 0, 0, 0);
            var className = "Pesho";
            var methodName = "Pesho";
            var className1 = "Pesho1";
            var methodName1 = "Pesho1";
            var cachingService = new CachingService(duration);
            var objectForCaching = new object();

            // Act
            cachingService.AddCacheValue(className, methodName, objectForCaching);
            cachingService.ResetCache();
            cachingService.AddCacheValue(className1, methodName1, objectForCaching);
            var result = cachingService.GetCacheValue("Pesho1", "Pesho1");
            // Assert
            Assert.AreEqual(objectForCaching, result);
        }
    }
}
