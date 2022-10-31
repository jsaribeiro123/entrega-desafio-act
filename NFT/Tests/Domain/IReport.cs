using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.NFT.Domain
{
    public interface IReport
    {
        string GetReport(Report report);
    }
}