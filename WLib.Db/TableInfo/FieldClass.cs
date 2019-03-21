﻿/*---------------------------------------------------------------- 
// auth： Windragon
// date： 2018
// desc： None
// mdfy:  None
//----------------------------------------------------------------*/

using System;
using WLib.Db.TableInfo.Domain;

namespace WLib.Db.TableInfo
{
    /// <summary>
    /// 表示字段
    /// </summary>
    public class FieldClass
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public Type FieldType { get; set; }
        /// <summary>
        /// 字段别名
        /// </summary>
        public string AliasName { get; set; }
        /// <summary>
        /// 字段值域范围
        /// </summary>
        public IFieldDomain Domain { get; set; }
        /// <summary>
        /// 字段对应的字典表
        /// </summary>
        public DictionaryTable DictionaryTable { get; set; }
        /// <summary>
        /// 字段是否可空
        /// </summary>
        public bool Nullable { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public int Length { get; set; }
        /// <summary>
        /// 小数位数
        /// </summary>
        public int DecimalDigits { get; set; }
        /// <summary>
        /// 是否为主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue { get; set; }
        /// <summary>
        /// 是否显示字段
        /// </summary>
        public bool Visible { get; set; }

        /// <summary>
        /// 表示字段
        /// </summary>
        /// <param name="name">字段名</param>
        public FieldClass(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// 输出字段别名
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.AliasName;
        }

        /// <summary>
        /// 验证输入值是否符合字段规范
        /// </summary>
        /// <param name="value">输入值</param>
        /// <param name="message">验证结果信息，验证通过时此值为string.Empty</param>
        /// <returns></returns>
        public bool ValidateValue(string value, out string message)
        {
            //1、非空验证
            if (!Nullable)
            {
                if (string.IsNullOrEmpty(value) || value.Trim() == string.Empty)
                {
                    message = "此项不允许为空";
                    return false;
                }
            }
            //2、长度验证
            message = string.Empty;
            if (FieldType == typeof(string))
            {
                if (Length > 0 && value.Length > Length)
                {
                    message = "长度不得大于" + Length;
                    return false;
                }
                return true;
            }

            //3、类型验证
            bool isOK = false;
            if (FieldType == typeof(int))
            {
                isOK = int.TryParse(value, out _);
                if (!isOK)
                    message = "请输入整数";
            }
            else if (FieldType == typeof(float))
            {
                isOK = float.TryParse(value, out _);
                if (!isOK)
                    message = "请输入数值";
                else
                {
                    int pointTag = value.Contains(".") ? 1 : 0;//是否包含小数点
                    int correctLength = Length + pointTag;
                    if (value.Length > correctLength)
                    {
                        isOK = false;
                        message = $"要求数值的整数部分位数不能超过{Length - DecimalDigits}，小数位为{DecimalDigits}位";
                    }
                }
            }
            else if (FieldType == typeof(DateTime))
            {
                isOK = DateTime.TryParse(value, out _);
                if (!isOK)
                    message = "请输入正确的时间";
            }

            //4、值域验证
            if (isOK)
                isOK = Domain.CheckValue(value, out message);

            return isOK;
        }
    }
}
