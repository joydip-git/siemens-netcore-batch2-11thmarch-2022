namespace NetCoreApp
{
    internal class Program
    {
        static async Task Main()
        {
            //Console.WriteLine(await Check(12,13));
            var res = await Read();
            await Console.Out.WriteLineAsync(res.ToString());
            //Console.WriteLine("end...");
        }

        private async static Task<int> Check(int a, int b)
        {
            try
            {
                return await Task.Run(() => { return a / b; });
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        static async Task<int> Read()
        {            
            using var reader = new StreamReader(@"D:\training\siemens-netcore-batch2-11thmarch-2022\codes\day-4\NetCoreApp\data.txt");
            return  await reader.ReadAsync(new char[256]);
        }
    }
}
