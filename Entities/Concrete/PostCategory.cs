using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Concrete
{
    public class PostCategory:IEntity
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public int CategoryId { get; set; }
    }
}
