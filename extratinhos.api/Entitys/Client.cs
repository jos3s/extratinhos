using extratinhos.api.Entitys.Base;

namespace extratinhos.Entitys
{
    public class Client : BaseEntity
	{
		public long Limit { get; set; }

		public ICollection<Entry> Entrys { get; set;}

		public Balance Balance { get; set; }
	}
}
