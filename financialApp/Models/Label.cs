using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Label
{
    [Key]
    public int LabelID { get; set; }
    public string LabelName { get; set; }
    public string EntityType { get; set; }
    public int EntityID { get; set; }

    public Transaction Transaction { get; set; }
}
