using System.ComponentModel;
using System.Reflection;
using MudBlazor;

namespace WebReceipt.Common
{

    public class Extensions
    {
        public static void ShowSnackbar(string message, Variant variant, ISnackbar snackbar, Severity severity)
        {
            snackbar.Configuration.PositionClass = Defaults.Classes.Position.BottomCenter;
            snackbar.Configuration.SnackbarVariant = variant;
            snackbar.Configuration.MaxDisplayedSnackbars = 10;
            snackbar.Configuration.VisibleStateDuration = 2000;
            snackbar.Add($"{message}", severity);
        }
        public static string GetEnumDescription(Enum value)  
        {  
            var enumMember = value.GetType().GetMember(value.ToString()).FirstOrDefault();  
            var descriptionAttribute =  
                enumMember == null  
                    ? default(DescriptionAttribute)  
                    : enumMember.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;  
            return  
                descriptionAttribute == null  
                    ? value.ToString()  
                    : descriptionAttribute.Description;  
        }
    }
}