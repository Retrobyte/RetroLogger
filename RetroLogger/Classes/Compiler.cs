using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroLogger.Classes
{
    public static class Compiler
    {
        public static CompilerResults compile(string[] sources, string output, bool isExecutable, string iconPath = null, params string[] references)
        {
            CompilerParameters param = new CompilerParameters(references, output) { GenerateExecutable = isExecutable, CompilerOptions = "/optimize /platform:x86" };

            if (isExecutable)
                param.CompilerOptions += " /target:winexe";

            if (isExecutable && !string.IsNullOrEmpty(iconPath))
                param.CompilerOptions += " /win32icon:\"" + iconPath + "\"";

            using (CSharpCodeProvider provider = new CSharpCodeProvider())
                return provider.CompileAssemblyFromSource(param, sources);
        }
    }
}
