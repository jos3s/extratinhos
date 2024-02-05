using extratinhos.api.Entitys.Base;

namespace extratinhos.Entitys
{
    public class Balance : BaseEntity
	{
		public long Value { get; set; }

		public long ClientId { get; set; }

		public Client Client { get; set; } = null;
	}
}
