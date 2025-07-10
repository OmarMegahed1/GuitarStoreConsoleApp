namespace GuitarStoreConsoleApp;

public enum GuitarType
{
    ACOUSTIC,
    ELECTRIC
}

public static class TypeExtensions
{
    public static string ToDisplayString(this GuitarType type)
    {
        switch (type)
        {
            case GuitarType.ACOUSTIC:
                return "acoustic";
            case GuitarType.ELECTRIC:
                return "electric";
            default:
                return "unspecified";
        }
    }
}
