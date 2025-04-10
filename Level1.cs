namespace OpenApiSelfReferenceRepro
{
    public class LevelResponse
    {
        public IReadOnlyList<Level1> Level1s { get; set; } = [];
    }

    public class Level1
    {
        public IReadOnlyList<Level1> Level1s { get; set; } = [];
    }
}
