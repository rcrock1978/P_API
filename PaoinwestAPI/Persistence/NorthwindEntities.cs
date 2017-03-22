using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PaoinwestAPI.Persistence
{ 
    public partial class NorthwindEntities
    {
        public static NorthwindEntities Create()
        {
            return new NorthwindEntities();
        }
    }
}