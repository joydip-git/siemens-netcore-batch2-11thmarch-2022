using System.IO;

namespace ErrorHandling
{
    internal class Program
    {
        static void Main()
        {
            FileAccess? fileAccess = null;
            DrivingLicenseForm? licenseForm = null;
            try
            {
                licenseForm = new DrivingLicenseForm();
                licenseForm.Name = "anil";
                licenseForm.Age = 15;
                //int[] arr = new int[] { 1, 2, 3 };
                //int[] arr = { 1, 2, 3 };
                //int[] arr = [1, 2, 3];
                //for (int i = 0; i < 4; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}
                //int x = 12345678;//0101010101010101.....
                //short y = checked((short)x);
                //Console.WriteLine(y);
                fileAccess = new FileAccess();
                fileAccess.WriteIntoFile(@"D:\training\siemens-netcore-batch2-11thmarch-2022\codes\day-3\ErrorHandling\data.txt", "data to be written");
            }
            catch(AgeLessThanEighteenException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite);
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.HelpLink);
            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            catch(IOException ex)
            {
                Console.WriteLine(ex);
            }
            catch(Exception ex)
            {                
                Console.WriteLine(ex);
            }
            //finally
            //{
            //    //any code in this block will be executed
            //    //mainly used for cleaning up resources
            //    writer?.Flush();
            //    writer?.Close();
            //    writer?.Dispose();
            //}
        }
    }
}
