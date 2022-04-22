﻿namespace LeagueActivityBot.Riot
{
    public class RiotClientOptions
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        
        public string SummonerApiResource { get; set; }
        public string SpectatorApiResource { get; set; }
        
        public string MatchApiUrl { get; set; }
    }
}