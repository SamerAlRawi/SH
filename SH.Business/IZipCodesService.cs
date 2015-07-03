using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SH.Business
{
    public interface IZipCodesService
    {
        IList<ZipCode> GetRandomZipCodes(int length);
    }
}
