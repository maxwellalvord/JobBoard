

namespace JobBoard.Models
{
  public class Job
  {
    public string Adjective1 { get; set; }
    public string Noun1 { get; set; }
    public string Verb { get; set; }   
    public string Adjective2 { get; set; }
    public string Noun2 { get; set; }
  
    public void myJob(string adjective1, string noun1, string verb, string adjective2, string noun2)
    {
      Adjective1 = adjective1;
      Noun1 = noun1;
      Verb = verb;
      Adjective2 = adjective2;
      Noun2 = noun2;
    }
  }
}