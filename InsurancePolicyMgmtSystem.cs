using System;
using System.Collections.Generic;
using System.Linq;

class Policy : IComparable<Policy>
{
    public string PolicyNumber { get; }
    public string HolderName { get; }
    public string CoverageType { get; }
    public DateTime ExpiryDate { get; }

    public Policy(string policyNumber, string holderName, string coverageType, DateTime expiryDate)
    {
        PolicyNumber = policyNumber;
        HolderName = holderName;
        CoverageType = coverageType;
        ExpiryDate = expiryDate;
    }

    public override bool Equals(object obj)
    {
        return obj is Policy policy && PolicyNumber == policy.PolicyNumber;
    }

    public override int GetHashCode()
    {
        return PolicyNumber.GetHashCode();
    }

    public int CompareTo(Policy other)
    {
        return ExpiryDate.CompareTo(other.ExpiryDate);
    }

    public override string ToString()
    {
        int daysUntilExpiry = (ExpiryDate - DateTime.Now).Days;
        string expiryStatus = daysUntilExpiry < 0 ? "Expired" :
                              daysUntilExpiry == 0 ? "Expires Today" :
                              $"Expires in {daysUntilExpiry} days";

        return $"{PolicyNumber} - {HolderName} - {CoverageType} - {expiryStatus} (Expiry: {ExpiryDate:yyyy-MM-dd})";
    }
}

class Program
{
    static void Main()
    {
        HashSet<Policy> uniquePolicies = new HashSet<Policy>();
        LinkedList<Policy> insertionOrderPolicies = new LinkedList<Policy>();
        SortedSet<Policy> sortedPolicies = new SortedSet<Policy>();
        Dictionary<string, List<Policy>> duplicatePolicies = new Dictionary<string, List<Policy>>();

        Console.Write("Enter the number of policies: ");
        int numPolicies = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < numPolicies; i++)
        {
            Console.Write("\nEnter Policy Number: ");
            string policyNumber = Console.ReadLine();

            Console.Write("Enter Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Coverage Type: ");
            string coverageType = Console.ReadLine();

            Console.Write("Enter Expiry Date (yyyy-MM-dd): ");
            DateTime expiryDate = Convert.ToDateTime(Console.ReadLine());

            Policy policy = new Policy(policyNumber, holderName, coverageType, expiryDate);

            // Check for duplicates
            if (!uniquePolicies.Add(policy))
            {
                if (!duplicatePolicies.ContainsKey(policyNumber))
                    duplicatePolicies[policyNumber] = new List<Policy>();

                duplicatePolicies[policyNumber].Add(policy);
            }

            insertionOrderPolicies.AddLast(policy);
            sortedPolicies.Add(policy);
        }

        // Display all unique policies
        Console.WriteLine("\nAll Unique Policies:");
        foreach (var policy in uniquePolicies)
        {
            Console.WriteLine(policy);
        }

        // Display policies expiring within the next 30 days
        Console.WriteLine("\nPolicies Expiring Soon (Within 30 Days):");
        DateTime today = DateTime.Now;
        foreach (var policy in sortedPolicies)
        {
            if ((policy.ExpiryDate - today).TotalDays <= 30 && (policy.ExpiryDate - today).TotalDays >= 0)
            {
                Console.WriteLine(policy);
            }
        }

        // Retrieve policies based on coverage type
        Console.Write("\nEnter Coverage Type to Search: ");
        string searchCoverageType = Console.ReadLine();
        Console.WriteLine($"Policies with Coverage Type '{searchCoverageType}':");
        foreach (var policy in uniquePolicies.Where(p => p.CoverageType.Equals(searchCoverageType, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine(policy);
        }

        // Display duplicate policies
        Console.WriteLine("\nDuplicate Policies Based on Policy Number:");
        if (duplicatePolicies.Count == 0)
        {
            Console.WriteLine("No duplicate policies found.");
        }
        else
        {
            foreach (var kvp in duplicatePolicies)
            {
                Console.WriteLine($"Policy Number: {kvp.Key}");
                foreach (var policy in kvp.Value)
                {
                    Console.WriteLine($"  {policy}");
                }
            }
        }
    }
}
