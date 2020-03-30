using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Fasetto.Word
{
    /// <summary>
    /// Focuses (keyboard focus) this element on load
    /// </summary>
    public class IsFocusedProperty: BaseAttachedProperty<IsFocusedProperty, bool> 
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // If we don't have a control, return
            if (!(sender is Control control))
                return;

            // Focus this control once loaded
            control.Loaded += (ss, ee) => control.Focus();
        }
    }
    
    /// <summary>
    /// Focuses (keyboard focus) this element if true
    /// </summary>
    public class FocusAdnSelectProperty : BaseAttachedProperty<FocusAdnSelectProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            // If we don't have a control, return
            if (!(sender is TextBoxBase control))
                return;

            if ((bool)e.NewValue)
            {
                // Focus this control 
                control.Focus();

                // Select All
                control.SelectAll();
            }
        }
    }
}
