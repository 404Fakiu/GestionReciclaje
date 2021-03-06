
namespace GestionReciclaje.Dtos.Plant
{
    public class PlantParamsDto
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        private int pageSize = 10;
        public int PageSize
        {
            get { return pageSize;}
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value;}
        }

        public string Name { get; set; }
        public int UserId { get; set; }               
        public string OrderBy { get; set; }
        public int TotalRecords { get; set; }
       
    }
}