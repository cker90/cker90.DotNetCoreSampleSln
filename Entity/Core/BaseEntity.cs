using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Entity.Core
{
    /// <summary>
    /// DB表基础属性
    /// </summary>
    public abstract class BaseEntity<T>
    {
        public BaseEntity()
        {
            CreteTime = DateTime.Now;
        }
        /// <summary>
        /// 主键Id
        /// </summary>
        [DataMember]
        [Key]
        public T Id { get; set; }

        /// <summary>
        /// DB版号,Mysql详情参考;http://www.cnblogs.com/shanyou/p/6241612.html
        /// </summary>
        //[Timestamp]//Mysql不允许byte[]类型上标记TimeStamp/RowVersion，这里使用DateTime类型配合标记ConcurrencyCheck达到并发控制
        [ConcurrencyCheck]
        public DateTime RowVersion { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreteTime { get; set; }
    }
}
