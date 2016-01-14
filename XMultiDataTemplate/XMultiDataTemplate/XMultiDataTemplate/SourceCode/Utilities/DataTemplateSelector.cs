using Xamarin.Forms;
using XMultiDataTemplate.SourceCode.Database;

namespace XMultiDataTemplate.SourceCode.Utilities
{
    public class DataTemplateSelector
    {
        public virtual DataTemplate SelectTemplate(object item, BindableObject container)
        {
            return null;
        }
    }
    public class TvSeriesTemplateSelector: DataTemplateSelector
    {
        public DataTemplate TvSeriesSmallSizeTemplate { get; set; }
        public DataTemplate TvSeriesMediumSizeTemplate { get; set; }
        public DataTemplate TvSeriesLargeSizeTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, BindableObject container)
        {
            var tvSeries = item as TvSerie;
            if (tvSeries != null && tvSeries.Width == 1)
            {
                return TvSeriesSmallSizeTemplate;
            }
            if (tvSeries != null && tvSeries.Width == 2 && tvSeries.Height == 1)
            {
                return TvSeriesMediumSizeTemplate;
            }
            return TvSeriesLargeSizeTemplate;
        }
    }
}
