using Microsoft.EntityFrameworkCore;

namespace Human_Resources_Management_System.Repositories;

    public class OrganizationRepository : IOrganizationRepository
    {

        private readonly ApplicationDbContext _db;
        public OrganizationRepository(ApplicationDbContext db)
        {
            _db = db;
        }


        public async Task<IEnumerable<Department>> GetDepartments(string sTerm = "", int genreId = 0){

                   sTerm = sTerm.ToLower();
                    
                  IEnumerable<Department> departments = await (from Department in _db.Departments

                     where string.IsNullOrWhiteSpace(sTerm) || (Department != null && Department.DepartmentName.ToLower().StartsWith(sTerm))

                    select new Department
                      {
                        Id = Department.Id,
                        DepartmentName = Department.DepartmentName
                       }
                ).ToListAsync();

        if(genreId > 0)
        {
            departments = departments.Where(a => a.Id == genreId).ToList();
        }
        return departments;
}

    }

