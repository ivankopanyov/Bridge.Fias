using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    public enum FiasPostingTypes
    {
        /// <summary>
        /// Must include <see cref="FiasPostingRequest.TotalPostingAmount"/> or
        /// <see cref="FiasPostingSimple.TotalPostingAmount"/>.<br/>
        /// Должны быть включены <see cref="FiasPostingRequest.TotalPostingAmount"/>
        /// или <see cref="FiasPostingSimple.TotalPostingAmount"/>.
        /// </summary>
        [EnumMember(Value = "C")]
        DirectCharge = 1,

        /// <summary>
        /// Must include <see cref="FiasPostingRequest.MinibarArticle"/>
        /// or <see cref="FiasPostingSimple.MinibarArticle"/> and <see cref="FiasPostingRequest.NumberOfArticles"/> or
        /// <see cref="FiasPostingSimple.NumberOfArticles"/>, posting is by PMS using article number/count.<br/>
        /// Должны быть включены <see cref="FiasPostingRequest.MinibarArticle"/>
        /// или <see cref="FiasPostingSimple.MinibarArticle"/> и <see cref="FiasPostingRequest.NumberOfArticles"/> или
        /// <see cref="FiasPostingSimple.NumberOfArticles"/>, постинг осуществляется через PMS
        /// с использованием номера/количества товара.
        /// </summary>
        [EnumMember(Value = "M")]
        MinibarCharge = 2,

        /// <summary>
        /// Must include <see cref="FiasPostingSimple.MeterOrTaxPulse"/>, and PMS calculates the call charge.
        /// (Not supported by <see cref="FiasPostingRequest"/>, only <see cref="FiasPostingSimple"/>).<br/>
        /// Должно быть включено <see cref="FiasPostingSimple.MeterOrTaxPulse"/> и PMS рассчитает стоимость звонка.
        /// (Не поддерживается в <see cref="FiasPostingRequest"/>, только в <see cref="FiasPostingSimple"/>).<br/>
        /// </summary>
        [EnumMember(Value = "T")]
        TelephoneCharge = 3
    }
}

