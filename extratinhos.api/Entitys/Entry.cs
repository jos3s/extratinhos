using extratinhos.api.Entitys.Base;
using extratinhos.Entitys.Enums;

namespace extratinhos.Entitys
{
    public class Entry : BaseEntity
	{	
		public long Value { get; set; }

		public EntryType Type { get; set; }

		public string Description { get; set; }

		public long ClientId { get; set; }

		public Client Client { get; set; } = null;
	}
}
