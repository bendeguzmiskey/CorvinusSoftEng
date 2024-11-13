namespace _9Gyak
{
    public class Tárgy
    {
        public string Név { get; set; }

        public int Kredit { get; set; }

        public bool IsBoring { get; set; }

        public decimal? Average { get; set; }

        public DateTime Dátum { get; set; } = DateTime.Now;
    }
}
