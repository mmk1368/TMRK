using System.ComponentModel.DataAnnotations;

namespace TMRK.DTOModel
{
    public class TakhsisInfo
    {
        [DataType(DataType.Text)]
        [StringLength(8)]
        [Required]
        public string BankAuthorityNo { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string BankShobehDsc { get; set; }
        [DataType(DataType.Text)]
        [StringLength(50)]
        public string FishId { get; set; }
        [DataType(DataType.Text)]
        [StringLength(8)]
        public string TarikhIjadFish { get; set; }
        [DataType(DataType.Text)]
        [StringLength(100)]
        public string ArzDsc { get; set; }
        [StringLength(20)]
        public decimal? MablaghArzi { get; set; }
        [DataType(DataType.Text)]
        [StringLength(8)]
        public string TarikhMojavez { get; set; }
        public int? MohlateEngheza { get; set; }
        [DataType(DataType.Text)]
        [StringLength(3)]
        public string Priority { get; set; }
        public string NerkhArzDsc { get; set; }
        public bool? TaahodStatus { get; set; }
        public int? NezaratTaeedVaziat { get; set; }
        public string RealNationalCode { get; set; }
        public string LegalNationalCode { get; set; }
        public string CommercialCardNo { get; set; }
    }
}