using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using twitter_contest_dotnet.Models;
using twitter_contest_dotnet.Services;

namespace twitter_contest_dotnet_test
{
    [TestClass]
    public class DuelServiceTest
    {
        [TestMethod]
        public void TestGenerateDuelLights2Tweeters()
        {
            var service = new DuelService();
            var tweeters = new List<Tweeter>
            {
                new Tweeter
                {
                    Id= "1",
                    Name = "1",
                    TwitterUserId = "1"
                },
                new Tweeter
                {
                    Id= "2",
                    Name = "2",
                    TwitterUserId = "2"
                }
            };
            var likesByTweeterId = new Dictionary<string, int>();
            likesByTweeterId.Add(key: "1", value: 5);
            likesByTweeterId.Add(key: "2", value: 10);
            var duels = service.GenerateDuelLights(tweeters, likesByTweeterId);

            Assert.AreEqual(1, duels.Length);
            // 1 vs 2
            Assert.AreEqual("1", duels[0].TweeterA.Id);
            Assert.AreEqual("2", duels[0].TweeterB.Id);
        }
        [TestMethod]
        public void TestGenerateDuelLights4Tweeters()
        {
            var service = new DuelService();
            var tweeters = new List<Tweeter>
            {
                new Tweeter
                {
                    Id= "1",
                    Name = "1",
                    TwitterUserId = "1"
                },
                new Tweeter
                {
                    Id= "2",
                    Name = "2",
                    TwitterUserId = "2"
                },
                new Tweeter
                {
                    Id= "3",
                    Name = "3",
                    TwitterUserId = "3"
                },
                new Tweeter
                {
                    Id= "4",
                    Name = "4",
                    TwitterUserId = "4"
                },
            };
            var likesByTweeterId = new Dictionary<string, int>();
            likesByTweeterId.Add(key: "1", value: 5);
            likesByTweeterId.Add(key: "2", value: 10);
            likesByTweeterId.Add(key: "3", value: 5);
            likesByTweeterId.Add(key: "4", value: 20);
            var duels = service.GenerateDuelLights(tweeters, likesByTweeterId);

            Assert.AreEqual(3, duels.Length);
            // 1 vs 2
            Assert.AreEqual("1", duels[0].TweeterA.Id);
            Assert.AreEqual("2", duels[0].TweeterB.Id);

            // 2 vs 3
            Assert.AreEqual("2", duels[1].TweeterA.Id);
            Assert.AreEqual("3", duels[1].TweeterB.Id);

            // 2 vs 4
            Assert.AreEqual("2", duels[2].TweeterA.Id);
            Assert.AreEqual("4", duels[2].TweeterB.Id);
        }
        [TestMethod]
        public void TestGenerateDuelLights5Tweeters()
        {
            var service = new DuelService();
            var tweeters = new List<Tweeter>
            {
                new Tweeter
                {
                    Id= "1",
                    Name = "1",
                    TwitterUserId = "1"
                },
                new Tweeter
                {
                    Id= "2",
                    Name = "2",
                    TwitterUserId = "2"
                },
                new Tweeter
                {
                    Id= "3",
                    Name = "3",
                    TwitterUserId = "3"
                },
                new Tweeter
                {
                    Id= "4",
                    Name = "4",
                    TwitterUserId = "4"
                },
                new Tweeter
                {
                    Id= "5",
                    Name = "5",
                    TwitterUserId = "5"
                },

            };
            var likesByTweeterId = new Dictionary<string, int>();
            likesByTweeterId.Add(key: "1", value: 5);
            likesByTweeterId.Add(key: "2", value: 10);
            likesByTweeterId.Add(key: "3", value: 5);
            likesByTweeterId.Add(key: "4", value: 20);
            likesByTweeterId.Add(key: "5", value: 5);
            var duels = service.GenerateDuelLights(tweeters, likesByTweeterId);

            Assert.AreEqual(4, duels.Length);

            // 1 vs 2
            Assert.AreEqual("1", duels[0].TweeterA.Id);
            Assert.AreEqual("2", duels[0].TweeterB.Id);

            // 2 vs 3
            Assert.AreEqual("2", duels[1].TweeterA.Id);
            Assert.AreEqual("3", duels[1].TweeterB.Id);

            // 2 vs 4
            Assert.AreEqual("2", duels[2].TweeterA.Id);
            Assert.AreEqual("4", duels[2].TweeterB.Id);

            // 4 vs 5
            Assert.AreEqual("4", duels[3].TweeterA.Id);
            Assert.AreEqual("5", duels[3].TweeterB.Id);
        }
    }
}
