using Bridge.Fias.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace Bridge.Fias.Entities
{
    public partial class FiasLinkDescription : FiasMessageToPms
    {
        /// <summary>
        /// <b>Required.</b><br/>
        /// <b>Обязательно.</b>
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Determines the display of the PMS Interface system and enables corresponding functionality in the PMS.<br/>
        /// <b>Обязательно.</b><br/>
        /// Определяет отображение системы интерфейса PMS и включает соответствующие функции в PMS.
        /// </summary>
        [Required]
        public FiasInterfaceTypes InterfaceFamily { get; set; }

        /// <summary>
        /// <b>Required.</b><br/>
        /// Max length is 10.<br/>
        /// Can only contain characters from the ASCII table in the range 32 to 127, inclusive.<br/>
        /// <b>Обязательно.</b><br/>
        /// Максимальная длина = 10.<br/>
        /// Может содержать только символы из таблицы ASCII в диапазоне от 32 до 127 включительно.
        /// </summary>
        [Required]
        [StringLength(10)]
        [RegularExpression(FiasEnviroments.AN_PATTERN)]
        public string VendorSystemsVersion { get; set; }

        /// <summary>
        /// Required when IFC connection authentication functionality is used - in
        /// correspondence with <see cref="Cryptogram"/>.<br/>
        /// Required when EFT functionality is used – in correspondence with
        /// <see cref="Cryptogram"/> – for encryption key exchange for encrypting sensitive data.<br/>
        /// Требуется при использовании функции аутентификации соединения IFC - в переписке с <see cref="Cryptogram"/>.<br/>
        /// Требуется при использовании функции EFT – в соответствии с <see cref="Cryptogram"/> – для
        /// обмен ключами шифрования для шифрования конфиденциальных данных.
        /// </summary>
        public FiasLinkDescriptionRequestTypes RequestTypes { get; set; }

        /// <summary>
        /// Valid values ​​range from 1 to 2000.<br/>
        /// Допустимое значение в диапазоне от 1 до 2000.
        /// </summary>
        [Range(1, 2000)]
        public int? MaximumRecordLength { get; set; }

        /// <summary>
        /// Can only contain characters from the ASCII table in the range 32 to 127, inclusive.<br/>
        /// Cryptogram for secure connection with IfcAuthKey.<br/>
        /// Required when IFC connection authentication functionality is used - in correspondence
        /// with <see cref="Cryptogram"/> field.<br/>
        /// Required when EFT functionality is used – in correspondence with
        /// <see cref="Cryptogram"/> – for encryption key exchange for encrypting sensitive data.<br/>
        /// Может содержать только символы из таблицы ASCII в диапазоне от 32 до 127 включительно.<br/>
        /// Криптограмма для безопасного соединения с IfcAuthKey.<br/>
        /// Требуется при использовании функции аутентификации соединения IFC - в переписке с <see cref="Cryptogram"/>.<br/>
        /// Требуется при использовании функции EFT – в соответствии с <see cref="Cryptogram"/> – для
        /// обмен ключами шифрования для шифрования конфиденциальных данных
        /// </summary>
        [Required]
        [RegularExpression(FiasEnviroments.AN_PATTERN)]
        public string Cryptogram { get; set; }
    }
}

