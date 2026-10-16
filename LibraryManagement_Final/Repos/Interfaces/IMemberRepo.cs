using AutoMapper.Execution;
using LibraryManagement_Final.DTOs.Member;

namespace LibraryManagement_Final.Repos.Interfaces
{
    public interface IMemberRepo : IGenericRepo<Models.Member>
    {
        Task<List<Models.Member>> TopReaders();
        Task<StatisticsDTO> Statistics(int id);
    }
}
