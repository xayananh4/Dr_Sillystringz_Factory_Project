using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
   
    [Required(ErrorMessage = "The textbox can't be empty!")]
    public string EngineerName { get; set; }

    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:M/d/yyyy}")]
    public DateTime HireDate { get; set; }

    public List<EngineerMachine> JoinEntities { get; }
  }
}