// See https://aka.ms/new-console-template for more information

string folder=Environment.GetFolderPath(
    Environment.SpecialFolder.MyDocuments);
StreamReader reader=new StreamReader(folder+@"\secret_plan.txt");
StreamWriter writer = new StreamWriter(folder + @"\emailToCaptainAmazing.txt");
writer.WriteLine("To: CaptainAmazing@objectville.net");
writer.WriteLine("From:Commissioner@objectville.net");
writer.WriteLine("Subject: Can you save the day ... again?");
writer.WriteLine();
writer.WriteLine("We've discovered the Swindler's plan:");
while (!reader.EndOfStream)
{
    string lineFromThePlan = reader.ReadLine();
    writer.WriteLine("The plan ->"+lineFromThePlan);
}
writer.WriteLine("Can you help us?");
writer.Close();
reader.Close();
