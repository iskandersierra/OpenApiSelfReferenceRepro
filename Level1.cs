namespace OpenApiSelfReferenceRepro;

public class Level1
{
    public IReadOnlyList<Level1> Level1s { get; set; } = [];
}