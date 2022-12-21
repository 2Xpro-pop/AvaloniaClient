using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaClient.Models;
public interface IIdPickable
{
    public int Id
    {
        get;
    }
    public string Description
    {
        get;
    }
}
