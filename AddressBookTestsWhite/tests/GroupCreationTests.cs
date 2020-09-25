using System;
using System.Collections.Generic;
using AddressBookTestsWhite.model;
using NUnit.Framework;


namespace AddressBookTestsWhite.tests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {
            List<GroupData> oldGroups = app.Groups.GetGroupList();
            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.Add(newGroup);
            oldGroups.Sort();
            newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);
        }

        [Test]
        public void TestGroupRemoval()
        {
            //prepair

            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };
            app.Groups.CreateGroupIfExist(newGroup);

            List<GroupData> oldGroups = app.Groups.GetGroupList();


            //action
            app.Groups.RemoveGroup();

            //verification
            List<GroupData> newGroups = app.Groups.GetGroupList();
            Assert.AreEqual(newGroups.Count + 1, oldGroups.Count);
            //Assert.AreEqual()
        }

    }
}
