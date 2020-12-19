using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CooperativeUriHandler;
using CooperativeUriHandler.definitions.enums;
using Xunit;

namespace CooperativeUriHandlerShould
{
    public class UriHelperShould
    {
        [Fact]
        public void GetPositionTypeShould()
        {
            Assert.Equal(PositionType.File, UriHelper.GetPositionType(new Uri("file://C:\\test.txt")));
            Assert.Equal(PositionType.Directory, UriHelper.GetPositionType(new Uri("file://C:\\test\\")));
            Assert.Equal(PositionType.Directory, UriHelper.GetPositionType(new Uri("file:///test/")));
            Assert.Equal(PositionType.File, UriHelper.GetPositionType(new Uri("file:///test.txt", UriKind.Absolute)));
        }
    }
}
