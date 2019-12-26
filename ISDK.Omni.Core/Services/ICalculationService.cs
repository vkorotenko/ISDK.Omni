namespace ISDK.Omni.Core.Services
{
    public interface ICalculationService
    {
        double TipAmount(double subTotal, int generosity);
    }
}
