using System;
using Xamarin.Forms;

namespace XMultiDataTemplate.SourceCode.Utilities
{
    public class ExtendedListView : ListView
    {
        public ExtendedListView() { }
        public ExtendedListView(ListViewCachingStrategy strategy) : base(strategy)
        {
        }

        public static readonly BindableProperty ItemTemplateSelectorProperty = BindableProperty.Create("ItemTemplateSelector", typeof(DataTemplateSelector), typeof(ExtendedListView), null, propertyChanged: OnDataTemplateSelectorChanged);
        private DataTemplateSelector _currentItemSelector;
        private static void OnDataTemplateSelectorChanged(BindableObject bindable, object oldvalue, object newvalue)
        {
            ((ExtendedListView)bindable).OnDataTemplateSelectorChanged((DataTemplateSelector)oldvalue, (DataTemplateSelector)newvalue);
        }
        protected virtual void OnDataTemplateSelectorChanged(DataTemplateSelector oldValue, DataTemplateSelector newValue)
        {
            // check to see we don't have an ItemTemplate set
            if (ItemTemplate != null && newValue != null)
                throw new ArgumentException("Cannot set both ItemTemplate and ItemTemplateSelector");
            _currentItemSelector = newValue;
        }
        protected override Cell CreateDefault(object item)
        {
            var template = _currentItemSelector?.SelectTemplate(item, this);
            if (template == null) return base.CreateDefault(item);
            var templateInstance = template.CreateContent();
            // see if it's a view or a cell
            var templateView = templateInstance as View;
            var templateCell = templateInstance as Cell;
            if (templateView == null && templateCell == null)
                throw new InvalidOperationException("DataTemplate must be either a Cell or a View");
            if (templateView != null) // we got a view, wrap in a cell
                templateCell = new ViewCell { View = templateView };
            return templateCell;
        }
        public DataTemplateSelector ItemTemplateSelector
        {
            get { return (DataTemplateSelector) GetValue(ItemTemplateSelectorProperty); }
            set { SetValue(ItemTemplateSelectorProperty, value); }
        }
    }
}
