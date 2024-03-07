namespace Arc.Core;

public class State: ICloneable<State>
{
    public CompositeOperationState CompositeOperationState { get; set; } = new CompositeOperationState(CompositeOperation.SourceOver);
    public Paint FillPaint { get; private set; } = new Paint(new Color(255, 255, 255, 255));
    public Paint StrokePaint { get; private set; } = new Paint(new Color(0, 0, 0, 255));
    public float StrokeWidth { get; set; } = 1.0f;
    public float MiterLimit { get; set; } = 2.5f;
    public LineJoin LineJoin { get; set; } = LineJoin.Miter;
    public LineCap LineCap { get; set; } = LineCap.Butt;
    public float alpha { get; set; } = 1;
    public Matrix2D Transform { get; set; }
    public Scissor Scissor { get; private set; } = new Scissor();
    public float fontSize { get; set; }
    public float letterSpacing { get; set; }
    public float lineHeight { get; set; }
    public float fontBlur { get; set; }
    public int textAlign { get; set; }
    public int fontId { get; set; }

    public State Clone() => 
        new State()
        {
            CompositeOperationState = this.CompositeOperationState,
            FillPaint = this.FillPaint.Clone(),
            StrokePaint = this.StrokePaint.Clone(),
            StrokeWidth = this.StrokeWidth,
            MiterLimit = this.MiterLimit,
            LineJoin = this.LineJoin,
            LineCap = this.LineCap,
            alpha = this.alpha,
            Transform = this.Transform,
            Scissor = this.Scissor.Clone(),
            fontSize = this.fontSize,
            letterSpacing = this.letterSpacing,
            lineHeight = this.lineHeight,
            fontBlur = this.fontBlur,
            textAlign = this.textAlign,
            fontId = this.fontId,
        };
}