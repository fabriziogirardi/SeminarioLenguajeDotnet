namespace SeminarioLenguajeDotnet.MenuClasses;

internal class MenuRun(Menu root)
{
    public void Run()
    {
        root.Run();
    }
}