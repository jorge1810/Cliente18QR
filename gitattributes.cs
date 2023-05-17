using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("###############################################################################");
        Console.WriteLine("# Set default behavior to automatically normalize line endings.");
        Console.WriteLine("###############################################################################");
        Console.WriteLine("* text=auto");
        Console.WriteLine();
        Console.WriteLine("###############################################################################");
        Console.WriteLine("# Set default behavior for command prompt diff.");
        Console.WriteLine("#");
        Console.WriteLine("# This is need for earlier builds of msysgit that does not have it on by");
        Console.WriteLine("# default for csharp files.");
        Console.WriteLine("# Note: This is only used by command line");
        Console.WriteLine("###############################################################################");
        Console.WriteLine("#*.cs     diff=csharp");
        Console.WriteLine();
        Console.WriteLine("###############################################################################");
        Console.WriteLine("# Set the merge driver for project and solution files");
        Console.WriteLine("#");
        Console.WriteLine("# Merging from the command prompt will add diff markers to the files if there");
        Console.WriteLine("# are conflicts (Merging from VS is not affected by the settings below, in VS");
        Console.WriteLine("# the diff markers are never inserted). Diff markers may cause the following");
        Console.WriteLine("# file extensions to fail to load in VS. An alternative would be to treat");
        Console.WriteLine("# these files as binary and thus will always conflict and require user");
        Console.WriteLine("# intervention with every merge. To do so, just uncomment the entries below");
        Console.WriteLine("###############################################################################");
        Console.WriteLine("#*.sln       merge=binary");
        Console.WriteLine("#*.csproj    merge=binary");
        Console.WriteLine("#*.vbproj    merge=binary");
        Console.WriteLine("#*.vcxproj   merge=binary");
        Console.WriteLine("#*.vcproj    merge=binary");
        Console.WriteLine("#*.dbproj    merge=binary");
        Console.WriteLine("#*.fsproj    merge=binary");
        Console.WriteLine("#*.lsproj    merge=binary");
        Console.WriteLine("#*.wixproj   merge=binary");
        Console.WriteLine("#*.modelproj merge=binary");
        Console.WriteLine("#*.sqlproj   merge=binary");
        Console.WriteLine("#*.wwaproj   merge=binary");
        Console.WriteLine();
        Console.WriteLine("###############################################################################");
        Console.WriteLine("# behavior for image files");
        Console.WriteLine("#");
        Console.WriteLine("# image files are treated as binary by default.");
        Console.WriteLine("###############################################################################");
        Console.WriteLine("#*.jpg   binary");
        Console.WriteLine("#*.png   binary");
        Console.WriteLine("#*.gif   binary");
        Console.WriteLine();
        Console.WriteLine("###############################################################################");
        Console.WriteLine("# diff behavior for common document formats");
        Console.WriteLine("#");
        Console.WriteLine("# Convert binary document formats to text before diffing them. This feature");
        Console.WriteLine("# is only available from the command line. Turn it on by uncommenting the");
        Console.WriteLine("# entries below.");
        Console.WriteLine("###############################################################################");
        Console.WriteLine("#*.doc   diff=astextplain");
        Console.WriteLine("#*.DOC   diff=astextplain");
        Console.WriteLine("#*.docx  diff=astextplain");
        Console.WriteLine("#*.DOCX  diff=astextplain");
        Console.WriteLine("#*.dot   diff=astextplain");
        Console.WriteLine("#*.DOT   diff=astextplain");
        Console.WriteLine("#*.pdf   diff=astextplain");
        Console.WriteLine("#*.PDF   diff=astextplain");
        Console.WriteLine("#*.rtf   diff=astextplain");
        Console.WriteLine("#*.RTF   diff=astextplain");
    }
}
