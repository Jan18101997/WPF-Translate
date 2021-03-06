﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace de.LandauSoftware.WPFTranslate.IO
{
    internal class XAMLSettingsXamarin : XAMLSettings
    {
        private DictionaryNamespace _MainNamepsace;
        private DictionaryNamespace _StaticNamepsace;

        public override ReadOnlyCollection<DictionaryNamespace> GetNamespacesAsCollection
        {
            get
            {
                return (new List<DictionaryNamespace>
                {
                    MainNamepsace,
                    XNamespace
                }).AsReadOnly();
            }
        }

        public override DictionaryNamespace MainNamepsace => _MainNamepsace ?? (_MainNamepsace = new DictionaryNamespace("", "http://xamarin.com/schemas/2014/forms"));

        public override bool SupportesXmlPreserveSpace => false;
        public override DictionaryNamespace SystemNamespace => XNamespace;

        public override DictionaryNamespace XNamespace => _StaticNamepsace ?? (_StaticNamepsace = new DictionaryNamespace("x", "http://schemas.microsoft.com/winfx/2009/xaml"));
    }
}