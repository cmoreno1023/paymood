using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp.Models
{
    internal class PayModeModel
    {
        [DisplayName("pay Mode Id")]
        public int Id { get; set; }

        [DisplayName("pay Mode Name")]
        [Required(ErrorMessage = "pay Mode Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "pay Mode Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [DisplayName("observation")]
        [Required(ErrorMessage = "pay Mode observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "pay Mode observation must be between 3 and 200 characters")]
        public string observation { get; set; }
    }

}


