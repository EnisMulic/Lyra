using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Lyra.Model.Requests
{
    public class UserTrackReviewUpsertRequest
    {
        [Required]
        public int UserID { get; set; }
        [Required]
        public int TrackID { get; set; }
        [Required]
        public int Score { get; set; }
    }
}
