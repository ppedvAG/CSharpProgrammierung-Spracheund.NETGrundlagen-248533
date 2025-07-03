using Lab12_TermCalc.Enums;
using Lab12_TermCalc.Logik;

namespace Lab12_TermCalc.Tests.Logik
{
    [TestClass]
    public sealed class TermTests
    {
        // Empfohlene Benennung der Test-Methoden
        // public void ZuTestendeMethode_Szenario_ErwartetesErgebnis()
        // Aubau der Test-Methoden nach dem AAA-Prinzip
        // - Arrange: Vorbereitung der Testumgebung
        // - Act: Ausführung der zu testenden Methode
        // - Assert: Überprüfung des Ergebnisses
        // Jede Test-Methode fuer sich muss eigenstaendig ausfuehrbar sein
        // Sie darf nicht von anderen Test-Methoden abhaengig sein
        // Ausfuehrreihenfolge muss egal sein

        #region Positiven Testfaelle
        [TestMethod]
        public void GetRechenoperation_Addition_ReturnsAddition()
        {
            // Arrange
            var term = new Term("1 + 2");

            // Act
            var result = term.GetRechenoperation();

            // Assert
            Assert.AreEqual(Rechenoperation.Addition, result);
        }

        [TestMethod]
        [DataRow("1 - 2", Rechenoperation.Subtraktion)]
        [DataRow("1 * 2", Rechenoperation.Multiplikation)]
        [DataRow("1 / 2", Rechenoperation.Division)]
        public void GetRechenoperation_FromString_ReturnsCorrectOperation(string input, Rechenoperation expected)
        {
            // Arrange
            var term = new Term(input);

            // Act
            var result = term.GetRechenoperation();

            // Assert
            Assert.AreEqual(expected, result);
        }
        #endregion

        #region Negativen Testfaelle
        [TestMethod]
        [DataRow(null)]
        [DataRow("")]
        [DataRow("23")]
        [DataRow("adf")]
        public void GetRechenoperation_Null_ThrowsInvalidOperationException(string? input)
        {
            // Arrange
            var term = new Term(input);

            // Act
            // hier als Lambda-Ausdruck, um das Ergebnis nicht sofort zu evaluieren 
            Action action = () => term.GetRechenoperation();

            // Assert
            Assert.ThrowsException<InvalidOperationException>(action);
        }
        #endregion
    }
}
