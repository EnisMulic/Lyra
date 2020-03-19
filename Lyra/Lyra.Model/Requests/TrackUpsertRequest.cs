using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class TrackUpsertRequest
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public TimeSpan Length { get; set; }
    }
}
