using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Wallet.NFT.Domain
{
    public interface ILancamento
    {
        string Create(Lancamento lancamento);
        Lancamento GetLancamento();
    }
}