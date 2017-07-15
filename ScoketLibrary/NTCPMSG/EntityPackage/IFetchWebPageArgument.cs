﻿using NTCPMessage.EntityPackage.Arguments;
using System.Collections.Generic;

namespace NTCPMessage.EntityPackage
{

    /// <summary>
    /// 抓取搜索网页的参数接口
    /// </summary>
    public interface IFetchWebPageArgument
    {
        /// <summary>
        /// 关键词
        /// </summary>
        string KeyWord { get; set; }

        /// <summary>
        /// 页码
        /// </summary>

         int PageNumber { get; set; }


        /// <summary>
        /// 排序字段集合
        /// </summary>
         List<OrderField> OrderFiledList { get; set; }

        /// <summary>
        /// 需要过滤的字段集合 对于勾选的字段  传递过来
        /// </summary>
         List<FilterFiled> FilterFiledList { get; set; }

        /// <summary>
        /// 获取当前平台支持的排序字段列表
        /// </summary>
        /// <returns></returns>
        List<OrderField> GetCurrentPlatformSupportOrderFields();
    }
}