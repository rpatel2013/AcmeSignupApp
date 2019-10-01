using Acme.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acme.AppCore.Interfaces
{
    public interface ISignups
    {
        void Save(Signups signup);

    }
}
