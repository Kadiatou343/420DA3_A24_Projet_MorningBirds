using Project_Utilities.Services.Abstracts;

namespace Project_Utilities.Services.APIs;
public class FakePurolatorAPI : IShipmentDataProvider {
    public string GetTrackingNumber() {
        return "PUR-" + IShipmentDataProvider.GenerateNumber();
    }

}
