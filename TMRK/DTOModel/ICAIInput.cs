namespace TMRK.DTOModel
{
    public interface ICAIInput
    {
        string BankAuthorityNo { get; set; }
        string NationalCode { get; set; }
        int PageSize { get; set; }
        int StartIndex { get; set; }
    }
}