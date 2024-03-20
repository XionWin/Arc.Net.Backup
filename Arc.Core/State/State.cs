namespace Arc.Core;

public class State: ICloneable<State>
{
    public Paint FillPaint { get; internal set; }
    public Paint StrokePaint { get; private set; }
    public float StrokeWidth { get; set; }
    public float MiterLimit { get; set; }
    public LineJoin LineJoin { get; set; }
    public LineCap LineCap { get; set; }
    public float alpha { get; set; }
    public Matrix2x3 Transform { get; set; } = Matrix2x3.Identity;
    public Scissor? Scissor { get; internal set; }
    public float fontSize { get; set; }
    public float letterSpacing { get; set; }
    public float lineHeight { get; set; }
    public float fontBlur { get; set; }
    public int textAlign { get; set; }
    public int fontId { get; set; }

    public State()
    {
        this.FillPaint = new Paint();
        this.StrokePaint = new Paint();
        // this.Scissor = new Scissor();
        this.StrokeWidth = 1.0f;
        this.MiterLimit = 2.5f;
        this.LineJoin = LineJoin.Miter;
        this.LineCap = LineCap.Butt;
        this.alpha = 1f;
    }
    public State Clone() => 
        new State()
        {
            FillPaint = this.FillPaint.Clone(),
            StrokePaint = this.StrokePaint.Clone(),
            StrokeWidth = this.StrokeWidth,
            MiterLimit = this.MiterLimit,
            LineJoin = this.LineJoin,
            LineCap = this.LineCap,
            alpha = this.alpha,
            Transform = this.Transform,
            Scissor = this.Scissor?.Clone(),
            fontSize = this.fontSize,
            letterSpacing = this.letterSpacing,
            lineHeight = this.lineHeight,
            fontBlur = this.fontBlur,
            textAlign = this.textAlign,
            fontId = this.fontId,
        };
}