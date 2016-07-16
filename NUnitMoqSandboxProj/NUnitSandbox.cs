using Moq;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace NUnitTestProject2 {
  [TestFixture]
  public class NUnitTest1 {
    [Test]
    public void MoqDictionaryPOC() {
      // Arrange
      Mock<ITestRepository> _repo = new Mock<ITestRepository>();
      Dictionary<string, string> expected = new Dictionary<string, string>() { { "Some name", "Some value" } };
      // Act
      _repo.Setup(x => x.GetBullshitDictionaryData()).Returns(() => new Dictionary<string, string> { { "Some name", "Some value" } });
      // Assert
      Assert.AreEqual(expected, _repo.Object.GetBullshitDictionaryData());
    }
  }

  public class TestRepository : ITestRepository {
    public Dictionary<string, string> GetBullshitDictionaryData() {
      return null;
    }
  }
}