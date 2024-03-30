using SeminarioLenguajeDotnet.MenuClasses;

namespace SeminarioLenguajeDotnet.Practicas.Practica4;

internal class Practica4Ejercicio11(Menu menu) : Practica(menu)
{
    public override string Description { get; protected set; } =
        "Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing\n" +
        "(?? ) y / o la asignación null-coalescing (??=)\n\n"                                                 +
        "...\n"                                                                                               +
        "if (st1 == null)\n"                                                                                  +
        "{\n"                                                                                                 +
        "    if (st2 == null)\n"                                                                              +
        "    {\n"                                                                                             +
        "        st = st3;\n"                                                                                 +
        "    }\n"                                                                                             +
        "    else\n"                                                                                          +
        "    {\n"                                                                                             +
        "        st = st2;\n"                                                                                 +
        "    }\n"                                                                                             +
        "}\n"                                                                                                 +
        "else\n"                                                                                              +
        "{\n"                                                                                                 +
        "    st = st1;\n"                                                                                     +
        "}\n"                                                                                                 +
        "if (st4 == null)\n"                                                                                  +
        "{\n"                                                                                                 +
        "    st4 = \"valor por defecto\";\n"                                                                  +
        "}\n"                                                                                                 +
        "...";

    protected override void Execute()
    {
        Console.WriteLine("Reemplazando las líneas de código por otras equivalentes que utilicen el operador " +
                          "null-coalescing (??) y/o la asignación null-coalescing (??=):\n\n"                  +
                          "st = st1 ?? st2 ?? st3;\n"                                                          +
                          "st4 ??= \"valor por defecto\"");
    }
}