using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) // params verdiğiniz zaman istediğiniz kadar run metotuna IResult gönderebilirsiniz. logics iş kuralı demek
        {                                                   // IResult[] demek, virgülle istediğin kadar iş kuralı gönderebilirsin demek.
            foreach(var logic in logics)  // her bir iş kuralını gez
            {
                if (!logic.Success)         // kurala uymayan varsa o kuralı döndür
                {
                    return logic;           // yani ErrorResult döndürecek
                }
            }
            return null;        // iş kuralı başarılıysa hiç bir şey döndürmesine gerek yok. o yüzden null.
        }
    }
}
