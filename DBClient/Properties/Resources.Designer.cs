﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBClient.Properties {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DBClient.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Insert into Взаиморасчеты.dbo.Клиенты 
        ///Values (@client_name, @manager_id, @phone, @email); .
        /// </summary>
        internal static string AddClient {
            get {
                return ResourceManager.GetString("AddClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на INSERT INTO Взаиморасчеты.dbo.Содержимое_склада
        ///      VALUES (@storage_id, @item_id, @item_amount);.
        /// </summary>
        internal static string AddExistingItem {
            get {
                return ResourceManager.GetString("AddExistingItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap addIcon {
            get {
                object obj = ResourceManager.GetObject("addIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на INSERT INTO Взаиморасчеты.dbo.Товар
        ///      VALUES (@item_type, @item_material, @item_price);
        ///    
        ///    INSERT INTO Взаиморасчеты.dbo.Содержимое_склада
        ///      VALUES(@storage_id, (select ident_current(&apos;Взаиморасчеты.dbo.Товар&apos;)), @item_amount);.
        /// </summary>
        internal static string AddNewItem {
            get {
                return ResourceManager.GetString("AddNewItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на INSERT INTO Взаиморасчеты.dbo.Оплата
        ///  VALUES (@date, @client_id, @payment);
        ///
        ///  UPDATE Взаиморасчеты.dbo.Счет_клиента
        ///    SET Взаиморасчеты.dbo.Счет_клиента.client_balance = (Взаиморасчеты.dbo.Счет_клиента.client_balance + @payment)
        ///    WHERE Взаиморасчеты.dbo.Счет_клиента.client_id = @client_id;.
        /// </summary>
        internal static string AddPayment {
            get {
                return ResourceManager.GetString("AddPayment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на INSERT INTO Взаиморасчеты.dbo.Отгрузка
        ///  VALUES (@date, @client_id, @storage_id, @item_id, @item_amount)
        ///
        ///  UPDATE Взаиморасчеты.dbo.Содержимое_склада
        ///    SET Взаиморасчеты.dbo.Содержимое_склада.item_amount = (Взаиморасчеты.dbo.Содержимое_склада.item_amount - @item_amount)
        ///    WHERE Взаиморасчеты.dbo.Содержимое_склада.item_id = @item_id AND Взаиморасчеты.dbo.Содержимое_склада.storage_id = @storage_id;
        ///
        ///  UPDATE Взаиморасчеты.dbo.Счет_клиента
        ///    SET Взаиморасчеты.dbo.Счет_клиента.client_balance = (В [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string AddShipment {
            get {
                return ResourceManager.GetString("AddShipment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap authorizationIcon {
            get {
                object obj = ResourceManager.GetObject("authorizationIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Счет_клиента set client_balance = @client_balance where client_id = @client_id.
        /// </summary>
        internal static string ChangeClientBalance {
            get {
                return ResourceManager.GetString("ChangeClientBalance", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Счет_клиента set client_credit = @client_credit where client_id = @client_id.
        /// </summary>
        internal static string ChangeClientCredit {
            get {
                return ResourceManager.GetString("ChangeClientCredit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Клиенты set email = @email where client_id = @client_id.
        /// </summary>
        internal static string ChangeClientEmail {
            get {
                return ResourceManager.GetString("ChangeClientEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Клиенты set client_name = @client_name
        ///	where client_id = @client_id.
        /// </summary>
        internal static string ChangeClientName {
            get {
                return ResourceManager.GetString("ChangeClientName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Клиенты set phone = @phone 
        ///	where client_id = @client_id.
        /// </summary>
        internal static string ChangeClientPhone {
            get {
                return ResourceManager.GetString("ChangeClientPhone", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Оплата set date = @date where client_id = @client_id AND payment = @payment.
        /// </summary>
        internal static string ChangeFinanceDate {
            get {
                return ResourceManager.GetString("ChangeFinanceDate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Клиенты set client_name = @client_name where client_id = @client_id.
        /// </summary>
        internal static string ChangeFinanceName {
            get {
                return ResourceManager.GetString("ChangeFinanceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Оплата set payment = @payment where client_id = @client_id AND date = @date.
        /// </summary>
        internal static string ChangeFinancePayment {
            get {
                return ResourceManager.GetString("ChangeFinancePayment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Склад set storage_capacity = @storage_capacity
        ///	where storage_id = @storage_id.
        /// </summary>
        internal static string ChangeStorageCapacity {
            get {
                return ResourceManager.GetString("ChangeStorageCapacity", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Содержимое_склада set item_amount = @item_amount where storage_id = @storage_id.
        /// </summary>
        internal static string ChangeStorageItemAmount {
            get {
                return ResourceManager.GetString("ChangeStorageItemAmount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE Взаиморасчеты.dbo.Содержимое_склада
        ///    SET Взаиморасчеты.dbo.Содержимое_склада.item_id = (SELECT Взаиморасчеты.dbo.Товар.item_id FROM Взаиморасчеты.dbo.Товар WHERE (Взаиморасчеты.dbo.Товар.item_type = @item_type AND Взаиморасчеты.dbo.Товар.item_material = @item_material))
        ///    WHERE Взаиморасчеты.dbo.Содержимое_склада.storage_id = @storage_id AND Взаиморасчеты.dbo.Содержимое_склада.item_amount = @item_amount;.
        /// </summary>
        internal static string ChangeStorageItemMaterialAndType {
            get {
                return ResourceManager.GetString("ChangeStorageItemMaterialAndType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на update Склад set storage_name = @storage_name
        ///	where storage_id = @storage_id.
        /// </summary>
        internal static string ChangeStorageName {
            get {
                return ResourceManager.GetString("ChangeStorageName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на IF NOT EXISTS (SELECT Взаиморасчеты.dbo.Товар.item_type, Взаиморасчеты.dbo.Товар.item_material 
        ///           FROM Взаиморасчеты.dbo.Товар 
        ///           WHERE Взаиморасчеты.dbo.Товар.item_type = @item_type AND Взаиморасчеты.dbo.Товар.item_material = @item_material)
        ///BEGIN
        ///INSERT INTO Взаиморасчеты.dbo.Товар (item_type, item_material, item_price)
        ///  VALUES (@item_type, @item_material, @item_price);
        ///END.
        /// </summary>
        internal static string CheckItemExists {
            get {
                return ResourceManager.GetString("CheckItemExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT MAX(Взаиморасчеты.dbo.Склад.storage_capacity), COALESCE(SUM(item_amount), 0)
        ///  FROM Взаиморасчеты.dbo.Склад LEFT JOIN Взаиморасчеты.dbo.Содержимое_склада ON Взаиморасчеты.dbo.Склад.storage_id = Взаиморасчеты.dbo.Содержимое_склада.storage_id
        ///  WHERE Взаиморасчеты.dbo.Склад.storage_id = @storage_id.
        /// </summary>
        internal static string CheckItemFitsStorage {
            get {
                return ResourceManager.GetString("CheckItemFitsStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap closeIcon {
            get {
                object obj = ResourceManager.GetObject("closeIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap darkCloseIcon {
            get {
                object obj = ResourceManager.GetObject("darkCloseIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap darkMinimizeIcon {
            get {
                object obj = ResourceManager.GetObject("darkMinimizeIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap deleteIcon {
            get {
                object obj = ResourceManager.GetObject("deleteIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap folderIcon {
            get {
                object obj = ResourceManager.GetObject("folderIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT Взаиморасчеты.dbo.Клиенты.client_name, Взаиморасчеты.dbo.Клиенты.phone, Взаиморасчеты.dbo.Клиенты.email, Взаиморасчеты.dbo.Счет_клиента.client_credit, Взаиморасчеты.dbo.Счет_клиента.client_balance, Взаиморасчеты.dbo.Клиенты.manager_id
        ///  FROM Взаиморасчеты.dbo.Клиенты LEFT JOIN Взаиморасчеты.dbo.Счет_клиента ON Взаиморасчеты.dbo.Клиенты.client_id = Взаиморасчеты.dbo.Счет_клиента.client_id
        ///  WHERE Клиенты.client_id = @client_id;.
        /// </summary>
        internal static string GetClientData {
            get {
                return ResourceManager.GetString("GetClientData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap hamburgerMenu {
            get {
                object obj = ResourceManager.GetObject("hamburgerMenu", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap infoIcon {
            get {
                object obj = ResourceManager.GetObject("infoIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap logOutIcon {
            get {
                object obj = ResourceManager.GetObject("logOutIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap minimizeIcon {
            get {
                object obj = ResourceManager.GetObject("minimizeIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap openIcon {
            get {
                object obj = ResourceManager.GetObject("openIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap operationsIcon {
            get {
                object obj = ResourceManager.GetObject("operationsIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap promekzAppLogo {
            get {
                object obj = ResourceManager.GetObject("promekzAppLogo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap promekzLogoGray {
            get {
                object obj = ResourceManager.GetObject("promekzLogoGray", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap queriesIcon {
            get {
                object obj = ResourceManager.GetObject("queriesIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap reduceIcon {
            get {
                object obj = ResourceManager.GetObject("reduceIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE FROM Взаиморасчеты.dbo.Клиенты WHERE client_id = @client_id.
        /// </summary>
        internal static string RemoveClient {
            get {
                return ResourceManager.GetString("RemoveClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE FROM Взаиморасчеты.dbo.Содержимое_склада
        ///  WHERE Взаиморасчеты.dbo.Содержимое_склада.item_id = @item_id;
        ///
        ///DELETE FROM Взаиморасчеты.dbo.Товар
        ///  WHERE item_id = @item_id;.
        /// </summary>
        internal static string RemoveItem {
            get {
                return ResourceManager.GetString("RemoveItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE FROM Взаиморасчеты.dbo.Содержимое_склада 
        ///  WHERE Взаиморасчеты.dbo.Содержимое_склада.storage_id = @storage_id AND Взаиморасчеты.dbo.Содержимое_склада.item_id = @item_id AND Взаиморасчеты.dbo.Содержимое_склада.item_amount = @item_amount.
        /// </summary>
        internal static string RemoveItemFromStorage {
            get {
                return ResourceManager.GetString("RemoveItemFromStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на DELETE FROM Взаиморасчеты.dbo.Склад WHERE storage_id = @storage_id.
        /// </summary>
        internal static string RemoveStorage {
            get {
                return ResourceManager.GetString("RemoveStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap renameIcon {
            get {
                object obj = ResourceManager.GetObject("renameIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap rickAvatar {
            get {
                object obj = ResourceManager.GetObject("rickAvatar", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap saveIcon {
            get {
                object obj = ResourceManager.GetObject("saveIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap searchIcon {
            get {
                object obj = ResourceManager.GetObject("searchIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EXEC(&apos;SELECT COUNT(&apos; + @column_name + &apos;) FROM &apos; + @table_name + &apos; WHERE &apos; + @column_name + &apos; = &apos;&apos;&apos; + @value + &apos;&apos;&apos; AND &apos; + @column_name2 + &apos; = &apos;&apos;&apos; + @value2 + &apos;&apos;&apos;&apos;).
        /// </summary>
        internal static string SearchItem {
            get {
                return ResourceManager.GetString("SearchItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на EXEC(&apos;SELECT COUNT(&apos; + @column_name + &apos;) FROM &apos; + @table_name + &apos; WHERE &apos; + @column_name + &apos; = &apos;&apos;&apos; + @value + &apos;&apos;&apos;&apos;).
        /// </summary>
        internal static string SearchObject {
            get {
                return ResourceManager.GetString("SearchObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE Взаиморасчеты.dbo.Счет_клиента
        ///  SET client_credit = @client_credit, client_balance = @client_balance
        ///  WHERE client_id = (SELECT client_id FROM Взаиморасчеты.dbo.Клиенты WHERE client_name = @client_name);.
        /// </summary>
        internal static string SetClientWallet {
            get {
                return ResourceManager.GetString("SetClientWallet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap settingsButton {
            get {
                object obj = ResourceManager.GetObject("settingsButton", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT Взаиморасчеты.dbo.Клиенты.client_id AS &apos;ID&apos;, Взаиморасчеты.dbo.Клиенты.client_name AS &apos;Имя клиента&apos;, Взаиморасчеты.dbo.Клиенты.phone AS &apos;Телефон&apos;, Взаиморасчеты.dbo.Клиенты.email AS &apos;Эл. адрес&apos;, Взаиморасчеты.dbo.Счет_клиента.client_credit AS &apos;Кредит&apos;, Взаиморасчеты.dbo.Счет_клиента.client_balance AS &apos;Баланс&apos;
        ///  FROM Взаиморасчеты.dbo.Клиенты LEFT JOIN Взаиморасчеты.dbo.Счет_клиента ON Взаиморасчеты.dbo.Клиенты.client_id = Взаиморасчеты.dbo.Счет_клиента.client_id;.
        /// </summary>
        internal static string SimpleTable_Clients {
            get {
                return ResourceManager.GetString("SimpleTable_Clients", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT Взаиморасчеты.dbo.Клиенты.client_id AS &apos;ID&apos;, Взаиморасчеты.dbo.Оплата.date AS &apos;Дата&apos;, (SELECT Взаиморасчеты.dbo.Клиенты.client_name WHERE Взаиморасчеты.dbo.Клиенты.client_id = Взаиморасчеты.dbo.Оплата.client_id) AS &apos;Имя клиента&apos;, Взаиморасчеты.dbo.Оплата.payment AS &apos;Оплата&apos;, (SELECT ABS(Взаиморасчеты.dbo.Счет_клиента.client_balance + Взаиморасчеты.dbo.Счет_клиента.client_credit) FROM Взаиморасчеты.dbo.Счет_клиента WHERE Взаиморасчеты.dbo.Счет_клиента.client_id = Взаиморасчеты.dbo.Клиенты.client_id AN [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string SimpleTable_Payment {
            get {
                return ResourceManager.GetString("SimpleTable_Payment", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на SELECT Взаиморасчеты.dbo.Склад.storage_id AS &apos;ID&apos;, Взаиморасчеты.dbo.Склад.storage_name AS &apos;Адрес/Имя&apos;, Взаиморасчеты.dbo.Склад.storage_capacity AS &apos;Вместимость&apos;, Взаиморасчеты.dbo.Товар.item_type AS &apos;Тип товара&apos;, Взаиморасчеты.dbo.Товар.item_material AS &apos;Материал&apos;, Взаиморасчеты.dbo.Содержимое_склада.item_amount &apos;Количество&apos;, (SELECT  Взаиморасчеты.dbo.Товар.item_price* Взаиморасчеты.dbo.Содержимое_склада.item_amount) AS &apos;Сумма (руб)&apos; FROM Взаиморасчеты.dbo.Склад LEFT JOIN Взаиморасчеты.dbo.Содержимое_скла [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string SimpleTable_Storages {
            get {
                return ResourceManager.GetString("SimpleTable_Storages", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap statsIcon {
            get {
                object obj = ResourceManager.GetObject("statsIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Icon, аналогичного (Значок).
        /// </summary>
        internal static System.Drawing.Icon txtIcon {
            get {
                object obj = ResourceManager.GetObject("txtIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE Взаиморасчеты.dbo.Клиенты 
        ///  SET Взаиморасчеты.dbo.Клиенты.client_name = @client_name, Взаиморасчеты.dbo.Клиенты.phone = @phone, Взаиморасчеты.dbo.Клиенты.email = @email, Взаиморасчеты.dbo.Клиенты.manager_id = @manager_id
        ///  WHERE Взаиморасчеты.dbo.Клиенты.client_id = @client_id;
        ///
        ///UPDATE Взаиморасчеты.dbo.Счет_клиента
        ///  SET Взаиморасчеты.dbo.Счет_клиента.client_credit = @client_credit, Взаиморасчеты.dbo.Счет_клиента.client_balance = @client_balance
        ///  WHERE Взаиморасчеты.dbo.Счет_клиента.client_i [остаток строки не уместился]&quot;;.
        /// </summary>
        internal static string UpdateClient {
            get {
                return ResourceManager.GetString("UpdateClient", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Поиск локализованного ресурса типа System.Drawing.Bitmap.
        /// </summary>
        internal static System.Drawing.Bitmap updateIcon {
            get {
                object obj = ResourceManager.GetObject("updateIcon", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE Взаиморасчеты.dbo.Товар
        ///  SET Взаиморасчеты.dbo.Товар.item_type = @item_type, Взаиморасчеты.dbo.Товар.item_material = @item_material, Взаиморасчеты.dbo.Товар.item_price = @item_price
        ///  WHERE Взаиморасчеты.dbo.Товар.item_id = @item_id;.
        /// </summary>
        internal static string UpdateItem {
            get {
                return ResourceManager.GetString("UpdateItem", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на UPDATE Взаиморасчеты.dbo.Склад
        ///  SET Взаиморасчеты.dbo.Склад.storage_name = @storage_name, Взаиморасчеты.dbo.Склад.storage_capacity = @storage_capacity
        ///  WHERE Взаиморасчеты.dbo.Склад.storage_id = @storage_id.
        /// </summary>
        internal static string UpdateStorage {
            get {
                return ResourceManager.GetString("UpdateStorage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CREATE TRIGGER clearClientData ON Взаиморасчеты.dbo.Клиенты
        ///  AFTER DELETE
        ///  AS
        ///  BEGIN
        ///
        ///    DELETE FROM Взаиморасчеты.dbo.Счет_клиента WHERE client_id = (SELECT client_id FROM DELETED);
        ///    DELETE FROM Взаиморасчеты.dbo.Отгрузка WHERE client_id = (SELECT client_id FROM DELETED);
        ///    DELETE FROM Взаиморасчеты.dbo.Оплата WHERE client_id = (SELECT client_id FROM DELETED);
        ///
        ///  END.
        /// </summary>
        internal static string Z_Trigger_DeleteClientData__отключен__удаление_происходит_каскадно_по_связям___триггер_не_нужен_ {
            get {
                return ResourceManager.GetString("Z_Trigger_DeleteClientData (отключен, удаление происходит каскадно по связям - тр" +
                        "иггер не нужен)", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CREATE TRIGGER removeItem ON Взаиморасчеты.dbo.Товар
        ///  AFTER DELETE
        ///  AS
        ///    BEGIN
        ///    DELETE FROM Взаиморасчеты.dbo.Содержимое_склада WHERE item_id = (SELECT item_id FROM DELETED)
        ///    END.
        /// </summary>
        internal static string Z_Trigger_DeleteItemData {
            get {
                return ResourceManager.GetString("Z_Trigger_DeleteItemData", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на CREATE TRIGGER createWallet ON Взаиморасчеты.dbo.Клиенты
        ///    AFTER INSERT 
        ///    AS
        ///    BEGIN
        ///     declare @client_credit int;
        ///     declare @client_balance int;
        ///     SELECT @client_credit = 0;
        ///     SELECT @client_balance = 0;
        ///    	INSERT INTO Взаиморасчеты.dbo.Счет_клиента VALUES ((select ident_current(&apos;Взаиморасчеты.dbo.Клиенты&apos;)), @client_credit, @client_balance);
        ///    END.
        /// </summary>
        internal static string Z_Trigger_Wallet {
            get {
                return ResourceManager.GetString("Z_Trigger_Wallet", resourceCulture);
            }
        }
    }
}