namespace ImplementationInLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LINQ: Language Integrated Query
            //local data source (like in-memory collection, such as: IEnumerable<T>
            //remote data source (like SQL server, Oracle, MySql, Sqlite etc.) using IQueryable

            //LINQ is part of programming language and depends on following programming constructs:
            //OOP
            //generics
            //collection
            //delegate
            //new features: anonymous method, lambda expression, extension method etc.

            //two ways of writing the query:
            //1. fluent syntax (method query syntax): a source of data is queried by using some extension methods of the local data source (collection) itself
            //2. query expression (query operator) syntax: quite SQL like syntax, through some query operators

            //local data source storing some intgere values (numbers)
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            //local data source storing some string values (names)
            var names = new List<string>
            {
                "sunil","anil","amit","joydip","suresh"
            };

            //Querying
            //applying logic to filter even numbers from the local data source conatining numbers  and printing those even numbers
            IEnumerable<int> values = numbers.Where((num) => num % 2 == 0);
            List<int> nums = values.ToList();
            nums.ForEach((num) => { Console.WriteLine(num); });

            //applying logic to filter names, containing 's' as the first letter, from the local data source conatining names  and printing those names
            //names
            //    .OrderBy(name => name)
            //    .Where((name) => char.ToLower(name[0]) == 's')
            //    .ToList()
            //    .ForEach((name) => Console.WriteLine(name));

            IEnumerable<string> query =
                from name in names
                orderby name ascending
                where char.ToLower(name[0]) == 's'
                select name;

            query.ToList().ForEach(name => Console.WriteLine(name));

            (int, int, double) statistcs = (nums.Min(), nums.Max(), nums.Average());
            Console.WriteLine($"{statistcs.Item1},{statistcs.Item2},{statistcs.Item3}");

            //List<IGrouping<char,string>> => {GroupedBy:char, Names:List<string>}
            //IGrouping<char,string> => {'s',{"sunil","suresh"}}
            //IGrouping<char,string> => {'j',{"joydip"}}
            //IGrouping<char,string> => {'a',{"anil","amit"}}
            //Dictionary<char,List<string>>
            //names
            //    .GroupBy((name) => name[0])
            //    .ToList()
            //    .ForEach(
            //    group =>
            //    {
            //        Console.WriteLine($"Grouped by: {group.Key}");
            //        group.ToList().ForEach(name => Console.WriteLine(name));
            //        Console.WriteLine("\n");
            //    }
            //    );

            var groupQuery =
                from name in names
                group name by name[0] into g
                select new { GroupedBy = g.Key, Names = g.ToList() };

            groupQuery.ToList()
                .ForEach(
                g =>
                {
                    Console.WriteLine(g.GroupedBy);
                    g.Names.ForEach(name => Console.WriteLine(name));
                });


            /*
            Func<int, bool> isEven = (num) => num % 2 == 0;
            Action<int> printNum = (num) => { Console.WriteLine(num); };
            numbers.Where(isEven).ToList().ForEach(printNum);

            Func<string, bool> isHavingS = (name) => char.ToLower(name[0]) == 's';
            Action<string> printName = (name) => { Console.WriteLine(name); };
            names.Where(isHavingS).ToList().ForEach(printName);
            */
        }
    }
}
