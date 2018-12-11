﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Test_Boilerplate.Model;

namespace Test_Boilerplate.BO
{
  public interface IPersonAppService
  {
    Task Person_Insert(string PersonName);
    Task<Person> GetPersonById(long Id);

  }
}
