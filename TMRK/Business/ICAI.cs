using TMRK.DTOModel;

namespace TMRK.Business
{
    public interface ICAI
    {
        ReturnClass<CAIOutPut> GetCurrencyAllocationInformation(ICAIInput input);
    }
}