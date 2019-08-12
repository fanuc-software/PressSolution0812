using AutoMapper;
using FanucCnc.Model;
using PressHmi.ViewModel;

namespace PressHmi.App_Start
{
    public class AutoMapperConfig
    {
        private static MapperConfiguration _mapperConfiguration;

        /// <summary>
        /// 注册模块
        /// </summary>
        public static void Register()
        {

            _mapperConfiguration = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<MainTitleInfo, MainTitleInfoDto>();
                cfg.CreateMap<BaseInfo, SysetmInfoViewModel>()
                    .ForMember(m => m.Ip, e => e.MapFrom(item => item.Ip))
                    .ForMember(m => m.Port, e => e.MapFrom(item => item.Port))
                    .ForMember(m => m.Timeout, e => e.MapFrom(item => item.Timeout))
                    .ForMember(m => m.Increment, e => e.MapFrom(item => item.Increment))
                    .ForMember(m => m.RealTimeSciChartInflgAdr, e => e.MapFrom(item => item.RealTimeSciChartInflgAdr))
                .ForMember(m => m.RealTimeSciChartInflgAdrType, e => e.MapFrom(item => item.RealTimeSciChartInflgAdrType))
                .ForMember(m => m.RealTimeSciChartInflgBit, e => e.MapFrom(item => item.RealTimeSciChartInflgBit))
                .ForMember(m => m.SciChartXTimeMax, e => e.MapFrom(item => item.SciChartXTimeMax))
                .ForMember(m => m.CsdFolder, e => e.MapFrom(item => item.CsdFolder));
            });
        }

        /// <summary>
        /// 获取配置
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration GetMapperConfiguration()
        {
            if (_mapperConfiguration == null)
                Register();

            return _mapperConfiguration;
        }
    }
}
