using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    /// <summary>
    /// 本接口为“可储钱的”，提供了钱库所具备的方法，
    /// 如：增加钱，减少钱，将钱与其他仓库进行转运
    /// 本项目中，可令Bank类与ATM类实现此接口，当ATM机钱款不够时，可以使用该类的方法，实现银行与ATM机之间的钱的调度。
    /// </summary>
    public interface IMoneyStorable
    {
        /// <summary>
        /// 增加钱数
        /// </summary>
        /// <param name="value">增加的金额</param>
        /// <returns>增加后的金额总数</returns>
        decimal IncreaseMoney(decimal value);

        /// <summary>
        /// 减少钱数
        /// </summary>
        /// <param name="value">减少的金额</param>
        /// <returns>是否够减</returns>
        bool DecreaseMoney(decimal value);

        /// <summary>
        /// 将指定数额的钱调配给指定的实现了本接口的“钱库”
        /// </summary>
        /// <param name="moneyStorage">实现了IMoneyStorable的对象</param>
        /// <param name="value">调配的金额数</param>
        /// <returns>调配是否成功</returns>
        bool TransferMoneyTo(IMoneyStorable moneyStorage, decimal value);
    }
}
