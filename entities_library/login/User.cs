namespace entities_library.login;

public class User : Person
{
    #region Atributtes
    public string Password { get; set; } = "";

    public UserStatus UserStatus { get; set; } = UserStatus.Active;

    public entities_library.file_system.File? File { get; set; }

    public string Description { get; set; } = "";
    #endregion

    #region Methods
    public void Encrypt(string password)
    {
        this.Password = this.encrypt(password);
    } 

    public bool IsPassword(string password)
    {
        return this.encrypt(password) == this.Password;
    }

    private string encrypt(string password)
    {
        //TODO - Fede: Averiguar como encriptar.
        return password;
    }
    #endregion
}