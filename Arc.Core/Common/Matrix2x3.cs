using System.Numerics;

namespace Arc.Core;

public struct Matrix2x3 : IEquatable<Matrix2x3>
{
    //
    // Summary:
    //     Top row of the matrix.
    public Vector3 Row0;

    //
    // Summary:
    //     Bottom row of the matrix.
    public Vector3 Row1;

    public static Matrix2x3 Identity = new Matrix2x3(
        new Vector3(1, 0, 0),
        new Vector3(0, 1, 0)
    );

    public Matrix2x3()
    {
        this = Identity;
    }
    public Matrix2x3(Vector3 row0, Vector3 row1)
    {
        this.Row0 = row0;
        this.Row1 = row1;
    }
    
    //
    // Summary:
    //     Gets or sets the value at row 1, column 1 of this instance.
    public float M11
    {
        get
        {
            return Row0.X;
        }
        set
        {
            Row0.X = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 1, column 2 of this instance.
    public float M12
    {
        get
        {
            return Row0.Y;
        }
        set
        {
            Row0.Y = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 1, column 3 of this instance.
    public float M13
    {
        get
        {
            return Row0.Z;
        }
        set
        {
            Row0.Z = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 2, column 1 of this instance.
    public float M21
    {
        get
        {
            return Row1.X;
        }
        set
        {
            Row1.X = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 2, column 2 of this instance.
    public float M22
    {
        get
        {
            return Row1.Y;
        }
        set
        {
            Row1.Y = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 2, column 3 of this instance.
    public float M23
    {
        get
        {
            return Row1.Z;
        }
        set
        {
            Row1.Z = value;
        }
    }

    public bool Equals(Matrix2x3 other) => Row0 == other.Row0 ? Row1 == other.Row1 : false;
}