namespace BookStore.Models.Repository
{
	public class clsProfile : IclsProfile
	{
		private BookDbContext context;
		public clsProfile(BookDbContext _context)
		{
			context = _context;
		}

        public ApplicationUser GetUser(string id)
        {
            var result = context.Users.FirstOrDefault(u => u.Id == id);
            return result;
        }

        public void EditUser(ApplicationUser oldUser)
        {
            ApplicationUser newUser = context.Users.FirstOrDefault(u => u.Email == oldUser.Email);
            newUser.FirstName = oldUser.FirstName;
            newUser.LastName = oldUser.LastName;
            newUser.Email = oldUser.Email;
            newUser.PhoneNumber = oldUser.PhoneNumber;
            newUser.Governorate = oldUser.Governorate;
            newUser.City = oldUser.City;
            newUser.DetailedAddress = oldUser.DetailedAddress;
            newUser.PostalCode = oldUser.PostalCode;
            context.SaveChanges();
        }
    }
}
