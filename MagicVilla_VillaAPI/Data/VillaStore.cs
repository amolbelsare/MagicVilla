using MagicVilla_VillaAPI.Models.Dto;

namespace MagicVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static new List<VillDTO> villaList = new List<VillDTO>
            {
                new VillDTO {Id=1, Name="Pool View"},
                new VillDTO {Id=2, Name="Beach View"}
            };
    }
}
