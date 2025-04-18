namespace Arc.Core;

public interface IContext
{
    public int FontTextureId { get; }
    public CompositeOperationState CompositeOperationState { get; }
    public float TessTol { get; }
    public float DistTol { get; }
    public float FringeWidth { get; }
    public float DevicePxRatio { get; }
    public List<Path> Paths { get; }
    public Path LastPath { get; }

    public void BeginFrame();
    public void AddCommand(CommandType commandType, params float[] values);
    public void AddCommand(Command command);
    public void Fill();
    public void Stroke();
    public void Triangles(Vertex[] vertices);
    public void UpdateTexture(int textureId, int offsetX, int offsetY, ImageData imageData, TextureType textureType);
    public void EndFrame();
    public void SaveState();
    public void RestoreState();
    public State GetState();
}
