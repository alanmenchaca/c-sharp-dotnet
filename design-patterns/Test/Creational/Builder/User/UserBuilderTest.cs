using design_patterns.Creational.Builder.User;
using NUnit.Framework;

namespace design_patterns.Test.Creational.Builder.User;

public class UserBuilderTest
{
    [Test]
    public void BuildEmptyUser_ShouldReturnUserWithDefaultValues()
    {
        // Arrange
        var userBuilder = UserBuilder.Make("1", "John", "Doe");

        // Act
        var user = userBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(user, Is.Not.Null);
            Assert.That(user.Id, Is.EqualTo("1"));
            Assert.That(user.Nick, Is.EqualTo("John"));
            Assert.That(user.Name, Is.EqualTo("Doe"));
            Assert.That(user.FamilyName, Is.Null);
            Assert.That(user.Age, Is.Null);
            Assert.That(user.Phone, Is.Null);
            Assert.That(user.Profession, Is.Null);
            Assert.That(user.Tags?.Count, Is.Null);
        });
    }

    [Test]
    public void BuildUserWithPartialFields_ShouldReturnUserWithSetFields()
    {
        // Arrange
        var userBuilder = UserBuilder
            .Make("1", "John", "Doe")
            .Phone(0123456789)
            .FamilyName("Doe");

        // Act
        var user = userBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(user.Id, Is.EqualTo("1"));
            Assert.That(user.Nick, Is.EqualTo("John"));
            Assert.That(user.Name, Is.EqualTo("Doe"));
            Assert.That(user.FamilyName, Is.EqualTo("Doe"));
            Assert.That(user.Age, Is.Null);
            Assert.That(user.Phone, Is.EqualTo(0123456789));
            Assert.That(user.Profession, Is.Null);
            Assert.That(user.Tags?.Count, Is.Null);
        });
    }

    [Test]
    public void BuildUserWithAllFields_ShouldReturnFullUser()
    {
        // Arrange
        var userBuilder = UserBuilder
            .Make("1", "John", "Doe")
            .FamilyName("Doe")
            .Phone(0123456789)
            .Adult()
            .Profession("Professor")
            .Tag("Director").Tag("Socio").Tag("Consejo");

        // Act
        var user = userBuilder.Build();

        // Assert
        Assert.Multiple(() =>
        {
            Assert.That(user.Id, Is.EqualTo("1"));
            Assert.That(user.Nick, Is.EqualTo("John"));
            Assert.That(user.Name, Is.EqualTo("Doe"));
            Assert.That(user.FamilyName, Is.EqualTo("Doe"));
            Assert.That(user.Phone, Is.EqualTo(0123456789));
            Assert.That(user.Age, Is.EqualTo(18));
            Assert.That(user.Profession, Is.EqualTo("Professor"));
            Assert.That(user.Tags?.Count, Is.EqualTo(3));
        });
    }
}