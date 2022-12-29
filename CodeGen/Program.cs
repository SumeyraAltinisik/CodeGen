namespace CodeGen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kisi k = new Kisi {Id=1, Ad="Ali", Soyad="Diker" };
            var propList = typeof(Kisi).GetProperties();
            List<string> proJlist = new List<string>();

            foreach (var item in propList)
            {
                object val = item.GetValue(k);
                if (item.PropertyType == typeof(string))
                {
                    proJlist.Add(String.Format("{0} \"{1}\"", item.Name, val));
                }
                else
                {
                    proJlist.Add(String.Format("{0}: {1}", item.Name, val));
                }                             
            }
            string final = "{" + string.Join(", \r\n", proJlist) + "}";
            Console.WriteLine(final);
            Console.ReadLine();
            
        }
    }
    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TamAdi
        {
            get { return Ad + " " + Soyad; }

        }
    }
}