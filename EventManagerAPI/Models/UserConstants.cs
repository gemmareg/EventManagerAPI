namespace EventManagerAPI.Models
{
    public class UserConstants
    {
        public static List<UserModel> Users = new List<UserModel>
        {
            new UserModel
            {
                UserName = "jason_admin",
                EmailAddress = "jason.admin@email.com",
                Password = "1234",
                GivenName = "Jason",
                Surname = "Bryant",
                Role = "Administrator"   
            },
            new UserModel
            {
                UserName = "elyse_seller",
                EmailAddress = "elyse.seller@email.com",
                Password = "1234",
                GivenName = "Elyse",
                Surname = "Lambert",
                Role = "Seller"
            }
        };
    }
}
