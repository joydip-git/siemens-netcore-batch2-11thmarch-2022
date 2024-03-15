namespace DelegateDemo
{
    //1. declaration of delegate
    //the signature of the delegate should be same as that of the method(s) that it is going to refer and invoke
    //this following delegate can be used to invoke/call any method whose return type is "void" and accepts exactly two arguments of type "int" in the exact order (the method can be static or instance)
    //public delegate void CalDel(int x, int y);

    //generic delegate (overloaded)
    public delegate void CalDel<in T>(T x, T y);
    public delegate TResult CalDel<in T,out TResult>(T x, T y);
}
