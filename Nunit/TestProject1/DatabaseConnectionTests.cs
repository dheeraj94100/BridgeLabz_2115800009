using NUnit.Framework;
using MyLibrary;  

public class DatabaseConnectionTests
    {
        private DatabaseConnection _dbConnection;

        [SetUp]
        public void Setup()
        {
            _dbConnection = new DatabaseConnection();
            _dbConnection.Connect();
        }

        [TearDown]
        public void Teardown()
        {
            _dbConnection.Disconnect();
        }

        [Test]
        public void TestDatabaseConnection_IsConnected()
        {
            Assert.IsTrue(_dbConnection.IsConnected);
        }

        [Test]
        public void TestDatabaseDisconnection_AfterTeardown()
        {
            // Disconnect is called in TearDown, so we check if it's disconnected after test
            Teardown();
            Assert.IsFalse(_dbConnection.IsConnected);
        }
    }
