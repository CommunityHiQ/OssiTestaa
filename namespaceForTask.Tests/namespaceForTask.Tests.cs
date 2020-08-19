using NUnit.Framework;
using System;

namespace namespaceForTask.Tests
{
    [TestFixture]
    class TestClass
    {
        /// <summary>
        /// You need to namespaceForTask.SetPaswordsEnv.ps1 before running unit test, or some other way set environment variables e.g. with GitHub Secrets.
        /// </summary>
        [Test]
        public void ThreeclassNameForTasks()
        {
            var input = new Parameters
            {
                Message = Environment.GetEnvironmentVariable("EXAMPLEENVIROMENTVARIABLE", EnvironmentVariableTarget.User)
        };

            var options = new Options
            {
                Amount = 3,
                Delimiter = ", "
            };

            var ret = classNameForTask.TaskName(input, options, new System.Threading.CancellationToken());

            Assert.That(ret.Replication, Is.EqualTo("foobar, foobar, foobar"));
        }
    }
}
