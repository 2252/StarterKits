﻿using APIMASH;
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

//
// LICENSE: http://opensource.org/licenses/ms-pl) 
//

namespace APIMASH_StarterKit.Common
{
    public sealed class ApiStatusToInvisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            ApiResponseStatus s = value as ApiResponseStatus;
            return (s == null || s.IsSuccessStatusCode) ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}