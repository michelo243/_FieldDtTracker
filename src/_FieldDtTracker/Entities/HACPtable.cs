namespace _FieldDtTracker.Entities
{
    public class HACPtable
    {
        public int Id { get; set; }
        public int? CommuneId { get; set; }
        public Commune? Commune { get; set; }
        public string Organisation { get; set; } = null!;
        public string TypeActivite { get; set; } = null!;
        public string Activite { get; set; } = null!;
        public string Projet { get; set; } = null!;
        public string PrincipalBailleur { get; set; } = null!;
        public string? Bailleur_Secondaire { get; set; }
        public  string? Bailleur_Secondaire2 { get; set; }
        public string? TypeBailleur { get; set; }
        public int QteBailleur { get; set; }
        public int Annee { get; set; }
        public string? Cible { get; set; }
        public DateTime Debut { get; set; }
        public DateTime Fin { get; set; }
        public string? Beneficiaire { get; set; }
        public bool? International { get; set; }
        public float BudgetTotalProjet { get; set; }


    }
}
