namespace ErrorHandling
{
    internal class AgeLessThanEighteenException : ApplicationException
    {
        //public AgeLessThanEighteenException():base("Eligible age for driving license should be equal to or above 18"){}

        //public AgeLessThanEighteenException(string errorMessage):base(errorMessage) 
        //{

        //}   

        private readonly string _message;
        public AgeLessThanEighteenException()
        {
            _message = "Eligible age for driving license should be equal to or above 18";
        }
           
        public AgeLessThanEighteenException(string message)
        {
            _message = message;
        }
        public override string Message => _message;
    }
}
