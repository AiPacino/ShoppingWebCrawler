﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTCPMessage.EntityPackage.Arguments
{
    /// <summary>
    /// 【苏宁】搜索页面 参数
    /// 具体详细的搜索面板 回头慢慢完善
    /// </summary>
    public sealed class SuningFetchWebPageArgument:BaseFetchWebPageArgument
    {

        public SuningFetchWebPageArgument()
        {
            this.Platform = SupportPlatformEnum.Suning;
        }


        /// <summary>
        /// 排序参数
        /// </summary>
        public override string OrderFiledName
        {
            get
            {
                return "st";
            }

        }
        /// <summary>
        /// 获取【苏宁】平台支持的排序字段列表
        /// </summary>
        /// <returns></returns>
        public override List<OrderField> GetCurrentPlatformSupportOrderFields()
        {
            List<OrderField> fields = new List<OrderField>() {

                 new OrderField { DisplayName="综合", FieldValue="0" },
                 new OrderField { DisplayName="销量", FieldValue="8" },
                 new OrderField { DisplayName="价格", FieldValue="9" },
                 new OrderField { DisplayName="评价数", FieldValue="6" },
                
            };

            return fields;
        }
    }
}
