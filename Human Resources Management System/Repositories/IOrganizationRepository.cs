namespace Human_Resources_Management_System
{
    public interface IOrganizationRepository
    {
        Task<IEnumerable<Department>> GetDepartments(string sTerm = "", int genreId = 0);

    }
}