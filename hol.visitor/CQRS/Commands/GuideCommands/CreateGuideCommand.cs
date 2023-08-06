using MediatR;

namespace hol.visitor.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand : IRequest
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
