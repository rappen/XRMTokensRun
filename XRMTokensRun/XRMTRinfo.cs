using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace XRMTokensRun
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "XRM Tokens Runners"),
        ExportMetadata("Description", "Runner for the XRM Tokens - this them out for any data!"),
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAFXRFWHRDcmVhdGlvbiBUaW1lAAflBw4TDR5cYjbFAAAAB3RJTUUH5QcOFAIc5bq+0wAAAAlwSFlzAAAKjAAACowBvcbP2AAAASNQTFRF///G3ufGrca9jKW9e5y9hKW9pb29KWO1AEKtAEK9AEq9GFKtc5S91t7G7/fGa5S1AEK1AFLWAFrvAGP3AGP/WoS1vc69AFLeAFrnEEqtlK29AErOlLW9AFLnnLW9CEqtIXPea6WUhLV7c62EGHPnc62MOYTGSnu15+/G7/cQ//8A9/cI5+8YSpStxta9Qoy9xt45CGv3EGvve62EjLVz1ucpjL1rUpSt9//GSpS1hLWEY5yce62MjLV7vdZKpcZaKYTO3u8hKXvWnMZztc5SMYTOY5yljK29vdZClL1zWpylIXvezt455/cQpcZjWpytAErGCGvvY6WcnMZjKXve9/cQzt4xtdZKIVq1lL1rc5y9hLVzUoS1Y4y1lL1jQnO1ztbGIe9XnAAAAAF0Uk5TAEDm2GYAAAIFSURBVHjadVNrd9JAFAw00Et4JeRCoKhQTGOzwZaHS8u7YFNSqJr6tjbW//8r3F0OQiTOh5ycO7N35+7OStIWl2dHD0GQWZQupShkgwqoiu/7KtSKZ3t07BFSmo4CuuHDUzbMJytKGXdQUGoHu7wMm9V/YUCwtZIAA/dQhmDDx6N4rlis+dNKFSNh1H4LQaCi1Zv+qodIVlii8iQGhPKKkJnjhgTNpkOGBSgxwYOK58TTMTyGjl3yE/1HJviuoUkoL953BNd2RbMfZMlc5PgOiF+JyUqekC2b31p0jkhJB3W2RxxYcUrYos/UO0ecf2G/I8pdsE3VhbRQmaDl3COOux+n7PtJeLTQc1hXPy/JCtab74a8uOrYJr4/4QLvA7rUvkC/KAQt0kPsNweDWRcbYy6gLi4daunV4noLj5m8vr1Zdme4om1E945pbOZByW9MXpk2H3LWn7+9Nl16YzKTKEye8jFbpNMf8NbD0XgysUaTSZ/XxJjSYRVNh+5fVY9coFFhmUjwo26h3g7RHXbUb1Ap8tsGw7SJ7Vjhy7IJeV0AEd68qtePGy/NkOC4cWLpqVciD7n0fwKj1WLrSJVAi+Kfw4tNKJ9FKcqQ2cb+CKr/xl4DefdhlNJqKNlltZIMP61cHlStsG5T0BQoxvZfp3wIkFIUBSCdyUqRiMUPZDmRDC3+A9f7XoaI1LDfAAAAAElFTkSuQmCC"),
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#FFFFC0"),
        ExportMetadata("PrimaryFontColor", "#0000C0"),
        ExportMetadata("SecondaryFontColor", "#0000FF")]
    public class XRMTRinfo : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new XRMTR();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public XRMTRinfo()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}