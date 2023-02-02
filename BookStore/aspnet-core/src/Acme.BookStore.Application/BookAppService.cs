using System;
using Acme.BookStore.Books;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore;

public class BookAppService : CrudAppService<Books.Book,BookDto,Guid,PagedAndSortedResultRequestDto,CreateUpdateBookDto>,
    IBookAppService
{
    public BookAppService(IRepository<Books.Book,Guid> repository) : base(repository)
    {
        
    }
}