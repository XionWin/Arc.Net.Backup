using System.Security.Cryptography;

namespace Arc.Core;

public class Command
{
    public CommandType CommandType { get; init; }
    public float[] Values { get; init; }

	public Command(CommandType commandType, params float[] values)
	{
		if(commandType.Validate(values) is false)
		{
			throw new Exception("Command is not validated");
		}
		this.CommandType = commandType;
		this.Values = values;
	}
}

public static class CommandValidator
{
	public static bool Validate(this CommandType commandType, float[] values) =>
	commandType switch
	{
		CommandType.MoveTo => values.Length == 2,
		CommandType.LineTo => values.Length == 2,
		CommandType.BezierTo => values.Length >= 4,
		CommandType.Close => values.Length == 0,
		CommandType.Winding => values.Length == 0,
		_ => throw new Exception("Unexpected")
	};
}