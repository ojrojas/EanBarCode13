using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class SheetItemDeleteResponse : BaseResponse
    {
        public SheetItemDeleteResponse(Guid Correlation): base(Correlation) { }
        public SheetItem SheetItemDeleted { get; set; }
    }
}
