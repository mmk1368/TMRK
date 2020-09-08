using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.DTOModel;
using TMRK.UnitOfWork;

namespace TMRK.Business
{
    public class CAI : ICAI
    {
        private IDataBase _dataBase;
        private ILogDataBase _logDataBase;


        private readonly IMapper _mapper;

        public CAI(IMapper mapper, IDataBase dataBase, ILogDataBase logDataBase)
        {
            _mapper = mapper;
            _dataBase = dataBase;
            _logDataBase = logDataBase;
        }

        public ReturnClass<CAIOutPut> GetCurrencyAllocationInformation(ICAIInput input)
        {
            var requestId = _logDataBase.Request.AddAsync(new Entities.Request
            {
                CallTime = DateTime.Now,
                MethodInput = JsonConvert.SerializeObject(input),
                MethodOrginalName = "GetCurrencyAllocationInformation",
                PointerId = 0,
                Response = null,
                ServiceId = 1,
                ServiceMethodId = 1,
                SummeryData = null

            });
            var savechanges = _logDataBase.Request.SaveChangesAsync();
            Exception exception = null;
            CAIOutPut ReturnVal = null;
            // ********** Main Event **********
            try
            {
                if (string.IsNullOrWhiteSpace(input.BankAuthorityNo) && string.IsNullOrWhiteSpace(input.NationalCode))
                {
                    return new ReturnClass<CAIOutPut>
                    {
                        ErrorStatus = 1,
                        Message = "حداقل وارد کردن یکی از دو فیلد شماره ثبت سفارش و کد/شناسه ملی اجباری است",
                        Result = null
                    };
                }
                if (input.PageSize < 1)
                {
                    return new ReturnClass<CAIOutPut>
                    {
                        ErrorStatus = 2,
                        Message = "سایز صفحه نمیتواند کوچکتر از 1 باشد",
                        Result = null
                    };
                }
                if (input.StartIndex < 0)
                {
                    return new ReturnClass<CAIOutPut>
                    {
                        ErrorStatus = 3,
                        Message = "اندیس شروع نمیتواند کوچکتر از 0 باشد",
                        Result = null
                    };
                }
                var takhsisListOrderd = _dataBase.TakhsisNtsw.Get().OrderByDescending(x => x.TarikhIjadFish).ThenByDescending(x => x.Id);
                IQueryable<Entities.TakhsisNtsw> takhsisList;

                if (string.IsNullOrWhiteSpace(input.BankAuthorityNo))
                {
                    takhsisList = takhsisListOrderd.Where(x => x.CodeMelli == input.NationalCode || x.ShenaseMelli == input.NationalCode);
                }
                else if (string.IsNullOrWhiteSpace(input.NationalCode))
                {
                    takhsisList = takhsisListOrderd.Where(x => x.BankAuthorityNo == input.BankAuthorityNo);
                }
                else
                {
                    takhsisList = takhsisListOrderd.Where(x => (x.CodeMelli == input.NationalCode || x.ShenaseMelli == input.NationalCode) && (x.BankAuthorityNo == input.BankAuthorityNo));

                }

                var TakhsisPagedList = takhsisList.Skip((input.StartIndex) * input.PageSize).Take(input.PageSize).ToListAsync().Result;
                var ReturnItem = new CAIOutPut
                {
                    Count = takhsisList.Count(),
                    LastUpdateDate = _dataBase.TakhsisNtsw.Get().Max(x => x.TarikhIjadFish).NormalizeDate(),
                    TakhsisInfoList = _mapper.Map<List<TakhsisInfo>>(TakhsisPagedList)
                };
                ReturnVal = ReturnItem;
                return new ReturnClass<CAIOutPut>
                {
                    Result = ReturnItem,
                    Message = "OK",
                    ErrorStatus = 0
                };
            }
            catch (Exception ex)
            {
                exception = ex;
                return new ReturnClass<CAIOutPut>
                {
                    Message = "مشکل در سامانه به وجود آمده است",
                    ErrorStatus = 1,
                    Result = null
                };
            }
            finally
            {
                var aaa = savechanges.Result;
                _logDataBase.Response.AddAsync(new Entities.Response
                {
                    ErrorCode = exception == null ? 0 : 1,
                    Exception = exception != null ? exception?.Message + " ****  " + exception?.StackTrace : null,
                    MethodOutput = JsonConvert.SerializeObject(ReturnVal),
                    PointerId = 0,
                    RequestId = requestId.Result.Entity.RequestId,
                    ResponseTime = DateTime.Now,
                    ServiceId = 1,
                    ServiceMethodId = 1,
                    SummeryData = null
                });
                var a = _logDataBase.Response.SaveChangesAsync().Result;
            }
        }
    }
}
