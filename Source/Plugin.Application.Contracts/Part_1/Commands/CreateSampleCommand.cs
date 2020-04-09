using Command = Framework.Consistency.Contracts.Eventual.CommandAtrribute;

namespace Plugin.Application.Contracts.Part_1.Commands
{
    [Command(version: "1.0.0", Permission = nameof(Permissions.CreateSample))]
    public class CreateSampleCommand
    {
        public string Name { get; }
        public CreateSampleCommand(string name)
        {
            Name = name;
        }
    }
}
