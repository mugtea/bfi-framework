using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Legacy.Transaction.Request.Product
{
    public class ProductTransactionRequest
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class EditProductTransactionRequest
    {

        [Required]
        [Range(1, int.MaxValue - 1)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class AddProductTransactionRequest
    {

        [Required]
        [Range(1, int.MaxValue - 1)]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string ExpiredDate { get; set; }
    }
    public class DeleteProductTransactionRequest
    {

        [Required]
        [Range(1, int.MaxValue - 1)]
        public int ProductId { get; set; }
    }
}
