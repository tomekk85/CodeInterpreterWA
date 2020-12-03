using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeInterpreterWA.Models
{
    public class ConverterModel
    {
        public int Id { get; set; }
        public string NameOfCOnverter { get; set; }
        public ConverterModel(int id, string nameOfConverter)
        {
            Id = id;
            NameOfCOnverter = nameOfConverter;
        }
    }
}
