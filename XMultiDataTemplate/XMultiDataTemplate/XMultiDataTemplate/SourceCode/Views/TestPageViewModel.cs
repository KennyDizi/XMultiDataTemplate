using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using XMultiDataTemplate.SourceCode.Database;
using XMultiDataTemplate.SourceCode.Mvvm;

namespace XMultiDataTemplate.SourceCode.Views
{
    public class TestPageViewModel : BindableBase
    {
        private ObservableCollection<TvSerie> _tvSeries;

        public ObservableCollection<TvSerie> TvSeries
        {
            get { return _tvSeries ?? (_tvSeries = new ObservableCollection<TvSerie>()); }
            
            set { Set(() => TvSeries, ref _tvSeries, value); }
        }
        public TestPageViewModel()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                TvSeries.Add(new TvSerie { Name = "Supernatural", Seasons = "9 Seasons", Genre = "Supernatural Drama", Width = 2, Height = 2, Image = "http://images2.fanpop.com/images/photos/2700000/Supernatural-supernatural-2784812-1280-960.jpg", Description = "Supernatural is an American supernatural drama television series, created by Eric Kripke, which was first broadcast on September 13, 2005, on The WB, and is now part of The CW's lineup. Starring Jared Padalecki as Sam Winchester, and Jensen Ackles as Dean Winchester, the series follows these two brothers as they hunt demons, ghosts, monsters and other supernatural beings in the world. The series is produced by Warner Bros. Television, in association with Wonderland Sound and Vision. The current executive producers are Eric Kripke, McG, and Robert Singer." });
                TvSeries.Add(new TvSerie { Name = "Fringe", Seasons = "5 Seasons", Genre = "Science Fiction", Width = 2, Height = 1, Image = "http://tvafterdarkonline.com/wp-content/uploads/2012/06/FRINGE-Sunday-Hall-H-WBSDCC-2012.jpg" });
                TvSeries.Add(new TvSerie { Name = "Chuck", Seasons = "5 Seasons", Genre = "Action Comedy", Width = 2, Height = 1, Image = "http://zinemaniacos.files.wordpress.com/2012/06/chuck.jpg" });
                TvSeries.Add(new TvSerie { Name = "Falling Skies", Width = 1, Height = 1, Image = "http://2.bp.blogspot.com/-cVgdAr1EFQA/TgJpY5cciTI/AAAAAAAABDg/f4MetFkSeAo/s1600/tv_falling_skies04.jpg" });
                TvSeries.Add(new TvSerie { Name = "Revolution", Width = 1, Height = 1, Seasons = "2 Seasons", Image = "http://www.hdwallpapers.in/walls/revolution_tv_series-wide.jpg" });
                TvSeries.Add(new TvSerie { Name = "Battlestar Galactica", Seasons = "4 Seasons", Genre = "Science Fiction", Width = 2, Height = 1, Image = "http://image.allmusic.com/00/agg/cov200/drg200/g283/g28358peyd2.jpg" });
                TvSeries.Add(new TvSerie { Name = "House MD", Seasons = "8 Seasons", Genre = "Dramedy, Mystery", Width = 2, Height = 2, Image = "http://www.kotusozluk.com/img/2011/04/house-md_18373.jpg", Description = "House (also known as House, M.D.) was an American television medical drama that originally ran on the Fox network for eight seasons, from November 16, 2004 to May 21, 2012. The show's main character is Dr. Gregory House (Hugh Laurie), a drug-addicted, unconventional, misanthropic medical genius who leads a team of diagnosticians at the fictional Princeton–Plainsboro Teaching Hospital (PPTH) in New Jersey." });
                TvSeries.Add(new TvSerie { Name = "Sherlock", Seasons = "2 Seasons", Genre = "Crime Drama", Width = 2, Height = 1, Image = "http://skyethelimit.files.wordpress.com/2012/02/us-sherlock-dvd-cmyk.jpg" });
            });            
        }
    }
}
