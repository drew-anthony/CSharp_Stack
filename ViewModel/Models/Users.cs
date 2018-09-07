namespace ViewModel.Models
    {
        public class Users
    	{
            public string FirstName {get;set;}
            public string LastName {get;set;}

            public Users(){ }

            public Users(string first, string last)
            {
                FirstName = first;
                LastName = last;
            }
    	}
    }