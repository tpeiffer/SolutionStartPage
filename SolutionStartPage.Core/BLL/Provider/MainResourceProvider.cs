﻿namespace SolutionStartPage.Core.BLL.Provider
{
    using System.Globalization;
    using System.Windows;
    using Localization;
    using Shared.BLL.Provider;

    public class MainResourceProvider : IResourceProvider
    {
        /////////////////////////////////////////////////////////
        #region IResourceProvider Member

        CultureInfo IResourceProvider.Culture
        {
            get => Main.Culture;
            set => Main.Culture = value;
        }

        public string this[string key]
        {
            get
            {
                var resource = Main.ResourceManager.GetString(key, Main.Culture);
                if (resource == null)
                    throw new ResourceReferenceKeyNotFoundException(
                        "Couldn't find the requested text in the localization resources.", key);
                return resource;
            }
        }

        #endregion
    }
}