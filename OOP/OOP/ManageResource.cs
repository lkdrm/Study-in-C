using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;

namespace OOP
{
    public class ResourceHolder : IDisposable
    {
        private readonly SafeHandle managedResource;
        
        public ResourceHolder()
        {
            managedResource = new SafeFileHandle(new IntPtr(), true);
        }

        public void Dispose()
        {
            managedResource?.Dispose();
            //GC.SuppressFinalize(this);
        }
    }
}
// enough to use IDisposible = with managaResource
// without unmanage
