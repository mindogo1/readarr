using System;
using System.Collections.Generic;

namespace NzbDrone.Core.Indexers.Rarbg
{
    public class RarbgResponse
    {
        public string error { get; set; }
        public int? error_code { get; set; }
        public List<RarbgTorrent> torrent_results { get; set; }
    }

    public class RarbgTorrent
    {
        public string title { get; set; }
        public string category { get; set; }
        public string download { get; set; }
        public int? seeders { get; set; }
        public int? leechers { get; set; }
        public long size { get; set; }
        public DateTime pubdate { get; set; }
        public RarbgTorrentInfo episode_info { get; set; }
        public int? ranked { get; set; }
        public string info_page { get; set; }
    }

    public class RarbgTorrentInfo
    {
        // For Future if RARBG decides to return metadata
        public string author { get; set; }
        public string book { get; set; }
    }
}
