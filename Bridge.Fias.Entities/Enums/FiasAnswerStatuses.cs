using System.Runtime.Serialization;

namespace Bridge.Fias.Entities
{
    /// <summary>
    /// Sent by external systems to notify if a PMS request is successful or not.<br/>
    /// Отправляется внешними системами для уведомления об успешном или неуспешном запросе PMS.
    /// </summary>
    public enum FiasAnswerStatuses
    {
        /// <summary>
        /// <b>Supported Interface Types</b>: PBX - DID-Response.<br/>
        /// <b>Meaning</b>:<br/>Virtual Number already assigned.<br/>Виртуальный номер уже назначен.
        /// </summary>
        [EnumMember(Value = "AA")]
        VirtualNumberAlreadyAssigned,

        /// <summary>
        /// <b>Supported Interface Types</b>: PBX - DID-Response.<br/>
        /// <b>Meaning</b>:<br/>Virtual Number not found.<br/>Виртуальный номер не найден.
        /// </summary>
        [EnumMember(Value = "AN")]
        VirtualNumberNotFound,

        /// <summary>
        /// <b>Supported Interface Types</b>: VSS/remote check-out.<br/>
        /// <b>Meaning</b>:<br/>Balance mismatch.<br/>Несоответствие баланса.
        /// </summary>
        [EnumMember(Value = "BM")]
        BalanceMismatch,

        /// <summary>
        /// <b>Supported Interface Types</b>: Wakeup/Key Services.<br/>
        /// <b>Meaning</b>:<br/>Telephone/Encoder Busy.<br/>Телефон/кодировщик занят.
        /// </summary>
        [EnumMember(Value = "BY")]
        TelephoneEncoderBusy,

        /// <summary>
        /// <b>Supported Interface Types</b>: VSS/remote check-out.<br/>
        /// <b>Meaning</b>:<br/>Check-out date is not today.<br/>Дата выезда не сегодня
        /// </summary>
        [EnumMember(Value = "CD")]
        CheckOutDateIsNotToday,

        /// <summary>
        /// <b>Supported Interface Types</b>: POS Systems.<br/>
        /// <b>Meaning</b>:<br/>Posting denied because overwriting the credit limit is
        /// not allowed(not used with Suite8).<br/>Публикация отклонена, поскольку перезапись
        /// кредитного лимита не разрешена (не используется в Suite8).
        /// </summary>
        [EnumMember(Value = "CO")]
        PostingDenied,

        /// <summary>
        /// <b>Supported Interface Types</b>: Wakeup/Key.<br/>
        /// <b>Meaning</b>:<br/>Wakeup/Key has been deleted.<br/>Пробуждение/Ключ удален.
        /// </summary>
        [EnumMember(Value = "DE")]
        WakeupKeyHasBeenDeleted,

        /// <summary>
        /// <b>Supported Interface Types</b>: POS systems.<br/>
        /// <b>Meaning</b>:<br/>The Sum of subtotals doesn't match TotalAmount.<br/>
        /// Сумма промежуточных итогов не соответствует общей сумме.
        /// </summary>
        [EnumMember(Value = "DM")]
        NotMatchTotalAmount,

        /// <summary>
        /// <b>Meaning</b>:<br/>Request denied.<br/>Запрос отклонен.
        /// </summary>
        [EnumMember(Value = "DN")]
        RequestDenied,

        /// <summary>
        /// <b>Supported Interface Types</b>: Guest related requests.<br/>
        /// <b>Meaning</b>:<br/>Guest not allowed this feature.<br/>Гость не разрешил эту функцию.
        /// </summary>
        [EnumMember(Value = "FX")]
        GuestNotAllowedThisFeature,

        /// <summary>
        /// <b>Supported Interface Types</b>: Guest related requests.<br/>
        /// <b>Meaning</b>:<br/>Invalid account.<br/>Неверный аккаунт.
        /// </summary>
        [EnumMember(Value = "IA")]
        InvalidAccount,

        /// <summary>
        /// <b>Supported Interface Types</b>: All systems.<br/>
        /// <b>Meaning</b>:<br/>Night Audit.<br/>Ночной аудит.
        /// </summary>
        [EnumMember(Value = "NA")]
        NightAudit,

        /// <summary>
        /// <b>Supported Interface Types</b>: VSS/remote check-out.<br/>
        /// <b>Meaning</b>:<br/>Feature not enabled or Check-out process not running.<br/>
        /// Функция не включена или процесс оформления заказа не запущен.
        /// </summary>
        [EnumMember(Value = "NF")]
        NotEnabled,

        /// <summary>
        /// <b>Supported Interface Types</b>: All information requests.<br/>
        /// <b>Meaning</b>:<br/>Guest not found.<br/>Гость не найден.
        /// </summary>
        [EnumMember(Value = "NG")]
        GuestNotFound,

        /// <summary>
        /// <b>Supported Interface Types</b>: Message/Locator request.<br/>
        /// <b>Meaning</b>:<br/>Message/Locator not found.<br/>Сообщение/локатор не найден.
        /// </summary>
        [EnumMember(Value = "NM")]
        MessageLocatorNotFound,

        /// <summary>
        /// <b>Supported Interface Types</b>: POS Systems.<br/>
        /// <b>Meaning</b>:<br/>Posting denied for this guest (NoPost flag has been set).<br/>
        /// Публикация запрещена для этого гостя (установлен флаг NoPost).
        /// </summary>
        [EnumMember(Value = "NP")]
        PostingDeniedForThisGuest,

        /// <summary>
        /// <b>Supported Interface Types</b>: Wakeup.<br/>
        /// <b>Meaning</b>:<br/>No Response.<br/>Нет ответа.
        /// </summary>
        [EnumMember(Value = "NR")]
        NoResponse,

        /// <summary>
        /// <b>Supported Interface Types</b>: All systems.<br/>
        /// <b>Meaning</b>:<br/>Command or request completed successfully.<br/>
        /// Команда или запрос успешно выполнены.
        /// </summary>
        [EnumMember(Value = "OK")]
        Successfully,

        /// <summary>
        /// <b>Supported Interface Types</b>: All systems.<br/>
        /// <b>Meaning</b>:<br/>Retry.<br/>Повторить попытку.
        /// </summary>
        [EnumMember(Value = "RY")]
        Retry,

        /// <summary>
        /// <b>Supported Interface Types</b>: All systems.<br/>
        /// <b>Meaning</b>:<br/>Unprocessable request, this request cannot be carried out; no retry.<br/>
        /// Необработанный запрос, этот запрос невозможно выполнить. Нет повторной попытки.
        /// </summary>
        [EnumMember(Value = "UR")]
        UnprocessableRequest
    }
}

