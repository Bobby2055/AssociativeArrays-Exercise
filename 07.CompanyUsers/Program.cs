namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> companyUsers = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "End") 
            {
                string[] cmdArg = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string company = cmdArg[0];
                string employeeID = cmdArg[1];

                if (!companyUsers.ContainsKey(company))
                {
                    companyUsers[company] = new List<string>() { employeeID };
                }

                if (!companyUsers[company].Contains(employeeID)) 
                {
                    companyUsers[company].Add(employeeID);  
                }
            }

            foreach (var kvp in companyUsers)
            {
                Console.WriteLine($"{kvp.Key}");
                
                foreach (var user in kvp.Value)
                {
                    Console.WriteLine($"-- {user}");
                }
            }
        }
    }
}