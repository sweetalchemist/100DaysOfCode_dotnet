using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text;
using System.Threading.Tasks;

namespace CSharpInterfaces.Library
{
    public static class BeatleFactory
    {
        public static IBeatleSong CreateBeatleSong(string className)
        {
            string assemblyName = "CSharpInterfaces.Library"; 
            assemblyName = typeof(BeatleFactory).Assembly.GetName().Name;
            string assemblyLocation = AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + assemblyName;


            AssemblyLoadContext assemblyLoadContext = new AssemblyLoadContext(assemblyLocation);
            AssemblyName assemblyNameWithoutExtension = new AssemblyName( Path.GetFileNameWithoutExtension(assemblyName));
            Assembly assembly = assemblyLoadContext.LoadFromAssemblyName(assemblyNameWithoutExtension);

            string songTypeName = className;
            Type songType = assembly.GetType(songTypeName);

            IBeatleSong song = Activator.CreateInstance(songType) as IBeatleSong;
            return song;

        }
    }
}
