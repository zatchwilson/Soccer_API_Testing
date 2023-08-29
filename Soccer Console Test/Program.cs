using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Soccer_Console_Test
{

/*
    public class Data
    {
        public string Get = "";
        public Parameters Parameters = new Parameters();
        public List<string> Errors = new List<string>();
        public int Results { get; set; }
        public Paging Paging = new Paging();
        public RequestReponse Reponse = new RequestReponse();


    }

    public class Parameters
    {
        public string League = "";
        public string Season = "";
        public string Team = "";
    }

    public class Paging
    {
        public int Current { get; set; }
        public int Total { get; set; }
    }

    public class RequestReponse
    {
        public TeamLeague League = new TeamLeague();
        public TeamInfo Team = new TeamInfo();
        public string Form = "";
        public TeamFixtures Fixtures = new TeamFixtures();
        public TeamGoals Goals = new TeamGoals();
        public LargestTotals Biggest = new LargestTotals();

        public HomeAwayIntTotals Clean_Sheet = new HomeAwayIntTotals();
        public HomeAwayIntTotals Failed_To_Score = new HomeAwayIntTotals();

        public PenaltyInfo Penalty = new PenaltyInfo();

        public List<TeamLineups> Lineups = new List<TeamLineups>();


        public class TeamLeague
        {
            public int Id { get; set; }
            public string Name = "";
            public string Country = "";
            public string Logo = "";
            public string Flag = "";
            public int season { get; set; }
        }

        public class TeamInfo
        {
            public int Id { get; set; }
            public string Name = "";
            public string Logo = "";
        }

        public class TeamFixtures
        {

            public HomeAwayIntTotals Played = new HomeAwayIntTotals();

            public HomeAwayIntTotals Wins = new HomeAwayIntTotals();

            public HomeAwayIntTotals Draws = new HomeAwayIntTotals();

            public HomeAwayIntTotals Loses = new HomeAwayIntTotals();

            *//*            class Wins
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }

                        class Draws
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }
                        class Loses
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }*//*

        }

        public class TeamGoals
        {
            [JsonProperty("for")]
            public GoalsTotals GoalsFor = new GoalsTotals();

            [JsonProperty("against")]
            public GoalsTotals GoalsAgainst = new GoalsTotals();


            public class GoalsTotals
            {
                public HomeAwayIntTotals Total = new HomeAwayIntTotals();
                public HomeAwayStringTotals Average = new HomeAwayStringTotals();
                public GoalMinuteInformation Minute = new GoalMinuteInformation();
            }

            public class GoalMinuteInformation
            {
                [JsonProperty("0-15")]
                public TotalPercentage ZeroFifteen = new TotalPercentage();
                [JsonProperty("16-30")]
                public TotalPercentage SixteenThirty = new TotalPercentage();

                [JsonProperty("31-45")]
                public TotalPercentage ThirtyOneFourtyFive = new TotalPercentage();

                [JsonProperty("45-60")]
                public TotalPercentage FourtySixSixty = new TotalPercentage();

                [JsonProperty("61-75")]
                public TotalPercentage SixtySeventyFive = new TotalPercentage();

                [JsonProperty("76-90")]
                public TotalPercentage SeventyFiveNinety = new TotalPercentage();

                [JsonProperty("91-105")]
                public TotalPercentage NinetyOneHundredFive = new TotalPercentage();

                [JsonProperty("106-120")]
                public TotalPercentage OneHundredSixOneHundredTwenty = new TotalPercentage();

            }

            *//*            class GoalTotal
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }

                        class GoalAverage
                        {
                            string Home { get; set; }
                            string Away { get; set; }
                            string Total { get; set; }
                        }*//*
        }

        public class LargestTotals
        {

            public LargestStreaks Streak = new LargestStreaks();
            public WinsLosesString Wins = new WinsLosesString();
            public WinsLosesString Loses = new WinsLosesString();
            public MostGoalsForAgainst Goals = new MostGoalsForAgainst();

            public class LargestStreaks
            {
                public int Wins { get; set; }
                public int Draws { get; set; }
                public int Loses { get; set; }
            }

            public class MostGoalsForAgainst
            {
                public HomeAwayInt For = new HomeAwayInt();
                public HomeAwayInt Against = new HomeAwayInt();
            }
        }

        public class PenaltyInfo
        {
            public TotalPercentage Scored = new TotalPercentage();
            public TotalPercentage Missed = new TotalPercentage();
            public int Total { get; set; }
        }

        public class TeamLineups
        {
            public string Formation = "";
            public int Played { get; set; }
        }

        public class CardTotals
        {
            public CardType Yellow = new CardType();
            public CardType Red = new CardType();

            public class CardType
            {
                [JsonProperty("0-15")]
                public TotalPercentage ZeroFifteen = new TotalPercentage();

                [JsonProperty("16-30")]
                public TotalPercentage SixteenThirty = new TotalPercentage();

                [JsonProperty("31-45")]
                public TotalPercentage ThirtyOneFourtyFive = new TotalPercentage();

                [JsonProperty("45-60")]
                public TotalPercentage FourtySixSixty = new TotalPercentage();

                [JsonProperty("61-75")]
                public TotalPercentage SixtySeventyFive = new TotalPercentage();

                [JsonProperty("76-90")]
                public TotalPercentage SeventyFiveNinety = new TotalPercentage();

                [JsonProperty("91-105")]
                public TotalPercentage NinetyOneHundredFive = new TotalPercentage();

                [JsonProperty("106-120")]
                public TotalPercentage OneHundredSixOneHundredTwenty = new TotalPercentage();
            }
        }

        public class HomeAwayIntTotals
        {
            int Home { get; set; }
            int Away { get; set; }
            int Total { get; set; }
        }

        public class HomeAwayStringTotals
        {
            string Home = "";
            string Away = "";
            string Total = "";
        }

        public class WinsLosesString
        {
            string Home = "";
            string Away = "";
        }


        public class HomeAwayInt
        {
            int Home { get; set; }
            int Away { get; set; }
        }

        public class TotalPercentage
        {
            int Total;
            string Percentage = "";
        }

    }*/


    public class Data
    {
        public string Get { get; set; }
        public Parameters Parameters {get; set;}
        public List<string> Errors = new List<string>();
        public int Results;
        public Paging Paging;
        public RequestReponse Response;

        public Data() 
        {
            Get = string.Empty;
            Parameters = new Parameters();
            Errors = new List<string>();
            Results = 0;
            Paging = new Paging();
            Response = new RequestReponse();
        }
    }

    public class Parameters
    {
        public string League { get; set; }
        public string Season { get; set; }
        public string Team { get; set; }

        public Parameters()
        {
            League = string.Empty;
            Season = string.Empty;
            Team = string.Empty;
        }
    }

    public class Paging
    {
        public int Current { get; set; }
        public int Total { get; set; }
    }

    public class RequestReponse
    {
        public TeamLeague League { get; set; }
        public TeamInfo Team { get; set; }
        public string Form { get; set; }
        public TeamFixtures Fixtures { get; set; }
        public TeamGoals Goals { get; set; }
        public LargestTotals Biggest { get; set; }

        public HomeAwayIntTotals Clean_Sheet { get; set; }
        public HomeAwayIntTotals Failed_To_Score { get; set; }

        public PenaltyInfo Penalty { get; set; }

        public List<TeamLineups> Lineups = new List<TeamLineups>();


        public RequestReponse()
        {
            League = new TeamLeague();
            Team = new TeamInfo();
            Form = string.Empty;
            Fixtures = new TeamFixtures();
            Goals = new TeamGoals();
            Biggest = new LargestTotals();
            Clean_Sheet = new HomeAwayIntTotals();
            Failed_To_Score = new HomeAwayIntTotals();
            Penalty = new PenaltyInfo();

            Lineups = new List<TeamLineups>();
        }

        public class TeamLeague
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Country { get; set; }
            public string Logo { get; set; }
            public string Flag { get; set; }
            public int Season { get; set; }

            public TeamLeague()
            {
                Id = 0;
                Name = string.Empty;
                Country = string.Empty;
                Logo = string.Empty;
                Flag = string.Empty;
                Season = 0;
            }
        }

        public class TeamInfo
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Logo { get; set; }

            public TeamInfo() 
            {
                Id = 0;
                Name = string.Empty;
                Logo = string.Empty;
            }
        }

        public class TeamFixtures
        {

            public HomeAwayIntTotals Played { get; set; }

            public HomeAwayIntTotals Wins { get; set; }

            public HomeAwayIntTotals Draws { get; set; }

            public HomeAwayIntTotals Loses { get; set; }

            public TeamFixtures()
            {
                Played = new HomeAwayIntTotals();
                Wins = new HomeAwayIntTotals();
                Draws = new HomeAwayIntTotals();
                Loses = new HomeAwayIntTotals();
            }
            /*            class Wins
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }

                        class Draws
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }
                        class Loses
                        {
                            int Home { get; set; }
                            int Away { get; set; }
                            int Total { get; set; }
                        }*/

        }

        public class TeamGoals
        {
            [JsonProperty("for")]
            public GoalsTotals GoalsFor { get; set; }

            [JsonProperty("against")]
            public GoalsTotals GoalsAgainst { get; set; }

            public TeamGoals()
            {
                GoalsFor = new GoalsTotals();
                GoalsAgainst = new GoalsTotals();
            }


            public class GoalsTotals
            {
                public HomeAwayIntTotals Total { get; set; }
                public HomeAwayStringTotals Average { get; set; }
                public GoalMinuteInformation Minute { get; set; }

                public GoalsTotals()
                {
                    Total = new HomeAwayIntTotals();
                    Average = new HomeAwayStringTotals();
                    Minute = new GoalMinuteInformation();
                }

            }

            public class GoalMinuteInformation
            {   
                [JsonProperty("0-15")]
                public TotalPercentage ZeroFifteen { get; set; }
                [JsonProperty("16-30")]
                public TotalPercentage SixteenThirty { get; set; }

                [JsonProperty("31-45")]
                public TotalPercentage ThirtyOneFourtyFive { get; set; }

                [JsonProperty("45-60")]
                public TotalPercentage FourtySixSixty { get; set; }

                [JsonProperty("61-75")]
                public TotalPercentage SixtySeventyFive { get; set; }

                [JsonProperty("76-90")]
                public TotalPercentage SeventyFiveNinety { get; set; }

                [JsonProperty("91-105")]
                public TotalPercentage NinetyOneHundredFive { get; set; }

                [JsonProperty("106-120")]
                public TotalPercentage OneHundredSixOneHundredTwenty { get; set; }

                public GoalMinuteInformation()
                {
                    ZeroFifteen = new TotalPercentage();
                    SixteenThirty = new TotalPercentage();
                    ThirtyOneFourtyFive = new TotalPercentage();
                    FourtySixSixty = new TotalPercentage();
                    SixtySeventyFive = new TotalPercentage();
                    SeventyFiveNinety = new TotalPercentage();
                    NinetyOneHundredFive = new TotalPercentage();
                    OneHundredSixOneHundredTwenty = new TotalPercentage();
                }

            }

/*            class GoalTotal
            {
                int Home { get; set; }
                int Away { get; set; }
                int Total { get; set; }
            }

            class GoalAverage
            {
                string Home { get; set; }
                string Away { get; set; }
                string Total { get; set; }
            }*/
        }

        public class LargestTotals
        {

            public LargestStreaks Streak { get; set; }
            public WinsLosesString Wins { get; set; }
            public WinsLosesString Loses { get; set; }
            public MostGoalsForAgainst Goals { get; set; }

            public LargestTotals()
            {
                Streak = new LargestStreaks();
                Wins = new WinsLosesString();
                Loses = new WinsLosesString();
                Goals = new MostGoalsForAgainst();
            }

            public class LargestStreaks
            {
                public int Wins { get; set; }
                public int Draws { get; set; }
                public int Loses { get; set; }
            }

            public class MostGoalsForAgainst
            {
                public HomeAwayInt For { get; set; }
                public HomeAwayInt Against { get; set; }

                public MostGoalsForAgainst()
                {
                    For = new HomeAwayInt();
                    Against = new HomeAwayInt();
                }
            }
        }

        public class PenaltyInfo
        {
            public TotalPercentage Scored { get; set; }
            public TotalPercentage Missed { get; set; }
            public int Total { get; set; }

            public PenaltyInfo()
            {
                Scored = new TotalPercentage();
                Missed = new TotalPercentage();
                Total = 0;
            }
        }

        public class TeamLineups
        {
            public string Formation { get; set; }
            public int Played { get; set; }

            public TeamLineups()
            {
                Formation = string.Empty;
                Played = 0;
            }
        }

        public class CardTotals
        {
            public CardType Yellow { get; set; }
            public CardType Red { get; set; }

            public CardTotals()
            {
                Yellow = new CardType();
                Red = new CardType();
            }

            public class CardType
            {
                [JsonProperty("0-15")]
                public TotalPercentage ZeroFifteen { get; set; }
                [JsonProperty("16-30")]
                public TotalPercentage SixteenThirty { get; set; }

                [JsonProperty("31-45")]
                public TotalPercentage ThirtyOneFourtyFive { get; set; }

                [JsonProperty("45-60")]
                public TotalPercentage FourtySixSixty { get; set; }

                [JsonProperty("61-75")]
                public TotalPercentage SixtySeventyFive { get; set; }

                [JsonProperty("76-90")]
                public TotalPercentage SeventyFiveNinety { get; set; }

                [JsonProperty("91-105")]
                public TotalPercentage NinetyOneHundredFive { get; set; }

                [JsonProperty("106-120")]
                public TotalPercentage OneHundredSixOneHundredTwenty { get; set; }

                public CardType()
                {
                    ZeroFifteen = new TotalPercentage();
                    SixteenThirty = new TotalPercentage();
                    ThirtyOneFourtyFive = new TotalPercentage();
                    FourtySixSixty = new TotalPercentage();
                    SixtySeventyFive = new TotalPercentage();
                    SeventyFiveNinety = new TotalPercentage();
                    NinetyOneHundredFive = new TotalPercentage();
                    OneHundredSixOneHundredTwenty = new TotalPercentage();
                }
            }
        }

        public class HomeAwayIntTotals
        {
            int Home { get; set; }
            int Away { get; set; }
            int Total { get; set; }
        }

        public class HomeAwayStringTotals
        {
            string Home { get; set; }
            string Away { get; set; }
            string Total { get; set; }

            public HomeAwayStringTotals()
            {
                Home = string.Empty;
                Away = string.Empty;
                Total = string.Empty;
            }
        }

        public class WinsLosesString
        {
            string Home { get; set; }
            string Away { get; set; }

            public WinsLosesString()
            {
                Home = string.Empty;
                Away = string.Empty;
            }
        }


        public class HomeAwayInt
        {
            int Home { get; set; }
            int Away { get; set; }
        }

        public class TotalPercentage
        {
            int Total { get; set; }
            string Percentage { get; set; }

            public TotalPercentage()
            {
                Total = 0;
                Percentage = string.Empty;
            }
        }

    }



     class Program
    {
        public static Data returnData = new Data();
        static void Main(string[] args)

           
        {
            Data newData = new Data();

            newData = StartClient();

            Console.WriteLine(newData.Response.Team.Name);
        }

        public static Data StartClient()
        {
            Data data = new Data();
            string apiKey = ConfigurationManager.AppSettings.Get("APIKey");
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api-football-v1.p.rapidapi.com/v3/teams?id=33"),
                Headers =
                {
                    { "X-RapidAPI-Key", apiKey },
                    { "X-RapidAPI-Host", "api-football-v1.p.rapidapi.com" },
                },
            };

            data = TestClient(client, request, data).Result;

            return data;
        }

        static async Task<Data> TestClient(HttpClient client, HttpRequestMessage request, Data data)
        {
            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<Data>(System.IO.File.ReadAllText("TeamTest.json"));
                }
            }

            catch
            {
                Console.WriteLine("The information that was input is not valid.");
            }

            return data;
        }

    }


}