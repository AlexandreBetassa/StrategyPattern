using StrategyPattern.Contracts.v1;

namespace StrategyPattern.Enum.v1
{
    public enum TypeOperation : int
    {
        PixService,
        WithdrawService,
        CreditCardService,
        DebitCardService
    }
    public delegate IStrategy ServiceResolver(TypeOperation tipoServico);

}
