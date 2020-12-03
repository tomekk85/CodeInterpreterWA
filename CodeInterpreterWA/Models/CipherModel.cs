using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeInterpreterWA.Models
{
    public class CipherModel
    {
        public int Id { get; set; }
        public string NameOfCipher { get; set; }
        public CipherModel(int id, string nameOfCipher)
        {
            Id = id;
            NameOfCipher = nameOfCipher;
        }

    }

   
}
