namespace Arc.Core;

public struct Vector2 : IEquatable<Vector2>
{
    //
    // Summary:
    //     The X component of the Vector2.
    public float X;

    //
    // Summary:
    //     The Y component of the Vector2.
    public float Y;

    //
    // Summary:
    //     Defines a unit-length Vector2 that points towards the X-axis.
    public static readonly Vector2 UnitX = new Vector2(1f, 0f);

    //
    // Summary:
    //     Defines a unit-length Vector2 that points towards the Y-axis.
    public static readonly Vector2 UnitY = new Vector2(0f, 1f);

    //
    // Summary:
    //     Defines an instance with all components set to 0.
    public static readonly Vector2 Zero = new Vector2(0f, 0f);

    //
    // Summary:
    //     Defines an instance with all components set to 1.
    public static readonly Vector2 One = new Vector2(1f, 1f);

    //
    // Summary:
    //     Defines an instance with all components set to positive infinity.
    public static readonly Vector2 PositiveInfinity = new Vector2(float.PositiveInfinity, float.PositiveInfinity);

    //
    // Summary:
    //     Defines an instance with all components set to negative infinity.
    public static readonly Vector2 NegativeInfinity = new Vector2(float.NegativeInfinity, float.NegativeInfinity);

    //
    // Summary:
    //     Gets or sets the value at the index of the Vector.
    //
    // Parameters:
    //   index:
    //     The index of the component from the Vector.
    //
    // Exceptions:
    //   T:System.IndexOutOfRangeException:
    //     Thrown if the index is less than 0 or greater than 1.
    public float this[int index]
    {
        get
        {
            return index switch
            {
                0 => X,
                1 => Y,
                _ => throw new IndexOutOfRangeException("You tried to access this vector at index: " + index),
            };
        }
        set
        {
            switch (index)
            {
                case 0:
                    X = value;
                    break;
                case 1:
                    Y = value;
                    break;
                default:
                    throw new IndexOutOfRangeException("You tried to set this vector at index: " + index);
            }
        }
    }

    //
    // Summary:
    //     Gets the length (magnitude) of the vector.
    public float Length => MathF.Sqrt(X * X + Y * Y);

    //
    // Summary:
    //     Gets the square of the vector length (magnitude).
    //
    // Remarks:
    //     This property avoids the costly square root operation required by the Length
    //     property. This makes it more suitable for comparisons.
    public float LengthSquared => X * X + Y * Y;

    //
    // Summary:
    //     Gets the perpendicular vector on the right side of this vector.
    public Vector2 PerpendicularRight => new Vector2(Y, 0f - X);

    //
    // Summary:
    //     Gets the perpendicular vector on the left side of this vector.
    public Vector2 PerpendicularLeft => new Vector2(0f - Y, X);

    //
    // Summary:
    //     Initializes a new instance of the OpenTK.Mathematics.Vector2 struct.
    //
    // Parameters:
    //   value:
    //     The value that will initialize this instance.
    public Vector2(float value)
    {
        X = value;
        Y = value;
    }

    //
    // Summary:
    //     Initializes a new instance of the OpenTK.Mathematics.Vector2 struct.
    //
    // Parameters:
    //   x:
    //     The x coordinate of the net Vector2.
    //
    //   y:
    //     The y coordinate of the net Vector2.
    public Vector2(float x, float y)
    {
        X = x;
        Y = y;
    }

    //
    // Summary:
    //     Returns a copy of the Vector2 scaled to unit length.
    //
    // Returns:
    //     The normalized copy.
    public Vector2 Normalized()
    {
        Vector2 result = this;
        result.Normalize();
        return result;
    }

    //
    // Summary:
    //     Scales the Vector2 to unit length.
    public void Normalize()
    {
        float num = 1f / Length;
        X *= num;
        Y *= num;
    }

    //
    // Summary:
    //     Adds two vectors.
    //
    // Parameters:
    //   a:
    //     Left operand.
    //
    //   b:
    //     Right operand.
    //
    // Returns:
    //     Result of operation.
    public static Vector2 Add(Vector2 a, Vector2 b)
    {
        Add(in a, in b, out a);
        return a;
    }

    //
    // Summary:
    //     Adds two vectors.
    //
    // Parameters:
    //   a:
    //     Left operand.
    //
    //   b:
    //     Right operand.
    //
    //   result:
    //     Result of operation.
    public static void Add(in Vector2 a, in Vector2 b, out Vector2 result)
    {
        result.X = a.X + b.X;
        result.Y = a.Y + b.Y;
    }

    //
    // Summary:
    //     Subtract one Vector from another.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    // Returns:
    //     Result of subtraction.
    public static Vector2 Subtract(Vector2 a, Vector2 b)
    {
        Subtract(in a, in b, out a);
        return a;
    }

    //
    // Summary:
    //     Subtract one Vector from another.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    //   result:
    //     Result of subtraction.
    public static void Subtract(in Vector2 a, in Vector2 b, out Vector2 result)
    {
        result.X = a.X - b.X;
        result.Y = a.Y - b.Y;
    }

    //
    // Summary:
    //     Multiplies a vector by a scalar.
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the operation.
    public static Vector2 Multiply(Vector2 vector, float scale)
    {
        Multiply(in vector, scale, out vector);
        return vector;
    }

    //
    // Summary:
    //     Multiplies a vector by a scalar.
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    //   result:
    //     Result of the operation.
    public static void Multiply(in Vector2 vector, float scale, out Vector2 result)
    {
        result.X = vector.X * scale;
        result.Y = vector.Y * scale;
    }

    //
    // Summary:
    //     Multiplies a vector by the components a vector (scale).
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the operation.
    public static Vector2 Multiply(Vector2 vector, Vector2 scale)
    {
        Multiply(in vector, in scale, out vector);
        return vector;
    }

    //
    // Summary:
    //     Multiplies a vector by the components of a vector (scale).
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    //   result:
    //     Result of the operation.
    public static void Multiply(in Vector2 vector, in Vector2 scale, out Vector2 result)
    {
        result.X = vector.X * scale.X;
        result.Y = vector.Y * scale.Y;
    }

    //
    // Summary:
    //     Divides a vector by a scalar.
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the operation.
    public static Vector2 Divide(Vector2 vector, float scale)
    {
        Divide(in vector, scale, out vector);
        return vector;
    }

    //
    // Summary:
    //     Divides a vector by a scalar.
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    //   result:
    //     Result of the operation.
    public static void Divide(in Vector2 vector, float scale, out Vector2 result)
    {
        result.X = vector.X / scale;
        result.Y = vector.Y / scale;
    }

    //
    // Summary:
    //     Divides a vector by the components of a vector (scale).
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the operation.
    public static Vector2 Divide(Vector2 vector, Vector2 scale)
    {
        Divide(in vector, in scale, out vector);
        return vector;
    }

    //
    // Summary:
    //     Divide a vector by the components of a vector (scale).
    //
    // Parameters:
    //   vector:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    //   result:
    //     Result of the operation.
    public static void Divide(in Vector2 vector, in Vector2 scale, out Vector2 result)
    {
        result.X = vector.X / scale.X;
        result.Y = vector.Y / scale.Y;
    }

    //
    // Summary:
    //     Returns a vector created from the smallest of the corresponding components of
    //     the given vectors.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    // Returns:
    //     The component-wise minimum.
    public static Vector2 ComponentMin(Vector2 a, Vector2 b)
    {
        a.X = ((a.X < b.X) ? a.X : b.X);
        a.Y = ((a.Y < b.Y) ? a.Y : b.Y);
        return a;
    }

    //
    // Summary:
    //     Returns a vector created from the smallest of the corresponding components of
    //     the given vectors.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    //   result:
    //     The component-wise minimum.
    public static void ComponentMin(in Vector2 a, in Vector2 b, out Vector2 result)
    {
        result.X = ((a.X < b.X) ? a.X : b.X);
        result.Y = ((a.Y < b.Y) ? a.Y : b.Y);
    }

    //
    // Summary:
    //     Returns a vector created from the largest of the corresponding components of
    //     the given vectors.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    // Returns:
    //     The component-wise maximum.
    public static Vector2 ComponentMax(Vector2 a, Vector2 b)
    {
        a.X = ((a.X > b.X) ? a.X : b.X);
        a.Y = ((a.Y > b.Y) ? a.Y : b.Y);
        return a;
    }

    //
    // Summary:
    //     Returns a vector created from the largest of the corresponding components of
    //     the given vectors.
    //
    // Parameters:
    //   a:
    //     First operand.
    //
    //   b:
    //     Second operand.
    //
    //   result:
    //     The component-wise maximum.
    public static void ComponentMax(in Vector2 a, in Vector2 b, out Vector2 result)
    {
        result.X = ((a.X > b.X) ? a.X : b.X);
        result.Y = ((a.Y > b.Y) ? a.Y : b.Y);
    }

    //
    // Summary:
    //     Returns the Vector2 with the minimum magnitude. If the magnitudes are equal,
    //     the second vector is selected.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     The minimum Vector2.
    public static Vector2 MagnitudeMin(Vector2 left, Vector2 right)
    {
        if (!(left.LengthSquared < right.LengthSquared))
        {
            return right;
        }

        return left;
    }

    //
    // Summary:
    //     Returns the Vector2 with the minimum magnitude. If the magnitudes are equal,
    //     the second vector is selected.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    //   result:
    //     The magnitude-wise minimum.
    public static void MagnitudeMin(in Vector2 left, in Vector2 right, out Vector2 result)
    {
        result = ((left.LengthSquared < right.LengthSquared) ? left : right);
    }

    //
    // Summary:
    //     Returns the Vector2 with the maximum magnitude. If the magnitudes are equal,
    //     the first vector is selected.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     The maximum Vector2.
    public static Vector2 MagnitudeMax(Vector2 left, Vector2 right)
    {
        if (!(left.LengthSquared >= right.LengthSquared))
        {
            return right;
        }

        return left;
    }

    //
    // Summary:
    //     Returns the Vector2 with the maximum magnitude. If the magnitudes are equal,
    //     the first vector is selected.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    //   result:
    //     The magnitude-wise maximum.
    public static void MagnitudeMax(in Vector2 left, in Vector2 right, out Vector2 result)
    {
        result = ((left.LengthSquared >= right.LengthSquared) ? left : right);
    }

    //
    // Summary:
    //     Clamp a vector to the given minimum and maximum vectors.
    //
    // Parameters:
    //   vec:
    //     Input vector.
    //
    //   min:
    //     Minimum vector.
    //
    //   max:
    //     Maximum vector.
    //
    // Returns:
    //     The clamped vector.
    public static Vector2 Clamp(Vector2 vec, Vector2 min, Vector2 max)
    {
        vec.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
        vec.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
        return vec;
    }

    //
    // Summary:
    //     Clamp a vector to the given minimum and maximum vectors.
    //
    // Parameters:
    //   vec:
    //     Input vector.
    //
    //   min:
    //     Minimum vector.
    //
    //   max:
    //     Maximum vector.
    //
    //   result:
    //     The clamped vector.
    public static void Clamp(in Vector2 vec, in Vector2 min, in Vector2 max, out Vector2 result)
    {
        result.X = ((vec.X < min.X) ? min.X : ((vec.X > max.X) ? max.X : vec.X));
        result.Y = ((vec.Y < min.Y) ? min.Y : ((vec.Y > max.Y) ? max.Y : vec.Y));
    }

    //
    // Summary:
    //     Compute the euclidean distance between two vectors.
    //
    // Parameters:
    //   vec1:
    //     The first vector.
    //
    //   vec2:
    //     The second vector.
    //
    // Returns:
    //     The distance.
    public static float Distance(Vector2 vec1, Vector2 vec2)
    {
        Distance(in vec1, in vec2, out var result);
        return result;
    }

    //
    // Summary:
    //     Compute the euclidean distance between two vectors.
    //
    // Parameters:
    //   vec1:
    //     The first vector.
    //
    //   vec2:
    //     The second vector.
    //
    //   result:
    //     The distance.
    public static void Distance(in Vector2 vec1, in Vector2 vec2, out float result)
    {
        result = MathF.Sqrt((vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y));
    }

    //
    // Summary:
    //     Compute the squared euclidean distance between two vectors.
    //
    // Parameters:
    //   vec1:
    //     The first vector.
    //
    //   vec2:
    //     The second vector.
    //
    // Returns:
    //     The squared distance.
    public static float DistanceSquared(Vector2 vec1, Vector2 vec2)
    {
        DistanceSquared(in vec1, in vec2, out var result);
        return result;
    }

    //
    // Summary:
    //     Compute the squared euclidean distance between two vectors.
    //
    // Parameters:
    //   vec1:
    //     The first vector.
    //
    //   vec2:
    //     The second vector.
    //
    //   result:
    //     The squared distance.
    public static void DistanceSquared(in Vector2 vec1, in Vector2 vec2, out float result)
    {
        result = (vec2.X - vec1.X) * (vec2.X - vec1.X) + (vec2.Y - vec1.Y) * (vec2.Y - vec1.Y);
    }

    //
    // Summary:
    //     Scale a vector to unit length.
    //
    // Parameters:
    //   vec:
    //     The input vector.
    //
    // Returns:
    //     The normalized copy.
    public static Vector2 Normalize(Vector2 vec)
    {
        float num = 1f / vec.Length;
        vec.X *= num;
        vec.Y *= num;
        return vec;
    }

    //
    // Summary:
    //     Scale a vector to unit length.
    //
    // Parameters:
    //   vec:
    //     The input vector.
    //
    //   result:
    //     The normalized vector.
    public static void Normalize(in Vector2 vec, out Vector2 result)
    {
        float num = 1f / vec.Length;
        result.X = vec.X * num;
        result.Y = vec.Y * num;
    }

    //
    // Summary:
    //     Calculate the dot (scalar) product of two vectors.
    //
    // Parameters:
    //   left:
    //     First operand.
    //
    //   right:
    //     Second operand.
    //
    // Returns:
    //     The dot product of the two inputs.
    public static float Dot(Vector2 left, Vector2 right)
    {
        return left.X * right.X + left.Y * right.Y;
    }

    //
    // Summary:
    //     Calculate the dot (scalar) product of two vectors.
    //
    // Parameters:
    //   left:
    //     First operand.
    //
    //   right:
    //     Second operand.
    //
    //   result:
    //     The dot product of the two inputs.
    public static void Dot(in Vector2 left, in Vector2 right, out float result)
    {
        result = left.X * right.X + left.Y * right.Y;
    }

    //
    // Summary:
    //     Calculate the perpendicular dot (scalar) product of two vectors.
    //
    // Parameters:
    //   left:
    //     First operand.
    //
    //   right:
    //     Second operand.
    //
    // Returns:
    //     The perpendicular dot product of the two inputs.
    public static float PerpDot(Vector2 left, Vector2 right)
    {
        return left.X * right.Y - left.Y * right.X;
    }

    //
    // Summary:
    //     Calculate the perpendicular dot (scalar) product of two vectors.
    //
    // Parameters:
    //   left:
    //     First operand.
    //
    //   right:
    //     Second operand.
    //
    //   result:
    //     The perpendicular dot product of the two inputs.
    public static void PerpDot(in Vector2 left, in Vector2 right, out float result)
    {
        result = left.X * right.Y - left.Y * right.X;
    }

    //
    // Summary:
    //     Returns a new Vector that is the linear blend of the 2 given Vectors.
    //
    // Parameters:
    //   a:
    //     First input vector.
    //
    //   b:
    //     Second input vector.
    //
    //   blend:
    //     The blend factor. a when blend=0, b when blend=1.
    //
    // Returns:
    //     a when blend=0, b when blend=1, and a linear combination otherwise.
    public static Vector2 Lerp(Vector2 a, Vector2 b, float blend)
    {
        a.X = blend * (b.X - a.X) + a.X;
        a.Y = blend * (b.Y - a.Y) + a.Y;
        return a;
    }

    //
    // Summary:
    //     Returns a new Vector that is the linear blend of the 2 given Vectors.
    //
    // Parameters:
    //   a:
    //     First input vector.
    //
    //   b:
    //     Second input vector.
    //
    //   blend:
    //     The blend factor. a when blend=0, b when blend=1.
    //
    //   result:
    //     a when blend=0, b when blend=1, and a linear combination otherwise.
    public static void Lerp(in Vector2 a, in Vector2 b, float blend, out Vector2 result)
    {
        result.X = blend * (b.X - a.X) + a.X;
        result.Y = blend * (b.Y - a.Y) + a.Y;
    }

    //
    // Summary:
    //     Interpolate 3 Vectors using Barycentric coordinates.
    //
    // Parameters:
    //   a:
    //     First input Vector.
    //
    //   b:
    //     Second input Vector.
    //
    //   c:
    //     Third input Vector.
    //
    //   u:
    //     First Barycentric Coordinate.
    //
    //   v:
    //     Second Barycentric Coordinate.
    //
    // Returns:
    //     a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination of a,b,c
    //     otherwise.
    public static Vector2 BaryCentric(Vector2 a, Vector2 b, Vector2 c, float u, float v)
    {
        BaryCentric(in a, in b, in c, u, v, out var result);
        return result;
    }

    //
    // Summary:
    //     Interpolate 3 Vectors using Barycentric coordinates.
    //
    // Parameters:
    //   a:
    //     First input Vector.
    //
    //   b:
    //     Second input Vector.
    //
    //   c:
    //     Third input Vector.
    //
    //   u:
    //     First Barycentric Coordinate.
    //
    //   v:
    //     Second Barycentric Coordinate.
    //
    //   result:
    //     Output Vector. a when u=v=0, b when u=1,v=0, c when u=0,v=1, and a linear combination
    //     of a,b,c otherwise.
    public static void BaryCentric(in Vector2 a, in Vector2 b, in Vector2 c, float u, float v, out Vector2 result)
    {
        Subtract(in b, in a, out var result2);
        Multiply(in result2, u, out var result3);
        Add(in a, in result3, out var result4);
        Subtract(in c, in a, out var result5);
        Multiply(in result5, v, out var result6);
        Add(in result4, in result6, out result);
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix.
    //
    // Parameters:
    //   vec:
    //     The vector to transform.
    //
    //   mat:
    //     The desired transformation.
    //
    // Returns:
    //     The transformed vector.
    public static Vector2 TransformRow(Vector2 vec, Matrix2 mat)
    {
        TransformRow(in vec, in mat, out var result);
        return result;
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix.
    //
    // Parameters:
    //   vec:
    //     The vector to transform.
    //
    //   mat:
    //     The desired transformation.
    //
    //   result:
    //     The transformed vector.
    public static void TransformRow(in Vector2 vec, in Matrix2 mat, out Vector2 result)
    {
        result = new Vector2(vec.X * mat.Row0.X + vec.Y * mat.Row1.X, vec.X * mat.Row0.Y + vec.Y * mat.Row1.Y);
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix using right-handed notation.
    //
    // Parameters:
    //   mat:
    //     The desired transformation.
    //
    //   vec:
    //     The vector to transform.
    //
    // Returns:
    //     The transformed vector.
    public static Vector2 TransformColumn(Matrix2 mat, Vector2 vec)
    {
        TransformColumn(in mat, in vec, out var result);
        return result;
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix using right-handed notation.
    //
    // Parameters:
    //   mat:
    //     The desired transformation.
    //
    //   vec:
    //     The vector to transform.
    //
    //   result:
    //     The transformed vector.
    public static void TransformColumn(in Matrix2 mat, in Vector2 vec, out Vector2 result)
    {
        result.X = mat.Row0.X * vec.X + mat.Row0.Y * vec.Y;
        result.Y = mat.Row1.X * vec.X + mat.Row1.Y * vec.Y;
    }

    //
    // Summary:
    //     Adds the specified instances.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     Result of addition.
    public static Vector2 operator +(Vector2 left, Vector2 right)
    {
        left.X += right.X;
        left.Y += right.Y;
        return left;
    }

    //
    // Summary:
    //     Subtracts the specified instances.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     Result of subtraction.
    public static Vector2 operator -(Vector2 left, Vector2 right)
    {
        left.X -= right.X;
        left.Y -= right.Y;
        return left;
    }

    //
    // Summary:
    //     Negates the specified instance.
    //
    // Parameters:
    //   vec:
    //     Operand.
    //
    // Returns:
    //     Result of negation.
    public static Vector2 operator -(Vector2 vec)
    {
        vec.X = 0f - vec.X;
        vec.Y = 0f - vec.Y;
        return vec;
    }

    //
    // Summary:
    //     Multiplies the specified instance by a scalar.
    //
    // Parameters:
    //   vec:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of multiplication.
    public static Vector2 operator *(Vector2 vec, float scale)
    {
        vec.X *= scale;
        vec.Y *= scale;
        return vec;
    }

    //
    // Summary:
    //     Multiplies the specified instance by a scalar.
    //
    // Parameters:
    //   scale:
    //     Left operand.
    //
    //   vec:
    //     Right operand.
    //
    // Returns:
    //     Result of multiplication.
    public static Vector2 operator *(float scale, Vector2 vec)
    {
        vec.X *= scale;
        vec.Y *= scale;
        return vec;
    }

    //
    // Summary:
    //     Component-wise multiplication between the specified instance by a scale vector.
    //
    //
    // Parameters:
    //   scale:
    //     Left operand.
    //
    //   vec:
    //     Right operand.
    //
    // Returns:
    //     Result of multiplication.
    public static Vector2 operator *(Vector2 vec, Vector2 scale)
    {
        vec.X *= scale.X;
        vec.Y *= scale.Y;
        return vec;
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix.
    //
    // Parameters:
    //   vec:
    //     The vector to transform.
    //
    //   mat:
    //     The desired transformation.
    //
    // Returns:
    //     The transformed vector.
    public static Vector2 operator *(Vector2 vec, Matrix2 mat)
    {
        TransformRow(in vec, in mat, out var result);
        return result;
    }

    //
    // Summary:
    //     Transform a Vector by the given Matrix using right-handed notation.
    //
    // Parameters:
    //   mat:
    //     The desired transformation.
    //
    //   vec:
    //     The vector to transform.
    //
    // Returns:
    //     The transformed vector.
    public static Vector2 operator *(Matrix2 mat, Vector2 vec)
    {
        TransformColumn(in mat, in vec, out var result);
        return result;
    }

    //
    // Summary:
    //     Divides the specified instance by a scalar.
    //
    // Parameters:
    //   vec:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the division.
    public static Vector2 operator /(Vector2 vec, float scale)
    {
        vec.X /= scale;
        vec.Y /= scale;
        return vec;
    }

    //
    // Summary:
    //     Component-wise division between the specified instance by a scale vector.
    //
    // Parameters:
    //   vec:
    //     Left operand.
    //
    //   scale:
    //     Right operand.
    //
    // Returns:
    //     Result of the division.
    public static Vector2 operator /(Vector2 vec, Vector2 scale)
    {
        vec.X /= scale.X;
        vec.Y /= scale.Y;
        return vec;
    }

    //
    // Summary:
    //     Compares the specified instances for equality.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     True if both instances are equal; false otherwise.
    public static bool operator ==(Vector2 left, Vector2 right)
    {
        return left.Equals(right);
    }

    //
    // Summary:
    //     Compares the specified instances for inequality.
    //
    // Parameters:
    //   left:
    //     Left operand.
    //
    //   right:
    //     Right operand.
    //
    // Returns:
    //     True if both instances are not equal; false otherwise.
    public static bool operator !=(Vector2 left, Vector2 right)
    {
        return !(left == right);
    }

    public static implicit operator Vector2((float X, float Y) values)
    {
        return new Vector2(values.X, values.Y);
    }

    public override bool Equals(object? obj)
    {
        if (obj is Vector2)
        {
            return Equals((Vector2)obj);
        }

        return false;
    }

    public override string ToString()
    {
        return string.Format("({0}{2} {1})", X, Y, System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
    }

    public bool Equals(Vector2 other)
    {
        if (X == other.X)
        {
            return Y == other.Y;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y);
    }

    //
    // Summary:
    //     Deconstructs the vector into it's individual components.
    //
    // Parameters:
    //   x:
    //     The X component of the vector.
    //
    //   y:
    //     The Y component of the vector.
    public void Deconstruct(out float x, out float y)
    {
        x = X;
        y = Y;
    }
}