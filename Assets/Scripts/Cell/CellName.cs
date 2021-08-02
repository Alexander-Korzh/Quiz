
public static class CellName
{
    public static string Create(int cellNumber)
    {
        string name;
        switch (cellNumber)
        {
            case 0:
                name = "left top cell";
                break;
            case 1:
                name = "center top cell";
                break;
            case 2:
                name = "right top cell";
                break;
            case 3:
                name = "left middle cell";
                break;
            case 4:
                name = "center middle cell";
                break;
            case 5:
                name = "right middle cell";
                break;
            case 6:
                name = "left bottom cell";
                break;
            case 7:
                name = "center bottom cell";
                break;
            case 8:
                name = "right bottom cell";
                break;
            default:
                name = "noname cell";
                break;
        }
        return name;
    }
}
