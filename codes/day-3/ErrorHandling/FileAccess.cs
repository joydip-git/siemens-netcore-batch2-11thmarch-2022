using System.Text;
namespace ErrorHandling
{
    public class FileAccess
    {
        public void WriteIntoFile(string data, string path)
        {
            StreamWriter? writer = null;
            StringBuilder? sb = null;
            try
            {
                if (File.Exists(path))
                {
                    writer = new StreamWriter(path, true);
                    sb = new StringBuilder();
                    sb?
                        .AppendLine($"{Environment.NewLine}Logged at: {DateTime.Now}")
                        .AppendLine(data);

                    writer?.WriteLine(sb?.ToString());
                }
            }
            catch (FileNotFoundException)
            {
                throw;
            }
            catch (IOException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //writer?.Flush();
                writer?.Close();
                writer?.Dispose();
            }
        }
    }
}
