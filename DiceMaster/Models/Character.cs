
namespace DiceMaster.Models 
{
    public class Character : RavenModel
    {
        public Class Class { get; set; }
        public Race Race { get; set; }
    }
}
