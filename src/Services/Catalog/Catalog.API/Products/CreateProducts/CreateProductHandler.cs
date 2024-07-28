
using MediatR;
namespace Catalog.API.Products.CreateProducts;

public record CreateProductCommand(string name, List<string> category, string Description, string ImageFile, decimal Price) : IRequest<CreateProductResult>;
public record CreateProductResult(Guid Id);
internal class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
{
    public Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}