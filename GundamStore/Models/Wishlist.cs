using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GundamStore.Models;

    public partial class Wishlist
    {
        public int ProductId { get; set; }
        public int AccountId { get; set; }

        public virtual Product Product { get; set; } = null!;
        public virtual Account Account { get; set; } = null!;
    }


