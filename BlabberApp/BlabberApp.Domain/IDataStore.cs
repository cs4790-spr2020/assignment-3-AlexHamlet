using System;
using System.Collections.Generic;
using System.Text;

namespace BlabberApp.Domain
{
    interface IDataStore
    {
        bool Create(IDatum datum);
        IDatum Read(ISpecimen spec);
        bool Update(IDatum datum);
        IDatum Delete(ISpecimen spec);
    }
}
