using DevExpress.Persistent.Base;
using DevExpress.Xpo;
using System;
using System.Security.Cryptography;
using System.Text;

public class User : XPObject
{
    public User(Session session) : base(session) { }

    private string _username;
    [Size(50)]
    public string Username
    {
        get => _username;
        set => SetPropertyValue(nameof(Username), ref _username, value);
    }

    private string _storedPassword;
    [Size(50)]
    public string StoredPassword
    {
        get => _storedPassword;
        set => SetPropertyValue(nameof(StoredPassword), ref _storedPassword, value);
    }
    public void SetPassword(string password)
    {
        StoredPassword = password;
    }

    public bool CheckPassword(string password)
    {
        return StoredPassword == password;
    }


}
