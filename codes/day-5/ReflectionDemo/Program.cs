using System.Reflection;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                #region Loading assembly dynamically
                //dynamically loading an assembly
                Assembly loadedAssembly = Assembly.LoadFrom(@"D:\training\siemens-netcore-batch2-11thmarch-2022\codes\day-5\CalculationLibrary\bin\Debug\net8.0\CalculationLibrary.dll");

                Console.WriteLine($"Assembly details:\n {loadedAssembly.FullName}");
                #endregion

                #region Displaying all type and their member info
                Console.WriteLine("\n--all types---\n");
                Type[] allTypes = loadedAssembly.GetTypes();
                foreach (Type type in allTypes)
                {
                    Console.WriteLine(
                        $"Name: {type.Name}" +
                        $"\nIs Class:{type.IsClass}" +
                        $"\nIs Interface:{type.IsInterface}" +
                        $"\nIs Value type:{type.IsValueType}" +
                        $"\nIs Abstract Class:{type.IsAbstract}" +
                        $"\nIs Generic:{type.IsGenericType}" +
                        $"\n"
                        );
                    Console.WriteLine("--all member info--\n");
                    MemberInfo[] allMembers = type.GetMembers();
                    foreach (MemberInfo member in allMembers)
                    {
                        Console.WriteLine($"Name:{member.Name}\nType:{member.MemberType}\n");
                    }
                    /*
                    MethodInfo[] allMethods = type.GetMethods();
                    PropertyInfo[] allProperties = type.GetProperties();
                    FieldInfo[] allFields = type.GetFields();
                    ConstructorInfo[] allConstructors = type.GetConstructors();
                    */
                }
                #endregion

                #region Create object dynamically
                object? calcObject = null;
                Type? clsType = null;
                foreach (var typeInfo in allTypes)
                {
                    //extract metadata about Calculation class
                    if (typeInfo.Name == "Calculation")
                    {
                        //clsType = loadedAssembly.GetType(item.FullName);
                        clsType = typeInfo;

                        //create object based on the metadata of the class
                        calcObject = Activator.CreateInstance(clsType);
                    }
                }
                #endregion

                #region Invoke a method using its metadata
                MethodInfo? addMethodInfo = null;
                MethodInfo[]? allMethods = clsType?.GetMethods();

                //extracting metadata of Add Method
                Console.WriteLine("\n--Add method Info--\n");
                if (allMethods?.Length > 0)
                {
                    foreach (var methodInfo in allMethods)
                    {
                        if (methodInfo.Name == "Add")
                        {
                            //addMethodInfo = clsType.GetMethod(methodInfo.Name);
                            //addMethodInfo = clsType.GetMethod("Add");
                            addMethodInfo = methodInfo;
                            Console.WriteLine(
                                $"Is Static:{addMethodInfo.IsStatic}" +
                                $"\nIs Abstract:{addMethodInfo.IsAbstract}" +
                                $"\nReturn Type:{addMethodInfo.ReturnType}"
                                );
                        }
                    }
                }

                ParameterInfo[]? allParams = addMethodInfo?.GetParameters();
                Console.WriteLine("\n--parameters of Add Method--\n");
                if (allParams?.Length > 0)
                {
                    foreach (var parameterInfo in allParams)
                    {
                        Console.WriteLine($"Name:{parameterInfo.Name}\nPosition:{parameterInfo.Position}\nData Type:{parameterInfo.ParameterType}");
                    }
                }

                if (allParams?.Length > 0)
                {
                    //addMethodInfo?.Invoke(calcObject, new object[] { 12, 13 });
                    addMethodInfo?.Invoke(calcObject, [12, 13]);
                }
                else
                    addMethodInfo?.Invoke(calcObject, null);
                #endregion

                #region Invoking a property using its metadata
                PropertyInfo? resultPropertInfo = clsType?.GetProperty("Result");
                if (resultPropertInfo != null)
                {
                    //object? addRes = resultPropertInfo.GetMethod?.Invoke(calcObject, null);
                    object? addRes = resultPropertInfo.GetValue(calcObject, null);
                    Console.WriteLine($"\nResult: {addRes ?? "no value"}");
                }
                #endregion
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
