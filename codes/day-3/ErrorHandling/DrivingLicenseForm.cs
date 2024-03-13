namespace ErrorHandling
{
    internal class DrivingLicenseForm
    {
		private string name="";
		private int age;

        public DrivingLicenseForm()
        {
            
        }
        public DrivingLicenseForm(string name, int age)
        {
            this.name = name;
			if (age < 18)
			{
                AgeLessThanEighteenException ex = new AgeLessThanEighteenException("age should not be less than 18");
                throw ex;
            }
            this.age = age;
        }

        public int Age
		{
			get { return age; }
			set 
			{ 
				if(value < 18)
				{
                    //AgeLessThanEighteenException ex= new AgeLessThanEighteenException("age should not be less than 18");
                    AgeLessThanEighteenException ex = new AgeLessThanEighteenException();
                    throw ex;
				}
				age = value; 
			}
		}

		public string Name
		{
			get { return name; }
			set { name= value; }
		}

	}
}
