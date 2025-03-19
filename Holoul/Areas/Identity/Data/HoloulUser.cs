using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Holoul.Areas.Identity.Data;

// Add profile data for application users by adding properties to the HoloulUser class
public class HoloulUser : IdentityUser
{
    [Required(ErrorMessage = "الاسم الأول مطلوب")]
    [Display(Name = "الاسم الأول")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "الاسم الأخير مطلوب")]
    [Display(Name = "الاسم الأخير")]
    public string LastName { get; set; }

}

