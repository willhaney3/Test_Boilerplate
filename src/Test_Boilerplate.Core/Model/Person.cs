using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;

namespace Test_Boilerplate.Model
{
  public class Person :Entity<long>
  {

    [Column("PersonId")]
    public override long Id { get => base.Id; set => base.Id = value; }

    public string PersonName { get; set; }

    public ICollection<Item> Items { get; set; }
  }
}
