namespace Arc.Core;

public struct Matrix2 : IEquatable<Matrix2>
{
    //
    // Summary:
    //     Top row of the matrix.
    public Vector2 Row0;

    //
    // Summary:
    //     Bottom row of the matrix.
    public Vector2 Row1;

    //
    // Summary:
    //     The identity matrix.
    public static readonly Matrix2 Identity = new Matrix2(Vector2.UnitX, Vector2.UnitY);

    //
    // Summary:
    //     The zero matrix.
    public static readonly Matrix2 Zero = new Matrix2(Vector2.Zero, Vector2.Zero);

    //
    // Summary:
    //     Gets the determinant of this matrix.
    public float Determinant
    {
        get
        {
            float x = Row0.X;
            float y = Row0.Y;
            float x2 = Row1.X;
            float y2 = Row1.Y;
            return x * y2 - y * x2;
        }
    }

    //
    // Summary:
    //     Gets or sets the first column of this matrix.
    public Vector2 Column0
    {
        get
        {
            return new Vector2(Row0.X, Row1.X);
        }
        set
        {
            Row0.X = value.X;
            Row1.X = value.Y;
        }
    }

    //
    // Summary:
    //     Gets or sets the second column of this matrix.
    public Vector2 Column1
    {
        get
        {
            return new Vector2(Row0.Y, Row1.Y);
        }
        set
        {
            Row0.Y = value.X;
            Row1.Y = value.Y;
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
    //     Initializes a new instance of the OpenTK.Mathematics.Matrix2 struct.
    //
    // Parameters:
    //   row0:
    //     Top row of the matrix.
    //
    //   row1:
    //     Bottom row of the matrix.
    public Matrix2(Vector2 row0, Vector2 row1)
    {
        Row0 = row0;
        Row1 = row1;
    }

    //
    // Summary:
    //     Initializes a new instance of the OpenTK.Mathematics.Matrix2 struct.
    //
    // Parameters:
    //   m00:
    //     First item of the first row of the matrix.
    //
    //   m01:
    //     Second item of the first row of the matrix.
    //
    //   m10:
    //     First item of the second row of the matrix.
    //
    //   m11:
    //     Second item of the second row of the matrix.
    public Matrix2(float m00, float m01, float m10, float m11)
    {
        Row0 = new Vector2(m00, m01);
        Row1 = new Vector2(m10, m11);
    }

    //
    // Summary:
    //     Converts this instance to it's transpose.
    public void Transpose()
    {
        this = Transpose(this);
    }

    //
    // Summary:
    //     Converts this instance into its inverse.
    public void Invert()
    {
        this = Invert(this);
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
    //     The resulting Matrix2 instance.
    public static void CreateRotation(float angle, out Matrix2 result)
    {
        float num = MathF.Cos(angle);
        float num2 = MathF.Sin(angle);
        result.Row0.X = num;
        result.Row0.Y = num2;
        result.Row1.X = 0f - num2;
        result.Row1.Y = num;
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
    //     The resulting Matrix2 instance.
    public static Matrix2 CreateRotation(float angle)
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
    public static void CreateScale(float scale, out Matrix2 result)
    {
        result.Row0.X = scale;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = scale;
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
    public static Matrix2 CreateScale(float scale)
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
    public static void CreateScale(Vector2 scale, out Matrix2 result)
    {
        result.Row0.X = scale.X;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = scale.Y;
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
    public static Matrix2 CreateScale(Vector2 scale)
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
    public static void CreateScale(float x, float y, out Matrix2 result)
    {
        result.Row0.X = x;
        result.Row0.Y = 0f;
        result.Row1.X = 0f;
        result.Row1.Y = y;
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
    public static Matrix2 CreateScale(float x, float y)
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
    public static void Mult(in Matrix2 left, float right, out Matrix2 result)
    {
        result.Row0.X = left.Row0.X * right;
        result.Row0.Y = left.Row0.Y * right;
        result.Row1.X = left.Row1.X * right;
        result.Row1.Y = left.Row1.Y * right;
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
    public static Matrix2 Mult(Matrix2 left, float right)
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
    public static void Mult(in Matrix2 left, in Matrix2 right, out Matrix2 result)
    {
        float x = left.Row0.X;
        float y = left.Row0.Y;
        float x2 = left.Row1.X;
        float y2 = left.Row1.Y;
        float x3 = right.Row0.X;
        float y3 = right.Row0.Y;
        float x4 = right.Row1.X;
        float y4 = right.Row1.Y;
        result.Row0.X = x * x3 + y * x4;
        result.Row0.Y = x * y3 + y * y4;
        result.Row1.X = x2 * x3 + y2 * x4;
        result.Row1.Y = x2 * y3 + y2 * y4;
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
    // Returns:
    //     A new instance that is the result of the multiplication.
    public static Matrix2 Mult(Matrix2 left, Matrix2 right)
    {
        Mult(in left, in right, out var result);
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
    public static void Add(in Matrix2 left, in Matrix2 right, out Matrix2 result)
    {
        result.Row0.X = left.Row0.X + right.Row0.X;
        result.Row0.Y = left.Row0.Y + right.Row0.Y;
        result.Row1.X = left.Row1.X + right.Row1.X;
        result.Row1.Y = left.Row1.Y + right.Row1.Y;
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
    public static Matrix2 Add(Matrix2 left, Matrix2 right)
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
    public static void Subtract(in Matrix2 left, in Matrix2 right, out Matrix2 result)
    {
        result.Row0.X = left.Row0.X - right.Row0.X;
        result.Row0.Y = left.Row0.Y - right.Row0.Y;
        result.Row1.X = left.Row1.X - right.Row1.X;
        result.Row1.Y = left.Row1.Y - right.Row1.Y;
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
    public static Matrix2 Subtract(Matrix2 left, Matrix2 right)
    {
        Subtract(in left, in right, out var result);
        return result;
    }

    //
    // Summary:
    //     Calculate the inverse of the given matrix.
    //
    // Parameters:
    //   mat:
    //     The matrix to invert.
    //
    //   result:
    //     The inverse of the given matrix.
    //
    // Exceptions:
    //   T:System.InvalidOperationException:
    //     Thrown if the Matrix2 is singular.
    public static void Invert(in Matrix2 mat, out Matrix2 result)
    {
        float num = mat.Row0.X * mat.Row1.Y - mat.Row0.Y * mat.Row1.X;
        if (num == 0f)
        {
            throw new InvalidOperationException("Matrix is singular and cannot be inverted.");
        }

        float num2 = 1f / num;
        float x = mat.Row0.X;
        result.Row0.X = mat.Row1.Y * num2;
        result.Row0.Y = (0f - mat.Row0.Y) * num2;
        result.Row1.X = (0f - mat.Row1.X) * num2;
        result.Row1.Y = x * num2;
    }

    //
    // Summary:
    //     Calculate the inverse of the given matrix.
    //
    // Parameters:
    //   mat:
    //     The matrix to invert.
    //
    // Returns:
    //     The inverse of the given matrix.
    //
    // Exceptions:
    //   T:System.InvalidOperationException:
    //     Thrown if the Matrix2 is singular.
    public static Matrix2 Invert(Matrix2 mat)
    {
        Invert(in mat, out var result);
        return result;
    }

    //
    // Summary:
    //     Calculate the transpose of the given matrix.
    //
    // Parameters:
    //   mat:
    //     The matrix to transpose.
    //
    //   result:
    //     The transpose of the given matrix.
    public static void Transpose(in Matrix2 mat, out Matrix2 result)
    {
        result.Row0.X = mat.Row0.X;
        result.Row0.Y = mat.Row1.X;
        result.Row1.X = mat.Row0.Y;
        result.Row1.Y = mat.Row1.Y;
    }

    //
    // Summary:
    //     Calculate the transpose of the given matrix.
    //
    // Parameters:
    //   mat:
    //     The matrix to transpose.
    //
    // Returns:
    //     The transpose of the given matrix.
    public static Matrix2 Transpose(Matrix2 mat)
    {
        Transpose(in mat, out var result);
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
    //     A new Matrix2 which holds the result of the multiplication.
    public static Matrix2 operator *(float left, Matrix2 right)
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
    //     A new Matrix2 which holds the result of the multiplication.
    public static Matrix2 operator *(Matrix2 left, float right)
    {
        return Mult(left, right);
    }

    //
    // Summary:
    //     Matrix multiplication.
    //
    // Parameters:
    //   left:
    //     left-hand operand.
    //
    //   right:
    //     right-hand operand.
    //
    // Returns:
    //     A new Matrix2 which holds the result of the multiplication.
    public static Matrix2 operator *(Matrix2 left, Matrix2 right)
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
    //     A new Matrix2 which holds the result of the addition.
    public static Matrix2 operator +(Matrix2 left, Matrix2 right)
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
    //     A new Matrix2 which holds the result of the subtraction.
    public static Matrix2 operator -(Matrix2 left, Matrix2 right)
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
    public static bool operator ==(Matrix2 left, Matrix2 right)
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
    public static bool operator !=(Matrix2 left, Matrix2 right)
    {
        return !left.Equals(right);
    }

    //
    // Summary:
    //     Returns a System.String that represents the current Matrix4.
    //
    // Returns:
    //     The string representation of the matrix.
    public override string ToString()
    {
        return $"{Row0}\n{Row1}";
    }

    //
    // Summary:
    //     Returns the hashcode for this instance.
    //
    // Returns:
    //     A System.Int32 containing the unique hashcode for this instance.
    public override int GetHashCode()
    {
        return HashCode.Combine(Row0, Row1);
    }

    //
    // Summary:
    //     Indicates whether this instance and a specified object are equal.
    //
    // Parameters:
    //   obj:
    //     The object to compare to.
    //
    // Returns:
    //     True if the instances are equal; false otherwise.
    public override bool Equals(object? obj)
    {
        if (obj is Matrix2)
        {
            return Equals((Matrix2)obj);
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
    public bool Equals(Matrix2 other)
    {
        if (Row0 == other.Row0)
        {
            return Row1 == other.Row1;
        }

        return false;
    }
}