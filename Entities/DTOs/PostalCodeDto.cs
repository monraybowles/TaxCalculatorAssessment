using Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.DTOs
{
    public class PostalCode
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
    }
}
