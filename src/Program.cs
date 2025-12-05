using System.CommandLine;

RootCommand rootCommand = new("Command-line app for working with Active Directory users");

var addCommand = new Command("add", "Add new user");

var addCommandNameOption = new Option<string>("-n", "--name")
{
    Description = "User name"
};

var addCommandPasswordOptions = new Option<string>("-p", "password")
{
    Description = "User password"
};

return rootCommand.Parse(args).Invoke();