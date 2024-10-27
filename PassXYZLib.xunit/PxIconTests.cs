using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PassXYZLib.Resources;

namespace PassXYZLib.xunit
{
    public class PxIconTests
    {
        [Fact]
        public void PxIconDefaultTest()
        { 
            var pxIcon = new PxIcon();
            Debug.WriteLine($"{pxIcon.FontIcon.Glyph}");
            Assert.Equal(pxIcon.FontIcon.Glyph, FontAwesomeRegular.File);
            Assert.NotNull(pxIcon);
        }
    }
}
