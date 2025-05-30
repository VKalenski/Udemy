namespace dotnet_rpg.Models
{
    #region Properties User
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[] PasswordHash { get; set; } = new byte[0];
        public byte[] PasswordSalt { get; set; } = new byte[0];
        public List<Character>? Characters { get; set; }
    }
    #endregion
}