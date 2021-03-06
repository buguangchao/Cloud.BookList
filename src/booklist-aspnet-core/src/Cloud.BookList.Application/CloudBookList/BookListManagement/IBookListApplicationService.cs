
using System;
using System.Data;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Dynamic.Core;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Abp.UI;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Linq.Extensions;
using Abp.Domain.Repositories;
using Abp.Application.Services;
using Abp.Application.Services.Dto;


using Cloud.BookList.CloudBookList.BookListManagement.Dtos;
using Cloud.BookList.CloudBookList.BookListManagement;

namespace Cloud.BookList.CloudBookList.BookListManagement
{
    /// <summary>
    /// BookList应用层服务的接口方法
    ///</summary>
    public interface IBookListAppService : IApplicationService
    {
        /// <summary>
        /// 获取分享信息的接口
        /// </summary>
        /// <param name="id">书单Id</param>
        /// <param name="tenantId">租户Id</param>
        /// <returns></returns>
        Task<BookListShareDto> GetShare(long? id, int? tenantId);

        /// <summary>
		/// 获取BookList的分页列表信息
		///</summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<BookListListDto>> GetPaged(GetBookListsInput input);


		/// <summary>
		/// 通过指定id获取BookListListDto信息
		/// </summary>
		Task<BookListListDto> GetById(EntityDto<long> input);


        /// <summary>
        /// 返回实体的EditDto
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<GetBookListForEditOutput> GetForEdit(NullableIdDto<long> input);


        /// <summary>
        /// 添加或者修改BookList的公共方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task CreateOrUpdate(CreateOrUpdateBookListInput input);


        /// <summary>
        /// 删除BookList信息的方法
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task Delete(EntityDto<long> input);


        /// <summary>
        /// 批量删除BookList
        /// </summary>
        Task BatchDelete(List<long> input);


		/// <summary>
        /// 导出BookList为excel表
        /// </summary>
        /// <returns></returns>
		//Task<FileDto> GetToExcel();

    }
}
