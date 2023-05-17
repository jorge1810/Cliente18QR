using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string[] ignoredFiles = {
            "*.rsuser",
            "*.suo",
            "*.user",
            "*.userosscache",
            "*.sln.docstates",
            "*.userprefs",
            "mono_crash.*",
            "[Dd]ebug/",
            "[Dd]ebugPublic/",
            "[Rr]elease/",
            "[Rr]eleases/",
            "x64/",
            "x86/",
            "[Ww][Ii][Nn]32/",
            "[Aa][Rr][Mm]/",
            "[Aa][Rr][Mm]64/",
            "bld/",
            "[Bb]in/",
            "[Oo]bj/",
            "[Oo]ut/",
            "[Ll]og/",
            "[Ll]ogs/",
            ".vs/",
            "Generated\\ Files/",
            "[Tt]est[Rr]esult*/",
            "[Bb]uild[Ll]og.*",
            "*.VisualState.xml",
            "TestResult.xml",
            "nunit-*.xml",
            "[Dd]ebugPS/",
            "[Rr]eleasePS/",
            "dlldata.c",
            "BenchmarkDotNet.Artifacts/",
            "project.lock.json",
            "project.fragment.lock.json",
            "artifacts/",
            "ScaffoldingReadMe.txt",
            "StyleCopReport.xml",
            "*_i.c",
            "*_p.c",
            "*_h.h",
            "*.ilk",
            "*.meta",
            "*.obj",
            "*.iobj",
            "*.pch",
            "*.pdb",
            "*.ipdb",
            "*.pgc",
            "*.pgd",
            "*.rsp",
            "*.sbr",
            "*.tlb",
            "*.tli",
            "*.tlh",
            "*.tmp",
            "*.tmp_proj",
            "*_wpftmp.csproj",
            "*.log",
            "*.vspscc",
            "*.vssscc",
            ".builds",
            "*.pidb",
            "*.svclog",
            "*.scc",
            "_Chutzpah*",
            "ipch/",
            "*.aps",
            "*.ncb",
            "*.opendb",
            "*.opensdf",
            "*.sdf",
            "*.cachefile",
            "*.VC.db",
            "*.VC.VC.opendb",
            "*.psess",
            "*.vsp",
            "*.vspx",
            "*.sap",
            "*.e2e",
            "$tf/",
            "*.gpState",
            "_ReSharper*/",
            "*.[Rr]e[Ss]harper",
            "*.DotSettings.user",
            "_TeamCity*",
            "*.dotCover",
            ".axoCover/*",
            "!.axoCover/settings.json",
            "coverage*.json",
            "coverage*.xml",
            "coverage*.info",
            "*.coverage",
            "*.coveragexml",
            "_NCrunch_*",
            ".*crunch*.local.xml",
            "nCrunchTemp_*",
            "*.mm.*",
            "AutoTest.Net/",
            ".sass-cache/",
            "[Ee]xpress/",
            "DocProject/buildhelp/",
            "DocProject/Help/*.HxT",
            "DocProject/Help/*.HxC",
            "DocProject/Help/*.hhc",
            "DocProject/Help/*.hhk",
            "DocProject/Help/*.hhp",
            "DocProject/Help/Html2",
            "DocProject/Help/html",
            "publish/",
            "*.[Pp]ublish.xml",
        };
    }
}
