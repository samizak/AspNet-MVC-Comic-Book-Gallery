namespace ComicBookGallery.Models;

public class ComicBook
{
    public int Id { get; set; }
    public string SeriesTitle { get; set; } = string.Empty;
    public int IssueNumber { get; set; }
    public string DescriptionHtml { get; set; } = string.Empty;
    public Artists[] Artists { get; set; }
    public bool Favorite { get; set; }

    public string DisplayText
    {
        get
        {
            return SeriesTitle + " #" + IssueNumber;
        }
    }

    public string CoverImageFIleName
    {
        get
        {
            return SeriesTitle
                .Replace(" ", "-")
                .Replace(":", "")
                .ToLower() + "-" + IssueNumber + ".jpg";
        }
    }
}