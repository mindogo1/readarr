using System;
using System.Collections.Generic;
using System.Linq;
using NzbDrone.Common.Extensions;

namespace NzbDrone.Core.Books
{
    public class AuthorMetadata : Entity<AuthorMetadata>
    {
        public AuthorMetadata()
        {
            Images = new List<MediaCover.MediaCover>();
            Genres = new List<string>();
            Links = new List<Links>();
            Aliases = new List<string>();
            Ratings = new Ratings();
        }

        public string ForeignAuthorId { get; set; }
        public string TitleSlug { get; set; }
        public string Name { get; set; }
        public string SortName { get; set; }
        public string NameLastFirst { get; set; }
        public string SortNameLastFirst { get; set; }
        public List<string> Aliases { get; set; }
        public string Overview { get; set; }
        public string Disambiguation { get; set; }
        public string Gender { get; set; }
        public string Hometown { get; set; }
        public DateTime? Born { get; set; }
        public DateTime? Died { get; set; }
        public AuthorStatusType Status { get; set; }
        public List<MediaCover.MediaCover> Images { get; set; }
        public List<Links> Links { get; set; }
        public List<string> Genres { get; set; }
        public Ratings Ratings { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}][{1}]", ForeignAuthorId, Name.NullSafe());
        }

        public override void UseMetadataFrom(AuthorMetadata other)
        {
            ForeignAuthorId = other.ForeignAuthorId;
            TitleSlug = other.TitleSlug;
            Name = other.Name;
            NameLastFirst = other.NameLastFirst;
            SortName = other.SortName;
            SortNameLastFirst = other.SortNameLastFirst;
            Aliases = other.Aliases;
            Overview = other.Overview.IsNullOrWhiteSpace() ? Overview : other.Overview;
            Disambiguation = other.Disambiguation;
            Gender = other.Gender;
            Hometown = other.Hometown;
            Born = other.Born;
            Died = other.Died;
            Status = other.Status;
            Images = other.Images.Any() ? other.Images : Images;
            Links = other.Links;
            Genres = other.Genres;
            Ratings = other.Ratings.Votes > 0 ? other.Ratings : Ratings;
        }
    }
}
