using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class BaseEntity<TId>      //generic yapı     T => type'den gelir
{
    public TId Id { get; set; }        //Id sadece int veya diğer türlerden olmak zorunda değil bu yuzden Id'de generic kullanabiliriz

    public DateTime CreatedDate{ get; set; }

    public DateTime? UpdatedDate { get; set; }    //? koymak illa ki onu oluşturmak zorunda değilsin demek

    public DateTime? DeletedDate { get; set; }


}
