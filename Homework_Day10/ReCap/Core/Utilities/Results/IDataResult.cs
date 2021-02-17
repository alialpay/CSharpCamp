using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult     // interfaceler bu şekilde implemente ediliyor
    {
        T Data { get; }
    }
}
