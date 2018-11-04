namespace DiceMaster.Models
{
    public class RavenModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public void Update(RavenModel model)
        {
            this.Name = model.Name;
        }
    }
}