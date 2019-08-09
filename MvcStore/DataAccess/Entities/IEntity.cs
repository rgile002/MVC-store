using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcStore.DataAccess.Entities
{
    public interface IEntity
    {
        int ID { get; set; }
    }
}