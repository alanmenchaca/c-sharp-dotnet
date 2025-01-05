// using design_patterns.Singleton.Factory.Solution;
// using design_patterns.Singleton.Logger.Solution;

using design_patterns.Composite.Expression;
using design_patterns.Composite.TreeNumbers;

/*
 * SINGLETON PATTERN
 */
/*new Clazz1().Method1();
Clazz2 c2 = new Clazz2();
c2.Method1();
c2.Method2();
Console.WriteLine(Logger.Instance.GetLogs());*/

/*ReferencesFactory rf = ReferencesFactory.GetFactory();
rf.GetReference("key1");
rf.GetReference("key2");
rf.GetReference("key2");
rf.GetReference("key3");*/

/*
 * COMPOSITE PATTERN
 */
/*TreeNumbers tn = new TreeNumbers("Root");
tn.Add(new TreeNumbers(1));

TreeNumbers tnComposite1 = new TreeNumbers("Composite1");
tnComposite1.Add(new TreeNumbers(2));
tnComposite1.Add(new TreeNumbers(3));
tn.Add(tnComposite1);

TreeNumbers tnComposite2 = new TreeNumbers("Composite2");
tnComposite2.Add(new TreeNumbers(4));
tnComposite2.Add(new TreeNumbers(5));
tnComposite2.Add(new TreeNumbers(6));
tn.Add(tnComposite2);

Console.WriteLine(tn.Sum());
Console.WriteLine(tn.Higher());*/

Operation sum = new Addition(
    new Division(new Number(1), new Number(2)), new Number(2));
Console.WriteLine(sum.Evaluate());

// https://paulovich.net/
// https://gist.github.com/davidfowl/ed7564297c61fe9ab814

// dotnet new install xunit.v3.templates
// dotnet new xunit3