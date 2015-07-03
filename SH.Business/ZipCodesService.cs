using System.Collections.Generic;
using System.Linq;

namespace SH.Business
{
    public class ZipCodesService : IZipCodesService
    {
        public IList<ZipCode> GetRandomZipCodes(int length)
        {
            return GetAllZipCodes().ToList();
        }

        private static IEnumerable<ZipCode> GetAllZipCodes()
        {
            return new List<ZipCode>()
            {
                new ZipCode {Code = 44101},
                new ZipCode {Code = 44102},
                new ZipCode {Code = 44103},
                new ZipCode {Code = 44104},
                new ZipCode {Code = 44105},
                new ZipCode {Code = 44106},
                new ZipCode {Code = 44107},
                new ZipCode {Code = 44108},
                new ZipCode {Code = 44109},
                new ZipCode {Code = 44110},
                new ZipCode {Code = 44111},
                new ZipCode {Code = 44112},
                new ZipCode {Code = 44113},
                new ZipCode {Code = 44114},
                new ZipCode {Code = 44115},
                new ZipCode {Code = 44116},
                new ZipCode {Code = 44117},
                new ZipCode {Code = 44118},
                new ZipCode {Code = 44119},
                new ZipCode {Code = 44120},
                new ZipCode {Code = 44121},
                new ZipCode {Code = 44122},
                new ZipCode {Code = 44123},
                new ZipCode {Code = 44124},
                new ZipCode {Code = 44125},
                new ZipCode {Code = 44126},
                new ZipCode {Code = 44127},
                new ZipCode {Code = 44128},
                new ZipCode {Code = 44129},
                new ZipCode {Code = 44130},
                new ZipCode {Code = 44131},
                new ZipCode {Code = 44132},
                new ZipCode {Code = 44133},
                new ZipCode {Code = 44134},
                new ZipCode {Code = 44135},
                new ZipCode {Code = 44136},
                new ZipCode {Code = 44137},
                new ZipCode {Code = 44138},
                new ZipCode {Code = 44139},
                new ZipCode {Code = 44140},
                new ZipCode {Code = 44141},
                new ZipCode {Code = 44142},
                new ZipCode {Code = 44143},
                new ZipCode {Code = 44144},
                new ZipCode {Code = 44145},
                new ZipCode {Code = 44146},
                new ZipCode {Code = 44147},
                new ZipCode {Code = 44149},
                new ZipCode {Code = 44177},
                new ZipCode {Code = 44178},
                new ZipCode {Code = 44179},
                new ZipCode {Code = 44181},
                new ZipCode {Code = 44184},
                new ZipCode {Code = 44185},
                new ZipCode {Code = 44186},
                new ZipCode {Code = 44188},
                new ZipCode {Code = 44189},
                new ZipCode {Code = 44190},
                new ZipCode {Code = 44191},
                new ZipCode {Code = 44192},
                new ZipCode {Code = 44193},
                new ZipCode {Code = 44194},
                new ZipCode {Code = 44195},
                new ZipCode {Code = 44197},
                new ZipCode {Code = 44198},
                new ZipCode {Code = 44199}
            };
        }
    }
}