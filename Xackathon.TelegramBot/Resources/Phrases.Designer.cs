﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Xackathon.TelegramBot.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Phrases {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Phrases() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Xackathon.TelegramBot.Resources.Phrases", typeof(Phrases).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Выберите категорию:.
        /// </summary>
        public static string Category {
            get {
                return ResourceManager.GetString("Category", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Укажите адрес:.
        /// </summary>
        public static string Cordinates {
            get {
                return ResourceManager.GetString("Cordinates", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Заполните заявку следуя указаниям:.
        /// </summary>
        public static string CreateRequest {
            get {
                return ResourceManager.GetString("CreateRequest", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Опишите заявку:.
        /// </summary>
        public static string Description {
            get {
                return ResourceManager.GetString("Description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Здравствуйте! Через бота можно оставить заявку. Доступные методы:
        ////start - Просмотреть все команды
        ////create_request - Создать заявку
        ///.
        /// </summary>
        public static string Instructions {
            get {
                return ResourceManager.GetString("Instructions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Укажите фото с места события:.
        /// </summary>
        public static string Photos {
            get {
                return ResourceManager.GetString("Photos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Укажите ваше ФИО:.
        /// </summary>
        public static string WriteFIO {
            get {
                return ResourceManager.GetString("WriteFIO", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Укажите номер телефона:.
        /// </summary>
        public static string WritePhone {
            get {
                return ResourceManager.GetString("WritePhone", resourceCulture);
            }
        }
    }
}
