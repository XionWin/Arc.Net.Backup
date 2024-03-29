namespace TrueType.Mode;

[Flags]
public enum VerticalAlign
{
    Top = 1<< 0,
    Middle = 1<< 1,
    Bottom = 1<< 2,
    Baseline = 1<< 3
}


[Flags]
public enum HorizontalAlign
{
    Left = 1 << 4,
    Center = 1 << 5,
    Right = 1 << 6
}


[Flags]
public enum TextAlign
{
    Top = 1<< 0,
    Middle = 1<< 1,
    Bottom = 1<< 2,
    Baseline = 1<< 3,
    Left = 1 << 4,
    Center = 1 << 5,
    Right = 1 << 6
}