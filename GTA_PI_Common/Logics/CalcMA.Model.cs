﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace GTA.PI.Logics
{
    /// <summary>
    /// 原始数据
    /// </summary>
    public class MARawData
    {
        /// <summary>
        /// 股票安全码
        /// </summary>
        public ulong SecurityID { get; set; }

        /// <summary>
        /// 交易日
        /// </summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime TradingDate { get; set; }

        /// <summary>
        /// 股票编号
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// 收盘价
        /// </summary>
        public double CP { get; set; }
    }

    /// <summary>
    /// 结果
    /// </summary>
    public class MAResult
    {
        public ObjectId _id; // 这个对应了 MongoDB.Bson.ObjectId (插入新数据不需要加这个字段，用于查询的)

        /// <summary>
        /// 股票安全码
        /// </summary>
        public ulong SecurityID { get; set; }

        /// <summary>
        /// 交易日
        /// </summary>
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime TradingDate { get; set; }

        /// <summary>
        /// 股票编号
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// MA值
        /// </summary>
        public double MA { get; set; }
    }
}
