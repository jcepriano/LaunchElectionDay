using System;
using System.Collections.Generic;


namespace LaunchElectionDay
{
    public class Race
    {
        public string Office;
        public List<Candidate> Candidates;

        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
        }
        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }
        public bool IsOpen(Candidate candidate)
        {
            if (candidate.Votes == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
