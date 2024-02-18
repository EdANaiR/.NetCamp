namespace intro.Entities;

public class CorporateCustomer:BaseCustomer       // :... kullanımı ortak elemanların kullanıldıgını belirtir yani baseCustomerden al gibi
{

    public string Name { get; set; }

    public string TaxNumber { get; set; }

}

