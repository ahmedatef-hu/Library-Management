namespace LibraryManagement_Final.DTOs.Member
{
    public class StatisticsDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalBorrowedBooks { get; set; }
        public int ReturnedBooks { get; set; }
        public int CurrentlyBorrowedBooks { get; set; }
    }
}
