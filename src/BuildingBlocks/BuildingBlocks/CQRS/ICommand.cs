using MediatR;

namespace BuildingBlocks.CQRS;

//this one is an empty icommand
public interface ICommand : ICommand<Unit>
{

}

// this one produces a response
public  interface ICommand<out TResponse> : IRequest<TResponse>
{
}
