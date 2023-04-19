using LaunchElectionDay;
using System.Diagnostics;

var diana = new Candidate("Diana D", "Democrat");

Console.WriteLine(diana.Name);

Console.WriteLine(diana.Party);
Console.WriteLine(diana.Votes);

diana.VoteFor();
diana.VoteFor();
diana.VoteFor();

Console.WriteLine(diana.Votes);


var race = new Race("City Council District 10");

Console.WriteLine (race.Office);

List<Candidate> candidate = race.Candidates;

race.RegisterCandidate(diana);

List<Candidate> candidate2 = race.Candidates;

Console.WriteLine(diana);
    