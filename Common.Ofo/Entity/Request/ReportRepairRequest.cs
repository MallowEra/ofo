﻿namespace Common.Ofo.Entity.Request
{
    /// <summary>
    /// 保修请求
    /// </summary>
    public class ReportRepairRequest : BasePositionRequest
    {
        #region 属性

        /// <summary>
        /// 地址名称
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 是否GSM？
        /// 默认0
        /// </summary>
        public int IsGsm { get; set; } = 0;

        public string OrderNumber { get; set; }

        /// <summary>
        /// 原因，由报修原因字典接口获得
        /// errorpwd
        /// </summary>
        public string Reason { get; set; }

        #endregion 属性

        #region 构造函数

        /// <summary>
        /// 保修请求
        /// </summary>
        public ReportRepairRequest()
        {
            ApiUrl = ApiUrls.ReportRepair;
        }

        #endregion 构造函数

        #region 方法

        public override string GetFormString()
        {
            return base.GetFormString() + $"&ordernum={OrderNumber}&reason={Reason}&address={Address}&isGsm={IsGsm}";
        }

        #endregion 方法
    }
}