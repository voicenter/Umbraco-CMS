using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using umbraco.NodeFactory;
using Umbraco.Web.WebApi;
 using log4net;
using System.Reflection;

namespace Umbraco.Web.UI
{
    public class ContentController : UmbracoApiController
    {
        private static readonly ILog Log =
          LogManager.GetLogger(
              MethodBase.GetCurrentMethod().DeclaringType
          );

        public Node GetAllProducts(int id = 1103)
        {

            Log.Debug("GetAllProducts !!!!!!!!!!!!!!!!!" + id.ToString()) ;

            Node driverParentNode = new Node(id);
            return driverParentNode ;
        }

    }
}
