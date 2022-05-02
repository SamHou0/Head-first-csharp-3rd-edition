using System.IO;
// See https://aka.ms/new-console-template for more information
StreamWriter sw = new(@"D:\secret_plan.txt");
sw.WriteLine("How I'll defeat Captain Amazing");
sw.WriteLine("Another genius secret plan by the Swindler");
sw.Write("I'll create an army of clones and ");
sw.WriteLine("unleash them upon the citizens of objectville");
string location = "the mall";
for (int number = 0; number <= 6; number++)
{
    sw.WriteLine("Clone #{0} attacks {1}", number, location);
    if(location=="the mall") { location = "downtown"; }
    else { location = "the mall"; }
}
sw.Close();
