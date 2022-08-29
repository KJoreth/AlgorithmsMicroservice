namespace DataStructure.API.MapperProfiles
{
    public class DataStructureProfile : Profile
    {
        public DataStructureProfile()
        {
            CreateMap<Structure, StructureDTO>();
        }
    }
}
