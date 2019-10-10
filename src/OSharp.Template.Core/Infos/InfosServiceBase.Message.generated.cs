// -----------------------------------------------------------------------
// <auto-generated>
//    此代码由代码生成器生成。
//    手动更改此文件可能导致应用程序出现意外的行为。
//    如果重新生成代码，对此文件的任何修改都会丢失。
//    如果需要扩展此类，可以遵守如下规则进行扩展：
//      1.横向扩展：如需给当前实体 Message 添加方法，可新建文件“InfosServiceBase.Message.cs”的分部类“public abstract partial class InfosServiceBase”添加功能
//      2.纵向扩展：如需要重写当前实体 Message 的业务实现，可新建文件“InfosService.Message.cs”的分部类“public partial class InfosService”对现有方法进行方法重写实现
// </auto-generated>
//
//  <copyright file="InfosServiceBase.Message.generated.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2019 Liuliu. All rights reserved.
//  </copyright>
//  <site>https://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
// -----------------------------------------------------------------------

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

using OSharp.Data;
using OSharp.Dependency;
using OSharp.Extensions;
using OSharp.Mapping;

using OSharp.Template.Infos.Dtos;
using OSharp.Template.Infos.Entities;


namespace OSharp.Template.Infos
{
    public abstract partial class InfosServiceBase
    {
        /// <summary>
        /// 获取 站内信信息查询数据集
        /// </summary>
        public IQueryable<Message> Messages
        {
            get { return MessageRepository.QueryAsNoTracking(); }
        }

        /// <summary>
        /// 检查站内信信息是否存在
        /// </summary>
        /// <param name="predicate">检查谓语表达式</param>
        /// <param name="id">更新的站内信信息编号</param>
        /// <returns>站内信信息是否存在</returns>
        public virtual Task<bool> CheckMessageExists(Expression<Func<Message, bool>> predicate, Guid id = default(Guid))
        {
            return MessageRepository.CheckExistsAsync(predicate, id);
        }
        
        /// <summary>
        /// 添加站内信信息
        /// </summary>
        /// <param name="dtos">要添加的站内信信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> CreateMessages(params MessageInputDto[] dtos)
        {
            Check.Validate<MessageInputDto, Guid>(dtos, nameof(dtos));
            return MessageRepository.InsertAsync(dtos);
        }
        
        /// <summary>
        /// 更新站内信信息
        /// </summary>
        /// <param name="dtos">包含更新信息的站内信信息DTO信息</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> UpdateMessages(params MessageInputDto[] dtos)
        {
            Check.Validate<MessageInputDto, Guid>(dtos, nameof(dtos));
            return MessageRepository.UpdateAsync(dtos);
        }
        
        /// <summary>
        /// 删除站内信信息
        /// </summary>
        /// <param name="ids">要删除的站内信信息编号</param>
        /// <returns>业务操作结果</returns>
        public virtual Task<OperationResult> DeleteMessages(params Guid[] ids)
        {
            Check.NotNull(ids, nameof(ids));
            return MessageRepository.DeleteAsync(ids);
        }
    }
}
