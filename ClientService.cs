
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
    
public partial class ClientService
{

    public int clientServiceId { get; set; }

    public int serviceId { get; set; }

    public System.DateTime startDate { get; set; }

    public int clientId { get; set; }



    public virtual Clients Clients { get; set; }

    public virtual Services Services { get; set; }

}

}