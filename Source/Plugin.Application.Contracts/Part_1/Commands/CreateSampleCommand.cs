using Framework.Consistency.Contracts.Eventual.Command;

namespace Plugin.Application.Contracts.Part_1.Commands
{
    [Command(version: null, Permission = nameof(Permissions.CreateSample))]
    public class CreateSampleCommand
    {
        public string Name { get; }
        public CreateSampleCommand(string name)
        {
            Name = name;
        }
    }
}
