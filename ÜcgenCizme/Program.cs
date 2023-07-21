class Program
{
    static void Main()
    {
        int size = InputManager.GetTriangleSizeFromUser();
        TriangleDrawer.DrawTriangle(size);
    }
}
