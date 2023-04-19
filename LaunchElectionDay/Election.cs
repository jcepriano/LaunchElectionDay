using System;
using System.Collections.Generic;

namespace LaunchElectionDay
{
    public class Election
    {
        public string Year;
        public List<Race> Races;

        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();
        }
        public string GetYear()
        {
            return Year;
        }
        public List<Race> GetRaces()
        {
            return Races;
        }
        public void AddRace(Race race)
        {
            Races.Add(race);
        }
        public List<Candidate> GetAllCandidates(Race race)
        {
            var AllCandidates = new List<Candidate>();

            foreach (var candidate in race.Candidates)
            {
                AllCandidates.Add(candidate);
            }
            return AllCandidates;
        }
        public Dictionary<string, int> GetVoteCounts(Race race) 
        {
            var CandidateVotes = new Dictionary<string, int>(); 

            foreach(var candidate in race.Candidates)
            {
                CandidateVotes.Add(candidate.Name, candidate.Votes);
            }
            return CandidateVotes;
        }

        //public Dictionary<Candidate, int> GetVoteCounts()
        //{
        //    var AllCandidates = new List<Candidate>();

        //    Dictionary<List<Candidate>, int> DictList = new Dictionary<List<Candidate>, int>();

        //    AllCandidates.Add();

        //    return DictList;

        //}
    }
}
