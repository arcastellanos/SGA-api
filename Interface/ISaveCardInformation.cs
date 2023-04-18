using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SGA_api.Models;
using SGA_api.Database;
namespace SGA_api.Interface
{
    public interface ISaveCardInformation
    {
        void PostCardInformation(CardInformation myCardInfo);
    }
}