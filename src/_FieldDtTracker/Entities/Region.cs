namespace _FieldDtTracker.Entities
{
    public class Region
    {
        public int Id { get; set; } //refere to the Primary key
        public string Name { get; set; } = null!;

        //we need to add a collection showing that a Region could have many Department
        public ICollection<Departement> Departements { get; set; }=new List<Departement>();
       

    }
}
