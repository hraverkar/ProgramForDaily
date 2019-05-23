namespace WpfApp1
{
  internal class Patient
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Code { get; set; }
    public int Insurance { get; set; }

    public Patient(string line)
    {
      string[] parts = line.Split(',');
      this.FirstName = parts[0];
      this.LastName = parts[1];
      this.Code = parts[2];
      this.Insurance = int.Parse(parts[3]);
    }

    public string GetLine()
    {
      return this.FirstName + "," + this.LastName + "," + this.Code + "," + this.Insurance.ToString();
    }
  }
}