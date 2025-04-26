// using System.Threading.Channels;
// using design_patterns.Creational.AbstractFactory;
// using design_patterns.Creational.AbstractFactory.Accounts;
// using design_patterns.Creational.AbstractFactory.Accounts.Bronze;
// using design_patterns.Creational.AbstractFactory.Accounts.Silver;
// using design_patterns.Creational.AbstractFactory.Concrete1;
// using design_patterns.Creational.AbstractFactory.Concrete2;
// using design_patterns.Creational.Singleton;
// using design_patterns.Structural.Composite.Expression;
// using design_patterns.Structural.Composite.TreeNumbers;

/*
 * SINGLETON PATTERN
 */
/*new Clazz1().Method1();
Clazz2 c2 = new Clazz2();
c2.Method1();
c2.Method2();
Console.WriteLine(Logger.Instance.GetLogs());

ReferencesFactory rf = ReferencesFactory.GetFactory();
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
Console.WriteLine(tn.Higher());

Operation sum = new Addition(
    new Division(new Number(1), new Number(2)), new Number(2));
Console.WriteLine(sum.Evaluate());*/

/*
 * BUILDER PATTERN
 */
/*User user = User.Make("1", "nick", "name")
    .FamilyName("familyName")
    .Adult()
    .Build();

Article article = Article.Make(1)
    .Phone(123456789)
    .Reference("reference")
    .Description("description")
    .RetailPrice(10)
    .Stock(10)
    .WholeSalePrice(5)
    .Tag("tag1")
    .Tag("tag2")
    .Build();
Console.WriteLine(article);

Provider provider = Provider.Make()
    .Id("1")
    .Company("company")
    .Description("description")
    .Build();
Console.WriteLine(provider);*/

/*
 * ABSTRACT FACTORY PATTERN
 */
/*AbstractFactoryBase.SetAbstractFactory(new Concrete1Factory());
IProductA productA1 = AbstractFactoryBase.GetAbstractFactory()!.CreateProductA();
IProductB productB1 = AbstractFactoryBase.GetAbstractFactory()!.CreateProductB();

AbstractFactoryBase.SetAbstractFactory(new Concrete2Factory());
IProductA productA2 = AbstractFactoryBase.GetAbstractFactory()!.CreateProductA();
IProductB productB2 = AbstractFactoryBase.GetAbstractFactory()!.CreateProductB();

AccountFactory.SetAccountFactory(new BronzeAccount());
int bronzeCreditCardCost = AccountFactory
    .GetAccountFactory()!
    .GetCreditCard()
    .GetCreditCardCost();

AccountFactory.SetAccountFactory(new SilverAccount());
int silverCreditCardCost = AccountFactory
    .GetAccountFactory()!
    .GetCreditCard()
    .GetCreditCardCost();

Console.WriteLine($"bronzeCreditCardCost: {bronzeCreditCardCost}");
Console.WriteLine($"silverCreditCardCost: {silverCreditCardCost}");*/

// https://paulovich.net/
// https://gist.github.com/davidfowl/ed7564297c61fe9ab814

// dotnet new install xunit.v3.templates
// dotnet new xunit3

Console.WriteLine("Hello World!");