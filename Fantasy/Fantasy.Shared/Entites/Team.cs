﻿using Fantasy.Shared.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy.Shared.Entites
{
    public class Team
    {
        public int Id { get; set; }

        [Display(Name = "Team", ResourceType = typeof(Literals))]
        [MaxLength(100, ErrorMessageResourceName = "MaxLength", ErrorMessageResourceType = typeof(Literals))]
        [Required(ErrorMessageResourceName = "RequiredField", ErrorMessageResourceType = typeof(Literals))]
        public string Name { get; set; } = null!;

        public string? Image { get; set; }

        public Country? Country { get; set; }

        public int CountryId { get; set; }
        public string ImageFull => string.IsNullOrEmpty(Image) ? "/images/NoImage.png" : Image;
    }

}
