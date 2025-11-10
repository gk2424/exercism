public class SpiralMatrix
{
   public static int[,] GetMatrix(int size)
    {
        if (size <= 0)
        {
            return new int[0, 0]; // Return an empty matrix for invalid size
        }

        int[,] matrix = new int[size, size];
        int value = 1;

        int top = 0;
        int bottom = size - 1;
        int left = 0;
        int right = size - 1;

        while (top <= bottom && left <= right)
        {
            // Fill top row
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = value++;
            }
            top++;

            // Fill right column
            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = value++;
            }
            right--;

            // Fill bottom row (if applicable)
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    matrix[bottom, i] = value++;
                }
                bottom--;
            }

            // Fill left column (if applicable)
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    matrix[i, left] = value++;
                }
                left++;
            }
        }

        return matrix;
    }

    
}
