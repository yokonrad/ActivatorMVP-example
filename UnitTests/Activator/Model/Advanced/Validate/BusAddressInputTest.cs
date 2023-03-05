using Activator.Model.Advanced;

namespace UnitTests.Activator.Model.Advanced.Validate
{
    public class BusAddressInputTest
    {
        private static IEnumerable<object[]> BusAddressInputData()
        {
            List<object[]> list = new();

            for (int i = -5; i <= -1; i++)
            {
                list.Add(new object[] { false, i });
            }

            foreach (var item in RFID.Api.GetBusAddressItems().Select((value, i) => new { i, value }))
            {
                list.Add(new object[] { true, item.i });
            }

            for (int i = RFID.Api.GetBusAddressItems().Length + 1; i <= RFID.Api.GetBusAddressItems().Length + 5; i++)
            {
                list.Add(new object[] { false, i });
            }

            foreach (object[] row in list)
            {
                yield return row;
            }
        }

        [Test, TestCaseSource(nameof(BusAddressInputData))]
        public void BusAddressInputReturnsExpectedValue(bool expected, int index)
        {
            // Arrange
            var _validateModel = new ValidateModel();

            // Act
            var actual = _validateModel.BusAddressInput(index);

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}