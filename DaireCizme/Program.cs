class Program
{
    static void Main()
    {
        int radius = InputManager.GetCircleRadiusFromUser();
        CircleDrawer.DrawCircle(radius);
    }
}
