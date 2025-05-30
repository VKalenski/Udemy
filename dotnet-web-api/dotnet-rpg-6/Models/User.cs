namespace dotnet_rpg.Models
{
    #region Properties User
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public List<Character>? Characters { get; set; }
    }
    #endregion
}
