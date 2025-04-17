namespace ConsoleApp1.SolidPrinciples;

/*
 * The SRP states that a class should have only one reason to change,
 * meaning it should have only one job or responsibility. This promotes
 * modularization and makes the code easier to understand and maintain.
 * Key Idea: A class should do only one thing, and do it well.
 */
public class SingleResponsibilityPrinciple
{
    /*
     * In this escenario, the Report class has two responsibilities:
     *   1. Generating a report.
     *   2. Saving the report to a file.
     * This violates the SRP.
     */
    public class Report
    {
        public void GenerateReport()
        {
        }

        public void SaveToFile()
        {
        }
    }

    /*
     * Now, the ReportGenerator class is responsible only for generating reports,
     * while the ReportSaver class is responsible for saving reports. Each class
     * has a single responsibility.
     */
    public class ReportGenerator
    {
        public void GenerateReport()
        {
        }
    }

    public class ReportSaver
    {
        public void SaveToFile()
        {
        }
    }
    
    /*
     * Explanation: According to SRP, one class should take one responsibility
     * hence to overcome this issue we should write another class to save the
     * report functionality. If we make any changes to the ReportGenerator class
     * will not affect the ReportSaver class and vice versa.
     */
}