
namespace DiceMaster.Models {
    public class Character {
        public int Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }
        public Race Race { get; set; }
        
        public Character()
        {
            
        }
    }
}
