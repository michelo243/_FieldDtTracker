namespace _FieldDtTracker.Entities
{
    public class Departement
    {
        public int Id { get; set; } // primary key
        public string Name { get; set; } = null!;
        //Foreign key definition
        public int RegionId { get; set; }
        public Region? Region { get; set; }

        public ICollection<Commune> Communes { get; set; } = new List<Commune>();
    }
}
