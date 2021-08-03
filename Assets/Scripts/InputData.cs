public static class InputData 
{
    private static string[] imageNames  = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "O", "P", "Q", "R", "S", "T", "V", "W", "X", "Y", "Z" };
    public static string GetImageName(int indexInArray)
    {
        return imageNames[indexInArray];
    }
    public static string[] GetImageNames()
    {
        return imageNames;
    }
    public static int GetInputArrayLength()
    {
        return imageNames.Length;
    }
}
