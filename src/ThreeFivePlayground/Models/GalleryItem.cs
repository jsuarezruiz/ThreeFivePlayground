namespace ThreeFivePlayground.Models
{
    public enum GalleryItemType
    {
        Default,
        Medium,
        Big
    }

    public class GalleryItem
    {
        public GalleryItemType GalleryItemType { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
    }
}