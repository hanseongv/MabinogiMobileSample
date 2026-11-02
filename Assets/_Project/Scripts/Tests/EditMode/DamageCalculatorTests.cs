// using NUnit.Framework;

// public class DamageCalculatorTests
// {
//     [Test]
//     public void CalculateDamage_ReturnsCorrectDamage()
//     {
//         var calculator = new DamageCalculator();

//         int result = calculator.CalculateDamage(100, 30);

//         Assert.AreEqual(70, result);
//     }

//     [Test]
//     public void CalculateDamage_DoesNotReturnNegativeValue()
//     {
//         var calculator = new DamageCalculator();

//         int result = calculator.CalculateDamage(30, 100);

//         Assert.AreEqual(0, result);
//     }

//     [TestCase(100, 30, 70)]
//     [TestCase(30, 100, 0)]
//     [TestCase(0, 30, 0)]
//     [TestCase(50, 50, 0)]
//     public void CalculateDamage_ReturnsExpectedResult(
//     int attack,
//     int defense,
//     int expected)
//     {
//         var calculator = new DamageCalculator();

//         int result = calculator.CalculateDamage(attack, defense);

//         Assert.AreEqual(expected, result);
//     }
// }