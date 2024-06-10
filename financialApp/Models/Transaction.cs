using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Transaction
{
    [Key]
    public int TransactionID { get; set; }
    public int UserID { get; set; }
    public int EntityID { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }

    public User User { get; set; }
    public ICollection<Label> Labels { get; set; }
}