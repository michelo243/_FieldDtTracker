﻿namespace _FieldDtTracker.Entities
{
    public class Commune
    {
        public int Id { get; set; }

        public string Designation { get; set; } = null!;

        public int? DepartementId { get; set; }
        public Departement? Departement { get; set; }

       public ICollection<HACPtable> HACPtables { get; set; } = new List<HACPtable>();
    }
}
