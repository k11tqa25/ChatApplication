using System;
using System.Windows;
using System.Windows.Controls;

namespace Fasetto.Word
{
    ///// <summary>
    ///// This is one way to do the attactched property. However, it's too messy. 
    ///// </summary>
    //public class PasswordBoxProperties
    //{
    //    public static readonly DependencyProperty MonitorPasswordProperty =
    //        DependencyProperty.RegisterAttached("MonitorPasswordProperty", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false, OnMonitorPasswordChange));

    //    private static void OnMonitorPasswordChange(DependencyObject d, DependencyPropertyChangedEventArgs e)
    //    {
    //        var passwordBox = (d as PasswordBox);
    //        if (passwordBox == null) return;

    //        passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

    //        if ((bool)e.NewValue)
    //        {
    //            SetHasText(passwordBox);
    //            passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
    //        }
    //    }

    //    private static void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
    //    {
    //        SetHasText((PasswordBox)sender);
    //    }

    //    public static void SetMonitorPasswordProperty(PasswordBox element, bool value)
    //    {
    //        element.SetValue(MonitorPasswordProperty, value);
    //    }

    //    public static bool GetMonitorPasswordProperty(PasswordBox element)
    //    {
    //        return (bool)element.GetValue(MonitorPasswordProperty);
    //    }



    //    public static readonly DependencyProperty HasTextProperty = 
    //        DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(PasswordBoxProperties), new PropertyMetadata(false));

    //    private static void SetHasText(PasswordBox element)
    //    {
    //        element.SetValue(HasTextProperty, element.SecurePassword.Length > 0);
    //    }

    //    public static bool GetHasText(PasswordBox element)
    //    {
    //        return (bool)element.GetValue(HasTextProperty);
    //    }
    //}
}
