
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LanguageSchool
{

using System;
    using System.Collections.Generic;
    
public partial class Services
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Services()
    {

        this.ClientService = new HashSet<ClientService>();

    }


    public int serviceId { get; set; }

    public string serviceName { get; set; }

    public string mainImg { get; set; }

    public int duration { get; set; }

    public double cost { get; set; }

    public double discount { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<ClientService> ClientService { get; set; }

}

}
