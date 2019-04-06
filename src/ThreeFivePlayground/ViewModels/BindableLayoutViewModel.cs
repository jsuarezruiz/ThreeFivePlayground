using System.Collections.ObjectModel;
using ThreeFivePlayground.Models;
using ThreeFivePlayground.ViewModels.Base;

namespace ThreeFivePlayground.ViewModels
{
    public class BindableLayoutViewModel : ViewModelBase
    {
        public BindableLayoutViewModel()
        {
            Gallery = new ObservableCollection<GalleryItem>
             {
                 new GalleryItem { GalleryItemType = GalleryItemType.Medium, Picture = "sevilla01.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Medium, Picture = "sevilla02.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Big, Picture = "sevilla03.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla04.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla05.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla06.jpg" },
                 new GalleryItem { GalleryItemType = GalleryItemType.Default, Picture = "sevilla07.jpg" }
             };
        }

        public ObservableCollection<GalleryItem> Gallery { get; set; }
    }
}
