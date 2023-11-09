namespace UserTests
{
    public class UserTest
    {
        [Fact]
        public void Constructor_WorkingProperly()
        {
            var User = new User("Lance");
            Assert.Equal("Lance", User.Name);
            Assert.Equal();
        }
    }
}