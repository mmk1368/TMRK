using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.DTOModel;
using TMRK.Entities;

namespace TMRK.Config.Mapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<TakhsisNtsw, TakhsisInfo>()
                .ForMember(x => x.BankAuthorityNo, opt => opt.MapFrom(y => y.BankAuthorityNo))
                .ForMember(x => x.BankShobehDsc, opt => opt.MapFrom(y => y.BankShobehDsc))
                .ForMember(x => x.FishId, opt => opt.MapFrom(y => y.Id))
                .ForMember(x => x.TarikhIjadFish, opt => opt.MapFrom(y => y.TarikhIjadFish.NormalizeDate()))
                .ForMember(x => x.ArzDsc, opt => opt.MapFrom(y => y.ArzDsc))
                .ForMember(x => x.MablaghArzi, opt => opt.MapFrom(y => y.MablaghArzi))
                .ForMember(x => x.TarikhMojavez, opt => opt.MapFrom(y => y.TarikhMojavez.NormalizeDate()))
                .ForMember(x => x.MohlateEngheza, opt => opt.MapFrom(y => y.MohlatEngheza))
                .ForMember(x => x.Priority, opt => opt.MapFrom(y => y.Priority))
                .ForMember(x => x.NerkhArzDsc, opt => opt.MapFrom(y => SelectNerkhArzDsc(y)))
                .ForMember(x => x.TaahodStatus, opt => opt.MapFrom(y => y.Taahod))
                .ForMember(x => x.NezaratTaeedVaziat, opt => opt.MapFrom(y => NezaratTaeedVaziyat(y)))
                .ForMember(x => x.RealNationalCode, opt => opt.MapFrom(y => y.CodeMelli))
                .ForMember(x => x.LegalNationalCode, opt => opt.MapFrom(y => y.ShenaseMelli))
                .ForMember(x => x.CommercialCardNo, opt => opt.MapFrom(y => y.CommercialCardNo));
        }

        private object NezaratTaeedVaziyat(TakhsisNtsw y)
        {
            if (!string.IsNullOrWhiteSpace(y.TarikhEbtalFish))
            {
                return 0;
            }
            if (y.NezaratTaeedVaziyat == 1)
            {
                return 1;
            }
            if (y.NezaratTaeedVaziyat == 2)
            {
                return 2;
            }
            if (y.NezaratTaeedVaziyat > 2)
            {
                return 3;
            }
            return null;
        }

        private object SelectNerkhArzDsc(TakhsisNtsw y)
        {
            if (y.NerkhArzCode != "6")
            {
                return y.NerkhArzDsc;
            }
            else
            {
                switch (y.MahalCode)
                {
                    case null:
                    case "":
                        return "ارز اشخاص";
                    case "1":
                        return "ارز اشخاص-از محل صادرات";
                    case "2":
                        return "ارز اشخاص-از محل سپرده ارزی";
                    case "3":
                        return "ارز اشخاص-از محل صادرات خود";
                    case "4":
                        return "ارز اشخاص-از محل صادرات غیر";
                    default:
                        break;
                }
                return "Error";
            }
        }
    }
}
