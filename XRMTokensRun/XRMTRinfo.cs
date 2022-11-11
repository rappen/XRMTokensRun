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
        ExportMetadata("Name", "XRM Tokens Runner"),
        ExportMetadata("Description", "Runner for the XRM Tokens, now including Microsoft Power Fx! Try it, test it, do more, and use the Bulk Data Updater."),
        ExportMetadata("SmallImageBase64", "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAMAAABEpIrGAAAAFXRFWHRDcmVhdGlvbiBUaW1lAAflBw4TDR5cYjbFAAAAB3RJTUUH5QkLDhI5fSMQMAAAAAlwSFlzAAAKjAAACowBvcbP2AAAASxQTFRF///G3ufGrca9jKW9e5y9hKW9pb29KWO1AEKtAEK9AEq9GFKtc5S91t7G7/fGa5S1AEK1AFLWAFrvAGP3AGP/WoS1vc69AFLeAFrnEEqtlK29AErOlLW9nLW9CEqtIXPea6WUe7V7e62EEGvvKXvOa6WMUpStSpStc6WMKXvWUpylhLV7OYTGSnu15+/GGHPn7/cI//8A7/cQ9/cIWpyltc5Krc5S5/cQxta9Qoy9xt45CGP3pcZahLVz9/8A1ucplL1r5+8YjL1r9//GlL1jjLVz3uchzt4xvdZCpc5SjK29AErGSpS1zucpY5ycnMZjOYy9MYTOc62EEHPnCGv3GHPeIXveIVq1c5y9c62MY6WUUoS1Y6WctdZCY4y1zucx9/8IQnO1ztbGCGvvuNkoFgAAAAF0Uk5TAEDm2GYAAAJSSURBVHjabVPrWtpAEA0KukbBhAw3aUFJBCypcQyguUAIAommQmmr9dLSWt//Hbq7apHK+bFfsnNmz8zsWUGY4+x052Y227rIngnLkJwViCRGUSSRUub0TTh2TzZkBTiUXEQekovxtYKYh1dIi6XV1/E4ecn+hxyZzUtJkBy8QZ7MXuIrPK4pMDV0/VHVAB4POONZ5bBQZBm9Wz2ot/a8mu/AvstVSn84YSaB3ncH2i9P272D1vj3GAKXbjRBfOANkvx1F31z6nrOj+BnOG2HljvxfRPHaZKlhBsJLAxBabY6w9s73dbd4WVtokAFOxDdU8J3GQwcAVQMp1ezoGPVryoHY4ABNmkVKaYAEKDx1WEzVNVv6lX5WqXfl6iCQjVWCP1x0UI0j48Qd11kCMvg+3R20oVwIVGCbU6HDReDLw19gu5+JcSRE5oGQLQtxEUo+ydUE2o4oWsfdZaBnzXvqApRhhPsbo9uWjiga4cT+vipaV5ajMAlwq7BCIzWYATFxrJnOlziuUhtTgjPXY8e5vvAizxkbdq0pWeJIY5sDwPaevepTWG9CEbX40WyK+qhBY7fPaBl0EEVqCcSbNQ2OE4V21ytRqdKuQ066o0Mu22SM47w2NSb2KKENlYBDBNPEGtpws27LSnl3b2Kqu1XmVCdmeVDvVHXQfzI/ZDaLMJSyKXYk6WyRF4Wz5P3L6Z8t4yRJ1tz2++Q4v+2l0n89cPIbkoLzs9LhbXFp5XaJpKcfjomLYskE3v7OuPrhGyIokjI5lZSWIrYymo8nlhbSP4LgZlwLqr9vOkAAAAASUVORK5CYII="),
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#FFFFC0"),
        ExportMetadata("PrimaryFontColor", "#0000C0"),
        ExportMetadata("SecondaryFontColor", "#0000FF")]
    public class XRMTRinfo : PluginBase, IPayPalPlugin
    {
        public string DonationDescription => "Donation to XRM Tokens Runner for XrmToolBox";

        public string EmailAccount => "jonas@rappen.net";

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
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
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