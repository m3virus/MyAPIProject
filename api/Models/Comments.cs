using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Comments
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public DateTime CreationTime { get; set; } = DateTime.Now;


        #region navigationProperty
        public int? StockId { get; set; }
        public Stocks? Stock { get; set; }
        #endregion

    }
}