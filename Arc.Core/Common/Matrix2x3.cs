using System.Numerics;

namespace Arc.Core;

public struct Matrix2x3 : IEquatable<Matrix2x3>
{
    //
    // Summary:
    //     Top row of the matrix.
    public Vector2 Row0;

    //
    // Summary:
    //     Second row of the matrix.
    public Vector2 Row1;

    //
    // Summary:
    //     Bottom row of the matrix.
    public Vector2 Row2;

    //
    // Summary:
    //     The zero matrix.
    public static readonly Matrix2x3 Zero = new Matrix2x3(Vector2.Zero, Vector2.Zero, Vector2.Zero);

    //
    // Summary:
    //     The identity matrix.
    public static readonly Matrix2x3 Identity = new Matrix2x3(
        new Vector2(1, 0),
        new Vector2(0, 1),
        new Vector2(0, 0)
    );

    //
    // Summary:
    //     Gets or sets the first column of this matrix.
    public Vector3 Column0
    {
        get
        {
            return new Vector3(Row0.X, Row1.X, Row2.X);
        }
        set
        {
            Row0.X = value.X;
            Row1.X = value.Y;
            Row2.X = value.Z;
        }
    }

    //
    // Summary:
    //     Gets or sets the second column of this matrix.
    public Vector3 Column1
    {
        get
        {
            return new Vector3(Row0.Y, Row1.Y, Row2.Y);
        }
        set
        {
            Row0.Y = value.X;
            Row1.Y = value.Y;
            Row2.Y = value.Z;
        }
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
    //     Gets or sets the value at row 1, column 3 of this instance.
    public float M31
    {
        get
        {
            return Row2.X;
        }
        set
        {
            Row2.X = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the value at row 2, column 3 of this instance.
    public float M32
    {
        get
        {
            return Row2.Y;
        }
        set
        {
            Row2.Y = value;
        }
    }

    //
    // Summary:
    //     Gets or sets the values along the main diagonal of the matrix.
    public Vector2 Diagonal
    {
        get
        {
            return new Vector2(Row0.X, Row1.Y);
        }
        set
        {
            Row0.X = value.X;
            Row1.Y = value.Y;
        }
    }

    //
    // Summary:
    //     Gets the trace of the matrix, the sum of the values along the diagonal.
    public float Trace => Row0.X + Row1.Y;

    //
    // Summary:
    //     Gets or sets the value at a specified row and column.
    //
    // Parameters:
    //   rowIndex:
    //     The index of the row.
    //
    //   columnIndex:
    //     The index of the column.
    //
    // Returns:
    //     The element at the given row and column index.
    public float this[int rowIndex, int columnIndex]
    {
        get
        {
            return rowIndex switch
            {
                0 => Row0[columnIndex],
                1 => Row1[columnIndex],
                _ => throw new IndexOutOfRangeException("You tried to access this matrix at: (" + rowIndex + ", " + columnIndex + ")"),
            };
        }
        set
        {
            switch (rowIndex)
            {
                case 0:
                    Row0[columnIndex] = value;
                    return;
                case 1:
                    Row1[columnIndex] = value;
                    return;
            }

            throw new IndexOutOfRangeException("You tried to set this matrix at: (" + rowIndex + ", " + columnIndex + ")");
        }
    }

    //
    // Summary:
    //     Initializes a new instance of the OpenTK.Mathematics.Matrix2x3 struct.
    //
    // Parameters:
    //   row0:
    //     Top row of the matrix.
    //
    //   row1:
    //     Bottom row of the matrix.
    public Matrix2x3(Vector2 row0, Vector2 row1, Vector2 row2)
    {
        Row0 = row0;
        Row1 = row1;
        Row2 = row2;
    }

    //
    // Summary:
    //     Initializes a new instance of the OpenTK.Mathematics.Matrix2x3 struct.
    //
    // Parameters:
    //   m00:
    //     First item of the first row of the matrix.
    //
    //   m01:
    //     Second item of the first row of the matrix.
    //
    //   m02:
    //     Third item of the first row of the matrix.
    //
    //   m10:
    //     First item of the second row of the matrix.
    //
    //   m11:
    //     Second item of the second row of the matrix.
    //
    //   m12:
    //     Third item of the second row of the matrix.
    public Matrix2x3(float m00, float m01, float m10, float m11, float m20, float m21)
    {
        Row0 = new Vector2(m00, m01);
        Row1 = new Vector2(m10, m11);
        Row2 = new Vector2(m20, m21);
    }

    //
    // Summary:
    //     Builds a rotation matrix.
    //
    // Parameters:
    //   angle:
    //     The counter-clockwise angle in radians.
    //
    //   result:
    //     The resulting Matrix2x3 instance.
    public static void CreateRotation(float angle, out Matrix2x3 result)
    {
        float num = MathF.Cos(angle);
        float num2 = MathF.Sin(angle);
        result.Row0.X = num;
        result.Row0.Y = num2;
        result.Row1.X = 0f - num2;
        result.Row1.Y = num;
        result.Row2.X = 0f;
        result.Row2.Y = 0f;
    }

    //
    // Summary:
    //     Builds a rotation matrix.
    //
    // Parameters:
    //   angle:
    //     The counter-clockwise angle in radians.
    //
    // Returns:
    //     The resulting Matrix2x3 instance.
    public static Matrix2x3 CreateRotation(float angle)
    {
        CreateRotation(angle, out var result);
        return result;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   scale:
    //     Single scale factor for the x, y, and z axes.
    //
    //   result:
    //     A scale matrix.
    public static void CreateScale(float scale, out Matrix2x3 result)
    {
        result.Row0.X = scale;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = scale;
        result.Row2.X = 0f;
        result.Row2.Y = 0f;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   scale:
    //     Single scale factor for the x and y axes.
    //
    // Returns:
    //     A scale matrix.
    public static Matrix2x3 CreateScale(float scale)
    {
        CreateScale(scale, out var result);
        return result;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   scale:
    //     Scale factors for the x and y axes.
    //
    //   result:
    //     A scale matrix.
    public static void CreateScale(Vector2 scale, out Matrix2x3 result)
    {
        result.Row0.X = scale.X;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = scale.Y;
        result.Row2.X = 0f;
        result.Row2.Y = 0f;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   scale:
    //     Scale factors for the x and y axes.
    //
    // Returns:
    //     A scale matrix.
    public static Matrix2x3 CreateScale(Vector2 scale)
    {
        CreateScale(scale, out var result);
        return result;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   x:
    //     Scale factor for the x axis.
    //
    //   y:
    //     Scale factor for the y axis.
    //
    //   result:
    //     A scale matrix.
    public static void CreateScale(float x, float y, out Matrix2x3 result)
    {
        result.Row0.X = x;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = y;
        result.Row2.X = 0f;
        result.Row2.Y = 0f;
    }

    //
    // Summary:
    //     Creates a scale matrix.
    //
    // Parameters:
    //   x:
    //     Scale factor for the x axis.
    //
    //   y:
    //     Scale factor for the y axis.
    //
    // Returns:
    //     A scale matrix.
    public static Matrix2x3 CreateScale(float x, float y)
    {
        CreateScale(x, y, out var result);
        return result;
    }

    //
    // Summary:
    //     Multiplies and instance by a scalar.
    //
    // Parameters:
    //   left:
    //     The left operand of the multiplication.
    //
    //   right:
    //     The right operand of the multiplication.
    //
    //   result:
    //     A new instance that is the result of the multiplication.
    public static void Mult(in Matrix2x3 left, float right, out Matrix2x3 result)
    {
        result.Row0.X = left.Row0.X * right;
        result.Row0.Y = left.Row0.Y * right;
        result.Row1.X = left.Row1.X * right;
        result.Row1.Y = left.Row1.Y * right;
        result.Row2.X = left.Row2.X * right;
        result.Row2.Y = left.Row2.Y * right;
    }

    //
    // Summary:
    //     Multiplies and instance by a scalar.
    //
    // Parameters:
    //   left:
    //     The left operand of the multiplication.
    //
    //   right:
    //     The right operand of the multiplication.
    //
    // Returns:
    //     A new instance that is the result of the multiplication.
    public static Matrix2x3 Mult(Matrix2x3 left, float right)
    {
        Mult(in left, right, out var result);
        return result;
    }

    //
    // Summary:
    //     Multiplies two instances.
    //
    // Parameters:
    //   left:
    //     The left operand of the multiplication.
    //
    //   right:
    //     The right operand of the multiplication.
    //
    //   result:
    //     A new instance that is the result of the multiplication.
    public static void Mult(in Matrix2x3 left, in Matrix2x3 right, out Matrix2x3 result)
    {
        float L11 = left.Row0.X;
        float L12 = left.Row0.Y;
        float L21 = left.Row1.X;
        float L22 = left.Row1.Y;
        float L31 = left.Row2.X;
        float L32 = left.Row2.Y;
        float R11 = right.Row0.X;
        float R12 = right.Row0.Y;
        float R21 = right.Row1.X;
        float R22 = right.Row1.Y;
        float R31 = right.Row2.X;
        float R32 = right.Row2.Y;

        result.Row0.X = L11 * R11 + L12 * R21;
        result.Row0.Y = L11 * R12 + L12 * R22;
        result.Row1.X = L21 * R11 + L22 * R21;
        result.Row1.Y = L21 * R12 + L22 * R22;
        result.Row2.X = L31 * R11 + L32 * R21 + R31;
        result.Row2.Y = L31 * R12 + L32 * R22 + R32;
    }

    //
    // Summary:
    //     Multiplies and instance by a scalar.
    //
    // Parameters:
    //   left:
    //     The left operand of the multiplication.
    //
    //   right:
    //     The right operand of the multiplication.
    //
    // Returns:
    //     A new instance that is the result of the multiplication.
    public static Matrix2x3 Mult(Matrix2x3 left, Matrix2x3 right)
    {
        Mult(in left, right, out var result);
        return result;
    }

    //
    // Summary:
    //     Adds two instances.
    //
    // Parameters:
    //   left:
    //     The left operand of the addition.
    //
    //   right:
    //     The right operand of the addition.
    //
    //   result:
    //     A new instance that is the result of the addition.
    public static void Add(in Matrix2x3 left, in Matrix2x3 right, out Matrix2x3 result)
    {
        result.Row0.X = left.Row0.X + right.Row0.X;
        result.Row0.Y = left.Row0.Y + right.Row0.Y;
        result.Row1.X = left.Row1.X + right.Row1.X;
        result.Row1.Y = left.Row1.Y + right.Row1.Y;
        result.Row2.X = left.Row2.X + right.Row2.X;
        result.Row2.Y = left.Row2.Y + right.Row2.Y;
    }

    //
    // Summary:
    //     Adds two instances.
    //
    // Parameters:
    //   left:
    //     The left operand of the addition.
    //
    //   right:
    //     The right operand of the addition.
    //
    // Returns:
    //     A new instance that is the result of the addition.
    public static Matrix2x3 Add(Matrix2x3 left, Matrix2x3 right)
    {
        Add(in left, in right, out var result);
        return result;
    }

    //
    // Summary:
    //     Subtracts two instances.
    //
    // Parameters:
    //   left:
    //     The left operand of the subtraction.
    //
    //   right:
    //     The right operand of the subtraction.
    //
    //   result:
    //     A new instance that is the result of the subtraction.
    public static void Subtract(in Matrix2x3 left, in Matrix2x3 right, out Matrix2x3 result)
    {
        result.Row0.X = left.Row0.X - right.Row0.X;
        result.Row0.Y = left.Row0.Y - right.Row0.Y;
        result.Row1.X = left.Row1.X - right.Row1.X;
        result.Row1.Y = left.Row1.Y - right.Row1.Y;
        result.Row2.X = left.Row2.X - right.Row2.X;
        result.Row2.Y = left.Row2.Y - right.Row2.Y;
    }

    //
    // Summary:
    //     Subtracts two instances.
    //
    // Parameters:
    //   left:
    //     The left operand of the subtraction.
    //
    //   right:
    //     The right operand of the subtraction.
    //
    // Returns:
    //     A new instance that is the result of the subtraction.
    public static Matrix2x3 Subtract(Matrix2x3 left, Matrix2x3 right)
    {
        Subtract(in left, in right, out var result);
        return result;
    }

    //
    // Summary:
    //     Scalar multiplication.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2x3 which holds the result of the multiplication.
    public static Matrix2x3 operator *(float left, Matrix2x3 right)
    {
        return Mult(right, left);
    }

    //
    // Summary:
    //     Scalar multiplication.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2x3 which holds the result of the multiplication.
    public static Matrix2x3 operator *(Matrix2x3 left, float right)
    {
        return Mult(left, right);
    }

    //
    // Summary:
    //     Scalar multiplication.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2x3 which holds the result of the multiplication.
    public static Matrix2x3 operator *(Matrix2x3 left, Matrix2x3 right)
    {
        return Mult(left, right);
    }

    //
    // Summary:
    //     Matrix addition.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2x3 which holds the result of the addition.
    public static Matrix2x3 operator +(Matrix2x3 left, Matrix2x3 right)
    {
        return Add(left, right);
    }

    //
    // Summary:
    //     Matrix subtraction.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2x3 which holds the result of the subtraction.
    public static Matrix2x3 operator -(Matrix2x3 left, Matrix2x3 right)
    {
        return Subtract(left, right);
    }

    //
    // Summary:
    //     Compares two instances for equality.
    //
    // Parameters:
    //   left:
    //     The first instance.
    //
    //   right:
    //     The second instance.
    //
    // Returns:
    //     True, if left equals right; false otherwise.
    public static bool operator ==(Matrix2x3 left, Matrix2x3 right)
    {
        return left.Equals(right);
    }

    //
    // Summary:
    //     Compares two instances for inequality.
    //
    // Parameters:
    //   left:
    //     The first instance.
    //
    //   right:
    //     The second instance.
    //
    // Returns:
    //     True, if left does not equal right; false otherwise.
    public static bool operator !=(Matrix2x3 left, Matrix2x3 right)
    {
        return !left.Equals(right);
    }

    //
    // Summary:
    //     Returns a System.String that represents the current Matrix2x3.
    //
    // Returns:
    //     The string representation of the matrix.
    public override string ToString()
    {
        return $"{Row0}\n{Row1}\n{Row2}";
    }

    //
    // Summary:
    //     Returns the hashcode for this instance.
    //
    // Returns:
    //     A System.Int32 containing the unique hashcode for this instance.
    public override int GetHashCode()
    {
        return HashCode.Combine(Row0, Row1, Row2);
    }

    //
    // Summary:
    //     Indicates whether this instance and a specified object are equal.
    //
    // Parameters:
    //   obj:
    //     The object to compare tresult.
    //
    // Returns:
    //     True if the instances are equal; false otherwise.
    public override bool Equals(object? obj)
    {
        if (obj is Matrix2x3)
        {
            return Equals((Matrix2x3)obj);
        }

        return false;
    }

    //
    // Summary:
    //     Indicates whether the current matrix is equal to another matrix.
    //
    // Parameters:
    //   other:
    //     An matrix to compare with this matrix.
    //
    // Returns:
    //     true if the current matrix is equal to the matrix parameter; otherwise, false.
    public bool Equals(Matrix2x3 other)
    {
        if (Row0 == other.Row0 && Row1 == other.Row1)
        {
            return Row2 == other.Row2;
        }

        return false;
    }
}

public static class Matrix2x3Extension
{
    public static void Rotate(ref this Matrix2x3 matrix, float angle)
    {
        var rotateMatrix = new Matrix2x3(
            (float)Math.Cos(angle), (float)Math.Sin(angle),
            
            -(float)Math.Sin(angle), (float)Math.Cos(angle), 
            0, 0
        );
        matrix *= rotateMatrix;
    }
}