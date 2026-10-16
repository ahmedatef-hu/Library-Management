using AutoMapper;
using LibraryManagement_Final.DTOs.Book;
using LibraryManagement_Final.DTOs.Borrowing;
using LibraryManagement_Final.DTOs.Category;
using LibraryManagement_Final.DTOs.Member;
using LibraryManagement_Final.Models;
using System.Dynamic;

namespace LibraryManagement_Final.Mapping
{
    public class ModelProfile : Profile
    {
        public ModelProfile()
        {
            CreateMap<Book, GetBookDTO>();
            CreateMap<Book, BookSearchDto>();
            CreateMap<CreateBookDTO, Book>();


            CreateMap<Borrowing, GetBorrowingDTO>();
            CreateMap<CreateBorrowingDTO, Borrowing>();


            CreateMap<Category, GetCategoryDTO>();
            CreateMap<CreateCategoryDTO, Category>();


            CreateMap<Member, GetMemberDTO>();
            CreateMap<CreateMemberDTO, Member>();
        }
    }
}
