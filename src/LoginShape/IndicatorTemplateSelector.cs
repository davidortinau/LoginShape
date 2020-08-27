using System;
using Xamarin.Forms;

namespace LoginShape
{
    public class IndicatorTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ActiveTemplate { get; set; }
        public DataTemplate DefaultTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((OnboardingSteps)item).IsSelected ? ActiveTemplate : DefaultTemplate;
        }
    }

    public class OnboardingSteps
    {
        public bool IsFinal { get; set; }
        public bool IsSelected { get; set; }
    }
}
