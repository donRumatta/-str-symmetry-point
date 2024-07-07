namespace StrSymmetryPoint;

public static class SymmetryPointSeeker
{
    public static int Seek(string input)
    {
        if (input.Length == 1)
        {
            return 0;
        }
        
        if (input.Length % 2 == 0)
        {
            return -1;
        }
        
        var middle = (input.Length - 1) / 2;

        var i = middle - 1;
        var j = middle + 1;

        while (j < input.Length)
        {
            if (input[i] != input[j])
            {
                return -1;
            }

            i -= 1;
            j += 1;
        }

        return middle;
    }
}