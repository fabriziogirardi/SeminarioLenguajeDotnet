namespace SeminarioLenguajeDotnet.MenuClasses;

internal class MenuItem(string name, Action action)
{
    public string Name   { get; private set; } = name;
    public Action Action { get; private set; } = action;
}