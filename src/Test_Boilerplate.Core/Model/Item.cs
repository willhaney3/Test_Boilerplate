using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Test_Boilerplate.Model
{
  public class Item : Entity<long>
  {
    [Column("ItemId")]
    public override long Id { get => base.Id; set => base.Id = value; }

    public string ItemName { get; set; }

    [ForeignKey("PersonId")]
    public Person Person { get; set; }
  }
}
