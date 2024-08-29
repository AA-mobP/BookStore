namespace BookStore.Models.Repository
{
	public interface IclsProfile
	{
		ApplicationUser GetUser(string id);
        void EditUser(ApplicationUser oldUser);
    }
}
