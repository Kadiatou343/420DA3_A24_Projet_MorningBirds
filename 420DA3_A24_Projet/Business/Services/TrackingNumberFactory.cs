using Project_Utilities.Enums;
using Project_Utilities.Services.APIs;

namespace _420DA3_A24_Projet.Business.Services;
public class TrackingNumberFactory {

    private static readonly FakeCanadaPostAPI fakeCanadaPostAPI = new FakeCanadaPostAPI();
    private static readonly FakeFedExAPI fakeFedExAPI = new FakeFedExAPI();
    private static readonly FakePurolatorAPI fakePurolatorAPI = new FakePurolatorAPI();

    private static TrackingNumberFactory? instance;
    private TrackingNumberFactory() { }

    public static TrackingNumberFactory GetInstance() {
        instance ??= new TrackingNumberFactory();
        return instance;
    }

    public string GetNewTrackingNumber(ShippingProvidersEnum shipmentProvider) {
        string trackingNumber;
        switch (shipmentProvider) {
            case ShippingProvidersEnum.Purolator:
                trackingNumber = fakePurolatorAPI.GetTrackingNumber();
                break;
            case ShippingProvidersEnum.FedEx:
                trackingNumber = fakeFedExAPI.GetTrackingNumber();
                break;
            case ShippingProvidersEnum.PostesCanada:
            default:
                trackingNumber = fakeCanadaPostAPI.GetTrackingNumber();
                break;

        }
        return trackingNumber;
    }
}
